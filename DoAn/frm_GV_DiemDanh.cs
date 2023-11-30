using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frm_GV_DiemDanh : Form
    {
        DBConnect db = new DBConnect();
        DataTable dt_diemdanh = new DataTable();
        public bool isThoat = true;
        string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public void getID(string malop)
        {
            Id = malop;
        }
        string ngayhoc;
        public string Ngayhoc
        {
            get { return ngayhoc; }
            set { ngayhoc = value; }
        }

        public void getNgayHoc(string ngayhoc)
        {
            Ngayhoc = DateTime.Parse(ngayhoc).ToString("MM-dd-yyyy");

        }

        string magv;
        public string Magv
        {
            get { return magv; }
            set { magv = value; }
        }
        public void getMaGV(string ma)
        {
            Magv = ma;
        }
        public frm_GV_DiemDanh()
        {
            InitializeComponent();
        }
        
        void loadCboNgayHoc()
        {
            string sql = "select distinct NgayHoc from DiemDanh where MaLopMonHoc = '" + Id + "'";
            DataTable dt = db.getDataTable(sql);
            cbo_NgayHoc.DataSource = dt;
            cbo_NgayHoc.DisplayMember = "NgayHoc";
            cbo_NgayHoc.ValueMember = "NgayHoc";

        }

        void loadGRDDiemDanh()
        {
            getNgayHoc(cbo_NgayHoc.SelectedValue.ToString());
            string sql = "select *from DiemDanh where MaLopMonHoc = '" + Id + "' and NgayHoc = '" + ngayhoc + "'";
            dt_diemdanh = db.getDataTable(sql);
            grd_DiemDanh.DataSource = dt_diemdanh;

        }

        private void frm_GV_DiemDanh_Load(object sender, EventArgs e)
        {
            string sql = "select HoTenGiangvien from Giangvien where MaGiangVien = '" + magv + "'";
            menuStrip.Items["Name"].Text = db.getScalar(sql).ToString();
            loadCboNgayHoc();
            loadGRDDiemDanh();

        }

        private void btn_ChonNgay_Click(object sender, EventArgs e)
        {
            loadGRDDiemDanh();
        }



        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string sql = "select *from DiemDanh";
            int kq = db.updateDatabase(sql, dt_diemdanh);
            if (kq == 0)
                MessageBox.Show("Cập nhật điểm danh thất bại");
            else
                MessageBox.Show("Cập nhật điểm danh thành công");
        }
        public event EventHandler DangXuat;
        private void dangxuatMenuStrip_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }
      
        private void frm_GV_DiemDanh_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult r;
            //r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
            //    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //if (r == DialogResult.Cancel)
            //    e.Cancel = true;
        }


    }
}
