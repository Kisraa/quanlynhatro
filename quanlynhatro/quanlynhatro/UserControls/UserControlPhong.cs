using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlynhatro.FormChucNang;

namespace quanlynhatro.UserControls
{
    public partial class UserControlPhong : UserControl
    {
        public UserControlPhong()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormChiTietThuePhong phong = new FormChiTietThuePhong();
            phong.Maphong = Maphong;
            phong.Tenphong = Tenphong;
            phong.Maloaiphong = Maloaiphong;
            phong.Trangthaithuephong = Trangthaithuephong;
            phong.Sodienthangcu = Sodienthangcu;
            phong.Sonuocthangcu = Sonuocthangcu;
            phong.Sokhachtoida = Sokhachtoida;
            phong.ShowDialog();
        }
        public void load()
        {
            labeltenphong.Text = "Tên phòng: " + Tenphong;
            labelloaiphong.Text = "Loại phòng: " + Maloaiphong;
            labeltrangthai.Text = "Trạng thái: " + Trangthaithuephong;
            labelsodien.Text = "Số điện: " + Sodienthangcu;
            labelsonuoc.Text = "Số nước: " + Sonuocthangcu;
            labelsokhachtoida.Text = "Số khách tối đa: " + Sokhachtoida;
            if (Trangthaithuephong.Equals("Chưa có khách thuê"))
            {
                flowLayoutPanel1.BackColor = Color.LightSlateGray;
            }
        }
        private void UserControlPhong_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
