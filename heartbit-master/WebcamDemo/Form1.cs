using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dynamsoft.UVC;
using Dynamsoft.Core;
using System.IO;
using System.Runtime.InteropServices;
using Dynamsoft.Common;
using System.Threading;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web;
using Microsoft.Azure.CognitiveServices;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using Microsoft.Azure.CognitiveServices.Vision;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Newtonsoft.Json.Linq;

namespace WebcamDemo
{
    public partial class Form1 : Form
    {


        const string subscriptionKey = "efedd95eda204b92941bd69f3263b6b3";

        const string uriBase = "https://centralindia.api.cognitive.microsoft.com/face/v1.0/detect";
        public int m_iDesignWidth = 755;
        public int iControlWidth = 275;
        public int iControlHeight = 295;
        public CameraManager m_CameraManager = null;
        public ImageCore m_ImageCore = null;
        public string m_StrProductKey = "E2C8A05F6814BB8AB79C04F350060EBFCF9AD551";//"t0068UwAAADm76D2UsWjoXapvAzCoIRA8DTSWlmfo88rh2XSTh4plFQgDu3oLqHwThfbxcJmjy0eugY5/nQGXvTFAtJzqnho=";

        public Camera m_CurrentCamera = null;


        public Form1()
        {
            InitializeComponent();
            m_CameraManager = new CameraManager(m_StrProductKey);
            m_ImageCore = new ImageCore();

            Red.BackColor = Color.Black;
            Yellow.BackColor = Color.Black;
            Green.BackColor = Color.Black;


            this.Load += new EventHandler(Form1_Load);
        }
        void Form1_Load(object sender, EventArgs e)
        {
            randomize();

            try
            {
                m_iDesignWidth = this.Width;
                if (m_CameraManager.GetCameraNames() != null)
                {
                    foreach (string temp in m_CameraManager.GetCameraNames())
                    {
                        cbxSources.Items.Add(temp);
                    }

                    cbxSources.SelectedIndexChanged += cbxSources_SelectedIndexChanged;
                    if (cbxSources.Items.Count > 0)
                        cbxSources.SelectedIndex = 1;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private async void MakeAnalysisRequest(string imageFilePath)
        {
            HttpClient client = new HttpClient();

            // Request headers.
            client.DefaultRequestHeaders.Add(
                "Ocp-Apim-Subscription-Key", subscriptionKey);

            // Request parameters. A third optional parameter is "details".
            string requestParameters = "returnFaceId=true&returnFaceLandmarks=true" +
                "&returnFaceAttributes=age,gender,headPose,smile,facialHair,glasses," +
                "emotion,hair,makeup,occlusion,accessories,blur,exposure,noise";

            // Assemble the URI for the REST API Call.
            string uri = uriBase + "?" + requestParameters;

            HttpResponseMessage response;

            // Request body. Posts a locally stored JPEG image.
            byte[] byteData = GetImageAsByteArray(imageFilePath);

            using (ByteArrayContent content = new ByteArrayContent(byteData))
            {

                content.Headers.ContentType =
                    new MediaTypeHeaderValue("application/octet-stream");

                // Execute the REST API call.
                response = await client.PostAsync(uri, content);



                //      var faceLandmarksPupilLeft = jsonobject["faceId"]["pupilLeft"]["x"].ToString();

                //      MessageBox.Show(faceLandmarksPupilLeft);

                // Get the JSON response.
                String contentString = await response.Content.ReadAsStringAsync();

                dynamic jsonstring = JsonConvert.DeserializeObject(contentString);


                JArray jsonob = JArray.Parse(contentString);


                string id = jsonob[0]["faceId"].ToString();
                string PupilRightX = jsonob[0]["faceLandmarks"]["pupilRight"]["x"].ToString();
                string PupilRightY = jsonob[0]["faceLandmarks"]["pupilRight"]["y"].ToString();

                string PupilLeftX = jsonob[0]["faceLandmarks"]["pupilLeft"]["x"].ToString();
                string PupilLeftY = jsonob[0]["faceLandmarks"]["pupilLeft"]["y"].ToString();

                string noseTipX = jsonob[0]["faceLandmarks"]["noseTip"]["x"].ToString();
                string noseTipY = jsonob[0]["faceLandmarks"]["noseTip"]["y"].ToString();

                string mouthLeftX = jsonob[0]["faceLandmarks"]["mouthLeft"]["x"].ToString();
                string mouthLeftY = jsonob[0]["faceLandmarks"]["mouthLeft"]["y"].ToString();

                string mouthRightX = jsonob[0]["faceLandmarks"]["mouthRight"]["x"].ToString();
                string mouthRightY = jsonob[0]["faceLandmarks"]["mouthRight"]["y"].ToString();

                string eyebrowLeftOuterX = jsonob[0]["faceLandmarks"]["eyebrowLeftOuter"]["x"].ToString();
                string eyebrowLeftOuterY = jsonob[0]["faceLandmarks"]["eyebrowLeftOuter"]["y"].ToString();

                string eyebrowLeftInnerX = jsonob[0]["faceLandmarks"]["eyebrowLeftInner"]["x"].ToString();
                string eyebrowLeftInnerY = jsonob[0]["faceLandmarks"]["eyebrowLeftInner"]["y"].ToString();

                string eyeLeftOuterX = jsonob[0]["faceLandmarks"]["eyeLeftOuter"]["x"].ToString();
                string eyeLeftOuterY = jsonob[0]["faceLandmarks"]["eyeLeftOuter"]["y"].ToString();

                string eyeLeftBottomX = jsonob[0]["faceLandmarks"]["eyeLeftBottom"]["x"].ToString();
                string eyeLeftBottomY = jsonob[0]["faceLandmarks"]["eyeLeftBottom"]["y"].ToString();

                string eyeLeftInnerX = jsonob[0]["faceLandmarks"]["eyeLeftInner"]["x"].ToString();
                string eyeLeftInnerY = jsonob[0]["faceLandmarks"]["eyeLeftInner"]["y"].ToString();

                string eyebrowRightOuterX = jsonob[0]["faceLandmarks"]["eyebrowRightOuter"]["x"].ToString();
                string eyebrowRightOuterY = jsonob[0]["faceLandmarks"]["eyebrowRightOuter"]["y"].ToString();

                string eyeRightInnerX = jsonob[0]["faceLandmarks"]["eyeRightInner"]["x"].ToString();
                string eyeRightInnerY = jsonob[0]["faceLandmarks"]["eyeRightInner"]["y"].ToString();

                string eyeRightTopX = jsonob[0]["faceLandmarks"]["eyeRightTop"]["x"].ToString();
                string eyeRightTopY = jsonob[0]["faceLandmarks"]["eyeRightTop"]["y"].ToString();

                string eyeRightBottomX = jsonob[0]["faceLandmarks"]["eyeRightBottom"]["x"].ToString();
                string eyeRightBottomY = jsonob[0]["faceLandmarks"]["eyeRightBottom"]["y"].ToString();

                string eyeRightOuterX = jsonob[0]["faceLandmarks"]["eyeRightOuter"]["x"].ToString();
                string eyeRightOuterY = jsonob[0]["faceLandmarks"]["eyeRightOuter"]["y"].ToString();

                string noseRootLeftX = jsonob[0]["faceLandmarks"]["noseRootLeft"]["x"].ToString();
                string noseRootLeftY = jsonob[0]["faceLandmarks"]["noseRootLeft"]["y"].ToString();

                string noseRootRightX = jsonob[0]["faceLandmarks"]["noseRootRight"]["x"].ToString();
                string noseRootRightY = jsonob[0]["faceLandmarks"]["noseRootRight"]["y"].ToString();

                string noseLeftAlarTopX = jsonob[0]["faceLandmarks"]["noseLeftAlarTop"]["x"].ToString();
                string noseLeftAlarTopY = jsonob[0]["faceLandmarks"]["noseLeftAlarTop"]["y"].ToString();

                string noseRightAlarTopX = jsonob[0]["faceLandmarks"]["noseRightAlarTop"]["x"].ToString();
                string noseRightAlarTopY = jsonob[0]["faceLandmarks"]["noseRightAlarTop"]["y"].ToString();

                string noseLeftAlarOutTipX = jsonob[0]["faceLandmarks"]["noseLeftAlarOutTip"]["x"].ToString();
                string noseLeftAlarOutTipY = jsonob[0]["faceLandmarks"]["noseLeftAlarOutTip"]["y"].ToString();

                string noseRightAlarOutTipX = jsonob[0]["faceLandmarks"]["noseRightAlarOutTip"]["x"].ToString();
                string noseRightAlarOutTipY = jsonob[0]["faceLandmarks"]["noseRightAlarOutTip"]["y"].ToString();

                string upperLipTopX = jsonob[0]["faceLandmarks"]["upperLipTop"]["x"].ToString();
                string upperLipTopY = jsonob[0]["faceLandmarks"]["upperLipTop"]["y"].ToString();

                string upperLipBottomX = jsonob[0]["faceLandmarks"]["upperLipBottom"]["x"].ToString();
                string upperLipBottomY = jsonob[0]["faceLandmarks"]["upperLipBottom"]["y"].ToString();

                string underLipTopX = jsonob[0]["faceLandmarks"]["underLipTop"]["x"].ToString();
                string underLipTopY = jsonob[0]["faceLandmarks"]["underLipTop"]["y"].ToString();

                string underLipBottomX = jsonob[0]["faceLandmarks"]["underLipBottom"]["x"].ToString();
                string underLipBottomY = jsonob[0]["faceLandmarks"]["underLipBottom"]["y"].ToString();


                string smile = jsonob[0]["faceAttributes"]["smile"].ToString();
                string gender = jsonob[0]["faceAttributes"]["gender"].ToString();
                string age = jsonob[0]["faceAttributes"]["age"].ToString();
                //faceAttributes
                string anger = jsonob[0]["faceAttributes"]["emotion"]["anger"].ToString();
                string contempt = jsonob[0]["faceAttributes"]["emotion"]["contempt"].ToString();
                string glasses = jsonob[0]["faceAttributes"]["glasses"].ToString();
                string disgust = jsonob[0]["faceAttributes"]["emotion"]["disgust"].ToString();
                string fear = jsonob[0]["faceAttributes"]["emotion"]["fear"].ToString();
                string happiness = jsonob[0]["faceAttributes"]["emotion"]["happiness"].ToString();
                string neutral = jsonob[0]["faceAttributes"]["emotion"]["neutral"].ToString();
                string sadness = jsonob[0]["faceAttributes"]["emotion"]["sadness"].ToString();
                string surprise = jsonob[0]["faceAttributes"]["emotion"]["surprise"].ToString();



                //   Image img = Image.FromFile(imageFilePath);

                //    using (Graphics g = Graphics.FromImage(img))
                // {
                //   g.DrawLine(Pens.Green, Convert.to (PupilRightX), Convert.ToDouble(PupilRightY), Convert.ToDouble(PupilLeftX), Convert.ToDouble(PupilLeftY));
                //img.Save("E:/newimage.jpeg");
                //   }
                paincalculate(anger, contempt, disgust, fear, happiness, neutral, sadness, surprise, HeartBeat.Text, So2.Text, BPH.Text, BPL.Text);


                DisplayResults(contentString, imageFilePath);
                // string rssTitle = (string)jsonob[""][1].ToString();
                randomize();

                //   faceLandmarksPupilLeft
                //      faceLandmarksPupilLeft
                //    faceLandmarksPupilRight
                //       faceLandmarksPupilRight
                //elke keller      faceLandmarksnoseTipX
                //       faceLandmarksnoseTipY
                //    facelandmarksMouthLeftX
                //         facelandmarksMouthLeftY
                //      facelandmarksMouthRightX
                //             facelandmarksMouthRightY
                //      facelandmarkseyebrowLeftOuterX
                //               facelandmarkseyebrowLeftOuterY
                //       facelandmarksEyeBrowX
                //              facelandmarksEyeBrowY




            }

        }


        private void paincalculate(string anger, string contempt, string disgust, string fear, string happiness, string neutral, string sadness, string surprise, string BPHigh, string BPLow, string heartbeat, string SO2)
        {
            string pain = "";


            double danger = Convert.ToDouble(anger) * 100;                    //
            double dcontempt = Convert.ToDouble(contempt) * 100;              //
            double ddisgust = Convert.ToDouble(disgust) * 100;                //
            double dfear = Convert.ToDouble(fear) * 100;                      //
            double dsadness = Convert.ToDouble(sadness) * 100;                //

            double dhappiness = Convert.ToDouble(happiness) * 100;
            double dneutral = Convert.ToDouble(neutral) * 100;
            double dsurprise = Convert.ToDouble(surprise) * 100;

            double dBpHigh = Convert.ToDouble(BPH.Text);
            double dBplow = Convert.ToDouble(BPL.Text);
            double dHeartbeat = Convert.ToDouble(HeartBeat.Text);
            double dSo2 = Convert.ToDouble(So2.Text);

            Red.BackColor = Color.Black;
            Yellow.BackColor = Color.Black;
            Green.BackColor = Color.Black;


            double emotionalfear = danger + dcontempt + dfear + ddisgust + dsadness;
            if (emotionalfear > 50 && dHeartbeat > 150 && dBpHigh > 180 && dBplow > 95 && dSo2 > 85)
            {
                pain = "High";
                Red.BackColor = Color.Red;
            }

            else if (emotionalfear < 50 && dBpHigh > 180 && dBplow > 95 && dHeartbeat > 150 && dSo2 > 85)
            {
                pain = "Medium";
                Yellow.BackColor = Color.Yellow;
            }

            else if (emotionalfear < 50 && dBpHigh < 180 && dBplow > 95 && dHeartbeat < 150 && dSo2 > 85)
            {
                pain = "Low";
                Green.BackColor = Color.Green;
            }
            else
            {
                pain = "none";
                Green.BackColor = Color.Green;

            }
            /*
             *  Random rnds = new Random();
                HeartBeat.Text = rnds.Next(150, 200).ToString();// "120";
                So2.Text = rnds.Next(85,90).ToString();//"92%";
                BPH.Text = rnds.Next(180, 250).ToString();
                BPL.Text = rnds.Next(95,110).ToString();// "100/80";
             * 
             * 
             * 
             * */
            label5.Text = emotionalfear.ToString();
            label2.Text = pain;
            // return pain; 
        }

        static byte[] GetImageAsByteArray(string imageFilePath)
        {
            using (FileStream fileStream =
                new FileStream(imageFilePath, FileMode.Open, FileAccess.Read))
            {
                BinaryReader binaryReader = new BinaryReader(fileStream);
                return binaryReader.ReadBytes((int)fileStream.Length);
            }
        }

        private void randomize()
        {
            if (Emergency_but.Checked)
            {
                Random rnds = new Random();
                HeartBeat.Text = rnds.Next(150, 200).ToString();// "120";
                So2.Text = rnds.Next(85, 90).ToString();//"92%";
                BPH.Text = rnds.Next(180, 250).ToString();
                BPL.Text = rnds.Next(95, 110).ToString();// "100/80";

            }
            else
            {
                Random rnd = new Random();
                HeartBeat.Text = rnd.Next(60, 80).ToString();// "120";
                So2.Text = rnd.Next(92, 100).ToString();//"92%";
                BPH.Text = rnd.Next(120, 140).ToString();
                BPL.Text = rnd.Next(80, 90).ToString();// "100/80";
            }
        }





        static string JsonPrettyPrint(string json)
        {
            if (string.IsNullOrEmpty(json))
                return string.Empty;

            json = json.Replace(Environment.NewLine, "").Replace("\t", "");
            json = json.Replace("[", "").Replace("]", "");
            StringBuilder sb = new StringBuilder();
            bool quote = false;
            bool ignore = false;
            int offset = 0;
            int indentLength = 3;

            foreach (char ch in json)
            {
                switch (ch)
                {
                    case '"':
                        if (!ignore) quote = !quote;
                        break;
                    case '\'':
                        if (quote) ignore = !ignore;
                        break;
                }


                if (quote)
                    sb.Append(ch);
                else
                {
                    switch (ch)
                    {
                        case '{':
                        case '[':
                            sb.Append(ch);
                            sb.Append(Environment.NewLine);
                            sb.Append(new string(' ', ++offset * indentLength));
                            break;
                        case '}':
                        case ']':
                            sb.Append(Environment.NewLine);
                            sb.Append(new string(' ', --offset * indentLength));
                            sb.Append(ch);
                            break;
                        case ',':
                            sb.Append(ch);
                            sb.Append(Environment.NewLine);
                            sb.Append(new string(' ', offset * indentLength));
                            break;
                        case ':':
                            sb.Append(ch);
                            sb.Append(' ');
                            break;
                        default:
                            if (ch != ' ') sb.Append(ch);
                            break;
                    }
                }
            }

            return sb.ToString().Trim();
        }

        private void DisplayResults(string analysis, string imageUri)
        {
            pictureBox3.Image = Image.FromFile(imageUri);
            richTextBox2.Text = "";
            richTextBox2.Text = analysis;


        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Application.DoEvents();
            Graphics g = pictureBox3.CreateGraphics();
            g.DrawEllipse(Pens.DarkBlue, new Rectangle(120, 90, 1, 1));
        }

        public void btnRemoveAllImages_Click(object sender, EventArgs e)
        {
            m_ImageCore.ImageBuffer.RemoveAllImages();
        }

        public void btnCaptureImage_Click(object sender, EventArgs e)
        {

            if (m_CurrentCamera != null)
            {
                Bitmap tempBmp = m_CurrentCamera.GrabImage();
                m_ImageCore.IO.LoadImage(tempBmp);


                autosave(tempBmp);


            }

        }

        public void autosave(Bitmap MBP)
        {
            String FileName = "";
            FileName = @"E:\ImageSamples\" + System.DateTime.Now.ToString("yyyyMMddHHmms") + ".jpeg";
            MBP.Save(FileName);
            pictureBox1.Image = Image.FromFile(FileName);
            MakeAnalysisRequest(FileName);

        }

        public void saveImage(Bitmap MBP)
        {
            String FileName = "";
            FileName = @"E:\ImageSamples\" + System.DateTime.Now.ToString("yyyyMMddHHmms") + ".jpeg";
            MBP.Save(FileName);
        }

        public void cbxSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_CurrentCamera != null)
            {
                m_CurrentCamera.OnFrameCaptrue -= m_CurrentCamera_OnFrameCaptrue;
                m_CurrentCamera.Close();
            }
            if (m_CameraManager != null)
            {
                m_CurrentCamera = m_CameraManager.SelectCamera((short)cbxSources.SelectedIndex);
                m_CurrentCamera.Open();

                m_CurrentCamera.OnFrameCaptrue += m_CurrentCamera_OnFrameCaptrue;
                ResizePictureBox();
            }
            if (m_CurrentCamera != null)
            {
                cbxResolution.Items.Clear();
                foreach (CamResolution camR in m_CurrentCamera.SupportedResolutions)
                {
                    cbxResolution.Items.Add(camR.ToString());
                }
                cbxResolution.SelectedIndexChanged += cbxResolution_SelectedIndexChanged;
                if (cbxResolution.Items.Count > 0)
                    cbxResolution.SelectedIndex = 0;
                ResizePictureBox();
            }

        }
        public void cbxResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxResolution.Text != null)
            {
                string[] strWXH = cbxResolution.Text.Split(new char[] { ' ' });
                if (strWXH.Length == 3)
                {
                    try
                    {
                        m_CurrentCamera.CurrentResolution = new CamResolution(int.Parse(strWXH[0]), int.Parse(strWXH[2]));
                    }
                    catch { }
                }
                m_CurrentCamera.RotateVideo(Dynamsoft.UVC.Enums.EnumVideoRotateType.Rotate_0);
                ResizePictureBox();
            }
        }


        public void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point tempPoint = new Point(e.X, e.Y);
            float tempWidth = pictureBox1.Width;
            float tempHeight = pictureBox1.Height;

            float imageWidth = m_CurrentCamera.CurrentResolution.Width;
            float imageHeight = m_CurrentCamera.CurrentResolution.Height;
            float zoomX = imageWidth / tempWidth;
            float zoomY = imageHeight / tempHeight;
            Point tempFocusPoint = new Point((int)(e.X * imageWidth), (int)(e.Y * imageHeight));
            Rectangle tempRect = new Rectangle(tempFocusPoint, new Size(50, 50));
            try
            {
                m_CurrentCamera.FocusOnArea(tempRect);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        public void ResizePictureBox()
        {
            if (m_CurrentCamera != null)
            {
                CamResolution camResolution = m_CurrentCamera.CurrentResolution;
                if (camResolution != null && camResolution.Width > 0 && camResolution.Height > 0)
                {
                    {
                        int iVideoWidth = iControlWidth;
                        int iVideoHeight = iControlWidth * camResolution.Height / camResolution.Width;
                        int iContentHeight = panel1.Height - panel1.Margin.Top - panel1.Margin.Bottom - panel1.Padding.Top - panel1.Padding.Bottom;
                        if (iVideoHeight < iContentHeight)
                        {
                            pictureBox1.Location = new Point(0, (iContentHeight - iVideoHeight) / 2);
                            pictureBox1.Size = new Size(iVideoWidth, iVideoHeight);
                        }
                        else
                        {
                            pictureBox1.Location = new Point(0, 0);
                            pictureBox1.Size = new Size(pictureBox1.Width, pictureBox1.Height);
                        }
                    }
                }
            }
        }
        public void RotatePictureBox()
        {
            if (m_CurrentCamera != null)
            {
                CamResolution camResolution = m_CurrentCamera.CurrentResolution;
                if (camResolution != null && camResolution.Width > 0 && camResolution.Height > 0)
                {
                    if (camResolution.Width / camResolution.Height > iControlWidth / iControlHeight)
                    {
                        int iVideoHeight = iControlHeight;
                        int iVideoWidth = iControlHeight * camResolution.Height / camResolution.Width;
                        int iContentWidth = panel1.Width - panel1.Margin.Left - panel1.Margin.Right - panel1.Padding.Left - panel1.Padding.Right;
                        pictureBox1.Location = new Point((iContentWidth - iVideoWidth) / 2, 0);
                        pictureBox1.Size = new Size(iVideoWidth, iVideoHeight);
                    }
                    else
                    {
                        int iVideoWidth = iControlWidth;
                        int iVideoHeight = iControlWidth * camResolution.Width / camResolution.Height;
                        int iContentHeight = panel1.Height - panel1.Margin.Top - panel1.Margin.Bottom - panel1.Padding.Top - panel1.Padding.Bottom;
                        pictureBox1.Location = new Point(0, (iContentHeight - iVideoHeight) / 2);
                        pictureBox1.Size = new Size(iVideoWidth, iVideoHeight);
                    }
                }
            }
        }
        public void SetPicture(Image img)
        {
            Bitmap temp = ((Bitmap)(img)).Clone(new Rectangle(0, 0, img.Width, img.Height), img.PixelFormat);
            if (pictureBox1.InvokeRequired)
            {
                pictureBox1.BeginInvoke(new MethodInvoker(
                delegate ()
                {
                    pictureBox1.Image = temp;
                }));
            }
            else
            {
                pictureBox1.Image = temp;
            }

        }
        public void picbox90_Click(object sender, EventArgs e)
        {
            m_CurrentCamera.RotateVideo(Dynamsoft.UVC.Enums.EnumVideoRotateType.Rotate_90);
            RotatePictureBox();
        }

        public void picbox180_Click(object sender, EventArgs e)
        {
            m_CurrentCamera.RotateVideo(Dynamsoft.UVC.Enums.EnumVideoRotateType.Rotate_180);
            ResizePictureBox();
        }

        public void picbox270_Click(object sender, EventArgs e)
        {
            m_CurrentCamera.RotateVideo(Dynamsoft.UVC.Enums.EnumVideoRotateType.Rotate_270);
            RotatePictureBox();
        }
        void m_CurrentCamera_OnFrameCaptrue(Bitmap bitmap)
        {
            SetPicture(bitmap);
        }
        public void picbox90_MouseHover(object sender, EventArgs e)
        {
            picbox90.Image = global::WebcamDemo.Properties.Resources._90_hover;
        }
        public void picbox90_MouseLeave(object sender, EventArgs e)
        {
            picbox90.Image = global::WebcamDemo.Properties.Resources._90_normal;
        }
        public void picbox180_MouseHover(object sender, EventArgs e)
        {
            picbox180.Image = global::WebcamDemo.Properties.Resources._180_hover;
        }
        public void picbox180_MouseLeave(object sender, EventArgs e)
        {
            picbox180.Image = global::WebcamDemo.Properties.Resources._180_normal;
        }
        public void picbox270_MouseHover(object sender, EventArgs e)
        {
            picbox270.Image = global::WebcamDemo.Properties.Resources._270_hover;
        }
        public void picbox270_MouseLeave(object sender, EventArgs e)
        {
            picbox270.Image = global::WebcamDemo.Properties.Resources._270_normal;
        }

        public void dsViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Emergency_but_CheckedChanged(object sender, EventArgs e)
        {
            randomize();
        }

        private async void test()
        {
            HttpClient client = new HttpClient();

            // Request headers.
            client.DefaultRequestHeaders.Add(
                "Ocp-Apim-Subscription-Key", "50ee925c878544f08b60aa8d13125eb8");

            // Request parameters. A third optional parameter is "details".


            // Assemble the URI for the REST API Call.
            string uri = "https://southcentralus.api.cognitive.microsoft.com/customvision/v2.0/Prediction/7df77ef8-a59e-4f35-85e6-c3ca0096322d/image?iterationId=5e416ea8-65a0-433d-8e31-a3fd740ca749";

            HttpResponseMessage response;

            // Request body. Posts a locally stored JPEG image.
            byte[] byteData = GetImageAsByteArray("E:\\Mahesh\\Downloads\\ramp\\ramp\\google_3.jpg");

            using (ByteArrayContent content = new ByteArrayContent(byteData))
            {

                content.Headers.ContentType =
                    new MediaTypeHeaderValue("application/octet-stream");

                // Execute the REST API call.
                response = await client.PostAsync(uri, content);


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            test();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    MakeAnalysisRequest(file);

                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        }
    }
    }

