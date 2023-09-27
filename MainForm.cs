using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Photo_booth
{
    public partial class MainForm : Form
    {
        private Bitmap cameraInputImage;
        private Image emptyImageBuffer;
        private string baseDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

        private FilterInfoCollection filterInfoCollection;

        private int numberOfColumns = 2;
        private int numberOfRows = 3;

        private VideoCaptureDevice videoCaptureDevice;

        public MainForm()
        {
            InitializeComponent();
        }

        public static Bitmap ResizeImage(Bitmap imgToResize, Size size)
        {
            try
            {
                Bitmap b = new Bitmap(size.Width, size.Height);
                using (Graphics g = Graphics.FromImage((Image)b))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.DrawImage(imgToResize, 0, 0, size.Width, size.Height);
                }
                return b;
            }
            catch
            {
                Console.WriteLine("Bitmap could not be resized");
                return imgToResize;
            }
        }

        private Image[] captureImages()
        {
            Image[] images = new Image[numberOfColumns * numberOfRows];

            // Set the initial time
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Define the interval in seconds
            double interval = 1.5;
            int iterator = 0;

            while (iterator < numberOfColumns * numberOfRows)
            {
                TimeSpan elapsed = stopwatch.Elapsed;
                // Check if the elapsed time is greater than or equal to the interval
                if (elapsed.TotalSeconds >= interval)
                {
                    using (var soundPlayer = new SoundPlayer(baseDirectory + "\\shutterSound.wav"))
                    {
                        soundPlayer.Play();
                    }
                    images[iterator] = (Bitmap)cameraInputImage.Clone();
                    iterator++;

                    // Restart the stopwatch for the next interval
                    stopwatch.Restart();
                }
            }

            return images;
        }

        private void savePicture_Click(object sender, EventArgs eventArgs)
        {
            oneByThreeRadioButton.Enabled = false;
            oneByFourRadioButton.Enabled = false;
            twoByThreeRadioButton.Enabled = false;

            Image[] capturedImages = captureImages(); // On a sidenote - in the end I couldn't set it up in a separate thread like in Python

            Bitmap emptyImageBuffer = new Bitmap(20 + 532 * numberOfColumns, 20 + 308 * numberOfRows);
            using (Graphics graphics = Graphics.FromImage(emptyImageBuffer))
            {
                Rectangle ImageSize = new Rectangle(0, 0, 20 + 532 * numberOfColumns, 20 + 308 * numberOfRows);
                graphics.FillRectangle(Brushes.White, ImageSize);

                int rowIterator = 0, columnIterator = 0;
                for (int iterator = 0; iterator < capturedImages.Length; iterator++)
                {
                    graphics.DrawImage(capturedImages[iterator], 20 + 532 * columnIterator, 20 + 308 * rowIterator);

                    if (columnIterator + 1 < numberOfColumns)
                    {
                        columnIterator++;
                    }
                    else
                    {
                        rowIterator++;
                        columnIterator = 0;
                    }
                }
            }

            Image newImage = emptyImageBuffer;

            newImage.Save(baseDirectory + "\\photoboothImage.jpg");
            Process.Start(baseDirectory + "\\photoboothImage.jpg");

            oneByThreeRadioButton.Enabled = true;
            oneByFourRadioButton.Enabled = true;
            twoByThreeRadioButton.Enabled = true;
            return;
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (File.Exists((baseDirectory + "\\photoboothImage.jpg")){
                Image newImage = Image.FromFile(baseDirectory + "\\photoboothImage.jpg");
                Clipboard.SetDataObject(newImage);
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs focusventArgs)
        {
            if (sender != null)
            {
                RadioButton radio = sender as RadioButton;
                switch (int.Parse(radio.Tag.ToString()))
                {
                    case 1:
                        numberOfColumns = 1;
                        numberOfRows = 3;
                        break;

                    case 2:
                        numberOfColumns = 1;
                        numberOfRows = 4;
                        break;

                    case 3:
                        numberOfColumns = 2;
                        numberOfRows = 3;
                        break;

                    default:
                        numberOfColumns = 2;
                        numberOfRows = 3;
                        break;
                }
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs newFrameEventArgs)
        {
            cameraInputImage = ResizeImage((Bitmap)newFrameEventArgs.Frame.Clone(), new Size(512, 288));
            cameraOutput.Image = ResizeImage((Bitmap)newFrameEventArgs.Frame.Clone(), new Size(542, 303)); ;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.Stop();
            }
        }
    }
}