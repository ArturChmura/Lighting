namespace _5__GK_lab2
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.m_trackBar = new System.Windows.Forms.TrackBar();
            this.kd_trackBar = new System.Windows.Forms.TrackBar();
            this.ks_trackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lightColorButton = new System.Windows.Forms.Button();
            this.objectColorGroupBox = new System.Windows.Forms.GroupBox();
            this.fromImageObjectColorButton = new System.Windows.Forms.Button();
            this.constantObjectColorButton = new System.Windows.Forms.Button();
            this.fromImageObjectColorRadioButton = new System.Windows.Forms.RadioButton();
            this.constantObjectColorRadioButton = new System.Windows.Forms.RadioButton();
            this.fromImageVectorNButton = new System.Windows.Forms.Button();
            this.fromImageNVectorRadioButton = new System.Windows.Forms.RadioButton();
            this.constantNVectorRadioButton = new System.Windows.Forms.RadioButton();
            this.NVectorGroupBox = new System.Windows.Forms.GroupBox();
            this.animatedLRadioButton = new System.Windows.Forms.RadioButton();
            this.constantLVectorRadioButton = new System.Windows.Forms.RadioButton();
            this.LVectorGroupBox = new System.Windows.Forms.GroupBox();
            this.FPSTrackBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.interpolationCheckBox = new System.Windows.Forms.CheckBox();
            this.FPSTrackBarToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.kdValueLabel = new System.Windows.Forms.Label();
            this.ksValueLabel = new System.Windows.Forms.Label();
            this.mValueLabel = new System.Windows.Forms.Label();
            this.rowsCount_trackBar = new System.Windows.Forms.TrackBar();
            this.colCount_trackBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rowsValueLabel = new System.Windows.Forms.Label();
            this.colValueLabel = new System.Windows.Forms.Label();
            this.bubbleCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kd_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ks_trackBar)).BeginInit();
            this.objectColorGroupBox.SuspendLayout();
            this.NVectorGroupBox.SuspendLayout();
            this.LVectorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FPSTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsCount_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colCount_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox.Location = new System.Drawing.Point(2, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 618);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // m_trackBar
            // 
            this.m_trackBar.Location = new System.Drawing.Point(849, 481);
            this.m_trackBar.Maximum = 100;
            this.m_trackBar.Name = "m_trackBar";
            this.m_trackBar.Size = new System.Drawing.Size(212, 45);
            this.m_trackBar.TabIndex = 1;
            this.m_trackBar.Value = 1;
            this.m_trackBar.ValueChanged += new System.EventHandler(this.m_trackBar_ValueChanged);
            // 
            // kd_trackBar
            // 
            this.kd_trackBar.Location = new System.Drawing.Point(849, 379);
            this.kd_trackBar.Maximum = 100;
            this.kd_trackBar.Name = "kd_trackBar";
            this.kd_trackBar.Size = new System.Drawing.Size(212, 45);
            this.kd_trackBar.TabIndex = 1;
            this.kd_trackBar.Value = 40;
            this.kd_trackBar.ValueChanged += new System.EventHandler(this.kd_trackBar_ValueChanged);
            // 
            // ks_trackBar
            // 
            this.ks_trackBar.Location = new System.Drawing.Point(849, 430);
            this.ks_trackBar.Maximum = 100;
            this.ks_trackBar.Name = "ks_trackBar";
            this.ks_trackBar.Size = new System.Drawing.Size(212, 45);
            this.ks_trackBar.TabIndex = 1;
            this.ks_trackBar.Value = 60;
            this.ks_trackBar.Scroll += new System.EventHandler(this.ks_trackBar_ValueChanged);
            this.ks_trackBar.ValueChanged += new System.EventHandler(this.ks_trackBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(817, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "kd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(817, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(819, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "m";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(827, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kolor światła";
            // 
            // lightColorButton
            // 
            this.lightColorButton.Location = new System.Drawing.Point(907, 32);
            this.lightColorButton.Name = "lightColorButton";
            this.lightColorButton.Size = new System.Drawing.Size(75, 23);
            this.lightColorButton.TabIndex = 4;
            this.lightColorButton.UseVisualStyleBackColor = true;
            this.lightColorButton.Click += new System.EventHandler(this.lightColorButton_Click);
            // 
            // objectColorGroupBox
            // 
            this.objectColorGroupBox.Controls.Add(this.fromImageObjectColorButton);
            this.objectColorGroupBox.Controls.Add(this.constantObjectColorButton);
            this.objectColorGroupBox.Controls.Add(this.fromImageObjectColorRadioButton);
            this.objectColorGroupBox.Controls.Add(this.constantObjectColorRadioButton);
            this.objectColorGroupBox.Location = new System.Drawing.Point(818, 73);
            this.objectColorGroupBox.Name = "objectColorGroupBox";
            this.objectColorGroupBox.Size = new System.Drawing.Size(172, 75);
            this.objectColorGroupBox.TabIndex = 5;
            this.objectColorGroupBox.TabStop = false;
            this.objectColorGroupBox.Text = "Kolor objektu";
            // 
            // fromImageObjectColorButton
            // 
            this.fromImageObjectColorButton.Location = new System.Drawing.Point(89, 44);
            this.fromImageObjectColorButton.Name = "fromImageObjectColorButton";
            this.fromImageObjectColorButton.Size = new System.Drawing.Size(75, 23);
            this.fromImageObjectColorButton.TabIndex = 2;
            this.fromImageObjectColorButton.Text = "Wybierz";
            this.fromImageObjectColorButton.UseVisualStyleBackColor = true;
            this.fromImageObjectColorButton.Click += new System.EventHandler(this.fromImageObjectColorButton_Click);
            // 
            // constantObjectColorButton
            // 
            this.constantObjectColorButton.Location = new System.Drawing.Point(89, 19);
            this.constantObjectColorButton.Name = "constantObjectColorButton";
            this.constantObjectColorButton.Size = new System.Drawing.Size(75, 23);
            this.constantObjectColorButton.TabIndex = 2;
            this.constantObjectColorButton.UseVisualStyleBackColor = true;
            this.constantObjectColorButton.Click += new System.EventHandler(this.constantObjectColorButton_Click);
            // 
            // fromImageObjectColorRadioButton
            // 
            this.fromImageObjectColorRadioButton.AutoSize = true;
            this.fromImageObjectColorRadioButton.Location = new System.Drawing.Point(9, 46);
            this.fromImageObjectColorRadioButton.Name = "fromImageObjectColorRadioButton";
            this.fromImageObjectColorRadioButton.Size = new System.Drawing.Size(71, 19);
            this.fromImageObjectColorRadioButton.TabIndex = 1;
            this.fromImageObjectColorRadioButton.TabStop = true;
            this.fromImageObjectColorRadioButton.Text = "Z obrazu";
            this.fromImageObjectColorRadioButton.UseVisualStyleBackColor = true;
            this.fromImageObjectColorRadioButton.CheckedChanged += new System.EventHandler(this.fromImageObjectColorRadioButton_CheckedChanged);
            // 
            // constantObjectColorRadioButton
            // 
            this.constantObjectColorRadioButton.AutoSize = true;
            this.constantObjectColorRadioButton.Checked = true;
            this.constantObjectColorRadioButton.Location = new System.Drawing.Point(9, 21);
            this.constantObjectColorRadioButton.Name = "constantObjectColorRadioButton";
            this.constantObjectColorRadioButton.Size = new System.Drawing.Size(50, 19);
            this.constantObjectColorRadioButton.TabIndex = 0;
            this.constantObjectColorRadioButton.TabStop = true;
            this.constantObjectColorRadioButton.Text = "Stały";
            this.constantObjectColorRadioButton.UseVisualStyleBackColor = true;
            this.constantObjectColorRadioButton.CheckedChanged += new System.EventHandler(this.constantObjectColorRadioButton_CheckedChanged);
            // 
            // fromImageVectorNButton
            // 
            this.fromImageVectorNButton.Location = new System.Drawing.Point(89, 44);
            this.fromImageVectorNButton.Name = "fromImageVectorNButton";
            this.fromImageVectorNButton.Size = new System.Drawing.Size(75, 23);
            this.fromImageVectorNButton.TabIndex = 2;
            this.fromImageVectorNButton.Text = "Wybierz";
            this.fromImageVectorNButton.UseVisualStyleBackColor = true;
            this.fromImageVectorNButton.Click += new System.EventHandler(this.fromImageVectorNButton_Click);
            // 
            // fromImageNVectorRadioButton
            // 
            this.fromImageNVectorRadioButton.AutoSize = true;
            this.fromImageNVectorRadioButton.Location = new System.Drawing.Point(9, 44);
            this.fromImageNVectorRadioButton.Name = "fromImageNVectorRadioButton";
            this.fromImageNVectorRadioButton.Size = new System.Drawing.Size(71, 19);
            this.fromImageNVectorRadioButton.TabIndex = 1;
            this.fromImageNVectorRadioButton.TabStop = true;
            this.fromImageNVectorRadioButton.Text = "Z obrazu";
            this.fromImageNVectorRadioButton.UseVisualStyleBackColor = true;
            this.fromImageNVectorRadioButton.CheckedChanged += new System.EventHandler(this.fromImageNVectorRadioButton_CheckedChanged);
            // 
            // constantNVectorRadioButton
            // 
            this.constantNVectorRadioButton.AutoSize = true;
            this.constantNVectorRadioButton.Checked = true;
            this.constantNVectorRadioButton.Location = new System.Drawing.Point(9, 22);
            this.constantNVectorRadioButton.Name = "constantNVectorRadioButton";
            this.constantNVectorRadioButton.Size = new System.Drawing.Size(85, 19);
            this.constantNVectorRadioButton.TabIndex = 0;
            this.constantNVectorRadioButton.TabStop = true;
            this.constantNVectorRadioButton.Text = "Stały [0,0,1]";
            this.constantNVectorRadioButton.UseVisualStyleBackColor = true;
            this.constantNVectorRadioButton.CheckedChanged += new System.EventHandler(this.constantNVectorRadioButton_CheckedChanged);
            // 
            // NVectorGroupBox
            // 
            this.NVectorGroupBox.Controls.Add(this.fromImageVectorNButton);
            this.NVectorGroupBox.Controls.Add(this.fromImageNVectorRadioButton);
            this.NVectorGroupBox.Controls.Add(this.constantNVectorRadioButton);
            this.NVectorGroupBox.Location = new System.Drawing.Point(818, 178);
            this.NVectorGroupBox.Name = "NVectorGroupBox";
            this.NVectorGroupBox.Size = new System.Drawing.Size(172, 76);
            this.NVectorGroupBox.TabIndex = 5;
            this.NVectorGroupBox.TabStop = false;
            this.NVectorGroupBox.Text = "Wektor Normalny";
            // 
            // animatedLRadioButton
            // 
            this.animatedLRadioButton.AutoSize = true;
            this.animatedLRadioButton.Location = new System.Drawing.Point(9, 46);
            this.animatedLRadioButton.Name = "animatedLRadioButton";
            this.animatedLRadioButton.Size = new System.Drawing.Size(127, 19);
            this.animatedLRadioButton.TabIndex = 1;
            this.animatedLRadioButton.TabStop = true;
            this.animatedLRadioButton.Text = "Animowana Spirala";
            this.animatedLRadioButton.UseVisualStyleBackColor = true;
            this.animatedLRadioButton.CheckedChanged += new System.EventHandler(this.animatedLRadioButton_CheckedChanged);
            // 
            // constantLVectorRadioButton
            // 
            this.constantLVectorRadioButton.AutoSize = true;
            this.constantLVectorRadioButton.Checked = true;
            this.constantLVectorRadioButton.Location = new System.Drawing.Point(9, 21);
            this.constantLVectorRadioButton.Name = "constantLVectorRadioButton";
            this.constantLVectorRadioButton.Size = new System.Drawing.Size(85, 19);
            this.constantLVectorRadioButton.TabIndex = 0;
            this.constantLVectorRadioButton.TabStop = true;
            this.constantLVectorRadioButton.Text = "Stały [0,0,1]";
            this.constantLVectorRadioButton.UseVisualStyleBackColor = true;
            this.constantLVectorRadioButton.CheckedChanged += new System.EventHandler(this.constantLVectorRadioButton_CheckedChanged);
            // 
            // LVectorGroupBox
            // 
            this.LVectorGroupBox.Controls.Add(this.animatedLRadioButton);
            this.LVectorGroupBox.Controls.Add(this.constantLVectorRadioButton);
            this.LVectorGroupBox.Location = new System.Drawing.Point(818, 281);
            this.LVectorGroupBox.Name = "LVectorGroupBox";
            this.LVectorGroupBox.Size = new System.Drawing.Size(172, 76);
            this.LVectorGroupBox.TabIndex = 5;
            this.LVectorGroupBox.TabStop = false;
            this.LVectorGroupBox.Text = "Wektor Światła";
            // 
            // FPSTrackBar
            // 
            this.FPSTrackBar.Location = new System.Drawing.Point(1035, 32);
            this.FPSTrackBar.Maximum = 240;
            this.FPSTrackBar.Minimum = 5;
            this.FPSTrackBar.Name = "FPSTrackBar";
            this.FPSTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.FPSTrackBar.Size = new System.Drawing.Size(45, 312);
            this.FPSTrackBar.TabIndex = 6;
            this.FPSTrackBar.Value = 60;
            this.FPSTrackBar.Scroll += new System.EventHandler(this.FPSTrackBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1035, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "FPS";
            // 
            // interpolationCheckBox
            // 
            this.interpolationCheckBox.AutoSize = true;
            this.interpolationCheckBox.Location = new System.Drawing.Point(902, 154);
            this.interpolationCheckBox.Name = "interpolationCheckBox";
            this.interpolationCheckBox.Size = new System.Drawing.Size(88, 19);
            this.interpolationCheckBox.TabIndex = 8;
            this.interpolationCheckBox.Text = "Interpolacja";
            this.interpolationCheckBox.UseVisualStyleBackColor = true;
            this.interpolationCheckBox.CheckedChanged += new System.EventHandler(this.interpolationCheckBox_CheckedChanged);
            // 
            // kdValueLabel
            // 
            this.kdValueLabel.AutoSize = true;
            this.kdValueLabel.Location = new System.Drawing.Point(1056, 379);
            this.kdValueLabel.Name = "kdValueLabel";
            this.kdValueLabel.Size = new System.Drawing.Size(38, 15);
            this.kdValueLabel.TabIndex = 9;
            this.kdValueLabel.Text = "label6";
            // 
            // ksValueLabel
            // 
            this.ksValueLabel.AutoSize = true;
            this.ksValueLabel.Location = new System.Drawing.Point(1056, 430);
            this.ksValueLabel.Name = "ksValueLabel";
            this.ksValueLabel.Size = new System.Drawing.Size(38, 15);
            this.ksValueLabel.TabIndex = 9;
            this.ksValueLabel.Text = "label6";
            // 
            // mValueLabel
            // 
            this.mValueLabel.AutoSize = true;
            this.mValueLabel.Location = new System.Drawing.Point(1056, 481);
            this.mValueLabel.Name = "mValueLabel";
            this.mValueLabel.Size = new System.Drawing.Size(38, 15);
            this.mValueLabel.TabIndex = 9;
            this.mValueLabel.Text = "label6";
            // 
            // rowsCount_trackBar
            // 
            this.rowsCount_trackBar.Location = new System.Drawing.Point(884, 516);
            this.rowsCount_trackBar.Maximum = 60;
            this.rowsCount_trackBar.Minimum = 2;
            this.rowsCount_trackBar.Name = "rowsCount_trackBar";
            this.rowsCount_trackBar.Size = new System.Drawing.Size(177, 45);
            this.rowsCount_trackBar.TabIndex = 10;
            this.rowsCount_trackBar.Value = 30;
            this.rowsCount_trackBar.Scroll += new System.EventHandler(this.rowsCount_trackBar_Scroll);
            // 
            // colCount_trackBar
            // 
            this.colCount_trackBar.Location = new System.Drawing.Point(883, 567);
            this.colCount_trackBar.Maximum = 60;
            this.colCount_trackBar.Minimum = 2;
            this.colCount_trackBar.Name = "colCount_trackBar";
            this.colCount_trackBar.Size = new System.Drawing.Size(178, 45);
            this.colCount_trackBar.TabIndex = 10;
            this.colCount_trackBar.Value = 20;
            this.colCount_trackBar.Scroll += new System.EventHandler(this.colCount_trackBar_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(806, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ilość wierszy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(808, 567);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ilość kolumn";
            // 
            // rowsValueLabel
            // 
            this.rowsValueLabel.AutoSize = true;
            this.rowsValueLabel.Location = new System.Drawing.Point(1056, 523);
            this.rowsValueLabel.Name = "rowsValueLabel";
            this.rowsValueLabel.Size = new System.Drawing.Size(38, 15);
            this.rowsValueLabel.TabIndex = 9;
            this.rowsValueLabel.Text = "label6";
            // 
            // colValueLabel
            // 
            this.colValueLabel.AutoSize = true;
            this.colValueLabel.Location = new System.Drawing.Point(1056, 567);
            this.colValueLabel.Name = "colValueLabel";
            this.colValueLabel.Size = new System.Drawing.Size(38, 15);
            this.colValueLabel.TabIndex = 9;
            this.colValueLabel.Text = "label6";
            // 
            // bubbleCheckBox
            // 
            this.bubbleCheckBox.AutoSize = true;
            this.bubbleCheckBox.Location = new System.Drawing.Point(825, 248);
            this.bubbleCheckBox.Name = "bubbleCheckBox";
            this.bubbleCheckBox.Size = new System.Drawing.Size(67, 19);
            this.bubbleCheckBox.TabIndex = 12;
            this.bubbleCheckBox.Text = "Bąbelek";
            this.bubbleCheckBox.UseVisualStyleBackColor = true;
            this.bubbleCheckBox.CheckedChanged += new System.EventHandler(this.bubbleCheckBox_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 624);
            this.Controls.Add(this.bubbleCheckBox);
            this.Controls.Add(this.colValueLabel);
            this.Controls.Add(this.rowsValueLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.colCount_trackBar);
            this.Controls.Add(this.rowsCount_trackBar);
            this.Controls.Add(this.mValueLabel);
            this.Controls.Add(this.ksValueLabel);
            this.Controls.Add(this.kdValueLabel);
            this.Controls.Add(this.interpolationCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FPSTrackBar);
            this.Controls.Add(this.LVectorGroupBox);
            this.Controls.Add(this.NVectorGroupBox);
            this.Controls.Add(this.objectColorGroupBox);
            this.Controls.Add(this.lightColorButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ks_trackBar);
            this.Controls.Add(this.kd_trackBar);
            this.Controls.Add(this.m_trackBar);
            this.Controls.Add(this.pictureBox);
            this.Name = "MainWindow";
            this.Text = "Obrazki Światełka Lustra teraz 50% taniej";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kd_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ks_trackBar)).EndInit();
            this.objectColorGroupBox.ResumeLayout(false);
            this.objectColorGroupBox.PerformLayout();
            this.NVectorGroupBox.ResumeLayout(false);
            this.NVectorGroupBox.PerformLayout();
            this.LVectorGroupBox.ResumeLayout(false);
            this.LVectorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FPSTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsCount_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colCount_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TrackBar m_trackBar;
        private System.Windows.Forms.TrackBar kd_trackBar;
        private System.Windows.Forms.TrackBar ks_trackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button lightColorButton;
        private System.Windows.Forms.GroupBox objectColorGroupBox;
        private System.Windows.Forms.RadioButton fromImageObjectColorRadioButton;
        private System.Windows.Forms.RadioButton constantObjectColorRadioButton;
        private System.Windows.Forms.Button fromImageObjectColorButton;
        private System.Windows.Forms.Button constantObjectColorButton;
        private System.Windows.Forms.Button fromImageVectorNButton;
        private System.Windows.Forms.RadioButton fromImageNVectorRadioButton;
        private System.Windows.Forms.RadioButton constantNVectorRadioButton;
        private System.Windows.Forms.GroupBox NVectorGroupBox;
        private System.Windows.Forms.RadioButton constantLVectorRadioButton;
        private System.Windows.Forms.GroupBox LVectorGroupBox;
        private System.Windows.Forms.RadioButton animatedLRadioButton;
        private System.Windows.Forms.TrackBar FPSTrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox interpolationCheckBox;
        private System.Windows.Forms.ToolTip FPSTrackBarToolTip;
        private System.Windows.Forms.Label kdValueLabel;
        private System.Windows.Forms.Label ksValueLabel;
        private System.Windows.Forms.Label mValueLabel;
        private System.Windows.Forms.TrackBar rowsCount_trackBar;
        private System.Windows.Forms.TrackBar colCount_trackBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label rowsValueLabel;
        private System.Windows.Forms.Label colValueLabel;
        private System.Windows.Forms.CheckBox bubbleCheckBox;
    }
}

