using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbMemberEntities db = new dbMemberEntities();
            dataGridViewMember.DataSource = db.tMember.ToList();
        }

        private void btn載入員工資料_Click(object sender, EventArgs e)
        {
            Form1_Load(sender,e);   //直接呼叫Form事件
        }

        private void btn人臉註冊_Click(object sender, EventArgs e)
        {
            FrmMember frmMember = new FrmMember();
            frmMember.ShowDialog();
        }

        private void btn人臉辨識_Click(object sender, EventArgs e)
        {
            FrmFace frmFace = new FrmFace();
            frmFace.ShowDialog();
        }
    }
}
