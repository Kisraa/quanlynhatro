namespace quanlynhatro.FormChucNang
{
    partial class FormChiTietThuePhong
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonthemkhach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxkhach = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewkhachhang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTraPhong = new System.Windows.Forms.Button();
            this.labelsokhachtoida = new System.Windows.Forms.Label();
            this.labelsonuoc = new System.Windows.Forms.Label();
            this.labelsodien = new System.Windows.Forms.Label();
            this.labeltrangthai = new System.Windows.Forms.Label();
            this.labelloaiphong = new System.Windows.Forms.Label();
            this.labeltenphong = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.makhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenkhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybatdauthuephong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtkhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkhachhang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1100, 516);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(553, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 510);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách trọ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.80042F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.19958F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(538, 481);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonthemkhach);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxkhach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 70);
            this.panel1.TabIndex = 0;
            // 
            // buttonthemkhach
            // 
            this.buttonthemkhach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.buttonthemkhach.ForeColor = System.Drawing.Color.White;
            this.buttonthemkhach.Location = new System.Drawing.Point(456, 16);
            this.buttonthemkhach.Name = "buttonthemkhach";
            this.buttonthemkhach.Size = new System.Drawing.Size(73, 35);
            this.buttonthemkhach.TabIndex = 16;
            this.buttonthemkhach.Text = "Thêm";
            this.buttonthemkhach.UseVisualStyleBackColor = false;
            this.buttonthemkhach.Click += new System.EventHandler(this.buttonthemkhach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn khách";
            // 
            // comboBoxkhach
            // 
            this.comboBoxkhach.FormattingEnabled = true;
            this.comboBoxkhach.Location = new System.Drawing.Point(114, 18);
            this.comboBoxkhach.Name = "comboBoxkhach";
            this.comboBoxkhach.Size = new System.Drawing.Size(336, 30);
            this.comboBoxkhach.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewkhachhang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 399);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewkhachhang
            // 
            this.dataGridViewkhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewkhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhach,
            this.hotenkhach,
            this.ngaybatdauthuephong,
            this.sdtkhach,
            this.socmnd,
            this.xoa});
            this.dataGridViewkhachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewkhachhang.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewkhachhang.Name = "dataGridViewkhachhang";
            this.dataGridViewkhachhang.ReadOnly = true;
            this.dataGridViewkhachhang.RowHeadersVisible = false;
            this.dataGridViewkhachhang.RowHeadersWidth = 51;
            this.dataGridViewkhachhang.RowTemplate.Height = 24;
            this.dataGridViewkhachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewkhachhang.Size = new System.Drawing.Size(532, 399);
            this.dataGridViewkhachhang.TabIndex = 4;
            this.dataGridViewkhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewkhachhang_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTraPhong);
            this.groupBox1.Controls.Add(this.labelsokhachtoida);
            this.groupBox1.Controls.Add(this.labelsonuoc);
            this.groupBox1.Controls.Add(this.labelsodien);
            this.groupBox1.Controls.Add(this.labeltrangthai);
            this.groupBox1.Controls.Add(this.labelloaiphong);
            this.groupBox1.Controls.Add(this.labeltenphong);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 510);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // buttonTraPhong
            // 
            this.buttonTraPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.buttonTraPhong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonTraPhong.ForeColor = System.Drawing.Color.White;
            this.buttonTraPhong.Location = new System.Drawing.Point(3, 455);
            this.buttonTraPhong.Name = "buttonTraPhong";
            this.buttonTraPhong.Size = new System.Drawing.Size(538, 52);
            this.buttonTraPhong.TabIndex = 15;
            this.buttonTraPhong.Text = "Trả phòng";
            this.buttonTraPhong.UseVisualStyleBackColor = false;
            this.buttonTraPhong.Click += new System.EventHandler(this.buttonTraPhong_Click);
            // 
            // labelsokhachtoida
            // 
            this.labelsokhachtoida.AutoSize = true;
            this.labelsokhachtoida.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsokhachtoida.Location = new System.Drawing.Point(13, 386);
            this.labelsokhachtoida.Name = "labelsokhachtoida";
            this.labelsokhachtoida.Size = new System.Drawing.Size(188, 33);
            this.labelsokhachtoida.TabIndex = 14;
            this.labelsokhachtoida.Text = "Số khách tối đa";
            // 
            // labelsonuoc
            // 
            this.labelsonuoc.AutoSize = true;
            this.labelsonuoc.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsonuoc.Location = new System.Drawing.Point(13, 341);
            this.labelsonuoc.Name = "labelsonuoc";
            this.labelsonuoc.Size = new System.Drawing.Size(165, 33);
            this.labelsonuoc.TabIndex = 13;
            this.labelsonuoc.Text = "Số nước: 280";
            // 
            // labelsodien
            // 
            this.labelsodien.AutoSize = true;
            this.labelsodien.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsodien.Location = new System.Drawing.Point(13, 296);
            this.labelsodien.Name = "labelsodien";
            this.labelsodien.Size = new System.Drawing.Size(157, 33);
            this.labelsodien.TabIndex = 12;
            this.labelsodien.Text = "Số điện: 280";
            // 
            // labeltrangthai
            // 
            this.labeltrangthai.AutoSize = true;
            this.labeltrangthai.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltrangthai.Location = new System.Drawing.Point(13, 251);
            this.labeltrangthai.Name = "labeltrangthai";
            this.labeltrangthai.Size = new System.Drawing.Size(175, 33);
            this.labeltrangthai.TabIndex = 11;
            this.labeltrangthai.Text = "Đã có khách ở";
            // 
            // labelloaiphong
            // 
            this.labelloaiphong.AutoSize = true;
            this.labelloaiphong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelloaiphong.Location = new System.Drawing.Point(13, 206);
            this.labelloaiphong.Name = "labelloaiphong";
            this.labelloaiphong.Size = new System.Drawing.Size(303, 33);
            this.labelloaiphong.TabIndex = 10;
            this.labelloaiphong.Text = "Loại phòng: đơn bình dân";
            // 
            // labeltenphong
            // 
            this.labeltenphong.AutoSize = true;
            this.labeltenphong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltenphong.Location = new System.Drawing.Point(177, 29);
            this.labeltenphong.Name = "labeltenphong";
            this.labeltenphong.Size = new System.Drawing.Size(174, 32);
            this.labeltenphong.TabIndex = 9;
            this.labeltenphong.Text = "Phòng A0202";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.flowLayoutPanel1.BackgroundImage = global::quanlynhatro.Properties.Resources.icons8_room_50;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(152, 152);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // makhach
            // 
            this.makhach.DataPropertyName = "makhach";
            this.makhach.HeaderText = "Mã khách hàng";
            this.makhach.MinimumWidth = 6;
            this.makhach.Name = "makhach";
            this.makhach.ReadOnly = true;
            // 
            // hotenkhach
            // 
            this.hotenkhach.DataPropertyName = "hotenkhach";
            this.hotenkhach.HeaderText = "Tên khách";
            this.hotenkhach.MinimumWidth = 6;
            this.hotenkhach.Name = "hotenkhach";
            this.hotenkhach.ReadOnly = true;
            // 
            // ngaybatdauthuephong
            // 
            this.ngaybatdauthuephong.DataPropertyName = "ngaybatdauthue";
            this.ngaybatdauthuephong.HeaderText = "Ngày bắt đầu thuê";
            this.ngaybatdauthuephong.MinimumWidth = 6;
            this.ngaybatdauthuephong.Name = "ngaybatdauthuephong";
            this.ngaybatdauthuephong.ReadOnly = true;
            // 
            // sdtkhach
            // 
            this.sdtkhach.DataPropertyName = "sdtkhach";
            this.sdtkhach.HeaderText = "SDT";
            this.sdtkhach.MinimumWidth = 6;
            this.sdtkhach.Name = "sdtkhach";
            this.sdtkhach.ReadOnly = true;
            // 
            // socmnd
            // 
            this.socmnd.DataPropertyName = "socmnd";
            this.socmnd.HeaderText = "CMND/CCCD";
            this.socmnd.MinimumWidth = 6;
            this.socmnd.Name = "socmnd";
            this.socmnd.ReadOnly = true;
            // 
            // xoa
            // 
            this.xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.xoa.HeaderText = "Xóa";
            this.xoa.MinimumWidth = 6;
            this.xoa.Name = "xoa";
            this.xoa.ReadOnly = true;
            this.xoa.Text = "Xóa";
            this.xoa.UseColumnTextForButtonValue = true;
            // 
            // FormChiTietThuePhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 516);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormChiTietThuePhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết phòng";
            this.Load += new System.EventHandler(this.FormChiTietThuePhong_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkhachhang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTraPhong;
        private System.Windows.Forms.Label labelsokhachtoida;
        private System.Windows.Forms.Label labelsonuoc;
        private System.Windows.Forms.Label labelsodien;
        private System.Windows.Forms.Label labeltrangthai;
        private System.Windows.Forms.Label labelloaiphong;
        private System.Windows.Forms.Label labeltenphong;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonthemkhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxkhach;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenkhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybatdauthuephong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtkhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn socmnd;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
    }
}