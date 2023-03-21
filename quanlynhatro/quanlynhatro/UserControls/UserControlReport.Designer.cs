namespace quanlynhatro.UserControls
{
    partial class UserControlReport
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxloc = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewDanhSachThuTien = new System.Windows.Forms.DataGridView();
            this.maphieuthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaidongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XemChiTietThu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttxem = new System.Windows.Forms.Button();
            this.buttonxuatbc = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachThuTien)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.827586F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.17242F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1112, 766);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonxuatbc);
            this.panel3.Controls.Add(this.buttxem);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBoxloc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1106, 61);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Trạng thái đóng tiền";
            // 
            // comboBoxloc
            // 
            this.comboBoxloc.FormattingEnabled = true;
            this.comboBoxloc.Items.AddRange(new object[] {
            "Tất cả",
            "Đã đóng tiền",
            "Chưa đóng tiền"});
            this.comboBoxloc.Location = new System.Drawing.Point(174, 15);
            this.comboBoxloc.Name = "comboBoxloc";
            this.comboBoxloc.Size = new System.Drawing.Size(176, 30);
            this.comboBoxloc.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dataGridViewDanhSachThuTien);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1106, 693);
            this.panel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Từ ngày";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(442, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(732, 11);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(651, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Đến ngày";
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
            this.dataGridViewDanhSachThuTien.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDanhSachThuTien.Name = "dataGridViewDanhSachThuTien";
            this.dataGridViewDanhSachThuTien.ReadOnly = true;
            this.dataGridViewDanhSachThuTien.RowHeadersVisible = false;
            this.dataGridViewDanhSachThuTien.RowHeadersWidth = 51;
            this.dataGridViewDanhSachThuTien.RowTemplate.Height = 24;
            this.dataGridViewDanhSachThuTien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDanhSachThuTien.Size = new System.Drawing.Size(1104, 691);
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
            // buttxem
            // 
            this.buttxem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttxem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(94)))), ((int)(((byte)(190)))));
            this.buttxem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttxem.ForeColor = System.Drawing.Color.White;
            this.buttxem.Location = new System.Drawing.Point(938, 10);
            this.buttxem.Name = "buttxem";
            this.buttxem.Size = new System.Drawing.Size(58, 34);
            this.buttxem.TabIndex = 18;
            this.buttxem.Text = "Xem";
            this.buttxem.UseVisualStyleBackColor = false;
            this.buttxem.Click += new System.EventHandler(this.buttxem_Click);
            // 
            // buttonxuatbc
            // 
            this.buttonxuatbc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonxuatbc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(94)))), ((int)(((byte)(190)))));
            this.buttonxuatbc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonxuatbc.ForeColor = System.Drawing.Color.White;
            this.buttonxuatbc.Location = new System.Drawing.Point(1002, 10);
            this.buttonxuatbc.Name = "buttonxuatbc";
            this.buttonxuatbc.Size = new System.Drawing.Size(99, 34);
            this.buttonxuatbc.TabIndex = 19;
            this.buttonxuatbc.Text = "Xuất BC";
            this.buttonxuatbc.UseVisualStyleBackColor = false;
            this.buttonxuatbc.Click += new System.EventHandler(this.buttonxuatbc_Click);
            // 
            // UserControlReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlReport";
            this.Size = new System.Drawing.Size(1112, 766);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachThuTien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxloc;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDanhSachThuTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieuthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaidongtien;
        private System.Windows.Forms.DataGridViewButtonColumn XemChiTietThu;
        private System.Windows.Forms.Button buttonxuatbc;
        private System.Windows.Forms.Button buttxem;
    }
}
