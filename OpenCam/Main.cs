using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV.CvEnum;
using Emgu.CV.Reg;
using System;
using System.Diagnostics;
using Emgu.CV.DepthAI;
using System.Text.RegularExpressions;
using Emgu.CV.Util;
using Emgu.Util;
using System.Runtime.CompilerServices;
using Emgu.CV.Face;
using Emgu.CV.Ocl;
using System.Collections;
using System.Management;
using System.Reflection;
using Emgu.CV.Dnn;

namespace Test
{
    public partial class Main : Form
    {
        VideoCapture _capture;
        private Mat _frame;

        public Main()
        {
            InitializeComponent();

            

            List<string> xx;

            xx = GetAllConnectedCameras();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> video;

            video = GetAllConnectedCameras();

            if (video != null)
            {
                int index = 0;
                foreach (var Count in video)
                {
                    toolStripComboBox1.Items.Add(video[index]);
                    index++;
                }
                toolStripComboBox1.SelectedIndex = 0;
            }
        }
        private void StartCam(int Cam)
        {
            _capture = new VideoCapture(Cam);

            _capture.ImageGrabbed += ProcessFrame;
            _frame = new Mat();
            if (_capture != null)
            {
                try
                {
                    _capture.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void ProcessFrame(object sender, EventArgs e)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                _capture.Retrieve(_frame, 0);


                CvInvoke.PutText(_frame, "Hallo", new Point(10, _frame.Height - 10), FontFace.HersheySimplex, 2.0, new Bgr(Color.White).MCvScalar);
        
                original.Image = _frame;

                Mat invert = new Mat();
                CvInvoke.BitwiseNot(_frame, invert);


         
            }
        }
        public static List<string> GetAllConnectedCameras()
        {
            var cameraNames = new List<string>();
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE (PNPClass = 'Image' OR PNPClass = 'Camera')"))
            {
                foreach (var device in searcher.Get())
                {
                    cameraNames.Add(device["Caption"].ToString());
                }
            }
            return cameraNames;
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartCam(toolStripComboBox1.SelectedIndex);
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _capture.Stop();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}

