using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.IO;
using System.Threading;
using System.Diagnostics;


namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        //Annethy Javier(2020-10518) y Virginia Martinez(2020-10169)
        //Variables

        private Capture CapturaVideo = null;
        private Image<Bgr, Byte> Cuadroactual = null;
        Mat cuadro = new Mat();
        private bool habilitardetencionfacial = false;
        CascadeClassifier clasificadorencascadadecaras = new CascadeClassifier(@"C:\Users\Annethy\OneDrive\Escritorio\ITLA\Cuarto cuatrimestre\DCU\INTENTO DE PROYECTO FINAL\INTENTO 2 PF\ProyectoFinal\ProyectoFinal\haarcascade_frontalface_alt.xml");
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLabes = new List<int>();
       

        bool EnableSaveImage = false;
        private bool isTrained = false;
        EigenFaceRecognizer recognizer;
        List<string> PersonsNames = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (CapturaVideo != null) CapturaVideo.Dispose();
            CapturaVideo = new Capture();
            Application.Idle += ProcessFrame;
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (CapturaVideo != null && CapturaVideo.Ptr != IntPtr.Zero)
            {
                //
                CapturaVideo.Retrieve(cuadro, 0);
                Cuadroactual = cuadro.ToImage<Bgr, Byte>().Resize(pictureCap.Width, pictureCap.Height, Inter.Cubic);

                //
                if (habilitardetencionfacial)
                {
                    //Convertir imagen a color a imagen gris
                    Mat ImagenGris = new Mat();
                    CvInvoke.CvtColor(Cuadroactual, ImagenGris, ColorConversion.Bgr2Gray);
                    CvInvoke.EqualizeHist(ImagenGris, ImagenGris);

                    Rectangle[] faces = clasificadorencascadadecaras.DetectMultiScale(ImagenGris, 1.1, 3, Size.Empty, Size.Empty);
                    if (faces.Length > 0)
                    {

                        foreach (var face in faces)
                        {
                            CvInvoke.Rectangle(Cuadroactual, face, new Bgr(Color.Red).MCvScalar, 2);

                            Image<Bgr, Byte> resultImage = Cuadroactual.Convert<Bgr, Byte>();
                            resultImage.ROI = face;
                            picDectetar.SizeMode = PictureBoxSizeMode.StretchImage;
                            picDectetar.Image = resultImage.Bitmap;

                            if (EnableSaveImage)
                            {
                                string path = Directory.GetCurrentDirectory() + @"\C:\Users\Annethy\OneDrive\Escritorio\ITLA\Cuarto cuatrimestre\DCU\INTENTO DE PROYECTO FINAL\INTENTO 2 PF\ProyectoFinal\ProyectoFinal\Directorio";
                                if (!Directory.Exists(path))
                                    Directory.CreateDirectory(path);
                                Task.Factory.StartNew(() =>
                                {
                                    for (int i = 0; i < 10; i++)
                                    {
                                        resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" +txtvacunado.Text + "_" + txtnombre.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                        Thread.Sleep(1000);
                                    }
                                });
                            }

                            EnableSaveImage = false;

                            if (btnAgregar.InvokeRequired)
                            {
                                btnAgregar.Invoke(new ThreadStart(delegate
                                {
                                    btnAgregar.Enabled = true;
                                }));
                            }
                            if (isTrained)
                            {
                                Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                                CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                                var result = recognizer.Predict(grayFaceResult);
                                pictureBox1.Image = grayFaceResult.Bitmap;
                                pictureBox2.Image = TrainedFaces[result.Label].Bitmap;
                                Debug.WriteLine(result.Label + ". " + result.Distance);


                                if (result.Label != -1 && result.Distance < 2000)
                                {
                                    CvInvoke.PutText(Cuadroactual, PersonsNames[result.Label], new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(Cuadroactual, face, new Bgr(Color.Green).MCvScalar, 2);
                                }
                                else
                                {
                                    CvInvoke.PutText(Cuadroactual, "Desconocido", new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(Cuadroactual, face, new Bgr(Color.Red).MCvScalar, 2);

                                }
                            }
                        }
                    }
                }
                pictureCap.Image = Cuadroactual.Bitmap;
            }

            if (Cuadroactual != null)
                Cuadroactual.Dispose();

        }

        private void btnDectetar_Click(object sender, EventArgs e)
        {
            habilitardetencionfacial = true;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
           
           btnAgregar.Enabled = true;
           EnableSaveImage = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            btnAgregar.Enabled = false;
            EnableSaveImage = true;

        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            TrainImagesFromDir();
        }

        private bool TrainImagesFromDir()
        {
            int ImagesCount = 0;
            double Threshold = 2000;
            TrainedFaces.Clear();
            PersonsLabes.Clear();
            PersonsNames.Clear();
            try
            {
                string path = Directory.GetCurrentDirectory() + @"C:\Users\Annethy\OneDrive\Escritorio\ITLA\Cuarto cuatrimestre\DCU\INTENTO DE PROYECTO FINAL\INTENTO 2 PF\ProyectoFinal\ProyectoFinal\Directorio\Directorio";
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    Image<Gray, byte> trainedImage = new Image<Gray, byte>(file).Resize(200, 200, Inter.Cubic);
                    CvInvoke.EqualizeHist(trainedImage, trainedImage);
                    TrainedFaces.Add(trainedImage);
                    PersonsLabes.Add(ImagesCount);
                    string name = file.Split('\\').Last().Split('_')[0];
                    PersonsNames.Add(name);
                    ImagesCount++;
                    Debug.WriteLine(ImagesCount + ". " + name);

                }

                if (TrainedFaces.Count() > 0)
                {
                    recognizer = new EigenFaceRecognizer(ImagesCount, Threshold);
                    recognizer.Train(TrainedFaces.ToArray(), PersonsLabes.ToArray());

                    isTrained = true;
                    return true;
                }
                else
                {
                    isTrained = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                isTrained = false;
                MessageBox.Show("Ninguna imagen guardada " + ex.Message);
                return false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnrecognize_Click(object sender, EventArgs e)
        {

        }
    }
}
   
