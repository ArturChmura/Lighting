using System;
using System.Numerics;

namespace _5__GK_lab2
{
    public partial class MainWindow
    {
        private void TimerEventRefresh(object myObject, EventArgs myEventArgs)
        {
            this.pictureBox.Invalidate();
        }

        private void TimerEventProcessor(object myObject, EventArgs myEventArgs)
        {
            if (this.animatedVecL.Z > this.vecLMaxHeight || this.animatedVecL.Z < this.vecLMinHeight)
            {
                this.animationZSpeed *= -1;
            }

            float z = this.animatedVecL.Z;
            this.animatedVecL = new Vector3((float)Math.Cos(this.spiralAngle), (float)Math.Sin(this.spiralAngle), 0);
            this.animatedVecL *= this.spiralRadius / this.animatedVecL.Length();
            this.animatedVecL.X += this.spiralMiddle.X;
            this.animatedVecL.Y += this.spiralMiddle.Y;
            this.animatedVecL.Z += z + this.animationZSpeed;
            this.spiralAngle += this.spiralRotationSpeed;
        }
    }
}
