namespace DoAn
{
    partial class frm_GiangVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GiangVien));
            this.label1 = new System.Windows.Forms.Label();
            this.grd_LopGiangDay = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ChonLop = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.NameMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.cbo_Lop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd_LopGiangDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(319, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách lớp giảng dạy";
            // 
            // grd_LopGiangDay
            // 
            this.grd_LopGiangDay.AllowUserToAddRows = false;
            this.grd_LopGiangDay.AllowUserToDeleteRows = false;
            this.grd_LopGiangDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_LopGiangDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grd_LopGiangDay.Location = new System.Drawing.Point(42, 213);
            this.grd_LopGiangDay.Name = "grd_LopGiangDay";
            this.grd_LopGiangDay.ReadOnly = true;
            this.grd_LopGiangDay.RowHeadersWidth = 51;
            this.grd_LopGiangDay.RowTemplate.Height = 24;
            this.grd_LopGiangDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_LopGiangDay.Size = new System.Drawing.Size(987, 174);
            this.grd_LopGiangDay.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaLopMonHoc";
            this.Column1.HeaderText = "Mã lớp";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenMonHoc";
            this.Column2.HeaderText = "Môn";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "MaMonHoc";
            this.Column3.HeaderText = "Mã môn học";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "SiSo";
            this.Column4.HeaderText = "Sĩ số";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ChonLop
            // 
            this.btn_ChonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ChonLop.Location = new System.Drawing.Point(42, 409);
            this.btn_ChonLop.Name = "btn_ChonLop";
            this.btn_ChonLop.Size = new System.Drawing.Size(205, 49);
            this.btn_ChonLop.TabIndex = 6;
            this.btn_ChonLop.Text = "Chọn lớp điểm danh";
            this.btn_ChonLop.UseVisualStyleBackColor = true;
            this.btn_ChonLop.Click += new System.EventHandler(this.btn_ChonLop_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NameMenuStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(78, 31);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip";
            // 
            // NameMenuStrip
            // 
            this.NameMenuStrip.BackColor = System.Drawing.Color.White;
            this.NameMenuStrip.Checked = true;
            this.NameMenuStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NameMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoMenuStrip,
            this.ChangePasswordMenuStrip,
            this.LogoutMenuStrip});
            this.NameMenuStrip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NameMenuStrip.ForeColor = System.Drawing.Color.Black;
            this.NameMenuStrip.Name = "NameMenuStrip";
            this.NameMenuStrip.Size = new System.Drawing.Size(70, 27);
            this.NameMenuStrip.Text = "Name";
            // 
            // InfoMenuStrip
            // 
            this.InfoMenuStrip.Name = "InfoMenuStrip";
            this.InfoMenuStrip.Size = new System.Drawing.Size(234, 28);
            this.InfoMenuStrip.Text = "Thông tin cá nhân";
            this.InfoMenuStrip.Click += new System.EventHandler(this.InfoMenuStrip_Click);
            // 
            // ChangePasswordMenuStrip
            // 
            this.ChangePasswordMenuStrip.Name = "ChangePasswordMenuStrip";
            this.ChangePasswordMenuStrip.Size = new System.Drawing.Size(234, 28);
            this.ChangePasswordMenuStrip.Text = "Đổi mật khẩu";
            // 
            // LogoutMenuStrip
            // 
            this.LogoutMenuStrip.Name = "LogoutMenuStrip";
            this.LogoutMenuStrip.Size = new System.Drawing.Size(234, 28);
            this.LogoutMenuStrip.Text = "Đăng xuất";
            this.LogoutMenuStrip.Click += new System.EventHandler(this.LogoutMenuStrip_Click);
            // 
            // cbo_Lop
            // 
            this.cbo_Lop.FormattingEnabled = true;
            this.cbo_Lop.Location = new System.Drawing.Point(281, 423);
            this.cbo_Lop.Name = "cbo_Lop";
            this.cbo_Lop.Size = new System.Drawing.Size(132, 24);
            this.cbo_Lop.TabIndex = 11;
            // 
            // frm_GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 486);
            this.Controls.Add(this.cbo_Lop);
            this.Controls.Add(this.btn_ChonLop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grd_LopGiangDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frm_GiangVien";
            this.Text = "frm_GiangVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_GiangVien_FormClosing);
            this.Load += new System.EventHandler(this.frm_GiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_LopGiangDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grd_LopGiangDay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ChonLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem NameMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem InfoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem LogoutMenuStrip;
        private System.Windows.Forms.ComboBox cbo_Lop;
    }
}