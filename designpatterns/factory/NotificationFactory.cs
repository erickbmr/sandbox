namespace designpatterns.factory
{
    abstract class NotificationFactory
    {
        public abstract INotification CreateNotification();

        public virtual string GetMessage()
        {
            return "New notification unread!";
        }
    }

    interface INotification
    {
        string Message;
        string To;
        string From;

        string GetFullMessage();
    }
}