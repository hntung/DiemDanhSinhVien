using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace DoAn
{
    public partial class ThongTinSinhVien : Form
    {
        DBConnect db =  new DBConnect();
        public bool isThoat = true;
        string imageURL = string.Empty;
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
        public ThongTinSinhVien()
        {
            InitializeComponent();
        }

        private void LoadImageFromUrl(string imageUrl)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    // Tải hình ảnh từ URL
                    byte[] data = webClient.DownloadData(imageUrl);

                    // Chuyển đổi dữ liệu byte thành hình ảnh
                    using (MemoryStream ms = new MemoryStream(data))
                    {
                        Image image = Image.FromStream(ms);

                        // Hiển thị hình ảnh trên PictureBox
                        pictureBox1.Image = image;
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void loadThongTin()
        {
            string sql = "select *from sinhvien where masinhvien = '" + id + "'";
            SqlDataReader rd = db.getDataReader(sql);
            if (rd.Read())
            {
                lb_MaSV.Text = rd["MaSinhVien"].ToString();
                lb_TenSV.Text = rd["HoTenSinhVien"].ToString();
                lb_NgaySinh.Text = rd["NgaySinh"].ToString();
                DateTime ngaySinh = Convert.ToDateTime(rd["NgaySinh"]);
                lb_NgaySinh.Text = ngaySinh.ToString("dd/MM/yyyy");
                lb_GioiTinh.Text = rd["GioiTinh"].ToString();
                lb_LopBC.Text = rd["LopNienChe"].ToString();
                imageURL = rd["Image"].ToString();
            }
        }
        private void ThongTinSinhVien_Load(object sender, EventArgs e)
        {
            loadThongTin();
            LoadImageFromUrl(imageURL);
        }
        public event EventHandler DangXuat;
        private void Exit_Click(object sender, EventArgs e)
        {
             DangXuat(this, new EventArgs());
        }
    }
}
