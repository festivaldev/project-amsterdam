using System.Drawing;
using Amsterdam.Core;

namespace Amsterdam.Drawing
{
    public class SingleColorPixel : IPixel
    {
        /// <summary>
        ///     Determines whether the <see cref="SingleColorPixel"/> is active or not.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        ///     Determines whether the <see cref="SingleColorPixel"/> got invalidated or not.
        /// </summary>
        public bool Invalidated { get; set; }

        /// <summary>
        ///     The position of the <see cref="SingleColorPixel"/>.
        /// </summary>
        public Point Position { get; set; }

        /// <summary>
        ///     Creates a new instance of a <see cref="SingleColorPixel"/>.
        /// </summary>
        public SingleColorPixel() { }

        /// <summary>
        ///     Creates a new instance of a <see cref="SingleColorPixel"/> with a given position.
        /// </summary>
        /// <param name="position">The <see cref="Point"/> in the <see cref="SingleColorMatrix"/> of this <see cref="SingleColorPixel"/>.</param>
        public SingleColorPixel(Point position) {
            Position = position;
        }
    }
}
