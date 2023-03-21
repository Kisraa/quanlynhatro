namespace quanlynhatro.FormChucNang
{
    partial class FormSuaPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownSOKhachToiDa = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownSoNuoc = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownSoDien = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.comboBoxLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTenPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSOKhachToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoNuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoDien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập thông tin phòng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.numericUpDownSOKhachToiDa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numericUpDownSoNuoc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numericUpDownSoDien);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buttonHuy);
            this.panel1.Controls.Add(this.buttonLuu);
            this.panel1.Controls.Add(this.comboBoxLoaiPhong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxTenPhong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(34, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 296);
            this.panel1.TabIndex = 4;
            // 
            // numericUpDownSOKhachToiDa
            // 
            this.numericUpDownSOKhachToiDa.Location = new System.Drawing.Point(26, 213);
            this.numericUpDownSOKhachToiDa.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.numericUpDownSOKhachToiDa.Name = "numericUpDownSOKhachToiDa";
            this.numericUpDownSOKhachToiDa.Size = new System.Drawing.Size(340, 30);
            this.numericUpDownSOKhachToiDa.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số khách tối đa";
            // 
            // numericUpDownSoNuoc
            // 
            this.numericUpDownSoNuoc.Location = new System.Drawing.Point(449, 129);
            this.numericUpDownSoNuoc.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.numericUpDownSoNuoc.Name = "numericUpDownSoNuoc";
            this.numericUpDownSoNuoc.Size = new System.Drawing.Size(340, 30);
            this.numericUpDownSoNuoc.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Số nước";
            // 
            // numericUpDownSoDien
            // 
            this.numericUpDownSoDien.Location = new System.Drawing.Point(26, 129);
            this.numericUpDownSoDien.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.numericUpDownSoDien.Name = "numericUpDownSoDien";
            this.numericUpDownSoDien.Size = new System.Drawing.Size(340, 30);
            this.numericUpDownSoDien.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số điện";
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.buttonHuy.FlatAppearance.BorderSize = 0;
            this.buttonHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHuy.ForeColor = System.Drawing.Color.Black;
            this.buttonHuy.Location = new System.Drawing.Point(681, 207);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(108, 38);
            this.buttonHuy.TabIndex = 11;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(94)))), ((int)(((byte)(190)))));
            this.buttonLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLuu.ForeColor = System.Drawing.Color.White;
            this.buttonLuu.Location = new System.Drawing.Point(530, 207);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(145, 38);
            this.buttonLuu.TabIndex = 9;
            this.buttonLuu.Text = "Cập nhật";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // comboBoxLoaiPhong
            // 
            this.comboBoxLoaiPhong.FormattingEnabled = true;
            this.comboBoxLoaiPhong.Location = new System.Drawing.Point(449, 52);
            this.comboBoxLoaiPhong.Name = "comboBoxLoaiPhong";
            this.comboBoxLoaiPhong.Size = new System.Drawing.Size(340, 30);
            this.comboBoxLoaiPhong.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại phòng";
            // 
            // textBoxTenPhong
            // 
            this.textBoxTenPhong.Location = new System.Drawing.Point(26, 52);
            this.textBoxTenPhong.Name = "textBoxTenPhong";
            this.textBoxTenPhong.Size = new System.Drawing.Size(340, 30);
            this.textBoxTenPhong.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên phòng";
            // 
            // FormSuaPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormSuaPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa thông tin phòng";
            this.Load += new System.EventHandler(this.FormSuaPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSOKhachToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoNuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoDien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownSOKhachToiDa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownSoNuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownSoDien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.ComboBox comboBoxLoaiPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTenPhong;
        private System.Windows.Forms.Label label2;
    }
}