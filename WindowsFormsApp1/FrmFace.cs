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
using System.IO;
using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;

namespace WindowsFormsApp1
{
    public partial class FrmFace : Form
    {
        public FrmFace()
        {
            InitializeComponent();
        }
        Capture Capture = null;
        string ApiUrl;
        string ApiKey;

        private async void btn人臉比對_Click(object sender, EventArgs e)
        {
            btn人臉比對.Enabled = false;
            try
            {

                string msg = "非員工請勿進入!";

                String fileName = $"{Guid.NewGuid().ToString()}.jpg";
                String TempfileName = $"{Application.StartupPath}/FaceTempImg/{fileName}";
                FileInfo fileInfo = new FileInfo(TempfileName);
                FileStream fileStream = fileInfo.Create();
                pictureBox1.Image = Capture.QueryFrame().Bitmap;
                pictureBox1.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                fileStream.Close();


                string Faceid01;
                string Faceid02;
                //建立人臉比對的物件
                FaceClient faceClient = new FaceClient(new ApiKeyServiceClientCredentials(ApiKey),
                   new System.Net.Http.DelegatingHandler[] { });
                faceClient.Endpoint = ApiUrl;

                dbMemberEntities db = new dbMemberEntities();

                VerifyResult result = null;
                foreach (var item in db.tMember)
                {
                    
                    Faceid01 = await GetFace(TempfileName);
                    Faceid02 = await GetFace($"{Application.StartupPath}/FaceMemberImg/{item.f照片}");
                    //比較兩個圖片，進行人臉辨識
                    result = await faceClient.Face.VerifyFaceToFaceAsync(
                        System.Guid.Parse(Faceid01),
                        System.Guid.Parse(Faceid02)
                        );
                    //商業邏輯
                    if (result.IsIdentical && result.Confidence > 0.85)
                    {
                        //觸發IOT的城市
                        msg = $"{item.f姓名} 夥伴您好，已成功刷卡!";
                        break;
                    }
                }
                richTextBox1.Text = $"{msg}\n是否為同一人:{result.IsIdentical}\n相似度:{result.Confidence}";
                //result.IsIdentical人臉辨識結果，result.Confidence是相似度
            }
            catch (Exception) {
                richTextBox1.Text = "比對失敗!";
            }
            btn人臉比對.Enabled = true;

        }

        private void FrmFace_Load(object sender, EventArgs e)
        {
            Capture = new Capture(0);
            timer1.Enabled = true;
            
            
            ApiKey = "d08e9e6ef9a747fea3669b8689a30800";
            ApiUrl = "https://face20220311.cognitiveservices.azure.com/";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Capture.QueryFrame().Bitmap;
        }
        async Task<string> GetFace(string _ImaPath) 
        {
            FileStream fs = File.OpenRead(_ImaPath);
            FaceClient faceClient = new FaceClient(new ApiKeyServiceClientCredentials(ApiKey),
                new System.Net.Http.DelegatingHandler[] { });
            faceClient.Endpoint = ApiUrl;

            IList<DetectedFace> detectedFaces = await faceClient.Face.DetectWithStreamAsync(
                fs,recognitionModel:RecognitionModel.Recognition02);

            if (detectedFaces.Count >0) {
                return detectedFaces[0].FaceId.ToString();
            }
            else {
                return "無法辨識";
            }


        }

    }
}
