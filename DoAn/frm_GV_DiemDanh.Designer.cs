
namespace DoAn
{
    partial class frm_GV_DiemDanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GV_DiemDanh));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbo_NgayHoc = new System.Windows.Forms.ComboBox();
            this.grd_DiemDanh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btn_ChonNgay = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Name = new System.Windows.Forms.ToolStripMenuItem();
            this.ketquadiemdanh = new System.Windows.Forms.ToolStripMenuItem();
            this.dangxuatMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_DiemDanh)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(357, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cbo_NgayHoc
            // 
            this.cbo_NgayHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_NgayHoc.FormattingEnabled = true;
            this.cbo_NgayHoc.Location = new System.Drawing.Point(12, 194);
            this.cbo_NgayHoc.Name = "cbo_NgayHoc";
            this.cbo_NgayHoc.Size = new System.Drawing.Size(177, 28);
            this.cbo_NgayHoc.TabIndex = 5;
            // 
            // grd_DiemDanh
            // 
            this.grd_DiemDanh.AllowUserToAddRows = false;
            this.grd_DiemDanh.AllowUserToDeleteRows = false;
            this.grd_DiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_DiemDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.TrangThai});
            this.grd_DiemDanh.Location = new System.Drawing.Point(12, 249);
            this.grd_DiemDanh.Name = "grd_DiemDanh";
            this.grd_DiemDanh.RowHeadersWidth = 51;
            this.grd_DiemDanh.RowTemplate.Height = 24;
            this.grd_DiemDanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_DiemDanh.Size = new System.Drawing.Size(1049, 225);
            this.grd_DiemDanh.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaSinhVien";
            this.Column1.HeaderText = "Mã số sinh viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MaLopMonHoc";
            this.Column2.HeaderText = "Mã lớp môn học";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "NgayHoc";
            this.Column5.HeaderText = "Ngày học";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "TrangThai";
            this.TrangThai.Items.AddRange(new object[] {
            "Có mặt",
            "Vắng"});
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btn_ChonNgay
            // 
            this.btn_ChonNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ChonNgay.Location = new System.Drawing.Point(210, 194);
            this.btn_ChonNgay.Name = "btn_ChonNgay";
            this.btn_ChonNgay.Size = new System.Drawing.Size(144, 37);
            this.btn_ChonNgay.TabIndex = 8;
            this.btn_ChonNgay.Text = "Chọn ngày buổi học";
            this.btn_ChonNgay.UseVisualStyleBackColor = true;
            this.btn_ChonNgay.Click += new System.EventHandler(this.btn_ChonNgay_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Luu.Location = new System.Drawing.Point(40, 491);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(126, 63);
            this.btn_Luu.TabIndex = 9;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Name});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1073, 30);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip";
            // 
            // Name
            // 
            this.Name.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ketquadiemdanh,
            this.dangxuatMenuStrip});
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(60, 26);
            this.Name.Text = "Menu";
            // 
            // ketquadiemdanh
            // 
            this.ketquadiemdanh.Name = "ketquadiemdanh";
            this.ketquadiemdanh.Size = new System.Drawing.Size(224, 26);
            this.ketquadiemdanh.Text = "Kết quả điểm danh";
            // 
            // dangxuatMenuStrip
            // 
            this.dangxuatMenuStrip.Name = "dangxuatMenuStrip";
            this.dangxuatMenuStrip.Size = new System.Drawing.Size(224, 26);
            this.dangxuatMenuStrip.Text = "Thoát";
            this.dangxuatMenuStrip.Click += new System.EventHandler(this.dangxuatMenuStrip_Click);
            // 
            // frm_GV_DiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 566);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_ChonNgay);
            this.Controls.Add(this.grd_DiemDanh);
            this.Controls.Add(this.cbo_NgayHoc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Text = "frm_GV_DiemDanh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_GV_DiemDanh_FormClosing);
            this.Load += new System.EventHandler(this.frm_GV_DiemDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_DiemDanh)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbo_NgayHoc;
        private System.Windows.Forms.DataGridView grd_DiemDanh;
        private System.Windows.Forms.Button btn_ChonNgay;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Name;
        private System.Windows.Forms.ToolStripMenuItem ketquadiemdanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn TrangThai;
        private System.Windows.Forms.ToolStripMenuItem dangxuatMenuStrip;
    }
}