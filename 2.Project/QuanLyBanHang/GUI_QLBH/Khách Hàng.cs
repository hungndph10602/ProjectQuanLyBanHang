using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBH
{
    public partial class Khách_Hàng : Form
    {
        public Khách_Hàng()
        {
            InitializeComponent();
        }

        private void btn_themKH_Click(object sender, EventArgs e)
        {
            txt_dienthoaiKH.Enabled = true;
            txt_tenKH.Enabled = true;
            RTB_DiachiKH.Enabled = true;
        }

        private void Khách_Hàng_Load(object sender, EventArgs e)
        {
            txt_dienthoaiKH.Enabled = false;
            txt_tenKH.Enabled = false;
            RTB_DiachiKH.Enabled = false;
            DataClasses1DataContext db = new DataClasses1DataContext();
            var get = (from lay in db.KHACHHANGs
                       select lay).ToList();
            dataGridView1.DataSource = get.ToList();

        }

        private void txt_dienthoaiKH_TextChanged(object sender, EventArgs e)
        {
            string ktradienthoai = "\\d";
            if (Regex.IsMatch(txt_dienthoaiKH.Text,ktradienthoai)==false)
            {
                MessageBox.Show("Số Điện thoại không đúng định dạng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_dienthoaiKH.Focus();
                return;
            }
        }

        private void txt_tenKH_TextChanged(object sender, EventArgs e)
        {
            string ktrahoten = "\\d";
            if (Regex.IsMatch(txt_tenKH.Text, ktrahoten) == true)
            {
                MessageBox.Show("Không đúng định dạng Tên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tenKH.Focus();
                return;
            }
        }

        private void RTB_DiachiKH_TextChanged(object sender, EventArgs e)
        {
            if (RTB_DiachiKH.Text =="")
            {
                MessageBox.Show("Không được để trống Địa chỉ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RTB_DiachiKH.Focus();
                return;
            }
        }

        private void btn_luuKH_Click(object sender, EventArgs e)
        {
            if (radio_NamKH.Checked ==false && radio_NuKH.Checked == false)
            {
                MessageBox.Show("Hãy Lựa chọn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_timkiemKH_Click(object sender, EventArgs e)
        {
            string ktradienthoai = "\\d";
            if (Regex.IsMatch(txt_dienthoaiKH.Text, ktradienthoai) == false)
            {
                MessageBox.Show("Số Điện thoại không đúng định dạng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }
    }
}
