using quanlynhatro.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlynhatro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static String id;
        public static String quyen;
        UserControlQuanTriHeThong quantrihethong;
        UserControlQuanLyPhong quanLyPhong;
        UserControlTaiKhoanNguoiDung nguoiDung;
        UserControlQLSuaChua suaChua;
        UserControlReport report;
        private void button_QLKho_Click(object sender, EventArgs e)
        {
            quanLyPhong = new UserControlQuanLyPhong();
            this.Text = "Quản lý phòng";
            ShowUserControls(quanLyPhong, panel_ShowUserControls);
            quanLyPhong.BringToFront();
            setcolor("button_QLPhong");
        }
        //set màu cho button
        public void setcolor(string name)
        {
            foreach (Control item in panel2.Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    if (item.Name.Equals(name))
                    {
                        item.BackColor = Color.FromArgb(0, 153, 153);
                    }
                    else
                    {
                        item.BackColor = Color.FromArgb(54, 96, 108);
                    }
                }
            }
        }
        public void ShowUserControls(UserControl user, Panel panel)//hiển thị usercontrol lên giao diện
        {
            panel.Controls.Add(user);
            user.Dock = DockStyle.Fill;
        }
        private void buttonQuanTriHeThong_Click(object sender, EventArgs e)
        {
            quantrihethong = new UserControlQuanTriHeThong();
            this.Text = "Quản trị hệ thống";
            ShowUserControls(quantrihethong, panel_ShowUserControls);
            quantrihethong.BringToFront();
            setcolor("buttonQuanTriHeThong");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nguoiDung = new UserControlTaiKhoanNguoiDung();
            this.Text = "Trung tâm điều kiển";
            ShowUserControls(nguoiDung, panel_ShowUserControls);
            nguoiDung.BringToFront();
            setcolor("button1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(quyen.Equals("Quyền khách hàng"))
            {
                button_QLPhong.Visible = false;
                button_QLSuaChua.Visible = false;
                buttonQuanTriHeThong.Visible = false;
                buttonBaoCao.Visible = false;
            }
            if(quyen.Equals("Quyền admin"))
            {
                button1.Visible = false;
            }
            if (quyen.Equals("Quyền nhân viên"))
            {
                buttonQuanTriHeThong.Visible = false;
                button1.Visible = false;
            }
        }

        private void button_QLSuaChua_Click(object sender, EventArgs e)
        {
            suaChua = new UserControlQLSuaChua();
            this.Text = "Quản lý trợ giúp sửa chữa";
            ShowUserControls(suaChua, panel_ShowUserControls);
            suaChua.BringToFront();
            setcolor("button_QLSuaChua");
        }

        private void buttonBaoCao_Click(object sender, EventArgs e)
        {
            report = new UserControlReport();
            this.Text = "Báo cáo thống kê";
            ShowUserControls(report, panel_ShowUserControls);
            report.BringToFront();
            setcolor("buttonBaoCao");
        }
    }
}
