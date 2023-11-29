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
        public bool isThoat = true;

        string id;

        public string Id { get => id; set => id = value; }

        public frm_SinhVien()
        {
            InitializeComponent();
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

        public void getID(string username)
        {
            Id = username;
        }


    }
}
