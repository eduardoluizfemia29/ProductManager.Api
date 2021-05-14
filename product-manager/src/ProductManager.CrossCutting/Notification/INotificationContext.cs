using System.Collections.Generic;

namespace ProductManager.CrossCutting.Notification
{
    public interface INotificationContext
    {
        IReadOnlyCollection<Notification> Notifications { get; }
        bool HasNotifications { get; }
        void AddNotification(string key, string message);
    }
}