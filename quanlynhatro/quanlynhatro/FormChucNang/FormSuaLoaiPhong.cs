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
    public partial class FormSuaLoaiPhong : Form
    {
        public FormSuaLoaiPhong()
        {
            InitializeComponent();
        }
        private String maloaiphong;
        private String tenloaiphong;
        private String giatien;

        public string Maloaiphong { get => maloaiphong; set => maloaiphong = value; }
        public string Tenloaiphong { get => tenloaiphong; set => tenloaiphong = value; }
        public string Giatien { get => giatien; set => giatien = value; }

        private void buttonhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        String chuoikn = ClassConnection.ConnectionString;
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlDelete = "update loaiphong set tenloaiphong=@tenloaiphong, giatien=@giatien WHERE maloaiphong=@maloaiphong";
                SqlCommand cmd = new SqlCommand(SqlDelete, con);
                cmd.Parameters.AddWithValue("tenloaiphong", textBoxTenLoaiPhong.Text);
                cmd.Parameters.AddWithValue("giatien", numericUpDownGia.Value);
                cmd.Parameters.AddWithValue("maloaiphong", Maloaiphong);
                cmd.ExecuteNonQuery();
                con.Close();
                UserControls.UserControlQuanTriHeThong.checkdataChange = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra ! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void FormSuaLoaiPhong_Load(object sender, EventArgs e)
        {
            textBoxTenLoaiPhong.Text = Tenloaiphong;
            numericUpDownGia.Value = Convert.ToInt32(Giatien);
        }
    }
}
