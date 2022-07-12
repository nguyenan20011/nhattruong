using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using DAO_NhaHang;
namespace DoAn_QL_NhaHang
{
    public partial class Report_HoaDon : Form
    {
        DAO_QLHD dao_hd = new DAO_QLHD();
        public string mahd { get; set; }
        public Report_HoaDon()
        {
            InitializeComponent();
        }

        private void Report_HoaDon_Load(object sender, EventArgs e)
        {
            rpt_HoaDon rpt = new rpt_HoaDon();
            rpt.SetDatabaseLogon("sa", "123", "LENOVOL340", "QUANLI_NHAHANG");
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();
            pdv.Value = mahd;
            ParameterValues pv = new ParameterValues();
            pv.Add(pdv);
            rpt.DataDefinition.ParameterFields["@MAHD"].ApplyCurrentValues(pv);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
