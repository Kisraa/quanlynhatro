namespace quanlynhatro.UserControls
{
    partial class UserControlQLSuaChua
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxloc = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewDanhSachThuTien = new System.Windows.Forms.DataGridView();
            this.matrogiup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenkhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaihotro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotro = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachThuTien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 766);
            this.panel1.TabIndex = 0;
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
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Trạng thái hổ trợ";
            // 
            // comboBoxloc
            // 
            this.comboBoxloc.FormattingEnabled = true;
            this.comboBoxloc.Items.AddRange(new object[] {
            "Tất cả",
            "Đã hổ trợ",
            "Chưa hổ trợ"});
            this.comboBoxloc.Location = new System.Drawing.Point(174, 15);
            this.comboBoxloc.Name = "comboBoxloc";
            this.comboBoxloc.Size = new System.Drawing.Size(258, 30);
            this.comboBoxloc.TabIndex = 12;
            this.comboBoxloc.SelectedIndexChanged += new System.EventHandler(this.comboBoxloc_SelectedIndexChanged);
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
            // dataGridViewDanhSachThuTien
            // 
            this.dataGridViewDanhSachThuTien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhSachThuTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachThuTien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matrogiup,
            this.hotenkhach,
            this.tenphong,
            this.mota,
            this.trangthaihotro,
            this.hotro});
            this.dataGridViewDanhSachThuTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDanhSachThuTien.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDanhSachThuTien.Name = "dataGridViewDanhSachThuTien";
            this.dataGridViewDanhSachThuTien.ReadOnly = true;
            this.dataGridViewDanhSachThuTien.RowHeadersVisible = false;
            this.dataGridViewDanhSachThuTien.RowHeadersWidth = 51;
            this.dataGridViewDanhSachThuTien.RowTemplate.Height = 24;
            this.dataGridViewDanhSachThuTien.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewDanhSachThuTien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDanhSachThuTien.Size = new System.Drawing.Size(1104, 691);
            this.dataGridViewDanhSachThuTien.TabIndex = 3;
            this.dataGridViewDanhSachThuTien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachThuTien_CellClick);
            // 
            // matrogiup
            // 
            this.matrogiup.DataPropertyName = "matrogiup";
            this.matrogiup.HeaderText = "Mã trợ giúp";
            this.matrogiup.MinimumWidth = 6;
            this.matrogiup.Name = "matrogiup";
            this.matrogiup.ReadOnly = true;
            // 
            // hotenkhach
            // 
            this.hotenkhach.DataPropertyName = "hotenkhach";
            this.hotenkhach.HeaderText = "Khách";
            this.hotenkhach.MinimumWidth = 6;
            this.hotenkhach.Name = "hotenkhach";
            this.hotenkhach.ReadOnly = true;
            // 
            // tenphong
            // 
            this.tenphong.DataPropertyName = "tenphong";
            this.tenphong.HeaderText = "Phòng";
            this.tenphong.MinimumWidth = 6;
            this.tenphong.Name = "tenphong";
            this.tenphong.ReadOnly = true;
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
            this.trangthaihotro.HeaderText = "Trạng thái hổ trợ";
            this.trangthaihotro.MinimumWidth = 6;
            this.trangthaihotro.Name = "trangthaihotro";
            this.trangthaihotro.ReadOnly = true;
            // 
            // hotro
            // 
            this.hotro.HeaderText = "Hổ trợ";
            this.hotro.MinimumWidth = 6;
            this.hotro.Name = "hotro";
            this.hotro.ReadOnly = true;
            this.hotro.Text = "Xác nhận đã hổ trợ";
            this.hotro.ToolTipText = "Xác nhận đã hổ trợ";
            this.hotro.UseColumnTextForButtonValue = true;
            // 
            // UserControlQLSuaChua
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlQLSuaChua";
            this.Size = new System.Drawing.Size(1112, 766);
            this.Load += new System.EventHandler(this.UserControlQLSuaChua_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachThuTien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxloc;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewDanhSachThuTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn matrogiup;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenkhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaihotro;
        private System.Windows.Forms.DataGridViewButtonColumn hotro;
    }
}
