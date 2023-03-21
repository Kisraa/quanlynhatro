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
    public partial class UserControlQuanTriHeThong : UserControl
    {
        public UserControlQuanTriHeThong()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        public static bool checkdataChange = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkdataChange == true)
            {
                checkdataChange = false;
                load();
            }
        }
        //Hàm hiển thị dữ liệu lên datagidview
        public void HienThiDuLieu(string TenBangSQL, DataGridView data)
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
                con.Close();
                read.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Lỗi: " + ex2.Message);
            }
        }
        public void load()
        {
            HienThiDuLieu("loaiphong", dataGridView_LoaiPhong);
            HienThiDuLieu("khachhang", dataGridViewkhachhang);
            HienThiDuLieu("dangnhapKH", dataGridViewNguoiDungHTT);
            HienThiDuLieu("nhanvien", dataGridViewNV);
            HienThiDuLieu("dangnhapNV", dataGridViewdangnhapnv);
            excutequerrryy("SELECT dbo.phong.maphong, dbo.phong.tenphong, dbo.loaiphong.tenloaiphong, dbo.loaiphong.giatien, dbo.phong.trangthaithuephong, dbo.phong.sodienthangcu, dbo.phong.sonuocthangcu, dbo.phong.sokhachtoida FROM dbo.phong INNER JOIN dbo.loaiphong ON dbo.phong.maloaiphong = dbo.loaiphong.maloaiphong", dataGridViewPhong);
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
        private void UserControlQuanTriHeThong_Load(object sender, EventArgs e)
        {
            load();
        }

        private void buttonThemLoaiPhong_Click(object sender, EventArgs e)
        {
            FormThemLoaiPhong f = new FormThemLoaiPhong();
            f.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormThemPhong f = new FormThemPhong();
            f.ShowDialog();
        }

        private void buttonthemkh_Click(object sender, EventArgs e)
        {
            FormThemKhachHang f = new FormThemKhachHang();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxnguoidunggg_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonThemNhanVien_Click(object sender, EventArgs e)
        {
            FormThemNV f = new FormThemNV();
            f.ShowDialog();
        }

        private void dataGridView_LoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String maloaiphong = "" + dataGridView_LoaiPhong.SelectedCells[0].OwningRow.Cells["maloaiphong"].Value;
            String tenloaiphong = "" + dataGridView_LoaiPhong.SelectedCells[0].OwningRow.Cells["tenloaiphong"].Value;
            String giatien = "" + dataGridView_LoaiPhong.SelectedCells[0].OwningRow.Cells["giatien"].Value;

            //if click is on new row or header row
            if (e.RowIndex == dataGridView_LoaiPhong.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            //xử lý sự kiện khi nhấn nút xóa loại hàng
            if (e.ColumnIndex == dataGridView_LoaiPhong.Columns["XoaLoaiPhong"].Index)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa: " + tenloaiphong + " hay không ???", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(chuoikn);
                        con.Open();
                        String SqlDelete = "DELETE FROM loaiphong WHERE maloaiphong=@maloaiphong";
                        SqlCommand cmd = new SqlCommand(SqlDelete, con);
                        cmd.Parameters.AddWithValue("maloaiphong", maloaiphong);
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
            else if (e.ColumnIndex == dataGridView_LoaiPhong.Columns["SuaLoaiPhong"].Index)
            {
                FormSuaLoaiPhong f = new FormSuaLoaiPhong();
                f.Maloaiphong = maloaiphong;
                f.Tenloaiphong = tenloaiphong;
                f.Giatien = giatien;
                f.Show();
            }
        }

        private void dataGridViewPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String maphong = "" + dataGridViewPhong.SelectedCells[0].OwningRow.Cells["maphong"].Value;
            String tenphong = "" + dataGridViewPhong.SelectedCells[0].OwningRow.Cells["tenphong"].Value;
            String tenloaiphong_fromphong = "" + dataGridViewPhong.SelectedCells[0].OwningRow.Cells["tenloaiphong_fromphong"].Value;
            String sodienthangcu = "" + dataGridViewPhong.SelectedCells[0].OwningRow.Cells["sodienthangcu"].Value;
            String sonuocthangcu = "" + dataGridViewPhong.SelectedCells[0].OwningRow.Cells["sonuocthangcu"].Value;
            String sokhachtoida = "" + dataGridViewPhong.SelectedCells[0].OwningRow.Cells["sokhachtoida"].Value;

            //if click is on new row or header row
            if (e.RowIndex == dataGridViewPhong.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            //xử lý sự kiện khi nhấn nút xóa loại hàng
            if (e.ColumnIndex == dataGridViewPhong.Columns["XoaPhong"].Index)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa: " + tenphong + " hay không ???", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(chuoikn);
                        con.Open();
                        String SqlDelete = "DELETE FROM phong WHERE maphong=@maphong";
                        SqlCommand cmd = new SqlCommand(SqlDelete, con);
                        cmd.Parameters.AddWithValue("maphong", maphong);
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
            else if (e.ColumnIndex == dataGridViewPhong.Columns["SuaPhong"].Index)
            {
                FormSuaPhong f = new FormSuaPhong();
                f.Maphong = maphong;
                f.Tenphong = tenphong;
                f.Tenloaiphong_fromphong = tenloaiphong_fromphong;
                f.Sodienthangcu = sodienthangcu;
                f.Sonuocthangcu = sonuocthangcu;
                f.Sokhachtoida = sokhachtoida;
                f.Show();
            }
        }

        private void dataGridViewkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String makhach = "" + dataGridViewkhachhang.SelectedCells[0].OwningRow.Cells["makhach"].Value;
            String hotenkhach = "" + dataGridViewkhachhang.SelectedCells[0].OwningRow.Cells["hotenkhach"].Value;
            String sdtkhach = "" + dataGridViewkhachhang.SelectedCells[0].OwningRow.Cells["sdtkhach"].Value;
            String socmnd = "" + dataGridViewkhachhang.SelectedCells[0].OwningRow.Cells["socmnd"].Value;
            String anhchandung = "" + dataGridViewkhachhang.SelectedCells[0].OwningRow.Cells["anhchandung"].Value;
            String mattruoccmnd = "" + dataGridViewkhachhang.SelectedCells[0].OwningRow.Cells["mattruoccmnd"].Value;
            String mattsaucmnd = "" + dataGridViewkhachhang.SelectedCells[0].OwningRow.Cells["mattsaucmnd"].Value;

            //if click is on new row or header row
            if (e.RowIndex == dataGridViewkhachhang.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            //xử lý sự kiện khi nhấn nút xóa loại hàng
            if (e.ColumnIndex == dataGridViewkhachhang.Columns["XoaKhach"].Index)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa: " + hotenkhach + " hay không ???", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(chuoikn);
                        con.Open();
                        String SqlDelete = "DELETE FROM phong WHERE khachhang=@khachhang";
                        SqlCommand cmd = new SqlCommand(SqlDelete, con);
                        cmd.Parameters.AddWithValue("maphong", maphong);
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
            else if (e.ColumnIndex == dataGridViewkhachhang.Columns["SuaKhach"].Index)
            {
                FormSuaKhachHang f = new FormSuaKhachHang();
                f.Makhach = makhach;
                f.Hotenkhach = hotenkhach;
                f.Sdtkhach = sdtkhach;
                f.Socmnd = socmnd;
                f.Anhchandung = anhchandung;
                f.Mattruoccmnd = mattruoccmnd;
                f.Mattsaucmnd = mattsaucmnd;
                f.Show();
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
        private void dataGridViewNguoiDungHTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String tendangnhap = "" + dataGridViewNguoiDungHTT.SelectedCells[0].OwningRow.Cells["tendangnhap"].Value;
           
            //if click is on new row or header row
            if (e.RowIndex == dataGridViewkhachhang.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            //xử lý sự kiện khi nhấn nút xóa loại hàng
            if (e.ColumnIndex == dataGridViewNguoiDungHTT.Columns["chankhach"].Index)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn chặn người này hay không ???", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(chuoikn);
                        con.Open();
                        String SqlDelete = "update dangnhapKH set active=0 WHERE tendangnhap=@tendangnhap";
                        SqlCommand cmd = new SqlCommand(SqlDelete, con);
                        cmd.Parameters.AddWithValue("tendangnhap", tendangnhap);
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
            else if (e.ColumnIndex == dataGridViewNguoiDungHTT.Columns["bochankhach"].Index)
            {
                if (MessageBox.Show("Bỏ chặn người này ???", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(chuoikn);
                        con.Open();
                        String SqlDelete = "update dangnhapKH set active=1 WHERE tendangnhap=@tendangnhap";
                        SqlCommand cmd = new SqlCommand(SqlDelete, con);
                        cmd.Parameters.AddWithValue("tendangnhap", tendangnhap);
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
            else if (e.ColumnIndex == dataGridViewNguoiDungHTT.Columns["resetmk"].Index)
            {
                if (MessageBox.Show("Khôi phục mật khẩu người này (Mật định:12345) ???", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(chuoikn);
                        con.Open();
                        String SqlDelete = "update dangnhapKH set matkhau=@matkhau WHERE tendangnhap=@tendangnhap";
                        SqlCommand cmd = new SqlCommand(SqlDelete, con);
                        cmd.Parameters.AddWithValue("matkhau", CreateMD5("12345"));
                        cmd.Parameters.AddWithValue("tendangnhap", tendangnhap);
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
        }

        private void dataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String manv = "" + dataGridViewNV.SelectedCells[0].OwningRow.Cells["manv"].Value;
            String hotennv = "" + dataGridViewNV.SelectedCells[0].OwningRow.Cells["hotennv"].Value;
            String cccd = "" + dataGridViewNV.SelectedCells[0].OwningRow.Cells["cccd"].Value;
            String ngaysinh = "" + dataGridViewNV.SelectedCells[0].OwningRow.Cells["ngaysinh"].Value;
            String gioitinh = "" + dataGridViewNV.SelectedCells[0].OwningRow.Cells["gioitinh"].Value;
            String email = "" + dataGridViewNV.SelectedCells[0].OwningRow.Cells["email"].Value;
            String sdt = "" + dataGridViewNV.SelectedCells[0].OwningRow.Cells["sdt"].Value;
            String diachi = "" + dataGridViewNV.SelectedCells[0].OwningRow.Cells["diachi"].Value;
            //if click is on new row or header row
            if (e.RowIndex == dataGridViewNV.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            //xử lý sự kiện khi nhấn nút xóa
            if (e.ColumnIndex == dataGridViewNV.Columns["XoaNV"].Index)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + hotennv + " hay không ???", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(chuoikn);
                        con.Open();
                        String SqlDelete = "DELETE FROM nhanvien WHERE manv=@manv";
                        SqlCommand cmd = new SqlCommand(SqlDelete, con);
                        cmd.Parameters.AddWithValue("manv", manv);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        load();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            //xử lý sự kiện khi nhấn nút sửa
            if (e.ColumnIndex == dataGridViewNV.Columns["SuaNV"].Index)
            {
                FormSuaNhanVien.manv = manv;
                FormSuaNhanVien.hotennv = hotennv;
                FormSuaNhanVien.cccd = cccd;
                FormSuaNhanVien.ngaysinh = ngaysinh;
                FormSuaNhanVien.gioitinh = gioitinh;
                FormSuaNhanVien.sdt = sdt;
                FormSuaNhanVien.email = email;
                FormSuaNhanVien.diachi = diachi;
                FormSuaNhanVien f = new FormSuaNhanVien();
                f.ShowDialog();
            }
        }

        private void dataGridViewdangnhapnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String tendangnhap = "" + dataGridViewdangnhapnv.SelectedCells[0].OwningRow.Cells["tendangnhapnv"].Value;
            String matkhau = "" + dataGridViewdangnhapnv.SelectedCells[0].OwningRow.Cells["matkhaunv"].Value;
            String quyen = "" + dataGridViewdangnhapnv.SelectedCells[0].OwningRow.Cells["quyennv"].Value;
            String active = "" + dataGridViewdangnhapnv.SelectedCells[0].OwningRow.Cells["activenv"].Value;
            //if click is on new row or header row
            if (e.RowIndex == dataGridViewdangnhapnv.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            //xử lý sự kiện khi nhấn nút sửa
            if (e.ColumnIndex == dataGridViewdangnhapnv.Columns["suadknv"].Index)
            {
                FormSuaPhanQuyen.tendangnhap = tendangnhap;
                FormSuaPhanQuyen.matkhau = matkhau;
                FormSuaPhanQuyen.quyen = quyen;
                FormSuaPhanQuyen.active = active;
                FormSuaPhanQuyen f = new FormSuaPhanQuyen();
                f.ShowDialog();
            }
        }
    }
}
