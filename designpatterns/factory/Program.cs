namespace designpatterns.factory
{
    class Main
    {
        public void Execute()
        {
            GUIFactory guiFactory = new UnixFactory();
            var scrollBar = guiFactory.CreateScrollBar();
            Console.WriteLine(scrollBar.ToCode()); //expected: AAA 10

            GUIFactory guiFactory = new WindowsFactory();
            var scrollBar = guiFactory.CreateScrollBar();
            Console.WriteLine(scrollBar.ToCode()); //expected: 12 000
        }
    }
}