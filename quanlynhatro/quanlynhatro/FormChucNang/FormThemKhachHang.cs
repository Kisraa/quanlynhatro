using quanlynhatro.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlynhatro.FormChucNang
{
    public partial class FormThemKhachHang : Form
    {
        public FormThemKhachHang()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //chọn ảnh
        String pathFileAnhChanDung = "";
        private void buttonChonAnhChanDung_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBoxAnhChanDung.Image = new Bitmap(open.FileName);
                // image file path 
                pathFileAnhChanDung = open.FileName;
            }
        }
        //chọn ảnh
        String pathFileAnhMatTruoc = "";
        private void button1_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBoxAnhMatTruoc.Image = new Bitmap(open.FileName);
                // image file path 
                pathFileAnhMatTruoc = open.FileName;
            }
        }
        //chọn ảnh
        String pathFileAnhMatSau = "";
        private void button2_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBoxAnhMatSau.Image = new Bitmap(open.FileName);
                // image file path 
                pathFileAnhMatSau = open.FileName;
            }
        }
        public String getMaKHMoiNhat()
        {
            try
            {
                String SQL = "select max(makhach) from khachhang";
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                String kq = cmd.ExecuteScalar().ToString();
                con.Close();
                return kq;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.ToString());
                return "";
            }
        }
        public string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlInsert = "INSERT INTO khachhang VALUES(@hotenkhach,@sdtkhach,@socmnd,@anhchandung,@mattruoccmnd,@mattsaucmnd)";
                SqlCommand cmd = new SqlCommand(SqlInsert, con);
                cmd.Parameters.AddWithValue("hotenkhach", textBoxTenKH.Text);
                cmd.Parameters.AddWithValue("sdtkhach", textBoxSDT.Text);
                cmd.Parameters.AddWithValue("socmnd",textBoxCMND.Text);
                cmd.Parameters.AddWithValue("anhchandung", pathFileAnhChanDung);
                cmd.Parameters.AddWithValue("mattruoccmnd",pathFileAnhMatTruoc);
                cmd.Parameters.AddWithValue("mattsaucmnd", pathFileAnhMatSau);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

                SqlConnection con2 = new SqlConnection(chuoikn);
                con2.Open();
                String SqlInsert2 = "INSERT INTO dangnhapKH VALUES(@tendangnhap, @matkhau,@quyen,@active)";
                SqlCommand cmd2 = new SqlCommand(SqlInsert2, con2);
                cmd2.Parameters.AddWithValue("tendangnhap", getMaKHMoiNhat());
                cmd2.Parameters.AddWithValue("matkhau", CreateMD5("12345"));//mật định 12345 =>> người dùng có thể tự đổi lại sau khi đăng nhập
                cmd2.Parameters.AddWithValue("quyen", "Quyền khách hàng");
                cmd2.Parameters.AddWithValue("active", 1);
                cmd2.ExecuteNonQuery();
                //MessageBox.Show("Thêm dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con2.Close();

                UserControlQuanTriHeThong.checkdataChange = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm mặt hàng: " + ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxAnhChanDung_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxAnhMatSau_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxAnhMatTruoc_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
