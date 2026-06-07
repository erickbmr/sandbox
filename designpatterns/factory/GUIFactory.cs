namespace designpatterns.factory
{
    abstract class GUIFactory
    {
        public abstract IScrollBar CreateScrollBar();

        public bool IncludeScrollBar()
        {
            var bar = CreateScrollBar();
            return bar.HasItems();
        }
    }

    interface IScrollBar
    {
        int Length;
        string Color;
        int Items;

        string ToCode();
        bool HasItems();
    }
}