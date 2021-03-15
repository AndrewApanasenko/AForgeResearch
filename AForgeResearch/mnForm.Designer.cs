namespace AForgeResearch
{
    partial class mnForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mnForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lstDevice = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPlayPause = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnScrShot = new System.Windows.Forms.ToolStripButton();
            this.btnExpand = new System.Windows.Forms.ToolStripButton();
            this.btnFlip = new System.Windows.Forms.ToolStripButton();
            this.btnGray = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.scrCapture = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scrCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.lstDevice,
            this.toolStripSeparator1,
            this.btnPlayPause,
            this.btnStop,
            this.toolStripSeparator2,
            this.btnScrShot,
            this.btnExpand,
            this.btnFlip,
            this.btnGray,
            this.toolStripSeparator3,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(109, 22);
            this.toolStripLabel1.Text = "Video Input Device:";
            // 
            // lstDevice
            // 
            this.lstDevice.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.lstDevice.Name = "lstDevice";
            this.lstDevice.Size = new System.Drawing.Size(121, 25);
            this.lstDevice.SelectedIndexChanged += new System.EventHandler(this.lstDevice_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPlayPause.Image = global::AForgeResearch.Properties.Resources.play;
            this.btnPlayPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(23, 22);
            this.btnPlayPause.Text = "toolStripButton1";
            this.btnPlayPause.ToolTipText = "Play";
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Image = global::AForgeResearch.Properties.Resources.stop;
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(23, 22);
            this.btnStop.Text = "toolStripButton1";
            this.btnStop.ToolTipText = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnScrShot
            // 
            this.btnScrShot.BackColor = System.Drawing.SystemColors.Control;
            this.btnScrShot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnScrShot.Image = global::AForgeResearch.Properties.Resources.screenshot;
            this.btnScrShot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnScrShot.Name = "btnScrShot";
            this.btnScrShot.Size = new System.Drawing.Size(23, 22);
            this.btnScrShot.Text = "Screenshot";
            this.btnScrShot.Click += new System.EventHandler(this.btnScrShot_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExpand.Image = global::AForgeResearch.Properties.Resources.expand;
            this.btnExpand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(23, 22);
            this.btnExpand.Text = "Expand";
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnFlip
            // 
            this.btnFlip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFlip.Image = global::AForgeResearch.Properties.Resources.flip;
            this.btnFlip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(23, 22);
            this.btnFlip.Text = "Flip";
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // btnGray
            // 
            this.btnGray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGray.Image = global::AForgeResearch.Properties.Resources.gray;
            this.btnGray.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(23, 22);
            this.btnGray.Text = "Grayscale";
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = global::AForgeResearch.Properties.Resources.exit;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 22);
            this.btnExit.Text = "toolStripButton1";
            this.btnExit.ToolTipText = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // scrCapture
            // 
            this.scrCapture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scrCapture.BackgroundImage")));
            this.scrCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.scrCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrCapture.Location = new System.Drawing.Point(0, 25);
            this.scrCapture.Name = "scrCapture";
            this.scrCapture.Size = new System.Drawing.Size(584, 396);
            this.scrCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scrCapture.TabIndex = 1;
            this.scrCapture.TabStop = false;
            // 
            // mnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 421);
            this.Controls.Add(this.scrCapture);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 460);
            this.Name = "mnForm";
            this.Text = "AForge Research [Just testing]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scrCapture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox lstDevice;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPlayPause;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.PictureBox scrCapture;
        private System.Windows.Forms.ToolStripButton btnScrShot;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnExpand;
        private System.Windows.Forms.ToolStripButton btnFlip;
        private System.Windows.Forms.ToolStripButton btnGray;
    }
}

