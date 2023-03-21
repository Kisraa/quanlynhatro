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
    public partial class UserControlReport : UserControl
    {
        public UserControlReport()
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
                MessageBox.Show("Lỗi: " + ex2.Message);
            }
        }
        private void buttxem_Click(object sender, EventArgs e)
        {
            String ngaybd=dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            String ngaykt = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            String trangthai = comboBoxloc.Text;
            if (trangthai.Equals("Tất cả"))
            {
                excutequerrryy("select maphieuthu,phong.tenphong,ngaylap,thanhtien,trangthaidongtien from phieuthutientro INNER JOIN phong ON phieuthutientro.maphong=phong.maphong where ngaylap>='"+ngaybd+"' and ngaylap<='"+ngaykt+"'", dataGridViewDanhSachThuTien);
            }
            else
                excutequerrryy("select maphieuthu,phong.tenphong,ngaylap,thanhtien,trangthaidongtien from phieuthutientro INNER JOIN phong ON phieuthutientro.maphong=phong.maphong where trangthaidongtien=N'" + trangthai + "' and ngaylap>='" + ngaybd + "' and ngaylap<='" + ngaykt + "'", dataGridViewDanhSachThuTien);
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

        private void buttonxuatbc_Click(object sender, EventArgs e)
        {
            CrystalReportBaoCao xuatbc = new CrystalReportBaoCao();
            xuatbc.SetDataSource(dataGridViewDanhSachThuTien.DataSource);
            //hiển thị báo cáo lên form in báo cáo
            FormXuatBaoCao inbc = new FormXuatBaoCao();
            inbc.crystalReportViewer1.ReportSource = xuatbc;
            inbc.ShowDialog();
        }
    }
}
