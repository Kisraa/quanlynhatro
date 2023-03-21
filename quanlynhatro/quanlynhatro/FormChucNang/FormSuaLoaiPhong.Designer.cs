namespace quanlynhatro.FormChucNang
{
    partial class FormSuaLoaiPhong
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
            this.numericUpDownGia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonhuy = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.textBoxTenLoaiPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGia)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownGia
            // 
            this.numericUpDownGia.Location = new System.Drawing.Point(16, 124);
            this.numericUpDownGia.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDownGia.Name = "numericUpDownGia";
            this.numericUpDownGia.Size = new System.Drawing.Size(439, 30);
            this.numericUpDownGia.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nhập giá loại phòng";
            // 
            // buttonhuy
            // 
            this.buttonhuy.BackColor = System.Drawing.Color.Red;
            this.buttonhuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhuy.ForeColor = System.Drawing.Color.White;
            this.buttonhuy.Location = new System.Drawing.Point(375, 171);
            this.buttonhuy.Name = "buttonhuy";
            this.buttonhuy.Size = new System.Drawing.Size(80, 31);
            this.buttonhuy.TabIndex = 14;
            this.buttonhuy.Text = "Hủy";
            this.buttonhuy.UseVisualStyleBackColor = false;
            this.buttonhuy.Click += new System.EventHandler(this.buttonhuy_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLuu.ForeColor = System.Drawing.Color.White;
            this.buttonLuu.Location = new System.Drawing.Point(212, 171);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(157, 31);
            this.buttonLuu.TabIndex = 13;
            this.buttonLuu.Text = "Cập nhật";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // textBoxTenLoaiPhong
            // 
            this.textBoxTenLoaiPhong.Location = new System.Drawing.Point(16, 44);
            this.textBoxTenLoaiPhong.Name = "textBoxTenLoaiPhong";
            this.textBoxTenLoaiPhong.Size = new System.Drawing.Size(443, 30);
            this.textBoxTenLoaiPhong.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nhập tên loại phòng:";
            // 
            // FormSuaLoaiPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 240);
            this.Controls.Add(this.numericUpDownGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonhuy);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.textBoxTenLoaiPhong);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormSuaLoaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa loại phòng";
            this.Load += new System.EventHandler(this.FormSuaLoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonhuy;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.TextBox textBoxTenLoaiPhong;
        private System.Windows.Forms.Label label1;
    }
}