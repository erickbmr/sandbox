namespace designpatterns.factory
{
    class Main
    {
        public void Execute()
        {
            NotificationFactory factory = new EmailNotification();
            var sender = factory.CreateNotification();
            Console.WriteLine(sender.GetFullMessage()); 
            //expected: Content: This is a new Email! | To: you@email.com | From: me@email.com

            Console.WriteLine(factory.GetMessage());
            //expected: New email unread!

            factory = new SMSNotification();
            sender = factory.CreateNotification();
            Console.WriteLine(sender.GetFullMessage());
            //expected: This is a new SMS! | To: 123456789 | From: 987654321

            Console.WriteLine(factory.GetMessage());
            //expected: New notification unread!
        }
    }
}