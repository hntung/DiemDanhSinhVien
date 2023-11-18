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
    public partial class frm_GiangVien : Form
    {
        DBConnect db = new DBConnect();
        public bool isThoat = true;
        string id;

        DataSet ds_LopGiangDay = new DataSet();
       
        public string Id { get => id; set => id = value; }
        public void getID(string username)
        {
            Id = username;
        }
        public frm_GiangVien()
        {
            InitializeComponent();
            
        }

        private void frm_GiangVien_Load(object sender, EventArgs e)
        {
            string sql = "select HoTenGiangvien from Giangvien where MaGiangVien = '"+Id+"'";
            menuStrip.Items["NameMenuStrip"].Text = db.getScalar(sql).ToString();
            load_gridview();
            DataBingding(ds_LopGiangDay.Tables["LopGiangDay"]);
            label_class.Hide();
        }
   

        private void grd_LopGiangDay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_class.Show();
        }
        public event EventHandler DangXuat;
        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        private void frm_GiangVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

     

        public void load_gridview()
        {
            string sql = "select MaLopMonHoc,TenMonHoc,l.MaMonHoc,SiSo from LopMonHoc l, MonHoc m where l.MaMonHoc = m.MaMonHoc and MaGiangVien = '" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.Connect);
            da.Fill(ds_LopGiangDay, "LopGiangDay");
            grd_LopGiangDay.DataSource = ds_LopGiangDay.Tables["LopGiangDay"];
        }

        public void DataBingding(DataTable pdt)
        {
            label_class.DataBindings.Clear();
            label_class.DataBindings.Add("Text", pdt, "MaLopMonHoc");
        }
     
        private void LogoutMenuStrip_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

       
    }
}
