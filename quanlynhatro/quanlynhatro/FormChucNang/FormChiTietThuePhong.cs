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
    public partial class FormChiTietThuePhong : Form
    {
        public FormChiTietThuePhong()
        {
            InitializeComponent();
        }
        private String maphong;
        private String tenphong;
        private String maloaiphong;
        private String trangthaithuephong;
        private String sodienthangcu;
        private String sonuocthangcu;
        private String sokhachtoida;
        private String ngaybatdauthue;

        public string Maphong { get => maphong; set => maphong = value; }
        public string Tenphong { get => tenphong; set => tenphong = value; }
        public string Maloaiphong { get => maloaiphong; set => maloaiphong = value; }
        public string Trangthaithuephong { get => trangthaithuephong; set => trangthaithuephong = value; }
        public string Sodienthangcu { get => sodienthangcu; set => sodienthangcu = value; }
        public string Sonuocthangcu { get => sonuocthangcu; set => sonuocthangcu = value; }
        public string Sokhachtoida { get => sokhachtoida; set => sokhachtoida = value; }
        public string Ngaybatdauthue { get => ngaybatdauthue; set => ngaybatdauthue = value; }
        public void load()
        {
            loadcombobox("khachhang", "makhach", "hotenkhach", comboBoxkhach);
            labeltenphong.Text = "Tên phòng: " + Tenphong;
            labelloaiphong.Text = "Loại phòng: " + Maloaiphong;
            labeltrangthai.Text = "Trạng thái: " + Trangthaithuephong;
            labelsodien.Text = "Số điện: " + Sodienthangcu;
            labelsonuoc.Text = "Số nước: " + Sonuocthangcu;
            labelsokhachtoida.Text = "Số khách tối đa: " + Sokhachtoida;
            if (Trangthaithuephong.Equals("Chưa có khách thuê"))
            {
                flowLayoutPanel1.BackColor = Color.LightSlateGray;
                labeltrangthai.ForeColor = Color.Red;
                buttonTraPhong.Visible = false;
            }
            else
            {
                flowLayoutPanel1.BackColor = Color.FromArgb(54, 96, 108);
                labeltrangthai.ForeColor = Color.Blue;
                buttonTraPhong.Visible = true;
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
        private void FormChiTietThuePhong_Load(object sender, EventArgs e)
        {
            load();
            excutequerrryy("SELECT dbo.khachhang.makhach, dbo.khachhang.hotenkhach,dbo.thuephong.ngaybatdauthue, dbo.khachhang.sdtkhach, dbo.khachhang.socmnd from thuephong INNER JOIN dbo.khachhang ON dbo.thuephong.makhach = dbo.khachhang.makhach where maphong='" + Maphong + "'", dataGridViewkhachhang);
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
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public String daohaychua(String makhach)
        {
            try
            {
                String SQL = "select count(*) from thuephong where makhach=" + makhach + "";
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
        public void updatetrangthai(String trangthai)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlUpdate = "UPDATE phong SET trangthaithuephong=@trangthaithuephong WHERE maphong=@maphong";
                SqlCommand cmd = new SqlCommand(SqlUpdate, con);
                cmd.Parameters.AddWithValue("trangthaithuephong",trangthai);
                cmd.Parameters.AddWithValue("maphong", Maphong);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa đổi trạng thai thất bại ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void buttonthemkhach_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(daohaychua(comboBoxkhach.SelectedValue.ToString())) >= 1)
            {
                MessageBox.Show("Người này đã ở thuê phòng rồi");
                return;
            }
            else
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlInsert = "INSERT INTO thuephong VALUES(@maphong, @makhach,@ngaybatdauthue)";
                SqlCommand cmd = new SqlCommand(SqlInsert, con);
                cmd.Parameters.AddWithValue("maphong", Maphong);
                cmd.Parameters.AddWithValue("makhach", comboBoxkhach.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("ngaybatdauthue", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd.ExecuteNonQuery();
                Trangthaithuephong = "Đã có khách thuê";
                updatetrangthai("Đã có khách thuê");
                load();
                excutequerrryy("SELECT dbo.khachhang.makhach, dbo.khachhang.hotenkhach,dbo.thuephong.ngaybatdauthue, dbo.khachhang.sdtkhach, dbo.khachhang.socmnd from thuephong INNER JOIN dbo.khachhang ON dbo.thuephong.makhach = dbo.khachhang.makhach where maphong='" + Maphong + "'", dataGridViewkhachhang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm khách hàng: " + ex.ToString());
            }
        }

        private void buttonTraPhong_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn trả phòng ?", "Xác nhận trả phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection con = new SqlConnection(chuoikn);
                    con.Open();
                    String SqlUpdate = "delete from thuephong WHERE maphong=@maphong";
                    SqlCommand cmd = new SqlCommand(SqlUpdate, con);
                    cmd.Parameters.AddWithValue("maphong", Maphong);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Trả phòng thất bài thai thất bại ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                }
                Trangthaithuephong = "Chưa có khách thuê";
                updatetrangthai("Chưa có khách thuê");
                load();
                excutequerrryy("SELECT dbo.khachhang.makhach, dbo.khachhang.hotenkhach,dbo.thuephong.ngaybatdauthue, dbo.khachhang.sdtkhach, dbo.khachhang.socmnd from thuephong INNER JOIN dbo.khachhang ON dbo.thuephong.makhach = dbo.khachhang.makhach where maphong='" + Maphong + "'", dataGridViewkhachhang);
            }
           
        }

        private void dataGridViewkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String makhach = "" + dataGridViewkhachhang.SelectedCells[0].OwningRow.Cells["makhach"].Value;
            String hotenkhach = "" + dataGridViewkhachhang.SelectedCells[0].OwningRow.Cells["hotenkhach"].Value;

            //if click is on new row or header row
            if (e.RowIndex == dataGridViewkhachhang.NewRowIndex || e.RowIndex < 0)
                return;
            //Check if click is on specific column 
            //xử lý sự kiện khi nhấn nút xóa loại hàng
            if (e.ColumnIndex == dataGridViewkhachhang.Columns["xoa"].Index)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + hotenkhach + " ra khỏi phòng hay không ???", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(chuoikn);
                        con.Open();
                        String SqlDelete = "DELETE FROM thuephong WHERE makhach=@makhach and maphong=@maphong";
                        SqlCommand cmd = new SqlCommand(SqlDelete, con);
                        cmd.Parameters.AddWithValue("makhach", makhach);
                        cmd.Parameters.AddWithValue("maphong", Maphong);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        load();
                        excutequerrryy("SELECT dbo.khachhang.makhach, dbo.khachhang.hotenkhach,dbo.thuephong.ngaybatdauthue, dbo.khachhang.sdtkhach, dbo.khachhang.socmnd from thuephong INNER JOIN dbo.khachhang ON dbo.thuephong.makhach = dbo.khachhang.makhach where maphong='" + Maphong + "'", dataGridViewkhachhang);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
