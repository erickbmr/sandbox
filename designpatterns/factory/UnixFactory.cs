namespace designpatterns.factory
{
    class UnixFactory : GUIFactory
    {
        public override IScrollBar CreateScrollBar()
        {
            return new UnixScrollBar();
        }
    }

    class UnixScrollBar : IScrollBar
    {
        public int Length { get; } = 10;
        public string Color { get; } = "AAA"; 
        public int Items { get; } = 1;

        public string ToCode()
        {
            return Color + " " + Length.ToString();
        }

        public bool HasItems()
        {
            return Items > 0;
        }
    }
}