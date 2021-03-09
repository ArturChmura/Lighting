using System;
using System.ComponentModel;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;
using _5__GK_lab2.BitMapExtensions;
using _5__GK_lab2.Models;

namespace _5__GK_lab2
{
    [System.ComponentModel.DesignerCategory("")]
    public partial class MainWindow : Form, INotifyPropertyChanged
    {
        private readonly float vecLMaxHeight;
        private readonly float vecLMinHeight = 0.5f;
        private readonly int animationFPS = 60;

        private readonly Timer refreshTimer;
        private readonly Timer spiralTimer = new Timer();
        private readonly double spiralRotationSpeed = Math.PI * 2 / 30;

        private readonly int bubbleRadious = 100;

        private readonly DirectBitmap bitmap;
        private DirectBitmap objectBitmap;
        private DirectBitmap vecNBitmap;
        private Grid grid;

        private Action<DirectBitmap, Polygon> fillPolygon;
        private Action<DirectBitmap, Polygon> fillPolygonActionDirect;
        private Action<DirectBitmap, Polygon> fillPolygonActionInterpolate;

        private float ks;
        private float kd;
        private int m;

        private Vector3 vecIl = new Vector3(1, 1, 1);

        private Vector3 constVecIo = new Vector3(0.2f, 0.6f, 0.9f);
        private Func<int, int, Vector3> getVecIo;

        private Vector3 constVecL = new Vector3(0, 0, 1);
        private Vector3 animatedVecL;
        private Func<int, int, Vector3> getVecL;

        private Vector3 constN = new Vector3(0, 0, 1);
        private Func<int, int, Vector3> getVecN;
        private GetOutBubbleVecNClass getOutBubbleVecN;

        private Func<int, int, Vector3> getBubbleVecN;

        private Vector3 vecV = new Vector3(0, 0, 1);

        private Vertex movingVertex;
        private Point lastMouseLocation;

        private PointF spiralMiddle;
        private float spiralRadius;
        private double spiralAngle = 0;

        private float animationZSpeed = 1f;

        private int rowsCount = 30;
        private int colCount = 30;

        public MainWindow()
        {
            this.InitializeComponent();
            this.MaximumSize = this.MinimumSize = this.Size;

            this.bitmap = new DirectBitmap(this.pictureBox.Width, this.pictureBox.Height);
            this.pictureBox.Image = this.bitmap.Bitmap;
            this.grid = new Grid(this.rowsCount, this.colCount, this.bitmap.Width, this.bitmap.Height);
            this.ks = (float)this.ks_trackBar.Value / 100;
            this.kd = (float)this.kd_trackBar.Value / 100;
            this.m = this.m_trackBar.Value;
            this.objectBitmap = new DirectBitmap(@"Images\Peja.jpg", this.pictureBox.Width, this.pictureBox.Height);
            this.vecNBitmap = new DirectBitmap(@"Images\NormalMap2.png", this.pictureBox.Width, this.pictureBox.Height);

            this.spiralTimer.Interval = 1000 / this.animationFPS;
            this.spiralTimer.Tick += new EventHandler(this.TimerEventProcessor);

            this.vecLMaxHeight = this.pictureBox.Height;
            this.refreshTimer = new Timer()
            {
                Interval = 1000 / this.FPSTrackBar.Value,
            };
            this.refreshTimer.Tick += this.TimerEventRefresh;
            this.refreshTimer.Start();

            this.InitActions();
            this.AddColorButtonsBinding();
            this.AddLabelsBinding();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Vector3 ConstVecIo
        {
            get => this.constVecIo; set
            {
                if (this.constVecIo == value)
                {
                    return;
                }

                this.constVecIo = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.ConstVecIo)));
            }
        }

        public Vector3 VecIl
        {
            get => this.vecIl; set
            {
                if (this.vecIl == value)
                {
                    return;
                }

                this.vecIl = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.VecIl)));
            }
        }

        public float Kd
        {
            get => this.kd; set
            {
                if (this.kd == value)
                {
                    return;
                }

                this.kd = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Kd)));
            }
        }

        public float Ks
        {
            get => this.ks; set
            {
                if (this.ks == value)
                {
                    return;
                }

                this.ks = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Ks)));
            }
        }

        public int M
        {
            get => this.m; set
            {
                if (this.m == value)
                {
                    return;
                }

                this.m = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.M)));
            }
        }

        public int RowsCount
        {
            get => this.rowsCount; set
            {
                if (this.rowsCount == value)
                {
                    return;
                }

                this.rowsCount = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.RowsCount)));
            }
        }

        public int ColCount
        {
            get => this.colCount; set
            {
                if (this.colCount == value)
                {
                    return;
                }

                this.colCount = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.ColCount)));
            }
        }
    }
}
