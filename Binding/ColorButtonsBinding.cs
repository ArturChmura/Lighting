using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace _5__GK_lab2
{
    public partial class MainWindow
    {
        private void AddColorButtonsBinding()
        {
            Binding constObjectButtonBinding = new Binding(nameof(this.constantObjectColorButton.BackColor), this, nameof(this.ConstVecIo), true, DataSourceUpdateMode.OnPropertyChanged)
            {
                DataSourceUpdateMode = DataSourceUpdateMode.Never,
            };
            constObjectButtonBinding.Format += new ConvertEventHandler(this.VectorToColor);
            this.constantObjectColorButton.DataBindings.Add(constObjectButtonBinding);

            Binding lightColorButtonBinding = new Binding(nameof(this.lightColorButton.BackColor), this, nameof(this.VecIl), true, DataSourceUpdateMode.OnPropertyChanged)
            {
                DataSourceUpdateMode = DataSourceUpdateMode.Never,
            };
            lightColorButtonBinding.Format += new ConvertEventHandler(this.VectorToColor);
            this.lightColorButton.DataBindings.Add(lightColorButtonBinding);
        }

        private void VectorToColor(object sender, ConvertEventArgs cevent)
        {
            if (cevent.DesiredType != typeof(Color))
            {
                return;
            }

            Vector3 vec = (Vector3)cevent.Value;
            Color color = Color.FromArgb((int)(vec.X * 255), (int)(vec.Y * 255), (int)(vec.Z * 255));

            cevent.Value = color;
        }
    }
}
