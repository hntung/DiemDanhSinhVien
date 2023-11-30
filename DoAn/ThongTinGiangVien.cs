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
    public partial class ThongTinGiangVien : Form
    {
        DBConnect db = new DBConnect();
        public bool isThoat = true;
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
        public ThongTinGiangVien()
        {
            InitializeComponent();
        }
        public event EventHandler DangXuat;
        private void Exit_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        void loadThongTinGV()
        {
            string sql = "select *from GiangVien where magiangvien = '" + id + "'";
            SqlDataReader rd = db.getDataReader(sql);
            if (rd.Read())
            {
                lb_MaGV.Text = rd["MaGiangVien"].ToString();
                lb_TenGV.Text = rd["HoTenGiangVien"].ToString();
                lb_TrinhDo.Text = rd["TrinhDo"].ToString();
                lb_ChuyenMon.Text = rd["ChuyenMon"].ToString();
            }
        }

        private void ThongTinGiangVien_Load(object sender, EventArgs e)
        {
            loadThongTinGV();
        }

        
    }
}
