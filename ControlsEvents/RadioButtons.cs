using System;
using System.Drawing;
using System.Numerics;

namespace _5__GK_lab2
{
    public partial class MainWindow
    {
        private void constantObjectColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.constantObjectColorRadioButton.Checked)
            {
                this.getVecIo = (int x, int y) => this.constVecIo;
            }
        }

        private void fromImageObjectColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.fromImageObjectColorRadioButton.Checked)
            {
                this.getVecIo = (int x, int y) =>
                {
                    Color color = this.objectBitmap.GetPixel(x, y);
                    return new Vector3((float)color.R / 255, (float)color.G / 255, (float)color.B / 255);
                };
            }
        }

        private void constantNVectorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.constantNVectorRadioButton.Checked)
            {
                this.getOutBubbleVecN.GetOutBubbleVecN = (int x, int y) => this.constN;
            }
        }

        private void fromImageNVectorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.fromImageNVectorRadioButton.Checked)
            {
                this.getOutBubbleVecN.GetOutBubbleVecN = (int x, int y) =>
                {
                    Color color = this.vecNBitmap.GetPixel(x, y);
                    return new Vector3((((float)color.R) * 2 / 255) - 1, (((float)color.G) * 2 / 255) - 1, ((float)color.B) / 255);
                };
            }
        }

        private void constantLVectorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.constantLVectorRadioButton.Checked)
            {
                this.getVecL = (int x, int y) => this.constVecL;
                this.spiralTimer?.Stop();
            }
        }

        private void animatedLRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.animatedLRadioButton.Checked)
            {
                this.getVecL = (int x, int y) =>
                {
                    return this.animatedVecL - new Vector3(x, y, 0);
                };
                this.spiralMiddle = new PointF(this.bitmap.Width / 2, this.bitmap.Height / 2);
                this.spiralRadius = Math.Min(this.bitmap.Width, this.bitmap.Height) / 4;
                this.animatedVecL = new Vector3(this.spiralRadius, 0, this.vecLMaxHeight);
                this.spiralTimer.Start();
            }
        }
    }
}
