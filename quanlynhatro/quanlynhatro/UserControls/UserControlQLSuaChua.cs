using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlynhatro.UserControls
{
    public partial class UserControlQLSuaChua : UserControl
    {
        public UserControlQLSuaChua()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        public void excutequerrryy(String query, DataGridView data)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                SqlCommand CMD = new SqlCommand(query, con);
                SqlDataReader read = CMD.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(read);
                data.DataSource = dt;
                con.Close();
                read.Close();
            }
            catch (Exception ex2)
            {
                //MessageBox.Show("Lỗi excute: " + ex2.Message);
            }
        }
        public void load()
        {
            excutequerrryy("select guitrogiup.matrogiup, khachhang.hotenkhach, phong.tenphong, guitrogiup.mota, guitrogiup.trangthaihotro from guitrogiup inner join khachhang on guitrogiup.makhach= khachhang.makhach inner join phong on guitrogiup.maphong= phong.maphong", dataGridViewDanhSachThuTien);
        }

        private void UserControlQLSuaChua_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridViewDanhSachThuTien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String matrogiup= "" + dataGridViewDanhSachThuTien.SelectedCells[0].OwningRow.Cells["matrogiup"].Value;

            //if click is on new row or header row
            if (e.RowIndex == dataGridViewDanhSachThuTien.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            //xử lý sự kiện khi nhấn nút xóa loại hàng
            if (e.ColumnIndex == dataGridViewDanhSachThuTien.Columns["hotro"].Index)
            {
                try
                {
                    SqlConnection con = new SqlConnection(chuoikn);
                    con.Open();
                    String SqlDelete = "update guitrogiup set trangthaihotro=@trangthaihotro WHERE matrogiup=@matrogiup";
                    SqlCommand cmd = new SqlCommand(SqlDelete, con);
                    cmd.Parameters.AddWithValue("trangthaihotro", "Đã hổ trợ");
                    cmd.Parameters.AddWithValue("matrogiup", matrogiup);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void comboBoxloc_SelectedIndexChanged(object sender, EventArgs e)
        {
            String trangthai = comboBoxloc.Text;
            if (!trangthai.Equals("Tất cả"))
                excutequerrryy("select guitrogiup.matrogiup, khachhang.hotenkhach, phong.tenphong, guitrogiup.mota, guitrogiup.trangthaihotro from guitrogiup inner join khachhang on guitrogiup.makhach= khachhang.makhach inner join phong on guitrogiup.maphong= phong.maphong where guitrogiup.trangthaihotro=N'" + trangthai + "'", dataGridViewDanhSachThuTien);
            else
                load();
        }
    }
}
