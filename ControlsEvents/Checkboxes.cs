using System;

namespace _5__GK_lab2
{
    public partial class MainWindow
    {
        private void interpolationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.interpolationCheckBox.Checked)
            {
                this.fillPolygon = this.fillPolygonActionInterpolate;
            }
            else
            {
                this.fillPolygon = this.fillPolygonActionDirect;
            }
        }

        private void bubbleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.bubbleCheckBox.Checked)
            {
                this.getVecN = this.getBubbleVecN;
            }
            else
            {
                this.getVecN = this.getOutBubbleVecN.GetVec;
            }
        }
    }
}
