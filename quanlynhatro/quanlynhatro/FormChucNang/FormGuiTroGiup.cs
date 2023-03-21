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
    public partial class FormGuiTroGiup : Form
    {
        public FormGuiTroGiup()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        public String getValue(String noidungSelect, String table, String KeyNameColumn, String ValueWhere)
        {
            try
            {
                String SQL = "select " + noidungSelect + " from " + table + " where " + KeyNameColumn + "=" + ValueWhere + "";
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

        private void buttonThemLoaiPhong_Click(object sender, EventArgs e)
        {
            try
            {
                String maphong = getValue("maphong", "thuephong", "makhach", Form1.id);
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlInsert = "INSERT INTO guitrogiup VALUES(@makhach,@maphong,@mota,@trangthaihotro)";
                SqlCommand cmd = new SqlCommand(SqlInsert, con);
                cmd.Parameters.AddWithValue("makhach", Form1.id);
                cmd.Parameters.AddWithValue("maphong",maphong);
                cmd.Parameters.AddWithValue("mota", richTextBoxNoiDung.Text);
                cmd.Parameters.AddWithValue("trangthaihotro", "Chưa hổ trợ");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                UserControlTaiKhoanNguoiDung.CheckChange = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm mặt hàng: " + ex.ToString());
            }
        }
    }
}
