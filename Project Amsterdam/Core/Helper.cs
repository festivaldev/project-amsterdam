using System;
using System.Collections.Generic;
using System.Drawing;

namespace Amsterdam.Core
{
    internal static class Helper
    {
        internal static void RepeatN(int n, Action action) {
            for (var i = 0; i < n; i++) {
                action();
            }
        }

        internal static int ElementCount(this Size size) => size.Height * size.Width;

        internal static Rectangle GetPixelRectangle(IPixel pixel, int size) => new Rectangle(size * pixel.Position.X, size * pixel.Position.Y, size, size);

        internal static IEnumerable<string> Explode(string content, int length) {
            for (var i = 0; i < content.Length; i += length)
                yield return content.Substring(i, Math.Min(length, content.Length - i));
        }
    }
}
