using System;

namespace _5__GK_lab2
{
    public partial class MainWindow
    {
        private void m_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.M = this.m_trackBar.Value;
        }

        private void kd_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Kd = (float)this.kd_trackBar.Value / 100;
        }

        private void ks_trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Ks = (float)this.ks_trackBar.Value / 100;
        }

        private void FPSTrackBar_Scroll(object sender, EventArgs e)
        {
            this.refreshTimer.Stop();
            this.refreshTimer.Interval = 1000 / this.FPSTrackBar.Value;
            this.refreshTimer.Start();
            this.FPSTrackBarToolTip.SetToolTip(this.FPSTrackBar, this.FPSTrackBar.Value.ToString());
        }

        private void rowsCount_trackBar_Scroll(object sender, EventArgs e)
        {
            this.RowsCount = Math.Max(this.rowsCount_trackBar.Value,2);
            this.grid = new Models.Grid(this.RowsCount, this.ColCount, this.bitmap.Width, this.bitmap.Height);
        }

        private void colCount_trackBar_Scroll(object sender, EventArgs e)
        {
            this.ColCount = Math.Max(this.colCount_trackBar.Value,2);
            this.grid = new Models.Grid(this.RowsCount, this.ColCount, this.bitmap.Width, this.bitmap.Height);
        }
    }
}
