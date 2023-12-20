using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void fDangKy_Load(object sender, EventArgs e)
        {

        }
        //Nhập tài khoản
        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "Nhập tên tài khoản")
            {
                txtTaiKhoan.Text = "";
                txtTaiKhoan.ForeColor = Color.Black;
            }
        }
        //Nhập mật khẩu
        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Nhập mật khẩu")
            {
                txtMatKhau.Text = "";
                txtMatKhau.PasswordChar = '*';
                txtMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtMatKhau2_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau2.Text == "Nhập lại mật khẩu")
            {
                txtMatKhau2.Text = "";
                txtMatKhau2.PasswordChar = '*';
                txtMatKhau2.ForeColor = Color.Black;
            }
        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == "")
            {
                txtTaiKhoan.Text = "Nhập tên tài khoản";
                txtTaiKhoan.ForeColor = SystemColors.ButtonShadow;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Trim() == "")
            {
                txtMatKhau.PasswordChar = '\0';
                txtMatKhau.Text = "Nhập mật khẩu";
                txtMatKhau.ForeColor = SystemColors.ButtonShadow;
            }
        }

        private void txtMatKhau2_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau2.Text.Trim() == "")
            {
                txtMatKhau2.PasswordChar = '\0';
                txtMatKhau2.Text = "Nhập lại mật khẩu";
                txtMatKhau2.ForeColor = SystemColors.ButtonShadow;
            }         
        }
        //sự kiện click vào button đăng ký
        private void button1_Click(object sender, EventArgs e)
        {
            //xử lý trường hợp để trống
            if (txtTaiKhoan.Text.Trim() == "Nhập tên tài khoản" || txtMatKhau.Text.Trim() == "Nhập mật khẩu" || txtMatKhau2.Text.Trim() == "Nhập lại mật khẩu")
            {
                MessageBox.Show("Vui lòng không để trống thông tin");
                return;
            }
            //xử lý trường hợp 2 mật khẩu không khớp nhau
            if (txtMatKhau.Text.Trim()!=txtMatKhau2.Text.Trim())
            {
                MessageBox.Show("Mật khẩu không khớp, vui lòng kiểm tra và điền lại");
                return;
            }
            //kiểm tra xem tên tài khoản tồn tại chưa
            if (User.CheckIfUserNameExists(txtTaiKhoan.Text) == true)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại");
                return;
            }
            //tạo tài khoản và thông báo thành công, đòng thời đưa cho người dùng mã code bí mật 
            User us = new User(txtTaiKhoan.Text , txtMatKhau.Text);
            MessageBox.Show("\t\tTạo tài khoản thành công \nVui lòng sao chép mã code này trong trường hợp quên mật khẩu \n\t\t" +us.Code);
        }

        //sự kiện click vào picture box quay lại form đăng nhập
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap f = new DangNhap();
            f.ShowDialog();
            this.Close();
        }
    }
}
