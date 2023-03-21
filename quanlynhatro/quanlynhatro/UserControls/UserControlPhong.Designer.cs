namespace quanlynhatro.UserControls
{
    partial class UserControlPhong
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
            this.labelsokhachtoida = new System.Windows.Forms.Label();
            this.labelsonuoc = new System.Windows.Forms.Label();
            this.labelsodien = new System.Windows.Forms.Label();
            this.labeltrangthai = new System.Windows.Forms.Label();
            this.labelloaiphong = new System.Windows.Forms.Label();
            this.labeltenphong = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelsokhachtoida);
            this.panel1.Controls.Add(this.labelsonuoc);
            this.panel1.Controls.Add(this.labelsodien);
            this.panel1.Controls.Add(this.labeltrangthai);
            this.panel1.Controls.Add(this.labelloaiphong);
            this.panel1.Controls.Add(this.labeltenphong);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 179);
            this.panel1.TabIndex = 0;
            // 
            // labelsokhachtoida
            // 
            this.labelsokhachtoida.AutoSize = true;
            this.labelsokhachtoida.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsokhachtoida.Location = new System.Drawing.Point(173, 142);
            this.labelsokhachtoida.Name = "labelsokhachtoida";
            this.labelsokhachtoida.Size = new System.Drawing.Size(131, 22);
            this.labelsokhachtoida.TabIndex = 7;
            this.labelsokhachtoida.Text = "Số khách tối đa";
            // 
            // labelsonuoc
            // 
            this.labelsonuoc.AutoSize = true;
            this.labelsonuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsonuoc.Location = new System.Drawing.Point(173, 119);
            this.labelsonuoc.Name = "labelsonuoc";
            this.labelsonuoc.Size = new System.Drawing.Size(117, 22);
            this.labelsonuoc.TabIndex = 6;
            this.labelsonuoc.Text = "Số nước: 280";
            // 
            // labelsodien
            // 
            this.labelsodien.AutoSize = true;
            this.labelsodien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsodien.Location = new System.Drawing.Point(173, 96);
            this.labelsodien.Name = "labelsodien";
            this.labelsodien.Size = new System.Drawing.Size(111, 22);
            this.labelsodien.TabIndex = 5;
            this.labelsodien.Text = "Số điện: 280";
            // 
            // labeltrangthai
            // 
            this.labeltrangthai.AutoSize = true;
            this.labeltrangthai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltrangthai.Location = new System.Drawing.Point(173, 73);
            this.labeltrangthai.Name = "labeltrangthai";
            this.labeltrangthai.Size = new System.Drawing.Size(123, 22);
            this.labeltrangthai.TabIndex = 4;
            this.labeltrangthai.Text = "Đã có khách ở";
            // 
            // labelloaiphong
            // 
            this.labelloaiphong.AutoSize = true;
            this.labelloaiphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelloaiphong.Location = new System.Drawing.Point(173, 50);
            this.labelloaiphong.Name = "labelloaiphong";
            this.labelloaiphong.Size = new System.Drawing.Size(211, 22);
            this.labelloaiphong.TabIndex = 3;
            this.labelloaiphong.Text = "Loại phòng: đơn bình dân";
            // 
            // labeltenphong
            // 
            this.labeltenphong.AutoSize = true;
            this.labeltenphong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltenphong.Location = new System.Drawing.Point(171, 13);
            this.labeltenphong.Name = "labeltenphong";
            this.labeltenphong.Size = new System.Drawing.Size(174, 32);
            this.labeltenphong.TabIndex = 2;
            this.labeltenphong.Text = "Phòng A0202";
            this.labeltenphong.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::quanlynhatro.Properties.Resources.icons8_right_32;
            this.button1.Location = new System.Drawing.Point(1013, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 177);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.flowLayoutPanel1.BackgroundImage = global::quanlynhatro.Properties.Resources.icons8_room_50;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(152, 152);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // UserControlPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlPhong";
            this.Size = new System.Drawing.Size(1090, 179);
            this.Load += new System.EventHandler(this.UserControlPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labeltenphong;
        private System.Windows.Forms.Label labelsokhachtoida;
        private System.Windows.Forms.Label labelsonuoc;
        private System.Windows.Forms.Label labelsodien;
        private System.Windows.Forms.Label labeltrangthai;
        private System.Windows.Forms.Label labelloaiphong;
    }
}
