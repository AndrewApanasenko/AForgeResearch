using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;

namespace AForgeResearch
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection devices = null;
        private VideoCaptureDevice captureDevice = null;
        private bool frameRotateX = false;
        private bool frameRotateY = false;
        private bool frameGray = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo dev in devices)
            {
                lstDevice.Items.Add(dev.Name);
            }
        }

        private void lstDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(devices[lstDevice.SelectedIndex].MonikerString);
        }

        private void changeBtnImg()
        {
            btnPlayPause.Image = captureDevice.IsRunning ? Properties.Resources.pause : Properties.Resources.play;
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            try
            {
                if (devices.Count == 0)
                {
                    throw new Exception("No devices found!");
                }
                else if (lstDevice.SelectedItem == null)
                {
                    throw new Exception("Device not select!");
                }
                else if (captureDevice.IsRunning)
                {
                    captureDevice.Stop();
                }
                else
                {
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

        private void CaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap frame = new Bitmap(eventArgs.Frame);
            if (frameRotateX)
            {
                frame.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            if (frameRotateY)
            {
                frame.RotateFlip(RotateFlipType.RotateNoneFlipY);
            }
            if (frameGray)
            {
                Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
                frame = filter.Apply(frame);
            }
            scrCapture.Image = frame;
        }

        private void stopCapture(bool mShow=false)
        {
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
                if (mShow)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnScrShot_Click(object sender, EventArgs e)
        {
            
            Image srcScreenFile = (Bitmap)scrCapture.Image.Clone();
            SaveFileDialog saveFileDlg = new SaveFileDialog();
            saveFileDlg.FileName = DateTime.Now.ToString("MM_dd_yyyy") + "_screenshot";
            saveFileDlg.DefaultExt = ".png";
            saveFileDlg.Filter = "PNG|*.png";
            if (saveFileDlg.ShowDialog() == DialogResult.OK)
            {
                srcScreenFile.Save(saveFileDlg.FileName, ImageFormat.Png);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopCapture();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopCapture();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            frameRotateX = frameRotateX ? false : true;
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            frameRotateY = frameRotateY ? false : true;
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            frameGray = frameGray ? false : true;
        }
    }

}
