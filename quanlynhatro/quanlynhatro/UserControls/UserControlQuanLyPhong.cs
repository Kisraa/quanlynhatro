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
using quanlynhatro.FormChucNang;

namespace quanlynhatro.UserControls
{
    public partial class UserControlQuanLyPhong : UserControl
    {
        public UserControlQuanLyPhong()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        public void loadAllProDuct()
        {
            SqlConnection con = new SqlConnection(chuoikn);
            con.Open();
            string sqlselect = "SELECT *FROM phong";
            SqlCommand CMD = new SqlCommand(sqlselect, con);
            SqlDataReader read = CMD.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);
            con.Close();
            read.Close();
            foreach (DataRow item in dt.Rows)
            {
                //CardProduct product = new CardProduct();
                //product.Tensp = item["tenmathang"].ToString();
                //product.Hinhanh = item["hinhanh"].ToString();
                //product.Soluong = item["soluong"].ToString();
                //product.Gia = item["giaban"].ToString();
                //product.MaSP1 = item["mamathang"].ToString();
                //product.Maloaihang = item["maloaihang"].ToString();
                //product.Mahangsx = item["mahangsx"].ToString();
                //product.Mota = item["mota"].ToString();
                UserControlPhong phong = new UserControlPhong();
                phong.Maphong = item["maphong"].ToString();
                phong.Tenphong = item["tenphong"].ToString();
                phong.Maloaiphong = item["maloaiphong"].ToString();
                phong.Trangthaithuephong = item["trangthaithuephong"].ToString();
                phong.Sodienthangcu = item["sodienthangcu"].ToString();
                phong.Sonuocthangcu = item["sonuocthangcu"].ToString();
                phong.Sokhachtoida = item["sokhachtoida"].ToString();
                phong.Dock = DockStyle.Top;
                flowLayoutPanelChuaPhong.Controls.Add(phong);
            }
        }
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
                MessageBox.Show("Lỗi: " + ex2.Message);
            }
        }
        private void UserControlQuanLyPhong_Load(object sender, EventArgs e)
        {
            loadAllProDuct();
            excutequerrryy("select maphieuthu,phong.tenphong,ngaylap,thanhtien,trangthaidongtien from phieuthutientro INNER JOIN phong ON phieuthutientro.maphong=phong.maphong", dataGridViewDanhSachThuTien);
        }

        private void buttonLapHoaDonNhapHang_Click(object sender, EventArgs e)
        {
            FormLapPhieuThuTien f = new FormLapPhieuThuTien();
            f.ShowDialog();
        }

        private void comboBoxloc_SelectedIndexChanged(object sender, EventArgs e)
        {
            String trangthai = comboBoxloc.Text;
            if (trangthai.Equals("Tất cả")){
                excutequerrryy("select maphieuthu,phong.tenphong,ngaylap,thanhtien,trangthaidongtien from phieuthutientro INNER JOIN phong ON phieuthutientro.maphong=phong.maphong", dataGridViewDanhSachThuTien);
            }
            else
                excutequerrryy("select maphieuthu,phong.tenphong,ngaylap,thanhtien,trangthaidongtien from phieuthutientro INNER JOIN phong ON phieuthutientro.maphong=phong.maphong where trangthaidongtien=N'"+trangthai+"'", dataGridViewDanhSachThuTien);
        }

        private void dataGridViewDanhSachThuTien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String maphieuthu = "" + dataGridViewDanhSachThuTien.SelectedCells[0].OwningRow.Cells["maphieuthu"].Value;
            
            //if click is on new row or header row
            if (e.RowIndex == dataGridViewDanhSachThuTien.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            //xử lý sự kiện khi nhấn nút xóa loại hàng
            if (e.ColumnIndex == dataGridViewDanhSachThuTien.Columns["XoaPhieuThu"].Index)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu thu " + maphieuthu + " ra khỏi phòng hay không ???", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(chuoikn);
                        con.Open();
                        String SqlDelete = "DELETE FROM phieuthutientro WHERE maphieuthu=@maphieuthu";
                        SqlCommand cmd = new SqlCommand(SqlDelete, con);
                        cmd.Parameters.AddWithValue("maphieuthu", maphieuthu);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        excutequerrryy("select maphieuthu,phong.tenphong,ngaylap,thanhtien,trangthaidongtien from phieuthutientro INNER JOIN phong ON phieuthutientro.maphong=phong.maphong", dataGridViewDanhSachThuTien);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            else if (e.ColumnIndex == dataGridViewDanhSachThuTien.Columns["dongtien"].Index)
            {
                try
                {
                    SqlConnection con = new SqlConnection(chuoikn);
                    con.Open();
                    String SqlDelete = "update phieuthutientro set trangthaidongtien=@trangthaidongtien WHERE maphieuthu=@maphieuthu";
                    SqlCommand cmd = new SqlCommand(SqlDelete, con);
                    cmd.Parameters.AddWithValue("maphieuthu", maphieuthu);
                    cmd.Parameters.AddWithValue("trangthaidongtien", "Đã đóng tiền");
                    cmd.ExecuteNonQuery();
                    con.Close();
                    excutequerrryy("select maphieuthu,phong.tenphong,ngaylap,thanhtien,trangthaidongtien from phieuthutientro INNER JOIN phong ON phieuthutientro.maphong=phong.maphong", dataGridViewDanhSachThuTien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                }
            }
            else if (e.ColumnIndex == dataGridViewDanhSachThuTien.Columns["XemChiTietThu"].Index)
            {
                FormXemChiTietPhieuThu f = new FormXemChiTietPhieuThu();
                f.Maphieuthu = maphieuthu;
                f.Show();
            }



        }
    }
}
