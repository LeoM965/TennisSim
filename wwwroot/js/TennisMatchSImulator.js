class TennisMatchSimulator {
    constructor(elements, player1Name, player2Name) {
        this.elements = elements;
        this.player1Name = player1Name;
        this.player2Name = player2Name;
        this.currentSetHistory = '';
        this.currentGames = { p1: 0, p2: 0 };
        this.currentSets = { p1: 0, p2: 0 };
        this.currentPoints = { p1: '0', p2: '0' };
        this.isPlayer1Serving = true;
        this.isSkipped = false;
    }

    async simulate(matchId) {
        this.resetUI();
        try {
            const result = await this.fetchSimulationData(matchId);
            await this.processSimulation(result);
            this.elements.button.disabled = true;
            localStorage.setItem(`match_${matchId}_completed`, 'true');
        } catch (error) {
            this.handleError(error);
            this.elements.button.disabled = false;
        }
    }

    resetUI() {
        this.elements.results.classList.remove('d-none');
        this.currentGames = { p1: 0, p2: 0 };
        this.currentSets = { p1: 0, p2: 0 };
        this.currentPoints = { p1: '0', p2: '0' };
        this.isPlayer1Serving = true;
        Object.values(this.elements).forEach(element => {
            if (element && element !== this.elements.results && element !== this.elements.button) {
                element.innerHTML = '';
            }
        });
        this.updateScoreDisplay();
    }

    async fetchSimulationData(matchId) {
        const response = await fetch(`/Match/RunSimulation?matchId=${matchId}`, {
            method: 'POST',
            headers: { 'Accept': 'application/json' }
        });

        if (!response.ok) {
            const errorData = await response.json();
            throw new Error(errorData.details || errorData.error || `HTTP error! status: ${response.status}`);
        }
        return response.json();
    }

    async processSimulation(result) {
        if (!Array.isArray(result.setDetails)) return;

        // Handle skip case
        if (this.isSkipped) {
            // Update all sets at once
            this.updateSetScores(result.setDetails);

            // Calculate final sets score
            this.currentSets = {
                p1: result.setDetails.filter(set => set.p1Score > set.p2Score).length,
                p2: result.setDetails.filter(set => set.p2Score > set.p1Score).length
            };

            // Get the last set's scores
            const lastSet = result.setDetails[result.setDetails.length - 1];
            this.currentGames = {
                p1: lastSet.p1Score,
                p2: lastSet.p2Score
            };

            // Reset points display
            this.currentPoints = { p1: '0', p2: '0' };

            // Update UI
            this.updateScoreDisplay();

            // Display match summary
            let matchSummary = '<div class="match-summary">';
            result.setDetails.forEach(set => {
                matchSummary += `
                            <div class="set-summary">
                                Set ${set.setNumber}: ${this.player1Name} ${set.p1Score} - ${set.p2Score} ${this.player2Name}
                            </div>`;
            });
            matchSummary += '</div>';

            this.elements.matchHistory.innerHTML = matchSummary;
            this.displayWinner(result.winner);
            return;
        }

        // Normal simulation processing
        for (let setIndex = 0; setIndex < result.setDetails.length; setIndex++) {
            const set = result.setDetails[setIndex];
            if (!set) continue;
            await this.processSet(set, setIndex, result.setDetails);
        }

        this.displayWinner(result.winner);
    }

    async processSet(set, setIndex, setDetails) {
        this.currentSetHistory = `<div class="set-header">Set ${set.setNumber}</div>`;
        this.currentGames = { p1: 0, p2: 0 };
        this.currentPoints = { p1: '0', p2: '0' };

        for (const game of set.games || []) {
            await this.processGame(game);
        }

        this.updateSetScores(setDetails.slice(0, setIndex + 1));
        this.currentSets[set.p1Score > set.p2Score ? 'p1' : 'p2']++;

        this.currentSetHistory += `
                    <div class="set-result">
                        <strong>Set ${set.setNumber} Final:</strong> ${this.player1Name} ${set.p1Score} - ${set.p2Score} ${this.player2Name}
                    </div>`;

        this.elements.matchHistory.innerHTML += this.currentSetHistory;
        await this.delay(1000);
    }

    async processGame(game) {
        if (!game) return;

        this.currentSetHistory += `<div class="game-header">Game ${game.gameNumber}</div>`;

        if (Array.isArray(game.points)) {
            await this.processGamePoints(game.points);
        }

        this.currentGames[game.winnerIsPlayer1 ? 'p1' : 'p2']++;
        this.updateScoreDisplay();

        this.currentSetHistory += `
                    <div class="game-result">
                        Game to ${game.winnerIsPlayer1 ? this.player1Name : this.player2Name}
                    </div>`;

        this.isPlayer1Serving = !this.isPlayer1Serving;
        await this.delay(1000);
    }

    formatScore(p1Score, p2Score, isCurrent = false) {
        if (isCurrent) {
            return `<span>${p1Score} ${this.isPlayer1Serving ? '🎾' : ''} - ${p2Score} ${!this.isPlayer1Serving ? '🎾' : ''}</span>`;
        }
        return `<span>${p1Score} - ${p2Score}</span>`;
    }

    updateScoreDisplay() {
        this.elements.currentSets.innerHTML = this.formatScore(this.currentSets.p1, this.currentSets.p2);
        this.elements.currentGames.innerHTML = this.formatScore(this.currentGames.p1, this.currentGames.p2);
        this.elements.currentGame.innerHTML = this.formatScore(this.currentPoints.p1, this.currentPoints.p2, true);
    }

    updateSetScores(setDetails) {
        this.elements.setScores.innerHTML = setDetails.map(set => `
                    <div class="set-score-item">
                        <div class="d-flex justify-content-between align-items-center">
                            <strong>Set ${set.setNumber}:</strong>
                            <span>${this.player1Name} ${set.p1Score} - ${set.p2Score} ${this.player2Name}</span>
                        </div>
                    </div>
                `).join('');
    }

    async processGamePoints(points) {
        if (!points?.length) return;

        this.elements.currentGamePoints.innerHTML = points.map(point => `
                    <div class="point-item">
                        <div class="d-flex justify-content-between align-items-center">
                            <span>${this.player1Name}</span>
                            <span class="score">${point.p1Score} - ${point.p2Score}</span>
                            <span>${this.player2Name}</span>
                        </div>
                    </div>
                `).join('');

        for (const point of points) {
            if (!point) continue;
            this.currentPoints = { p1: point.p1Score, p2: point.p2Score };
            this.updateScoreDisplay();
            this.currentSetHistory += `
                        <div class="point-score">
                            ${this.player1Name} ${point.p1Score} - ${point.p2Score} ${this.player2Name}
                        </div>`;
            await this.delay(500);
        }
    }

    displayWinner(winner) {
        if (winner) {
            this.elements.matchHistory.innerHTML += `
                        <div class="winner-section mt-4">
                            <h3>Match Complete</h3>
                            <h2>Winner: ${winner.name}</h2>
                        </div>`;
        }
    }

    handleError(error) {
        console.error('Simulation error:', error);
        this.elements.matchHistory.innerHTML = `
                    <div class="alert alert-danger">
                        <h4>Error</h4>
                        <p>${error.message || 'Simulation failed. Please try again.'}</p>
                    </div>`;
    }

    delay(ms) {
        return new Promise(resolve => setTimeout(resolve, ms));
    }
}

// Initialize when DOM is loaded
document.addEventListener('DOMContentLoaded', () => {
    const simulateBtn = document.getElementById('simulateBtn');
    const skipToResultBtn = document.getElementById('skipToResultBtn');

    if (!simulateBtn || !skipToResultBtn) return;

    const matchId = simulateBtn.dataset.matchId;
    if (localStorage.getItem(`match_${matchId}_completed`) === 'true') {
        simulateBtn.disabled = true;
        skipToResultBtn.disabled = true;
    }

    // Event listener pentru Skip to Result
    skipToResultBtn.addEventListener('click', async function () {
        this.disabled = true;
        simulateBtn.disabled = true;

        const elements = {
            results: document.getElementById('simulationResults'),
            currentGame: document.getElementById('currentGame'),
            currentGames: document.getElementById('currentGames'),
            currentSets: document.getElementById('currentSets'),
            setScores: document.getElementById('setScores'),
            currentGamePoints: document.getElementById('currentGamePoints'),
            matchHistory: document.getElementById('matchHistory'),
            button: simulateBtn
        };

        const simulator = new TennisMatchSimulator(
            elements,
            simulateBtn.dataset.player1 || 'Player 1',
            simulateBtn.dataset.player2 || 'Player 2'
        );

        simulator.isSkipped = true; // Setăm direct flag-ul de skip
        await simulator.simulate(matchId);
    });

    simulateBtn.addEventListener('click', async function () {
        this.disabled = true;
        skipToResultBtn.disabled = true;

        const elements = {
            results: document.getElementById('simulationResults'),
            currentGame: document.getElementById('currentGame'),
            currentGames: document.getElementById('currentGames'),
            currentSets: document.getElementById('currentSets'),
            setScores: document.getElementById('setScores'),
            currentGamePoints: document.getElementById('currentGamePoints'),
            matchHistory: document.getElementById('matchHistory'),
            button: this
        };

        const simulator = new TennisMatchSimulator(
            elements,
            this.dataset.player1 || 'Player 1',
            this.dataset.player2 || 'Player 2'
        );

        await simulator.simulate(this.dataset.matchId);
    });
});