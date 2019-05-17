﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaKho
{
    public partial class Login : Form
    {
        Login_Bus bus;
        
        public Login()
        {
            InitializeComponent();
            bus = new Login_Bus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_ID.Text=="" || tb_Password.Text=="")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu trống");
            }
            try
            {
                if (bus.Check(tb_ID.Text, tb_Password.Text) == true)
                {
                    Form main;
                    main = new QLNK();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài Khoản hoặc mật khẩu không chính xác");
                }
            }catch(Exception)
            {
                MessageBox.Show("Lỗi đăng nhập");
            }
        }
    }
}
