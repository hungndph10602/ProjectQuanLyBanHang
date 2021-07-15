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
    public partial class Sản_Phẩm : Form
    {
        public Sản_Phẩm()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void onloadproduct()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var get = (from lay in db.SANPHAMs
                       select lay).ToList();
            dataGridView1.DataSource = get.ToList();
        }
        private void Sản_Phẩm_Load(object sender, EventArgs e)
        {
            txt_masp.Enabled = false;
            txt_TSP.Enabled = false;
            txt_SL.Enabled = false;
            txt_giaban.Enabled = false;
            txt_gianhap.Enabled = false;
            RTB_ghichu.Enabled = false;
            onloadproduct();
        }

        private void txt_TSP_TextChanged(object sender, EventArgs e)
        {
            if (txt_TSP.Text=="")
            {
                MessageBox.Show("Không được để trống tên sản phẩm ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TSP.Focus();
                return;
            }
        }

        private void txt_SL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_gianhap_TextChanged(object sender, EventArgs e)
        {
            string ktradongianhap = "\\d";
            if (Regex.IsMatch(txt_gianhap.Text, ktradongianhap) == false)
            {
                MessageBox.Show("Đơn giá nhập không đúng định dạng ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_gianhap.Focus();
                return;
            }
        }

        private void txt_giaban_TextChanged(object sender, EventArgs e)
        {
            string ktradongiaban = "\\d";
            if (Regex.IsMatch(txt_giaban.Text, ktradongiaban) == false)
            {
                MessageBox.Show("Đơn giá nhập không đúng định dạng ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_giaban.Focus();
                return;
            }
        }

        private void RTB_ghichu_TextChanged(object sender, EventArgs e)
        {
            if (RTB_ghichu.Text =="")
            {
                MessageBox.Show("Không được để trống phần ghi trú ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RTB_ghichu.Focus();
                return;
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

            try
            {
                string ktramasp = "\\d";
                if (Regex.IsMatch(txt_masp.Text,ktramasp)== false || txt_masp.Text == "")
                {
                    MessageBox.Show("Mã Sản phẩm không đúng định dạng ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_masp.Focus();
                    return;
                }
                else
                {

                }
            }
            catch (Exception s)
            {

                MessageBox.Show("Lỗi" + s);
            }
        }

        private void txt_SL_TextChanged_1(object sender, EventArgs e)
        {
            string ktradongiaban = "\\d";
            if (Regex.IsMatch(txt_SL.Text, ktradongiaban) == false)
            {
                MessageBox.Show("số lượng nhập không đúng định dạng ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SL.Focus();
                return;
            }
        }

        private void btl_themSP_Click(object sender, EventArgs e)
        {
            txt_TSP.Enabled = true;
            txt_SL.Enabled = true;
            txt_giaban.Enabled = true;
            txt_gianhap.Enabled = true;
            RTB_ghichu.Enabled = true;
        }
    }
}
