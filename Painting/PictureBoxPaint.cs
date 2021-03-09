using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5__GK_lab2
{
    public partial class MainWindow
    {
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            var graphics = Graphics.FromImage(this.bitmap.Bitmap);
            graphics.FillRectangle(new SolidBrush(this.BackColor), 0, 0, this.bitmap.Width, this.bitmap.Height);

            Parallel.For(0, this.grid.Triangles.Length, i =>
            {
                this.fillPolygon(this.bitmap, this.grid.Triangles[i]);
            });
            e.Graphics.DrawImage(this.bitmap.Bitmap, new Point(0, 0));

            // Drawing triangles sides
            Pen blackPen = new Pen(Brushes.Black);
            for (int i = 0; i < this.grid.Triangles.Length; i++)
            {
                int n = this.grid.Triangles[i].Vertices.Length;
                float x1, y1, x2, y2;
                for (int j = 0; j < n - 1; j++)
                {
                    x1 = this.grid.Triangles[i].Vertices[j].X;
                    y1 = this.grid.Triangles[i].Vertices[j].Y;
                    x2 = this.grid.Triangles[i].Vertices[j + 1].X;
                    y2 = this.grid.Triangles[i].Vertices[j + 1].Y;
                    e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);
                }

                x1 = this.grid.Triangles[i].Vertices[n - 1].X;
                y1 = this.grid.Triangles[i].Vertices[n - 1].Y;
                x2 = this.grid.Triangles[i].Vertices[0].X;
                y2 = this.grid.Triangles[i].Vertices[0].Y;
                e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);
            }
        }
    }
}
