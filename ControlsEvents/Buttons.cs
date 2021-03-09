using System;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Windows.Forms;
using _5__GK_lab2.BitMapExtensions;

namespace _5__GK_lab2
{
    public partial class MainWindow
    {
        private void lightColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog myDialog = new ColorDialog
            {
                AllowFullOpen = false,
                Color = Color.FromArgb((int)this.vecIl.X * 255, (int)this.vecIl.Y * 255, (int)this.vecIl.Z * 255),
            };

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                this.VecIl = new Vector3((float)(myDialog.Color.R / 255), (float)myDialog.Color.G / 255, (float)myDialog.Color.B / 255);
            }
        }

        private void constantObjectColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog myDialog = new ColorDialog
            {
                AllowFullOpen = false,
                Color = Color.FromArgb((int)this.ConstVecIo.X * 255, (int)this.ConstVecIo.Y * 255, (int)this.ConstVecIo.Z * 255),
            };

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                this.ConstVecIo = new Vector3((float)myDialog.Color.R / 255, (float)myDialog.Color.G / 255, (float)myDialog.Color.B / 255);
            }
        }

        private void fromImageObjectColorButton_Click(object sender, EventArgs e)
        {
            string combinedPath = Path.Combine(Directory.GetCurrentDirectory(), ".\\Images");
            using OpenFileDialog dlg = new OpenFileDialog
            {
                Title = "Open Image",
                Filter = "All files (*.*)|*.*|bmp files (*.jpg)|*.jpg",
                InitialDirectory = System.IO.Path.GetFullPath(combinedPath),
                
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.objectBitmap.Dispose();
                this.objectBitmap = new DirectBitmap(dlg.FileName, this.pictureBox.Width, this.pictureBox.Height);
            }
        }

        private void fromImageVectorNButton_Click(object sender, EventArgs e)
        {
            string combinedPath = Path.Combine(Directory.GetCurrentDirectory(), ".\\Images");
            using OpenFileDialog dlg = new OpenFileDialog
            {
                Title = "Open Image",
                Filter = "All files (*.*)|*.*|bmp files (*.jpg)|*.jpg",
                InitialDirectory = System.IO.Path.GetFullPath(combinedPath),
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.vecNBitmap.Dispose();
                this.vecNBitmap = new DirectBitmap(dlg.FileName, this.pictureBox.Width, this.pictureBox.Height);
            }
        }
    }
}
