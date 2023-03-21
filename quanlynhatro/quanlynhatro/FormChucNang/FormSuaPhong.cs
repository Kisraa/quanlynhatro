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
    public partial class FormSuaPhong : Form
    {
        public FormSuaPhong()
        {
            InitializeComponent();
        }
        String chuoikn = ClassConnection.ConnectionString;
        String maphong ;
        String tenphong ;
        String tenloaiphong_fromphong;
        String sodienthangcu ;
        String sonuocthangcu;
        String sokhachtoida;
       
        public string Maphong { get => maphong; set => maphong = value; }
        public string Tenphong { get => tenphong; set => tenphong = value; }
        public string Tenloaiphong_fromphong { get => tenloaiphong_fromphong; set => tenloaiphong_fromphong = value; }
        public string Sodienthangcu { get => sodienthangcu; set => sodienthangcu = value; }
        public string Sonuocthangcu { get => sonuocthangcu; set => sonuocthangcu = value; }
        public string Sokhachtoida { get => sokhachtoida; set => sokhachtoida = value; }

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
        private void FormSuaPhong_Load(object sender, EventArgs e)
        {
            loadcombobox("loaiphong", "maloaiphong", "tenloaiphong", comboBoxLoaiPhong);
            textBoxTenPhong.Text = Tenphong;
            comboBoxLoaiPhong.Text = tenloaiphong_fromphong;
            numericUpDownSoDien.Value = Convert.ToInt32(Sodienthangcu);
            numericUpDownSoNuoc.Value = Convert.ToInt32(Sonuocthangcu);
            numericUpDownSOKhachToiDa.Value = Convert.ToInt32(Sokhachtoida);
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                String SqlDelete = "update phong set tenphong=@tenphong, maloaiphong=@maloaiphong,sodienthangcu=@sodienthangcu,sonuocthangcu=@sonuocthangcu,sokhachtoida=@sokhachtoida WHERE maphong=@maphong";
                SqlCommand cmd = new SqlCommand(SqlDelete, con);
                cmd.Parameters.AddWithValue("tenphong", textBoxTenPhong.Text);
                cmd.Parameters.AddWithValue("maloaiphong", comboBoxLoaiPhong.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("sodienthangcu", numericUpDownSoDien.Value);
                cmd.Parameters.AddWithValue("sonuocthangcu", numericUpDownSoNuoc.Value);
                cmd.Parameters.AddWithValue("sokhachtoida", numericUpDownSOKhachToiDa.Value);
                cmd.Parameters.AddWithValue("maphong", Maphong);

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

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
