using System.Windows;

namespace Paint
{
    public interface IPaintObjectConstructorListener
    {
        void constructionBeginning(PaintObject temporaryObject);
        void constructionContinuing(PaintObject temporaryObject);
        void constructionComplete(PaintObject finalObject);
        void hoveringOverConstructionArea(PaintObject hoverObject);
        IInputElement InputElement { get; }
    }
}
