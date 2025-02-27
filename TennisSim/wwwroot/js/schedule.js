document.addEventListener('DOMContentLoaded', () => {
    const container = document.querySelector('.tournament-schedule');
    if (!container) return;

    const dayButtons = container.querySelectorAll('.day-btn');

    const switchDay = (button) => {
        const date = button.dataset.date;

        dayButtons.forEach(b => b.classList.remove('active'));
        button.classList.add('active');

        document.querySelectorAll('.day-schedule').forEach(schedule => {
            schedule.classList.remove('active');
        });

        const targetSchedule = document.getElementById(`schedule-${date}`);
        if (targetSchedule) {
            targetSchedule.classList.add('active');
        }
    };

    dayButtons.forEach(btn => {
        btn.addEventListener('click', () => switchDay(btn));
    });
});