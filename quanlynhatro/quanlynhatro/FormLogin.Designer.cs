namespace quanlynhatro
{
    partial class FormLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelgrb = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_anhienmathau = new System.Windows.Forms.CheckBox();
            this.button_DangNhap = new System.Windows.Forms.Button();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.textBox_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonNguoithuetro = new System.Windows.Forms.RadioButton();
            this.radioButtonNhaQuanLy = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelgrb.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelgrb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(591, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 568);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.radioButtonNhaQuanLy);
            this.panel2.Controls.Add(this.radioButtonNguoithuetro);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.checkBox_anhienmathau);
            this.panel2.Controls.Add(this.button_DangNhap);
            this.panel2.Controls.Add(this.textBox_MatKhau);
            this.panel2.Controls.Add(this.textBox_TenDangNhap);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 568);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::quanlynhatro.Properties.Resources._67120251;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelgrb
            // 
            this.panelgrb.Controls.Add(this.pictureBox1);
            this.panelgrb.Location = new System.Drawing.Point(49, 40);
            this.panelgrb.Name = "panelgrb";
            this.panelgrb.Size = new System.Drawing.Size(258, 258);
            this.panelgrb.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "PM QUẢN LÝ NHÀ TRỌ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hiện đại, tiện dụng, chính xác";
            // 
            // checkBox_anhienmathau
            // 
            this.checkBox_anhienmathau.AutoSize = true;
            this.checkBox_anhienmathau.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.checkBox_anhienmathau.Location = new System.Drawing.Point(91, 283);
            this.checkBox_anhienmathau.Name = "checkBox_anhienmathau";
            this.checkBox_anhienmathau.Size = new System.Drawing.Size(128, 23);
            this.checkBox_anhienmathau.TabIndex = 11;
            this.checkBox_anhienmathau.Text = "Hiện mật khẩu";
            this.checkBox_anhienmathau.UseVisualStyleBackColor = true;
            this.checkBox_anhienmathau.CheckedChanged += new System.EventHandler(this.checkBox_anhienmathau_CheckedChanged);
            // 
            // button_DangNhap
            // 
            this.button_DangNhap.BackColor = System.Drawing.Color.Teal;
            this.button_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_DangNhap.ForeColor = System.Drawing.Color.White;
            this.button_DangNhap.Location = new System.Drawing.Point(90, 399);
            this.button_DangNhap.Name = "button_DangNhap";
            this.button_DangNhap.Size = new System.Drawing.Size(384, 32);
            this.button_DangNhap.TabIndex = 10;
            this.button_DangNhap.Text = "Đăng nhập";
            this.button_DangNhap.UseVisualStyleBackColor = false;
            this.button_DangNhap.Click += new System.EventHandler(this.button_DangNhap_Click);
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(90, 247);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(385, 30);
            this.textBox_MatKhau.TabIndex = 9;
            this.textBox_MatKhau.UseSystemPasswordChar = true;
            // 
            // textBox_TenDangNhap
            // 
            this.textBox_TenDangNhap.Location = new System.Drawing.Point(91, 174);
            this.textBox_TenDangNhap.Name = "textBox_TenDangNhap";
            this.textBox_TenDangNhap.Size = new System.Drawing.Size(384, 30);
            this.textBox_TenDangNhap.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(85, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đăng nhập hệ thống";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên đăng nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mật khẩu";
            // 
            // radioButtonNguoithuetro
            // 
            this.radioButtonNguoithuetro.AutoSize = true;
            this.radioButtonNguoithuetro.Location = new System.Drawing.Point(90, 355);
            this.radioButtonNguoithuetro.Name = "radioButtonNguoithuetro";
            this.radioButtonNguoithuetro.Size = new System.Drawing.Size(146, 26);
            this.radioButtonNguoithuetro.TabIndex = 14;
            this.radioButtonNguoithuetro.TabStop = true;
            this.radioButtonNguoithuetro.Text = "Người thuê trọ";
            this.radioButtonNguoithuetro.UseVisualStyleBackColor = true;
            // 
            // radioButtonNhaQuanLy
            // 
            this.radioButtonNhaQuanLy.AutoSize = true;
            this.radioButtonNhaQuanLy.Location = new System.Drawing.Point(348, 355);
            this.radioButtonNhaQuanLy.Name = "radioButtonNhaQuanLy";
            this.radioButtonNhaQuanLy.Size = new System.Drawing.Size(126, 26);
            this.radioButtonNhaQuanLy.TabIndex = 15;
            this.radioButtonNhaQuanLy.TabStop = true;
            this.radioButtonNhaQuanLy.Text = "Nhà quản lý";
            this.radioButtonNhaQuanLy.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Đăng nhập với tư cách";
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 568);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelgrb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelgrb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_anhienmathau;
        private System.Windows.Forms.Button button_DangNhap;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.TextBox textBox_TenDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonNhaQuanLy;
        private System.Windows.Forms.RadioButton radioButtonNguoithuetro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}