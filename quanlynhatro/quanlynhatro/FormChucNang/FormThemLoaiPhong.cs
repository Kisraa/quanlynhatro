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
    public partial class FormThemLoaiPhong : Form
    {
        public FormThemLoaiPhong()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        private void buttonhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlInsert = "INSERT INTO loaiphong VALUES(@tenloaiphong,@giatien)";
                SqlCommand cmd = new SqlCommand(SqlInsert, con);
                cmd.Parameters.AddWithValue("tenloaiphong", textBoxTenLoaiPhong.Text);
                cmd.Parameters.AddWithValue("giatien", numericUpDownGia.Value);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Thêm dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                UserControlQuanTriHeThong.checkdataChange = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm loại phòng: " + ex.Message);
            }
        }

        private void textBoxLoaiHang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
