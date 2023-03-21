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
    public partial class UserControlTaiKhoanNguoiDung : UserControl
    {
        public UserControlTaiKhoanNguoiDung()
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
        public String getValue(String noidungSelect, String table, String KeyNameColumn, String ValueWhere)
        {
            try
            {
                String SQL = "select " + noidungSelect + " from " + table + " where " + KeyNameColumn + "=" + ValueWhere + "";
               // MessageBox.Show(SQL);
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                String kq =cmd.ExecuteScalar() + "";
               // if(kq!=null)
                con.Close();
                return kq;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.ToString());
                return "";
            }
        }
        private void UserControlTaiKhoanNguoiDung_Load(object sender, EventArgs e)
        {
            String manguoidung = Form1.id;
            String maphong=getValue("maphong", "thuephong", "makhach", manguoidung);
            excutequerrryy("select maphieuthu,phong.tenphong,ngaylap,thanhtien,trangthaidongtien from phieuthutientro INNER JOIN phong ON phieuthutientro.maphong=phong.maphong where phieuthutientro.maphong ="+maphong+"", dataGridViewDanhSachThuTien);
            excutequerrryy("select matrogiup,mota,trangthaihotro from guitrogiup where makhach=" + Form1.id, dataGridView1);
        }

        private void dataGridViewDanhSachThuTien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String maphieuthu = "" + dataGridViewDanhSachThuTien.SelectedCells[0].OwningRow.Cells["maphieuthu"].Value;

            //if click is on new row or header row
            if (e.RowIndex == dataGridViewDanhSachThuTien.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            //xử lý sự kiện khi nhấn nút xóa loại hàng
            if (e.ColumnIndex == dataGridViewDanhSachThuTien.Columns["XemChiTietThu"].Index)
            {
                FormXemChiTietPhieuThu f = new FormXemChiTietPhieuThu();
                f.Maphieuthu = maphieuthu;
                f.Show();
            }
        }

        private void buttonThemLoaiPhong_Click(object sender, EventArgs e)
        {
            FormGuiTroGiup f = new FormGuiTroGiup();
            f.ShowDialog();
        }
        public static bool CheckChange = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckChange == true)
            {
                CheckChange = false;
                excutequerrryy("select matrogiup,mota,trangthaihotro from guitrogiup where makhach=" + Form1.id, dataGridView1);
            }
        }
    }
}
