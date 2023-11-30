namespace DoAn
{
    partial class frm_SinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SinhVien));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grd_DiemDanhLopMH = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_Lop = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_taikhoan = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TenSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảĐiểmDanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.info = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_DiemDanhLopMH)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(279, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(285, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách lớp môn học";
            // 
            // grd_DiemDanhLopMH
            // 
            this.grd_DiemDanhLopMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_DiemDanhLopMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.TrangThai});
            this.grd_DiemDanhLopMH.Location = new System.Drawing.Point(36, 233);
            this.grd_DiemDanhLopMH.Name = "grd_DiemDanhLopMH";
            this.grd_DiemDanhLopMH.RowHeadersWidth = 51;
            this.grd_DiemDanhLopMH.RowTemplate.Height = 24;
            this.grd_DiemDanhLopMH.Size = new System.Drawing.Size(1002, 193);
            this.grd_DiemDanhLopMH.TabIndex = 6;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "MaLopMonHoc";
            this.Column3.HeaderText = "Mã lớp môn học";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "ngayhoc";
            this.Column4.HeaderText = "Buổi học";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrangThai.DataPropertyName = "trangthai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // cbo_Lop
            // 
            this.cbo_Lop.FormattingEnabled = true;
            this.cbo_Lop.Location = new System.Drawing.Point(267, 190);
            this.cbo_Lop.Name = "cbo_Lop";
            this.cbo_Lop.Size = new System.Drawing.Size(132, 24);
            this.cbo_Lop.TabIndex = 13;
            this.cbo_Lop.SelectedIndexChanged += new System.EventHandler(this.cbo_Lop_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl_taikhoan
            // 
            this.lbl_taikhoan.AutoSize = true;
            this.lbl_taikhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_taikhoan.Location = new System.Drawing.Point(51, 183);
            this.lbl_taikhoan.Name = "lbl_taikhoan";
            this.lbl_taikhoan.Size = new System.Drawing.Size(174, 28);
            this.lbl_taikhoan.TabIndex = 15;
            this.lbl_taikhoan.Text = "Chọn lớp môn học";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TenSinhVien});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TenSinhVien
            // 
            this.TenSinhVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.kếtQuảĐiểmDanhToolStripMenuItem,
            this.info,
            this.logout});
            this.TenSinhVien.Name = "TenSinhVien";
            this.TenSinhVien.Size = new System.Drawing.Size(63, 24);
            this.TenSinhVien.Text = "Name";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // kếtQuảĐiểmDanhToolStripMenuItem
            // 
            this.kếtQuảĐiểmDanhToolStripMenuItem.Name = "kếtQuảĐiểmDanhToolStripMenuItem";
            this.kếtQuảĐiểmDanhToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.kếtQuảĐiểmDanhToolStripMenuItem.Text = "Thông tin điểm danh";
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(230, 26);
            this.logout.Text = "Đăng xuất";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // info
            // 
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(230, 26);
            this.info.Text = "Thông tin cá nhân";
            // 
            // frm_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 509);
            this.Controls.Add(this.lbl_taikhoan);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cbo_Lop);
            this.Controls.Add(this.grd_DiemDanhLopMH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_SinhVien";
            this.Text = "frm_SinhVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_SinhVien_FormClosing);
            this.Load += new System.EventHandler(this.frm_SinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_DiemDanhLopMH)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grd_DiemDanhLopMH;
        private System.Windows.Forms.ComboBox cbo_Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbl_taikhoan;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TenSinhVien;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtQuảĐiểmDanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.ToolStripMenuItem info;
    }
}