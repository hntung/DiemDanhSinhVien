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
        DataSet ds_LopGiangDay = new DataSet();
        string id;
       
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
            load_CboLop();
            DataBingding(ds_LopGiangDay.Tables["LopGiangDay"]);
        }
   
        private void frm_GiangVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult r;
            //r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
            //    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //if (r == DialogResult.Cancel)
            //    e.Cancel = true;
        }

     

        public void load_gridview()
        {
            string sql = "select MaLopMonHoc,TenMonHoc,l.MaMonHoc,SiSo from LopMonHoc l, MonHoc m where l.MaMonHoc = m.MaMonHoc and MaGiangVien = '" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.Connect);
            da.Fill(ds_LopGiangDay, "LopGiangDay");
            grd_LopGiangDay.DataSource = ds_LopGiangDay.Tables["LopGiangDay"];
        }

        public void load_CboLop()
        {
            string sql = "select * from LopMonHoc where MaGiangVien = '"+Id+"'";
            DataTable dt = db.getDataTable(sql);
            cbo_Lop.DataSource = dt;
            cbo_Lop.DisplayMember = "MaLopMonHoc";
            cbo_Lop.ValueMember = "MaLopMonHoc";
        }
        public void DataBingding(DataTable pdt)
        {
            cbo_Lop.DataBindings.Clear();
            cbo_Lop.DataBindings.Add("SelectedValue", pdt, "MaLopMonHoc");
        }

        private void btn_ChonLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbo_Lop.Text))
                MessageBox.Show("Vui lòng chọn lớp môn học để điểm danh");
            else
            {
                frm_GV_DiemDanh f = new frm_GV_DiemDanh();
                f.getID(cbo_Lop.SelectedValue.ToString());
                f.getMaGV(Id);
                f.Show();
                this.Hide();
                f.DangXuat += f_DangXuat;
            }

        }
        public event EventHandler DangXuat;
        private void LogoutMenuStrip_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }
        void f_DangXuat(object sender, EventArgs e)
        {
            (sender as frm_GV_DiemDanh).isThoat = false;
            (sender as frm_GV_DiemDanh).Close();
            this.Show();

        }

        private void InfoMenuStrip_Click(object sender, EventArgs e)
        {

        }
    }
}
