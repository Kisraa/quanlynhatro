﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlynhatro
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        int r = 255, g = 0, b = 0;
        String chuoikn = ClassConnection.ConnectionString;
        public String getValue(String noidungSelect, String table, String KeyNameColumn, String ValueWhere)
        {
            try
            {
                String SQL = "select " + noidungSelect + " from " + table + " where " + KeyNameColumn + "='" + ValueWhere + "'";
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox_anhienmathau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_anhienmathau.Checked == true)
            {
                textBox_MatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_MatKhau.UseSystemPasswordChar = true;
            }
        }
        public bool checkActive(String tendn)
        {
            try
            {
                String SQL = "select active from dangnhapNV where tendangnhap='" + tendn + "'";
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                String kq = cmd.ExecuteScalar().ToString();
                con.Close();
                if (kq.Equals("1"))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi " + ex.ToString());
                return false;
            }
        }
        public bool checkActiveKhach(String tendn)
        {
            try
            {
                String SQL = "select active from dangnhapKH where tendangnhap='" + tendn + "'";
                SqlConnection con = new SqlConnection(chuoikn);
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                String kq = cmd.ExecuteScalar().ToString();
                con.Close();
                if (kq.Equals("1"))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi " + ex.ToString());
                return false;
            }
        }
        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            if (radioButtonNhaQuanLy.Checked == true)
            {
                if (checkActive(textBox_TenDangNhap.Text) == false)
                {
                    MessageBox.Show("Xin lỗi, bạn không được phép truy cập hệ thống, vui lòng liên hệ với quản trị viên để được hổ trợ !!!");
                    return;
                }
                try
                {
                    SqlConnection con = new SqlConnection(chuoikn);
                    con.Open();
                    string username = textBox_TenDangNhap.Text;
                    String quyen = getValue("quyen", "dangnhapNV", "tendangnhap", username);
                    string passwword = textBox_MatKhau.Text;
                    string sqlselect = "select *from dangnhapNV where tendangnhap='" + username + "' and matkhau='" + CreateMD5(passwword) + "'";
                    SqlCommand cmd = new SqlCommand(sqlselect, con);
                    SqlDataReader data = cmd.ExecuteReader();
                    if (data.Read() == true)
                    {
                        this.Hide();
                        data.Close();
                        con.Close();
                        Form1.id = username;
                        Form1.quyen = quyen;
                        //FormDoiMatKhau.matkhau = passwword;
                        Form1 f = new Form1();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập không thành công, kiểm tra tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            if (radioButtonNguoithuetro.Checked == true)
            {
                if (checkActiveKhach(textBox_TenDangNhap.Text) == false)
                {
                    MessageBox.Show("Xin lỗi, bạn không được phép truy cập hệ thống, vui lòng liên hệ với quản trị viên để được hổ trợ !!!");
                    return;
                }
                try
                {
                    SqlConnection con = new SqlConnection(chuoikn);
                    con.Open();
                    string username = textBox_TenDangNhap.Text;
                    string passwword = textBox_MatKhau.Text;
                    string sqlselect = "select *from dangnhapKH where tendangnhap='" + username + "' and matkhau='" + CreateMD5(passwword) + "'";
                    SqlCommand cmd = new SqlCommand(sqlselect, con);
                    SqlDataReader data = cmd.ExecuteReader();
                    if (data.Read() == true)
                    {
                        this.Hide();
                        data.Close();
                        con.Close();
                        Form1.id = username;
                        Form1.quyen = "Quyền khách hàng";
                       // FormDoiMatKhau.matkhau = passwword;
                        Form1 f = new Form1();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập không thành công, kiểm tra tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            panelgrb.BackColor = Color.FromArgb(r, g, b);
            if (r > 0 && b == 0)
            {
                r--;
                g++;
            }
            if (g > 0 && r == 0)
            {
                g--;
                b++;
            }
            if (b > 0 && g == 0)
            {
                b--;
                r++;
            }
        }
    }
}
