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
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }


        Modify modify = new Modify();
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string taikhoan = txt_TaiKhoan.Text;
            string matkhau = txt_MatKhau.Text;
            if (taikhoan.Trim() == "") 
                MessageBox.Show("Vui lòng nhập tài khoản!"); 
            else if (matkhau.Trim() == "") 
                MessageBox.Show("Vui lòng nhập mật khẩu!"); 
            else
            {
                string query = string.Empty;
            
                if (rdo_GiangVien.Checked)
                {
                    query = "Select * from GiangVien where MaGiangVien = '" + taikhoan + "' and password = '" + matkhau + "'";
                    if (modify.DSTaiKhoan(query).Count != 0)
                    {
                        //MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_GiangVien f = new frm_GiangVien();
                        f.getID(taikhoan);
                        f.Show();
                        this.Hide();
                        f.DangXuat += f_DangXuat;
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_TaiKhoan.Focus();
                    }
                }
                   
                else
                {
                    query = "Select * from SinhVien where MaSinhVien = '" + taikhoan + "' and password = '" + matkhau + "'";
                    if (modify.DSTaiKhoan(query).Count != 0)
                    {
                        //MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_SinhVien f_sv = new frm_SinhVien();
                        f_sv.getID(taikhoan);
                        f_sv.Show();
                        this.Hide();
                        f_sv.DangXuat += f_sv_DangXuat;
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_TaiKhoan.Focus();
                    }

                }
                   
               
            }
            
        }
      
        void f_DangXuat(object sender, EventArgs e)
        {
            (sender as frm_GiangVien).isThoat = false;
            (sender as frm_GiangVien).Close();
            this.Show();

        }
        void f_sv_DangXuat(object sender, EventArgs e)
        {
            (sender as frm_SinhVien).isThoat = false;
            (sender as frm_SinhVien).Close();
            this.Show();
        }

        void reset()
        {
            txt_TaiKhoan.Clear();
            txt_MatKhau.Clear();
        }
        private void rdo_GiangVien_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo = (RadioButton)sender;
            if(rdo_GiangVien.Checked)
            {
                lbl_taikhoan.Text = "Mã giảng viên";
                reset();
            }
            else if (rdo_SinhVien.Checked)
            {
                lbl_taikhoan.Text = "Mã sinh viên";
                reset();
            }
        }
        private void frm_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Cancel)
                e.Cancel = true;
        }
        


    }
}
