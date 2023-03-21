namespace quanlynhatro.UserControls
{
    partial class UserControlTaiKhoanNguoiDung
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewDanhSachThuTien = new System.Windows.Forms.DataGridView();
            this.maphieuthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaidongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XemChiTietThu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonThemLoaiPhong = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.matrogiup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaihotro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachThuTien)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 766);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1112, 766);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewDanhSachThuTien);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1104, 731);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lịch sử đóng trọ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDanhSachThuTien
            // 
            this.dataGridViewDanhSachThuTien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhSachThuTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachThuTien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieuthu,
            this.tenphong,
            this.ngaylap,
            this.thanhtien,
            this.trangthaidongtien,
            this.XemChiTietThu});
            this.dataGridViewDanhSachThuTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDanhSachThuTien.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDanhSachThuTien.Name = "dataGridViewDanhSachThuTien";
            this.dataGridViewDanhSachThuTien.ReadOnly = true;
            this.dataGridViewDanhSachThuTien.RowHeadersVisible = false;
            this.dataGridViewDanhSachThuTien.RowHeadersWidth = 51;
            this.dataGridViewDanhSachThuTien.RowTemplate.Height = 24;
            this.dataGridViewDanhSachThuTien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDanhSachThuTien.Size = new System.Drawing.Size(1098, 725);
            this.dataGridViewDanhSachThuTien.TabIndex = 4;
            this.dataGridViewDanhSachThuTien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachThuTien_CellClick);
            // 
            // maphieuthu
            // 
            this.maphieuthu.DataPropertyName = "maphieuthu";
            this.maphieuthu.HeaderText = "Mã phiếu thu";
            this.maphieuthu.MinimumWidth = 6;
            this.maphieuthu.Name = "maphieuthu";
            this.maphieuthu.ReadOnly = true;
            // 
            // tenphong
            // 
            this.tenphong.DataPropertyName = "tenphong";
            this.tenphong.HeaderText = "Phòng";
            this.tenphong.MinimumWidth = 6;
            this.tenphong.Name = "tenphong";
            this.tenphong.ReadOnly = true;
            // 
            // ngaylap
            // 
            this.ngaylap.DataPropertyName = "ngaylap";
            this.ngaylap.HeaderText = "Ngày lập phiếu thu";
            this.ngaylap.MinimumWidth = 6;
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.MinimumWidth = 6;
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // trangthaidongtien
            // 
            this.trangthaidongtien.DataPropertyName = "trangthaidongtien";
            this.trangthaidongtien.HeaderText = "Trạng thái đóng tiền";
            this.trangthaidongtien.MinimumWidth = 6;
            this.trangthaidongtien.Name = "trangthaidongtien";
            this.trangthaidongtien.ReadOnly = true;
            // 
            // XemChiTietThu
            // 
            this.XemChiTietThu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.XemChiTietThu.HeaderText = "Xem chi tiết";
            this.XemChiTietThu.MinimumWidth = 6;
            this.XemChiTietThu.Name = "XemChiTietThu";
            this.XemChiTietThu.ReadOnly = true;
            this.XemChiTietThu.Text = "Chi tiết";
            this.XemChiTietThu.UseColumnTextForButtonValue = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1104, 731);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Trợ giúp, sửa chữa";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonThemLoaiPhong, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.275862F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.72414F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1098, 725);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonThemLoaiPhong
            // 
            this.buttonThemLoaiPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThemLoaiPhong.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonThemLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThemLoaiPhong.ForeColor = System.Drawing.Color.White;
            this.buttonThemLoaiPhong.Location = new System.Drawing.Point(843, 3);
            this.buttonThemLoaiPhong.Name = "buttonThemLoaiPhong";
            this.buttonThemLoaiPhong.Size = new System.Drawing.Size(252, 38);
            this.buttonThemLoaiPhong.TabIndex = 8;
            this.buttonThemLoaiPhong.Text = "Gửi trợ giúp, sửa chữa";
            this.buttonThemLoaiPhong.UseVisualStyleBackColor = false;
            this.buttonThemLoaiPhong.Click += new System.EventHandler(this.buttonThemLoaiPhong_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matrogiup,
            this.mota,
            this.trangthaihotro});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1092, 660);
            this.dataGridView1.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // matrogiup
            // 
            this.matrogiup.DataPropertyName = "matrogiup";
            this.matrogiup.HeaderText = "Mã hổ trợ";
            this.matrogiup.MinimumWidth = 6;
            this.matrogiup.Name = "matrogiup";
            this.matrogiup.ReadOnly = true;
            // 
            // mota
            // 
            this.mota.DataPropertyName = "mota";
            this.mota.HeaderText = "Mô tả";
            this.mota.MinimumWidth = 6;
            this.mota.Name = "mota";
            this.mota.ReadOnly = true;
            // 
            // trangthaihotro
            // 
            this.trangthaihotro.DataPropertyName = "trangthaihotro";
            this.trangthaihotro.HeaderText = "Trạng thái";
            this.trangthaihotro.MinimumWidth = 6;
            this.trangthaihotro.Name = "trangthaihotro";
            this.trangthaihotro.ReadOnly = true;
            // 
            // UserControlTaiKhoanNguoiDung
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlTaiKhoanNguoiDung";
            this.Size = new System.Drawing.Size(1112, 766);
            this.Load += new System.EventHandler(this.UserControlTaiKhoanNguoiDung_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachThuTien)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewDanhSachThuTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieuthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaidongtien;
        private System.Windows.Forms.DataGridViewButtonColumn XemChiTietThu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonThemLoaiPhong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matrogiup;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaihotro;
    }
}
