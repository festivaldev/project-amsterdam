using System.Drawing;
using Amsterdam.Core;

namespace Amsterdam
{
    /// <summary>
    ///     Contains all the needed information to style a <see cref="SingleColorMatrix"/>.
    /// </summary>
    public class SingleColorMatrixDefinition : IMatrixDefinition
    {
        /// <summary>
        ///     The <see cref="Brush"/> used to draw active pixels.
        /// </summary>
        public Brush ActivePixelBrush { get; set; }

        /// <summary>
        ///     The <see cref="Brush"/> used to draw the background of the <see cref="SingleColorMatrix"/>.
        /// </summary>
        public Brush BackgroundBrush { get; set; }

        /// <summary>
        ///     The percentage of dead pixels.
        /// </summary>
        public float DeadPixelRatio { get; set; }

        /// <summary>
        ///     The <see cref="Brush"/> used to draw inactive pixels.
        /// </summary>
        public Brush InactivePixelBrush { get; set; }

        /// <summary>
        ///     The amount of columns and rows (the size) of the <see cref="SingleColorMatrix"/>.
        /// </summary>
        public Size MatrixSize { get; set; }

        /// <summary>
        ///     The size of each matrix pixel in pixels.
        /// </summary>
        public int PixelSize { get; set; }

        /// <summary>
        ///     The rotation of the <see cref="SingleColorMatrix"/> in degrees.
        /// </summary>
        public float Rotation { get; set; }

        /// <summary>
        ///     The <see cref="Pen"/> used to draw the strokes of the <see cref="SingleColorMatrix"/>.
        /// </summary>
        public Pen StrokePen { get; set; }
        
        public Rectangle GetMatrixRectangle() => new Rectangle(0, 0, MatrixSize.Width * PixelSize + 1, MatrixSize.Height * PixelSize + 1);
    }
}
