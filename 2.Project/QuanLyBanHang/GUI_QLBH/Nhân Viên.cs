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
    public partial class Nhân_Viên : Form
    {
        public Nhân_Viên()
        {
            InitializeComponent();
        }

        private void txt_emailNV_TextChanged(object sender, EventArgs e)
        {
            string checkmail = "\\w+@\\w+(\\.\\w+){1,2}";
            if (Regex.IsMatch(txt_emailNV.Text, checkmail) == false)
            {
                MessageBox.Show("Email Khong Dung DInh Dang ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_emailNV.Focus();
                return;
            }
        }

        private void txt_tenNV_TextChanged(object sender, EventArgs e)
        {
            string ktraten = "\\d";
            if (Regex.IsMatch(txt_tenNV.Text,ktraten)==true)
            {
                MessageBox.Show("Không đúng định dạng tên Nhân viên ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tenNV.Focus();
                return;
            }
        }

        private void RTB_DiaChi_TextChanged(object sender, EventArgs e)
        {
            if (RTB_DiaChi.Text=="")
            {
                MessageBox.Show("Không để trống địa chỉ ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RTB_DiaChi.Focus();
                return;
            }
        }

        private void btn_themNV_Click(object sender, EventArgs e)
        {
            txt_emailNV.Enabled = true;
            txt_tenNV.Enabled = true;
            RTB_DiaChi.Enabled = true;
        }

        private void btn_luuNV_Click(object sender, EventArgs e)
        {
            if (Radio_HoatDong.Checked==false && radio_NgungHoatDong.Checked==false)
            {
                MessageBox.Show("Bạn phải chọn tình trạng ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
            else if (radio_quanli.Checked == false && radio_quanli.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn tình trạng ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private void Nhân_Viên_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var get = (from lay in db.NHANVIENs
                       select lay).ToList();
            dataGridView_NhanVien.DataSource = get.ToList();
            txt_emailNV.Enabled = false;
            txt_tenNV.Enabled = false;
            RTB_DiaChi.Enabled = false;
            
        }

        private void txt_timkiemNV_Click(object sender, EventArgs e)
        {
            string ktramanv = "\\w+@\\w+(\\.\\w+){1,2}";
            if (Regex.IsMatch(txt_emailNV.Text,ktramanv)== false)
            {
                MessageBox.Show("Bạn phải nhập đúng email nhân viên ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dataGridView_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
