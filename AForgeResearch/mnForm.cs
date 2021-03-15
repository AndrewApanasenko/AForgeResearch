using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;

namespace AForgeResearch
{
    // Andrew S. Apanasenko
    // WhatsApp: +7 969 089 9911
    public partial class mnForm : Form
    {
        // creating global variables.
        private FilterInfoCollection devices = null;
        private VideoCaptureDevice captureDevice = null;
        private bool debug = false;
        private bool frameRotateX = false;
        private bool frameRotateY = false;
        private bool frameGray = false;

        public mnForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get device list and put it to ListBox.
            devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo dev in devices)
            {
                lstDevice.Items.Add(dev.Name);
            }
        }

        private void lstDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set active device.
            captureDevice = new VideoCaptureDevice(devices[lstDevice.SelectedIndex].MonikerString);
        }

        private void changeBtnImg()
        {
            // Сhange play/pause button image depending on view state.
            btnPlayPause.Image = captureDevice.IsRunning ? Properties.Resources.pause : Properties.Resources.play;
        }

        // Event handler.
        private void CaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            // Get captured image.
            Bitmap frame = new Bitmap(eventArgs.Frame);
            if (frameRotateX)
            {
                // Expand button pressed. Expand image.
                frame.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            if (frameRotateY)
            {
                // Flip button pressed. flip image.
                frame.RotateFlip(RotateFlipType.RotateNoneFlipY);
            }
            if (frameGray)
            {
                // Grayscale button is pressed. Applying grayscale filter.
                Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
                frame = filter.Apply(frame);
            }
            // Put captured image into scrCapture.
            scrCapture.Image = frame;
        }

        private void stopCapture()
        {
            // If capture run, stop process, clear PictureBox and change button image.
            try
            {
                if (captureDevice != null && captureDevice.IsRunning)
                {
                    captureDevice.Stop();
                }
                changeBtnImg();
                scrCapture.Image = null;
            }
            catch (Exception ex)
            {
                if (debug)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBG(ToolStripButton btn, bool flag)
        {
            // Set active/inactive state for ToolStripButton object by state flag.
            btn.BackColor = flag ? SystemColors.ActiveCaption : SystemColors.Control;
        }

        // Before form close
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopCapture();
        }

        // Play/Pause button.
        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            try
            {
                if (devices.Count == 0)
                {
                    // Device list is empty.
                    throw new Exception("No devices found!");
                }
                else if (lstDevice.SelectedItem == null)
                {
                    // Device not select in ListBox.
                    throw new Exception("Device not select!");
                }
                else if (captureDevice.IsRunning)
                {
                    // Pause.
                    captureDevice.Stop();
                }
                else
                {
                    // Play video and subscribe to event.
                    captureDevice.NewFrame += CaptureDevice_NewFrame;
                    captureDevice.Start();
                }
                changeBtnImg();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Screenshot button
        private void btnScrShot_Click(object sender, EventArgs e)
        {
            try
            {
                // Get clone of current captured image.
                Image srcScreenFile = (Bitmap)scrCapture.Image.Clone();
                // Open SaveDialog.
                SaveFileDialog saveFileDlg = new SaveFileDialog();
                // Set default filename and extension.
                saveFileDlg.FileName = DateTime.Now.ToString("MM_dd_yyyy") + "_screenshot";
                saveFileDlg.DefaultExt = ".png";
                // Set file extension filter.
                saveFileDlg.Filter = "PNG|*.png";
                if (saveFileDlg.ShowDialog() == DialogResult.OK)
                {
                    // Save image to selected file.
                    srcScreenFile.Save(saveFileDlg.FileName, ImageFormat.Png);
                }
            }
            catch (Exception ex)
            {
                if (debug)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Stop button
        private void btnStop_Click(object sender, EventArgs e)
        {
            stopCapture();
        }

        // Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Turn button
        private void btnTurn_Click(object sender, EventArgs e)
        {
            frameRotateX = frameRotateX ? false : true;
            btnBG(sender as ToolStripButton, frameRotateX);
        }

        // Flip button
        private void btnFlip_Click(object sender, EventArgs e)
        {
            frameRotateY = frameRotateY ? false : true;
            btnBG(sender as ToolStripButton, frameRotateY);
        }

        // Grayscale button
        private void btnGray_Click(object sender, EventArgs e)
        {
            frameGray = frameGray ? false : true;
            btnBG(sender as ToolStripButton, frameGray);
        }

    }

}
