using System.Windows.Forms;

namespace _5__GK_lab2
{
    public partial class MainWindow
    {
        private void AddLabelsBinding()
        {
            Binding kdValueLabelBinding = new Binding(nameof(this.kdValueLabel.Text), this, nameof(this.Kd), true, DataSourceUpdateMode.Never);
            kdValueLabelBinding.Format += new ConvertEventHandler(this.FloatToFotmatString);
            this.kdValueLabel.DataBindings.Add(kdValueLabelBinding);

            Binding ksValueLabelBinding = new Binding(nameof(this.ksValueLabel.Text), this, nameof(this.Ks), true, DataSourceUpdateMode.Never);
            ksValueLabelBinding.Format += new ConvertEventHandler(this.FloatToFotmatString);
            this.ksValueLabel.DataBindings.Add(ksValueLabelBinding);

            Binding mValueLabelBinding = new Binding(nameof(this.mValueLabel.Text), this, nameof(this.M), true, DataSourceUpdateMode.Never);
            this.mValueLabel.DataBindings.Add(mValueLabelBinding);

            Binding rowsValueLabelBinding = new Binding(nameof(this.rowsValueLabel.Text), this, nameof(this.RowsCount), true, DataSourceUpdateMode.Never);
            this.rowsValueLabel.DataBindings.Add(rowsValueLabelBinding);
            
            Binding colValueLabelBinding = new Binding(nameof(this.colValueLabel.Text), this, nameof(this.ColCount), true, DataSourceUpdateMode.Never);
            this.colValueLabel.DataBindings.Add(colValueLabelBinding);
        }

        private void FloatToFotmatString(object sender, ConvertEventArgs cevent)
        {
            if (cevent.DesiredType != typeof(string))
            {
                return;
            }

            cevent.Value = ((float)cevent.Value).ToString("n2");
        }
    }
}
