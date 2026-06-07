namespace designpatterns.factory
{
    abstract class GUIFactory
    {
        public abstract IScrollBar CreateScrollBar();

        public abstract IButton CreateButton();

        public static string Include()
        {
            return "value: ";
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

    interface IButton
    {
        string Text;

        string WithAriaLabel();
    }
}