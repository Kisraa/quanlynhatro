namespace quanlynhatro.FormChucNang
{
    partial class FormGuiTroGiup
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
            this.richTextBoxNoiDung = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonThemLoaiPhong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxNoiDung
            // 
            this.richTextBoxNoiDung.Location = new System.Drawing.Point(29, 66);
            this.richTextBoxNoiDung.Name = "richTextBoxNoiDung";
            this.richTextBoxNoiDung.Size = new System.Drawing.Size(699, 273);
            this.richTextBoxNoiDung.TabIndex = 0;
            this.richTextBoxNoiDung.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mô tả nội dung cần hổ trợ";
            // 
            // buttonThemLoaiPhong
            // 
            this.buttonThemLoaiPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThemLoaiPhong.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonThemLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThemLoaiPhong.ForeColor = System.Drawing.Color.White;
            this.buttonThemLoaiPhong.Location = new System.Drawing.Point(612, 353);
            this.buttonThemLoaiPhong.Name = "buttonThemLoaiPhong";
            this.buttonThemLoaiPhong.Size = new System.Drawing.Size(116, 38);
            this.buttonThemLoaiPhong.TabIndex = 8;
            this.buttonThemLoaiPhong.Text = "Gửi";
            this.buttonThemLoaiPhong.UseVisualStyleBackColor = false;
            this.buttonThemLoaiPhong.Click += new System.EventHandler(this.buttonThemLoaiPhong_Click);
            // 
            // FormGuiTroGiup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(753, 403);
            this.Controls.Add(this.buttonThemLoaiPhong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxNoiDung);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormGuiTroGiup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gửi trợ giúp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxNoiDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonThemLoaiPhong;
    }
}