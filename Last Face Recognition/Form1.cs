using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace Last_Face_Recognition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private VideoCapture VideoCapture;
        private CascadeClassifier HaarCascade = null;
        private Image<Bgr, byte> CurrentImage = null;
        private List<FaceInfo> FaceList = new List<FaceInfo>();
        private VectorOfMat ImageList = new VectorOfMat();
        private List<string> NameList = new List<string>();
        private VectorOfInt LabelsVictor = new VectorOfInt();
        private EigenFaceRecognizer FaceRecognizer = null;

        public string FacePhotosPath = "Data\\Faces\\";
        public string FaceListTextFile = "Data\\FacesList.txt";
        public string HaarCascadePath = "haarcascade_frontalface_default.xml";
        public string ImageFileExtension = ".bmp";
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(HaarCascadePath))
            {
                MessageBox.Show("Haarcascade fayli topilmadi", "Xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!Directory.Exists(FacePhotosPath))
            {
                Directory.CreateDirectory(FacePhotosPath);
            }
            if (!File.Exists(FaceListTextFile))
            {
                File.Create(FaceListTextFile).Close();
            }
            HaarCascade = new CascadeClassifier(HaarCascadePath);
        }
        private void openCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Initialize();
            GetFaceList();
        }

        private void Initialize()
        {
            if (VideoCapture != null)
                VideoCapture.Dispose();

            VideoCapture = new VideoCapture();
            VideoCapture.SetCaptureProperty(CapProp.Fps, 30);
            Application.Idle += ProcessVideoFrame;
        }

        private void ProcessVideoFrame(object sender, EventArgs e)
        {
            CurrentImage = VideoCapture.QueryFrame().ToImage<Bgr, Byte>();

            if (CurrentImage != null)
            {
                try
                {
                    Image<Gray, byte> grayImage = CurrentImage.Convert<Gray, byte>();
                    Rectangle[] faces = HaarCascade.DetectMultiScale(grayImage, 1.2, 10, new System.Drawing.Size(50, 50), new System.Drawing.Size(200, 200));
                    
                    int currentFaceIndex = 0;
                    foreach (var face in faces)
                    {
                        CurrentImage.Draw(face, new Bgr(Color.LightGreen), 2);
                        Image<Gray, Byte> DetectedFace = CurrentImage.Copy(face).Convert<Gray, byte>();
                        FaceRecognition(DetectedFace, face, currentFaceIndex);
                        currentFaceIndex++;
                    }
                    Bitmap cameraCapture = CurrentImage.ToBitmap();
                    pictureBox1.Image = cameraCapture;
                    if (CurrentImage != null)
                    {
                        CurrentImage.Dispose();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void FaceRecognition(Image<Gray, byte> detectedFaceImage, Rectangle face, int currentFaceIndex)
        {
            string recognizedFaceName = string.Empty;
            if (ImageList.Size != 0)
            {
                Emgu.CV.Face.FaceRecognizer.PredictionResult result = FaceRecognizer.Predict(detectedFaceImage.Resize(148, 148, Inter.Cubic));
                recognizedFaceName = NameList[result.Label];
            }
            else
            {
                recognizedFaceName = "Noma'lum shaxs";
            }

            CurrentImage.Draw(recognizedFaceName, new Point(face.X - 2, face.Y - 2), FontFace.HersheyDuplex, 0.5, new Bgr(Color.LightGreen));
            Bitmap CameraCaptureFace = detectedFaceImage.ToBitmap();

            switch (currentFaceIndex)
            {
                case 0:
                    pbDetectedFace0.Image = CameraCaptureFace;
                    txtRecognizedFace0.Text = recognizedFaceName;
                    break;
                case 1:
                    pbDetectedFace1.Image = CameraCaptureFace;
                    txtRecognizedFace1.Text = recognizedFaceName;
                    break;
                default:
                    break;
            }
        }

        private void GetFaceList()
        {
            try
            {
                HaarCascade = new CascadeClassifier(HaarCascadePath);
                FaceList.Clear();
                string line = string.Empty;
                FaceInfo faceInfo = null;

                StreamReader reader = new StreamReader(FaceListTextFile);
                int index = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] lineParts = line.Split(':');
                    faceInfo = new FaceInfo();
                    faceInfo.GrayImage = new Image<Gray, Byte>(FacePhotosPath + lineParts[0] + ImageFileExtension);
                    faceInfo.Name = lineParts[1];
                    FaceList.Add(faceInfo);
                }
                foreach (var face in FaceList)
                {
                    ImageList.Push(face.GrayImage.Mat);
                    NameList.Add(face.Name);
                    LabelsVictor.Push(new[] { index++ });
                }
                reader.Close();

                if (ImageList.Size > 0)
                {
                    FaceRecognizer = new EigenFaceRecognizer(ImageList.Size);
                    FaceRecognizer.Train(ImageList, LabelsVictor);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSave_Click_Click(object sender, EventArgs e)
        {
            SavedDetectedFace(pbDetectedFace0.Image);
            GetFaceList();
        }

        private void SavedDetectedFace(Image img)
        {
            if (img == null)
            {
                MessageBox.Show("Tasvirda birorta yuzni aniqlay olmadim");
                return;
            }

            Size size = new Size(148, 148);
            Bitmap bmp = new Bitmap(img, size);
            bmp.Save(FacePhotosPath + "yuz" + (FaceList.Count + 1) + ImageFileExtension);

            StreamWriter writer = new StreamWriter(FaceListTextFile, true);
            string faceOwnerName = Microsoft.VisualBasic.Interaction.InputBox("Tasvirdagi rasm egasini ismini kiriting:");
            writer.WriteLine(String.Format("yuz{0}:{1}", (FaceList.Count + 1), faceOwnerName));
            writer.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SavedDetectedFace(pbDetectedFace1.Image);
            GetFaceList();
        }
    }
}
