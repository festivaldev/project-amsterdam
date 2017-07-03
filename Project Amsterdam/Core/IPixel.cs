using System.Drawing;

namespace Amsterdam.Core
{
    /// <summary>
    ///     Contains all the needed information to style a pixel of an <see cref="IMatrix"/>.
    /// </summary>
    public interface IPixel
    {
        bool Active { get; set; }
        bool Invalidated { get; set; }
        Point Position { get; set; }
    }
}
