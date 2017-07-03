using System.Drawing;
using System.Windows.Forms;
using Amsterdam;
using Amsterdam.Text;

namespace Project_Amsterdam_Tester
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();

            var Definition = new SingleColorMatrixDefinition {
                ActivePixelBrush = new SolidBrush(ColorTranslator.FromHtml("#E8AA0E")),
                BackgroundBrush = new SolidBrush(Color.Black),
                DeadPixelRatio = 0F,
                InactivePixelBrush = new SolidBrush(ColorTranslator.FromHtml("#111")),
                MatrixSize = new Size(200, 18),
                PixelSize = 7,
                Rotation = 0F,
                StrokePen = new Pen(Color.Black, 1F)
            };

            singleColorMatrix1.ApplyDefinition(Definition);

            singleColorMatrix1.Controller.CharacterSet = CharacterSet.FromJson(@"C:\Projekte\Project Amsterdam\version2.json");

            singleColorMatrix1.Controller.DrawString("Project Amsterdam 2", 1, new TextFormat { HAlign = TextFormat.HorizontalAlign.Center });
            singleColorMatrix1.Controller.DrawString("festival.ml", 2, new TextFormat { HAlign = TextFormat.HorizontalAlign.Center });
        }
    }
}
