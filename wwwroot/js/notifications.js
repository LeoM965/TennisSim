function showNotification(message, type = 'success') {
    const notification = $('#notificationSystem');
    notification.removeClass('notification-success notification-error')
        .addClass(`notification-${type}`);

    const icon = type === 'success' ? 'fa-check-circle' : 'fa-exclamation-circle';
    notification.find('.notification-icon')
        .removeClass()
        .addClass(`fas ${icon} notification-icon`);

    notification.find('.notification-message').text(message);

    notification.fadeIn(300);
    setTimeout(() => notification.fadeOut(300), 3000);
}