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
    public partial class FormThemPhong : Form
    {
        public FormThemPhong()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        //load combobox 
        public void loadcombobox(string TenBangSQL, String ValueMenber, String DisplayMenber, ComboBox data)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                string sqlselect = "SELECT *FROM " + TenBangSQL;
                SqlCommand CMD = new SqlCommand(sqlselect, con);
                SqlDataReader read = CMD.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(read);
                data.DataSource = dt;
                data.ValueMember = ValueMenber;
                data.DisplayMember = DisplayMenber;
                con.Close();
                read.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Lỗi: " + ex2.Message);
            }
        }
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlInsert = "INSERT INTO phong VALUES(@tenphong, @maloaiphong,@trangthaithuephong,@sodienthangcu,@sonuocthangcu,@sokhachtoida,@ngaybatdauthue)";
                SqlCommand cmd = new SqlCommand(SqlInsert, con);
                cmd.Parameters.AddWithValue("tenphong", textBoxTenPhong.Text);
                cmd.Parameters.AddWithValue("maloaiphong", comboBoxLoaiPhong.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("trangthaithuephong", "Chưa có khách thuê");
                cmd.Parameters.AddWithValue("sodienthangcu", numericUpDownSoDien.Value.ToString());
                cmd.Parameters.AddWithValue("sonuocthangcu", numericUpDownSoNuoc.Value.ToString());
                cmd.Parameters.AddWithValue("sokhachtoida", numericUpDownSOKhachToiDa.Value.ToString());
                cmd.Parameters.AddWithValue("ngaybatdauthue", "");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                UserControlQuanTriHeThong.checkdataChange = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm mặt hàng: " + ex.ToString());
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThemPhong_Load(object sender, EventArgs e)
        {
            loadcombobox("loaiphong","maloaiphong", "tenloaiphong", comboBoxLoaiPhong);
        }
    }
}
