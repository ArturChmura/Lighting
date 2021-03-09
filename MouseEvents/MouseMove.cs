using System;
using System.Windows.Forms;

namespace _5__GK_lab2
{
    public partial class MainWindow
    {
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.movingVertex != null)
            {
                int dx = e.X - this.lastMouseLocation.X;
                int dy = e.Y - this.lastMouseLocation.Y;

                int newX = this.movingVertex.X + dx;
                int newY = this.movingVertex.Y + dy;

                newX = Math.Max(Math.Min(newX, this.pictureBox.Width - 1), 0);
                newY = Math.Max(Math.Min(newY, this.pictureBox.Height - 1), 0);

                this.movingVertex.Move(newX - this.movingVertex.X, newY - this.movingVertex.Y);
            }

            this.lastMouseLocation = e.Location;
        }
    }
}
