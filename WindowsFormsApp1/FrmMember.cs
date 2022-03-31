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

namespace WindowsFormsApp1
{
    public partial class FrmMember : Form
    {
        public FrmMember()
        {
            InitializeComponent();
        }
        Capture capture = null;
        private void FrmMember_Load(object sender, EventArgs e)
        {
            //建立攝影機物件
            capture = new Capture(0);
            timer1.Enabled = true;


        }
        //讓圖片每0.1秒抓到攝影機的畫面
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = capture.QueryFrame().Bitmap;
        }

        private void btn註冊_Click(object sender, EventArgs e)
        {
            try
            {
                String fileName = $"{Guid.NewGuid().ToString()}.jpg";

                dbMemberEntities db = new dbMemberEntities();
                tMember tMember = new tMember();

                tMember.f姓名 = txt姓名.Text;
                tMember.f編號 = txt編號.Text;
                tMember.f照片 = fileName;

                db.tMember.Add(tMember);
                db.SaveChanges();

                //將照片存入指定得資料夾
                string faceMemberImgPath = $"{Application.StartupPath}/FaceMemberImg/{fileName}";
                FileInfo fileInfo = new FileInfo(faceMemberImgPath);
                FileStream fileStream = fileInfo.Create();
                pictureBox1.Image = capture.QueryFrame().Bitmap;
                pictureBox1.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg);

                MessageBox.Show("員工資料新增成功!");
                txt姓名.Text = "";
                txt編號.Text = "";
            }
            catch (Exception) 
            {
                MessageBox.Show("新增失敗!可能員工編號有重複");
            }

        }
    }
}
