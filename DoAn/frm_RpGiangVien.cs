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
namespace DoAn
{
    public partial class frm_RpGiangVien : Form
    {
        string malopmh;
        string magv;

        public string Magv
        {
            get { return magv; }
            set { magv = value; }
        }
        public string Malopmh
        {
            get { return malopmh; }
            set { malopmh = value; }
        }
        public frm_RpGiangVien()
        {
            InitializeComponent();
        }
        public void getMa(string ma)
        {
            Malopmh = ma;
        }
        public void getMaGV(string ma)
        {
            Magv = ma;
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            GiangVienBaoCao rp = new GiangVienBaoCao();
            ConnectionInfo connectionInfo = new ConnectionInfo
            {
                ServerName = "LAPTOP-VF2P0PFO",
                DatabaseName = "DSSV_Last",
                IntegratedSecurity = true
            };
            //rp.SetDatabaseLogon("sa","123","LAPTOP-VF2P0PFO","DSSV_Last");
            rp.SetParameterValue("locmalopmh", Malopmh);
            rp.SetParameterValue("magiangvien", Magv);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();
        }

    }
}
