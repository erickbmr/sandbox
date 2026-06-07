namespace designpatterns.factory
{
    class Main
    {
        public void Execute()
        {
            GUIFactory guiFactory = new UnixFactory();
            Creationing(guiFactory); //expected: value: AAA 10 | aria-label="unix"

            guiFactory = new WindowsFactory();
            Creationing(guiFactory); //expected: value: 12 000 | aria-label="WINDOWS"
        }

        public void Creationing(GUIFactory factory)
        {
            var bar = factory.CreateScrollBar();
            var button = factory.CreateButton();
            Console.WriteLine(factory.Include() + bar.ToCode() + " | " + button.WithAriaLabel());
        }
    }
}