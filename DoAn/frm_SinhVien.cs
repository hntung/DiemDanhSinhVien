using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frm_SinhVien : Form
    {
        DBConnect db = new DBConnect();
        public bool isThoat = true;
        string malop;
        public string Malop
        {
            get { return malop; }
            set { malop = value; }
        }
        void getMaLop()
        {
            Malop = cbo_Lop.SelectedValue.ToString();
        }
        string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public void getID(string username)
        {
            Id = username;
        }
        public frm_SinhVien()
        {
            InitializeComponent();
       
        }
       

        void loadCboLop()
        {
            string sql = "select distinct MaLopMonHoc from DiemDanh where MaSinhVien = '" + id+"'";
            DataTable dt = db.getDataTable(sql);
            cbo_Lop.DataSource = dt;
            cbo_Lop.DisplayMember = "MaLopMonHoc";
            cbo_Lop.ValueMember = "MaLopMonHoc";
            getMaLop();
        }

        void loadGRDLop()
        {
            string sql = "select MaLopMonHoc, ngayhoc, trangthai from DiemDanh inner join sinhvien on diemdanh.masinhvien = sinhvien.masinhvien where DiemDanh.MaSinhVien = '"+id+"' and MaLopMonHoc = '"+malop+"' ";
            DataTable dt = db.getDataTable(sql);
            grd_DiemDanhLopMH.DataSource = dt;

        }

        private void frm_SinhVien_Load(object sender, EventArgs e)
        {
            string sql = "select HoTenSinhVien from SinhVien where MaSinhVien = '" + Id + "'";
            menuStrip1.Items["TenSinhVien"].Text = db.getScalar(sql).ToString();
            loadCboLop();
            loadGRDLop();
        }

        private void cbo_Lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            getMaLop();
            loadGRDLop();
        }

        public event EventHandler DangXuat;
        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        private void frm_SinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }
        private void logout_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }
    }
}
