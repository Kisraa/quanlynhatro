namespace quanlynhatro.FormChucNang
{
    partial class FormThemLoaiPhong
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
            this.buttonhuy = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.textBoxTenLoaiPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownGia = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGia)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonhuy
            // 
            this.buttonhuy.BackColor = System.Drawing.Color.Red;
            this.buttonhuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhuy.ForeColor = System.Drawing.Color.White;
            this.buttonhuy.Location = new System.Drawing.Point(375, 199);
            this.buttonhuy.Name = "buttonhuy";
            this.buttonhuy.Size = new System.Drawing.Size(80, 31);
            this.buttonhuy.TabIndex = 8;
            this.buttonhuy.Text = "Hủy";
            this.buttonhuy.UseVisualStyleBackColor = false;
            this.buttonhuy.Click += new System.EventHandler(this.buttonhuy_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLuu.ForeColor = System.Drawing.Color.White;
            this.buttonLuu.Location = new System.Drawing.Point(286, 199);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(83, 31);
            this.buttonLuu.TabIndex = 7;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // textBoxTenLoaiPhong
            // 
            this.textBoxTenLoaiPhong.Location = new System.Drawing.Point(16, 72);
            this.textBoxTenLoaiPhong.Name = "textBoxTenLoaiPhong";
            this.textBoxTenLoaiPhong.Size = new System.Drawing.Size(443, 30);
            this.textBoxTenLoaiPhong.TabIndex = 6;
            this.textBoxTenLoaiPhong.TextChanged += new System.EventHandler(this.textBoxLoaiHang_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập tên loại phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhập giá loại phòng";
            // 
            // numericUpDownGia
            // 
            this.numericUpDownGia.Location = new System.Drawing.Point(16, 152);
            this.numericUpDownGia.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDownGia.Name = "numericUpDownGia";
            this.numericUpDownGia.Size = new System.Drawing.Size(439, 30);
            this.numericUpDownGia.TabIndex = 10;
            // 
            // FormThemLoaiHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 250);
            this.Controls.Add(this.numericUpDownGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonhuy);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.textBoxTenLoaiPhong);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormThemLoaiHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm loại phòng";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonhuy;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.TextBox textBoxTenLoaiPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownGia;
    }
}