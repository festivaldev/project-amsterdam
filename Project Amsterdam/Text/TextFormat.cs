namespace Amsterdam.Text
{
    public class TextFormat
    {
        public enum HorizontalAlign
        {
            Left,
            LeftFlow,
            Center,
            Right
        }

        public HorizontalAlign HAlign { get; set; } = HorizontalAlign.Left;
    }
}
