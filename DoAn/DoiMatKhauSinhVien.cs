using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAn
{
    public partial class DoiMatKhauSinhVien : Form
    {
        DBConnect db = new DBConnect();
        DataTable dt = new DataTable();
        public bool isThoat = true;
        string id;
        string sql;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public void getID(string username)
        {
            Id = username;
        }
        public DoiMatKhauSinhVien()
        {
            InitializeComponent();
        }
        public event EventHandler DangXuat;

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        private void DoiMatKhauSinhVien_Load(object sender, EventArgs e)
        {
            txt_tentaikhoan.Text = Id.ToString();
            
        }
        private bool check_passwordMatch(string newPaswword, string confirmPassword)
        {
            return newPaswword == confirmPassword;
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            sql = "select count(*)from SinhVien where MaSinhVien = '" + Id + "' and Password = '" + txt_matkhaucu.Text + "'";
            dt = db.getDataTable(sql);
            errorProvider1.Clear();
            if(dt.Rows[0][0].ToString()=="1")
            {
                if (check_passwordMatch(txt_matkhaumoi.Text, txt_xacnhanmk.Text))
                {
                    SqlDataAdapter da = new SqlDataAdapter("update SinhVien set Password = '" + txt_matkhaumoi.Text + "' where MaSinhVien = '" + Id + "'", db.Connect);
                    int kq = da.Fill(dt);
                    MessageBox.Show("Đổi mật khẩu thành công");

                }
                else
                {
                    errorProvider1.SetError(txt_matkhaumoi, "Bạn chưa điền mật khẩu");
                    errorProvider1.SetError(txt_xacnhanmk, "Mật khẩu nhập lại chưa đúng");
                }
            }
            else
            {
                errorProvider1.SetError(txt_matkhaucu, "Mật khẩu củ không đúng");
            }
            
        }
        
    }
}
