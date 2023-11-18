using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class TaiKhoan
    {
        private string taikhoan;

        public string Taikhoan
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }
        private string matkhau;

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        public TaiKhoan()
        {
        }
        public TaiKhoan(string taikhoan,string matkhau)
        {
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
        }

    }
}
