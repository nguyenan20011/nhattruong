using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO_NhaHang;

namespace DoAn_QL_NhaHang
{
    public partial class CongThucCheBien : Form
    {
        DAO_Menu dao_MonAn = new DAO_Menu();
        
        public CongThucCheBien()
        {
            InitializeComponent();
        }

        private void CongThucCheBien_Load(object sender, EventArgs e)
        {
            dataGrid_MonAn.DataSource = dao_MonAn.dt_Mon_An();
        }

        private void dataGrid_MonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGrid_MonAn.SelectedRows!=null)
            {
                string mamon = dataGrid_MonAn.CurrentRow.Cells["MAMON"].Value.ToString().Trim();
                dataGrid_CongThuc.DataSource = dao_MonAn.dt_CongThuc(mamon);
            }
        }
    }
}
