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
        public void createprofie()
        {
            Hồ_Sơ_Nhân_Viên profile = new Hồ_Sơ_Nhân_Viên();
            profile.WindowState = FormWindowState.Maximized;
            profile.MdiParent = this;
            profile.Show();
        }
        private void hồSơNhânViênCtrlHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createprofie();
        }

        private void thoátAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
               ("Bạn có chắc chắn muốn thoát không?", "Exit", MessageBoxButtons.YesNo);
            if (h == DialogResult.Yes)
                Application.Exit();
        }
        public void createproduct()
        {
            Sản_Phẩm product = new Sản_Phẩm();
            product.WindowState = FormWindowState.Maximized;
            product.MdiParent = this;
            product.Show();
        }
        private void sảnPhẩmAltSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createproduct();
        }
        public void createstaff()
        {
            Nhân_Viên staff = new Nhân_Viên();
            staff.WindowState = FormWindowState.Maximized;
            staff.MdiParent = this;
            staff.Show();
        }
        private void nhânViênAltNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createstaff();
        }
        public void createcustomer()
        {
            Khách_Hàng customer = new Khách_Hàng();
            customer.WindowState = FormWindowState.Maximized;
            customer.MdiParent = this;
            customer.Show();
        }
        private void kháchHàngAltKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createcustomer();
        }
        public void createthongke()
        {
            Thống_Kê_Sản_Phẩm thongke = new Thống_Kê_Sản_Phẩm();
            thongke.WindowState = FormWindowState.Maximized;
            thongke.MdiParent = this;
            thongke.Show();
        }
        private void thốngKêSảnPhẩmAltPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createthongke();
        }
    }
}
