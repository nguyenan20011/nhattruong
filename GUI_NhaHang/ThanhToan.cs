using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QL_NhaHang
{
    public partial class ThanhToan : Form
    {
        string soban;
        public ThanhToan(string _soban)
        {
            soban = _soban;
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu(soban);
            mn.Show();
            this.Hide();
        }
    }
}
