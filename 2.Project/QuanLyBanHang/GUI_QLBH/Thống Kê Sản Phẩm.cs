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
    public partial class Thống_Kê_Sản_Phẩm : Form
    {
        public Thống_Kê_Sản_Phẩm()
        {
            InitializeComponent();
        }

        private void data_SPNK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Thống_Kê_Sản_Phẩm_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            //var get = from lay in db.
        }
    }
}
