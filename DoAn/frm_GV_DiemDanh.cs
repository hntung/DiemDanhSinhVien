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
        DataSet DS_DiemDanh = new DataSet();
        string id;
        public string Id { get => id; set => id = value; }

        public void getID(string malop)
        {
            Id = malop;
        }
        string ngayhoc;
        public string Ngayhoc { get => ngayhoc; set => ngayhoc = value; }

        public void getNgayHoc(string ngayhoc)
        {
            Ngayhoc = ngayhoc;  
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
            getNgayHoc(cbo_NgayHoc.SelectedValue.ToString());
            loadGRDDiemDanh();
        }

        void loadGRDDiemDanh()
        {
            string sql = "select DiemDanh.MaSinhVien,HoTenSinhVien from DiemDanh inner join SinhVien on DiemDanh.MaSinhVien = SinhVien.MaSinhVien where MaLopMonHoc = '"+Id+"' and NgayHoc = '"+Ngayhoc+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.Connect);
            da.Fill(DS_DiemDanh, "DSDiemDanh");
            grd_DiemDanh.DataSource = DS_DiemDanh.Tables["DSDiemDanh"];
        }

        private void frm_GV_DiemDanh_Load(object sender, EventArgs e)
        {
            loadCboNgayHoc();
        }
    }
}
