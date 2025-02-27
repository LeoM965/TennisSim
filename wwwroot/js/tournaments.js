function applyFilters() {
    const category = document.getElementById('category').value;
    const surface = document.getElementById('surface').value;
    const country = document.getElementById('country').value;
    const dateFrom = document.getElementById('date-from').value;
    const dateTo = document.getElementById('date-to').value;

    document.querySelectorAll('.tournament-card').forEach(card => {
        const cardCategory = card.getAttribute('data-category');
        const cardSurface = card.getAttribute('data-surface');
        const cardCountry = card.querySelector('.tournament-location').innerText.trim();
        const cardStartDate = card.getAttribute('data-start-date');

        let visible = true;

        if (category && cardCategory !== category) visible = false;
        if (surface && cardSurface !== surface) visible = false;
        if (country && !cardCountry.includes(country)) visible = false;
        if (dateFrom && new Date(cardStartDate) < new Date(dateFrom)) visible = false;
        if (dateTo && new Date(cardStartDate) > new Date(dateTo)) visible = false;

        card.style.display = visible ? '' : 'none';
    });
}

function resetFilters() {
    document.getElementById('category').value = '';
    document.getElementById('surface').value = '';
    document.getElementById('country').value = '';
    document.getElementById('date-from').value = '';
    document.getElementById('date-to').value = '';
    applyFilters();
}
