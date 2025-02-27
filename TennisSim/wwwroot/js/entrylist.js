document.addEventListener('DOMContentLoaded', function () {
    const playerSearch = document.getElementById('playerSearch');
    const sortSelect = document.getElementById('sortSelect');
    const tableBody = document.getElementById('entryListBody');
    const originalRows = Array.from(tableBody.getElementsByTagName('tr'));

    function filterAndSortRows() {
        let rows = [...originalRows];

        // Filter
        if (playerSearch.value) {
            const searchTerm = playerSearch.value.toLowerCase();
            rows = rows.filter(row => {
                const playerName = row.getElementsByTagName('td')[1].textContent.toLowerCase();
                return playerName.includes(searchTerm);
            });
        }

        // Sort
        rows.sort((a, b) => {
            const aValue = getSortValue(a);
            const bValue = getSortValue(b);

            if (sortSelect.value === 'name') {
                return aValue.localeCompare(bValue);
            }
            return parseFloat(aValue) - parseFloat(bValue);
        });

        // Update table
        tableBody.innerHTML = '';
        rows.forEach(row => tableBody.appendChild(row));
    }

    function getSortValue(row) {
        switch (sortSelect.value) {
            case 'rank':
                return row.getElementsByTagName('td')[0].textContent.trim();
            case 'name':
                return row.getElementsByTagName('td')[1].textContent.trim();
            case 'points':
                return row.getElementsByTagName('td')[2].textContent.trim().replace(/,/g, '');
            default:
                return '';
        }
    }

    playerSearch.addEventListener('input', filterAndSortRows);
    sortSelect.addEventListener('change', filterAndSortRows);
});
document.addEventListener('DOMContentLoaded', function () {
    const toateRandurile = document.querySelectorAll('.entry-table tbody tr');

    function animeazaRandurile() {
        toateRandurile.forEach((rand, pozitie) => {
            let intarziere = pozitie * 0.10;
            rand.style.animationDelay = intarziere + 's';
            rand.style.animationPlayState = 'running';
        });
    }

    animeazaRandurile();

    const butonSortare = document.getElementById('sortSelect');
    const campCautare = document.getElementById('playerSearch');

    if (butonSortare) {
        butonSortare.addEventListener('change', function () {
            animeazaRandurile();
        });
    }

    if (campCautare) {
        campCautare.addEventListener('input', function () {
            animeazaRandurile();
        });
    }
});