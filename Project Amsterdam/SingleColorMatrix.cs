using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Amsterdam.Core;
using Amsterdam.Drawing;

namespace Amsterdam
{
    public sealed partial class SingleColorMatrix : Control, IMatrix
    {
        private SingleColorMatrixDefinition Definition = new SingleColorMatrixDefinition {
            ActivePixelBrush = new SolidBrush(ColorTranslator.FromHtml("#E8AA0E")),
            BackgroundBrush = new SolidBrush(Color.Black),
            DeadPixelRatio = 0F,
            InactivePixelBrush = new SolidBrush(ColorTranslator.FromHtml("#111")),
            MatrixSize = new Size(100, 9),
            PixelSize = 7,
            Rotation = 0F,
            StrokePen = new Pen(Color.Black, 1F)
        };

        public readonly List<SingleColorPixel> Pixels = new List<SingleColorPixel>();
        private PointF Center;

        public SingleColorMatrixController Controller { get; private set; }

        public SingleColorMatrix() {
            DoubleBuffered = true;

            InitializeComponent();

            Controller = new SingleColorMatrixController(this);
        }

        public void ApplyDefinition(IMatrixDefinition definition) {
            Definition = (SingleColorMatrixDefinition) definition;

            Helper.RepeatN(Definition.MatrixSize.ElementCount(), () => Pixels.Add(new SingleColorPixel()));
            ResetMatrix();
            Size = Definition.GetMatrixRectangle().Size;
            Center = new Point(Size.Width / 2, Size.Height / 2);

            Invalidate();
        }

        public int GetPixelSize() => Definition.PixelSize;

        public void ResetMatrix() {
            var Index = 0;
            for (var c = 0; c < Definition.MatrixSize.Width; c++) {
                for (var r = 0; r < Definition.MatrixSize.Height; r++) {
                    Pixels[Index].Active = false;
                    Pixels[Index].Invalidated = true;
                    Pixels[Index].Position = new Point(c, r);

                    Index++;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e) {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            try {
                var RotationMatrix = new Matrix();
                RotationMatrix.RotateAt(Definition.Rotation, Center);
                e.Graphics.Transform = RotationMatrix;

                e.Graphics.FillRectangle(Definition.BackgroundBrush, Definition.GetMatrixRectangle());
                Pixels.FindAll(p => p.Invalidated).ForEach(p => { e.Graphics.FillRectangle(p.Active ? Definition.ActivePixelBrush : Definition.InactivePixelBrush, Helper.GetPixelRectangle(p, Definition.PixelSize)); });
                Pixels.ForEach(p => e.Graphics.DrawRectangle(Definition.StrokePen, Helper.GetPixelRectangle(p, Definition.PixelSize)));
                Pixels.ForEach(p => p.Invalidated = false);

                e.Graphics.ResetTransform();
                RotationMatrix.Dispose();
            } catch { }
        }

        public void SetPixelState(int c, int r, bool active) {
            var Pixel = Pixels.Find(p => p.Position == new Point(c, r));
            Pixel.Active = active;
            Pixel.Invalidated = true;
            Invalidate();
        }
    }
}
