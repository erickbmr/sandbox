namespace designpatterns.factory
{
    class SMSNotification : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new SMSSenderNotification();
        }
    }

    class SMSSenderNotification : INotification
    {
        public string Message { get; } = "This is a new SMS!";
        public string To { get; } = "123456789";
        public string From {get; } = "987654321";

        public string GetFullMessage()
        {
            return string.Contat(Message, " | To: ", To, " | From: ", From);
        }
    }
}