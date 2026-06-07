namespace designpatterns.factory
{
    class WindowsFactory : GUIFactory
    {
        public override IScrollBar CreateScrollBar()
        {
            return new WindowsScrollBar();
        }

        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }

    class WindowsScrollBar : IScrollBar
    {
        public int Length { get; } = 12;
        public string Color { get; } = "000"; 
        public int Items { get; } = 0;

        public string ToCode()
        {
            return Length.ToString() + " " + Color;
        }
        
        public bool HasItems()
        {
            return Items > 0;
        }
    }

    class WindowsButton : IButton
    {
        public string Text { get; } = "windows";

        public string WithAriaLabel()
        {
            return "aria-label=\"" + Text.ToUpper() + "\"";
        }
    }
}