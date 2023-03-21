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
    public partial class FormXemChiTietPhieuThu : Form
    {
        public FormXemChiTietPhieuThu()
        {
            InitializeComponent();
        }
        private String maphieuthu;

        String chuoikn = ClassConnection.ConnectionString;

        public string Maphieuthu { get => maphieuthu; set => maphieuthu = value; }

        public String getValue(String noidungSelect, String table, String KeyNameColumn, String ValueWhere)
        {
            try
            {
                String SQL = "select "+noidungSelect+" from "+table+" where "+KeyNameColumn+"=" + ValueWhere + "";
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLapHoaDonNhapHang_Click(object sender, EventArgs e)
        {
            if(comboBoxtrangthaitratien.Text.Equals("Đã đóng tiền"))
            {
                MessageBox.Show("Bạn đã thu tiền cho phiếu thu này rồi, không thể sửa đổi thông tin");
            }
            else 
                try
                {
                    SqlConnection con = new SqlConnection(chuoikn);
                    con.Open();
                    String SqlUpdate = "UPDATE phieuthutientro SET maphong=@maphong,nhanvienlap=@nhanvienlap,ngaylap=@ngaylap,sodiencu=@sodiencu,sodienmoi=@sodienmoi,giadien=@giadien,sonuoccu=@sonuoccu,sonuocmoi=@sonuocmoi,gianuoc=@gianuoc,thanhtien=@thanhtien,trangthaidongtien=@trangthaidongtien,giaphong=@giaphong WHERE maphieuthu=@maphieuthu";
                    SqlCommand cmd = new SqlCommand(SqlUpdate, con);
                    cmd.Parameters.AddWithValue("maphong", comboBoxphong.Text);
                    cmd.Parameters.AddWithValue("nhanvienlap", textBoxNhanVien.Text);
                    cmd.Parameters.AddWithValue("ngaylap", DateTime.Now.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("sodiencu", (int)numericUpDownSoDienCu.Value);
                    cmd.Parameters.AddWithValue("sodienmoi", (int)numericUpDownsodienmoi.Value);
                    cmd.Parameters.AddWithValue("giadien", (float)numericUpDowngiadien.Value);
                    cmd.Parameters.AddWithValue("sonuoccu", (float)numericUpDownSoNuocCu.Value);
                    cmd.Parameters.AddWithValue("sonuocmoi", (float)numericUpDownsonuocmoi.Value);
                    cmd.Parameters.AddWithValue("gianuoc", (float)numericUpDowngianuoc.Value);
                    cmd.Parameters.AddWithValue("thanhtien", tinhtien());
                    cmd.Parameters.AddWithValue("trangthaidongtien", comboBoxtrangthaitratien.Text);
                    cmd.Parameters.AddWithValue("giaphong", textBoxgiaphong.Text);
                    cmd.Parameters.AddWithValue("maphieuthu", Maphieuthu);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa đổi dữ liệu thất bại ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                }
        }
        public Double tinhtien()
        {
            Double kq = 0;
            int sodiencu, sodienmoi, sonuoccu, sonuocmoi;
            Double giadien, gianuoc;
            sodiencu = (int)numericUpDownSoDienCu.Value;
            sodienmoi = (int)numericUpDownsodienmoi.Value;
            sonuoccu = (int)numericUpDownSoNuocCu.Value;
            sonuocmoi = (int)numericUpDownsonuocmoi.Value;
            giadien = Convert.ToDouble(numericUpDowngiadien.Value);
            gianuoc = Convert.ToDouble(numericUpDowngianuoc.Value);
            Double tienphong = Convert.ToDouble(textBoxgiaphong.Text);
            kq = (sodienmoi - sodiencu) * giadien + (sonuocmoi - sonuoccu) * gianuoc + tienphong;
            return kq;
        }
        private void FormXemChiTietPhieuThu_Load(object sender, EventArgs e)
        {
            String maphong, nhanvienlap, ngaylap, sodiencu, sodienmoi, giadien, sonuoccu, sonuocmoi, gianuoc, thanhtien, trangthaidongtien, giaphong;
            maphong = getValue("maphong", "phieuthutientro", "maphieuthu", Maphieuthu);
            nhanvienlap = getValue("nhanvienlap", "phieuthutientro", "maphieuthu", Maphieuthu);
            ngaylap = getValue("ngaylap", "phieuthutientro", "maphieuthu", Maphieuthu);
            sodiencu = getValue("sodiencu", "phieuthutientro", "maphieuthu", Maphieuthu);
            sodienmoi = getValue("sodienmoi", "phieuthutientro", "maphieuthu", Maphieuthu);
            giadien = getValue("giadien", "phieuthutientro", "maphieuthu", Maphieuthu);
            sonuoccu = getValue("sonuoccu", "phieuthutientro", "maphieuthu", Maphieuthu);
            sonuocmoi = getValue("sonuocmoi", "phieuthutientro", "maphieuthu", Maphieuthu);
            gianuoc = getValue("gianuoc", "phieuthutientro", "maphieuthu", Maphieuthu);
            thanhtien = getValue("thanhtien", "phieuthutientro", "maphieuthu", Maphieuthu);
            trangthaidongtien = getValue("trangthaidongtien", "phieuthutientro", "maphieuthu", Maphieuthu);
            giaphong = getValue("giaphong", "phieuthutientro", "maphieuthu", Maphieuthu);
            comboBoxphong.Text = maphong;
            textBoxNhanVien.Text = nhanvienlap;
            textBoxngaylap.Text = ngaylap;
            numericUpDownSoDienCu.Value =Convert.ToInt32(sodiencu);
            numericUpDownsodienmoi.Value= Convert.ToInt32(sodienmoi);
            numericUpDowngiadien.Value = Convert.ToInt32(giadien);
            numericUpDownSoNuocCu.Value = Convert.ToInt32(sonuoccu);
            numericUpDownsonuocmoi.Value = Convert.ToInt32(sonuocmoi);
            numericUpDowngianuoc.Value = Convert.ToInt32(gianuoc);
            textBoxthanhtien.Text = thanhtien;
            comboBoxtrangthaitratien.Text = trangthaidongtien;
            textBoxgiaphong.Text = giaphong;
            if(Form1.quyen.Equals("Quyền khách hàng"))
            {
                buttonLapHoaDonNhapHang.Visible = false;
            }
        }

        private void numericUpDownsodienmoi_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxthanhtien.Text = tinhtien() + "";
            }catch(Exception ex)
            {

            }
        }

        private void numericUpDownsonuocmoi_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxthanhtien.Text = tinhtien() + "";
            }
            catch (Exception ex)
            {

            }
        }

        private void numericUpDowngiadien_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxthanhtien.Text = tinhtien() + "";
            }
            catch (Exception ex)
            {

            }
        }

        private void numericUpDowngianuoc_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxthanhtien.Text = tinhtien() + "";
            }
            catch (Exception ex)
            {

            }
        }
    }
}
