using System.Drawing;
using System.Windows.Forms;
using Amsterdam;
using Amsterdam.Text;

namespace Project_Amsterdam_Tester
{
    public partial class MainWindow : Form
    {
        public MainWindow() {
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

            scmMatrix.ApplyDefinition(Definition);

            scmMatrix.Controller.CharacterSet = CharacterSet.FromJson(@"C:\Projekte\Project Amsterdam\version2.json");

            scmMatrix.Controller.DrawString("Project Amsterdam", 1, new TextFormat { HAlign = TextFormat.HorizontalAlign.Center });
            scmMatrix.Controller.DrawString("festival.ml", 2, new TextFormat { HAlign = TextFormat.HorizontalAlign.Center });
        }
    }
}
