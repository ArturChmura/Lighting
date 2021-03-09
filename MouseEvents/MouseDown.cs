using System.Windows.Forms;

namespace _5__GK_lab2
{
    public partial class MainWindow
    {
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.movingVertex = null;
            for (int i = 0; i < this.grid.Vertices.GetLength(0); i++)
            {
                for (int j = 0; j < this.grid.Vertices.GetLength(1); j++)
                {
                    if (this.grid.Vertices[i, j].Contains(e.Location))
                    {
                        this.lastMouseLocation = e.Location;
                        this.movingVertex = this.grid.Vertices[i, j];
                        break;
                    }
                }

                if (this.movingVertex != null)
                {
                    break;
                }
            }
        }
    }
}
