using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void createdangnhap()
        {
            Đăng_Nhập login = new Đăng_Nhập();
            login.WindowState = FormWindowState.Maximized;
            login.MdiParent = this;
            login.Show();
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createdangnhap();
        }

        private void đăngXuấtCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
