namespace designpatterns.factory
{
    class EmailNotification : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new EmailSenderNotification();
        }

        public override string GetMessage()
        {
            return "New email unread!";
        }
    }

    class EmailSenderNotification : INotification
    {
        public string Message { get; } = "This is a new Email!";
        public string To { get; } = "you@email.com";
        public string From {get; } = "me@email.com";

        public string GetFullMessage()
        {
            return string.Contat("Content: ", Message, " | To: ", To, " | From: ", From);
        }
    }
}