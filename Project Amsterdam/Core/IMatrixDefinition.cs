using System.Drawing;

namespace Amsterdam.Core
{
    /// <summary>
    ///     Contains all the needed information to style an <see cref="IMatrix"/>.
    /// </summary>
    public interface IMatrixDefinition
    {
        Brush BackgroundBrush { get; set; }
        float DeadPixelRatio { get; set; }
        Brush InactivePixelBrush { get; set; }
        Size MatrixSize { get; set; }
        int PixelSize { get; set; }
        float Rotation { get; set; }
        Pen StrokePen { get; set; }
    }
}
