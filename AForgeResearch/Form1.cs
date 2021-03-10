using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;

namespace AForgeResearch
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection devices = null;
        private VideoCaptureDevice captureDevice = null;

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
            scrCapture.Image = new Bitmap(eventArgs.Frame);
        }

        private void stopCapture()
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
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopCapture();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            stopCapture();
            Application.Exit();
        }
    }

}
