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
    public partial class FormLapPhieuThuTien : Form
    {
        public FormLapPhieuThuTien()
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
        public String getSoDienCuByPhong(String maphong)
        {
            try
            {
                String SQL = "select sodienthangcu from phong where maphong="+maphong+"";
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
        public String getSoNuocCuByPhong(String maphong)
        {
            try
            {
                String SQL = "select sonuocthangcu from phong where maphong=" + maphong + "";
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
        public String getLoaiPhong(String maphong)
        {
            try
            {
                String SQL = "select maloaiphong from phong where maphong=" + maphong + "";
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
        public String getGiaPhong(String maloai)
        {
            try
            {
                String SQL = "select giatien from loaiphong where maloaiphong=" + maloai + "";
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
        private void FormLapPhieuThuTien_Load(object sender, EventArgs e)
        {
            loadcombobox("phong", "maphong", "tenphong", comboBoxphong);
            textBoxNhanVien.Text = Form1.id;
        }

        private void comboBoxphong_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBoxphong_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                String sodien=getSoDienCuByPhong(comboBoxphong.SelectedValue.ToString());
                String sonuoc = getSoNuocCuByPhong(comboBoxphong.SelectedValue.ToString());
                String maloaiphong = getLoaiPhong(comboBoxphong.SelectedValue.ToString());
                String giaphong = getGiaPhong(maloaiphong);
                textBoxgiaphong.Text = giaphong;
                numericUpDownSoDienCu.Value = Convert.ToInt32(sodien);
                numericUpDownSoNuocCu.Value = Convert.ToInt32(sonuoc);
            }
            catch (Exception ex)
            {

            }
        }
        public Double tinhtien()
        {
            Double kq=0;
            int sodiencu, sodienmoi, sonuoccu, sonuocmoi;
            Double giadien, gianuoc;
            sodiencu = (int)numericUpDownSoDienCu.Value;
            sodienmoi = (int)numericUpDownsodienmoi.Value;
            sonuoccu = (int)numericUpDownSoNuocCu.Value;
            sonuocmoi = (int)numericUpDownsonuocmoi.Value;
            giadien = Convert.ToDouble(numericUpDowngiadien.Value);
            gianuoc = Convert.ToDouble(numericUpDowngianuoc.Value);
            Double tienphong =Convert.ToDouble(textBoxgiaphong.Text);
            kq = (sodienmoi - sodiencu) * giadien + (sonuocmoi - sonuoccu) * gianuoc+tienphong;
            return kq;
        }

        private void numericUpDownsodienmoi_ValueChanged(object sender, EventArgs e)
        {
            textBoxthanhtien.Text= tinhtien()+"VNĐ";
        }

        private void numericUpDowngiadien_ValueChanged(object sender, EventArgs e)
        {
            textBoxthanhtien.Text = tinhtien() + "VNĐ";
        }

        private void numericUpDownsonuocmoi_ValueChanged(object sender, EventArgs e)
        {
            textBoxthanhtien.Text = tinhtien() + "VNĐ";
        }

        private void numericUpDowngianuoc_ValueChanged(object sender, EventArgs e)
        {
            textBoxthanhtien.Text = tinhtien() + "VNĐ";
        }

        private void buttonLapHoaDonNhapHang_Click(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlInsert = "INSERT INTO phieuthutientro VALUES(@maphong,@nhanvienlap,@ngaylap,@sodiencu,@sodienmoi,@giadien,@sonuoccu,@sonuocmoi,@gianuoc,@thanhtien,@trangthaidongtien,@giaphong)";
                SqlCommand cmd = new SqlCommand(SqlInsert, con);
                cmd.Parameters.AddWithValue("maphong", comboBoxphong.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("nhanvienlap", textBoxNhanVien.Text);
                cmd.Parameters.AddWithValue("ngaylap", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("sodiencu",(int) numericUpDownSoDienCu.Value);
                cmd.Parameters.AddWithValue("sodienmoi", (int)numericUpDownsodienmoi.Value);
                cmd.Parameters.AddWithValue("giadien",(float) numericUpDowngiadien.Value);
                cmd.Parameters.AddWithValue("sonuoccu", (float)numericUpDownSoNuocCu.Value);
                cmd.Parameters.AddWithValue("sonuocmoi", (float)numericUpDownsonuocmoi.Value);
                cmd.Parameters.AddWithValue("gianuoc",(float) numericUpDowngianuoc.Value);
                cmd.Parameters.AddWithValue("thanhtien", tinhtien());
                cmd.Parameters.AddWithValue("trangthaidongtien", comboBoxtrangthaitratien.Text);
                cmd.Parameters.AddWithValue("giaphong", textBoxgiaphong.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lập phiếu thu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                this.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
