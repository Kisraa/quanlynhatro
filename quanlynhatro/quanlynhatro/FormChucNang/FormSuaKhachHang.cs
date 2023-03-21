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
    public partial class FormSuaKhachHang : Form
    {
        public FormSuaKhachHang()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        String makhach, hotenkhach, sdtkhach, socmnd, anhchandung, mattruoccmnd, mattsaucmnd;
        private void FormSuaKhachHang_Load(object sender, EventArgs e)
        {
            textBoxTenKH.Text = Hotenkhach;
            textBoxSDT.Text = Sdtkhach;
            textBoxCMND.Text = Socmnd;
            pathFileAnhChanDung = Anhchandung;
            pictureBoxAnhChanDung.Image = new Bitmap(pathFileAnhChanDung);
            pathFileAnhMatTruoc = Mattruoccmnd;
            pictureBoxAnhMatTruoc.Image = new Bitmap(pathFileAnhMatTruoc);
            pathFileAnhMatSau = Mattsaucmnd;
            pictureBoxAnhMatSau.Image = new Bitmap(pathFileAnhMatSau);
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlDelete = "update khachhang set hotenkhach=@hotenkhach, sdtkhach=@sdtkhach,socmnd=@socmnd,anhchandung=@anhchandung,mattruoccmnd=@mattruoccmnd,mattsaucmnd=@mattsaucmnd WHERE makhach=@makhach";
                SqlCommand cmd = new SqlCommand(SqlDelete, con);
                cmd.Parameters.AddWithValue("hotenkhach", textBoxTenKH.Text);
                cmd.Parameters.AddWithValue("sdtkhach", textBoxSDT.Text);
                cmd.Parameters.AddWithValue("socmnd", textBoxCMND.Text);
                cmd.Parameters.AddWithValue("anhchandung", pathFileAnhChanDung);
                cmd.Parameters.AddWithValue("mattruoccmnd", pathFileAnhMatTruoc);
                cmd.Parameters.AddWithValue("mattsaucmnd", pathFileAnhMatSau);
                cmd.Parameters.AddWithValue("makhach", Makhach);
                cmd.ExecuteNonQuery();
                con.Close();
                UserControls.UserControlQuanTriHeThong.checkdataChange = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
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

        public string Makhach { get => makhach; set => makhach = value; }
        public string Hotenkhach { get => hotenkhach; set => hotenkhach = value; }
        public string Sdtkhach { get => sdtkhach; set => sdtkhach = value; }
        public string Socmnd { get => socmnd; set => socmnd = value; }
        public string Anhchandung { get => anhchandung; set => anhchandung = value; }
        public string Mattruoccmnd { get => mattruoccmnd; set => mattruoccmnd = value; }
        public string Mattsaucmnd { get => mattsaucmnd; set => mattsaucmnd = value; }

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
    }
}
