using System.Drawing;
using System.Linq;
using Amsterdam.Core;
using Amsterdam.Text;

namespace Amsterdam.Drawing
{
    public class SingleColorMatrixController
    {
        private SingleColorMatrix Matrix;
        private int Caret;

        public CharacterSet CharacterSet { get; set; }

        public SingleColorMatrixController(SingleColorMatrix matrix) {
            this.Matrix = matrix;
        }

        public void DrawString(string content, int line, TextFormat format) {
            var _Caret = Caret;

            if (format.HAlign == TextFormat.HorizontalAlign.Center) {
                _Caret = (Matrix.Size.Width / Matrix.GetPixelSize() - MeasureString(content)) / 2;
            }

            foreach (var Char in content) {
                var Character = CharacterSet[Char];
                var Lines = Helper.Explode(Character.Definition, Character.Definition.Length / Character.Height).ToList();

                for (var l = 0; l < Lines.Count; l++) {
                    var LineDef = Lines[l];
                    for (var d = 0; d < LineDef.Length; d++) {
                        var ElementDef = LineDef[d];
                        try {
                            var Pnt = new Point(_Caret + d, (CharacterSet.LineHeight + 2) * line - (Character.Height - l) - (CharacterSet.DefaultBaseline + Character.BaselineDelta));
                            var Element = Matrix.Pixels.Find(e => e.Position == Pnt);
                            if (Element.Active ^ ElementDef == '1') {
                                Element.Invalidated = true;
                                Element.Active = ElementDef == '1';
                            }
                        } catch { }
                    }
                }
                _Caret += Character.Definition.Length / Character.Height + 1;
            }

            if (format.HAlign == TextFormat.HorizontalAlign.Left) {
                Caret = _Caret;
            }

            Matrix.Invalidate();
        }

        public int MeasureString(string content) {
            return content.Select(c => CharacterSet[c]).Select(character => character.Definition.Length / character.Height + 1).Sum() - 1;
        }
    }
}
