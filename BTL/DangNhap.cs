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
    public partial class DangNhap : Form
    {   //checkPass dùng để kiểm tra trạng thái mà người dùng để hiển thị mật khẩu hay không
        //Id dùng để lưu Id tài khoản và chuyển tiếp sang form tiếp theo sau khi đăng nhập thành công
        bool checkPass=false;
        public int Id;
        public DangNhap()
        {
            InitializeComponent(); 
        }
        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "Nhập tên tài khoản")
            {
                txtTaiKhoan.Text = "";
                txtTaiKhoan.ForeColor = Color.Black;
            }
        }
        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Nhập mật khẩu")
            {
                txtMatKhau.Text = "";
                if(checkPass==false) txtMatKhau.PasswordChar = '*';
                txtMatKhau.ForeColor = Color.Black;
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
            if (txtMatKhau.Text.Trim() == "") {
                txtMatKhau.PasswordChar = '\0';
                txtMatKhau.Text = "Nhập mật khẩu";
                txtMatKhau.ForeColor = SystemColors.ButtonShadow;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }
        //chuyển sang form đăng ký
        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy f = new DangKy();
            f.ShowDialog();
            this.Close();
        }
        //khi hover vào label sẽ hiển thị màu khác để người dùng biết nó tương tác được
        private void label6_MouseHover(object sender, EventArgs e)
        {
            lbDangKy.ForeColor = Color.Blue;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            lbDangKy.ForeColor = Color.Black;
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            lbQuenMK.ForeColor = Color.Blue;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            lbQuenMK.ForeColor = Color.Black;
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
        //đóng mở hiện mật khẩu khi người dùng click vào picture box
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (checkPass == true)
            {       
                    checkPass = false;
                    txtMatKhau.PasswordChar = '*';
                    if (txtMatKhau.Text == "Nhập mật khẩu") txtMatKhau.PasswordChar = '\0';
                    picbNhinMatKhau.BackColor = Color.White;
            }
            else
            {
                    checkPass = true;
                    txtMatKhau.PasswordChar = '\0';
                    picbNhinMatKhau.BackColor = SystemColors.ControlLight;   
            }
        }
        //sự kiện click button đăng nhập
        private void button1_Click(object sender, EventArgs e)
        {
            //kiểm tra khoảng trắng ở tài khoản và mật khẩu
            if (txtTaiKhoan.Text.Trim().Contains(" ") || txtMatKhau.Text.Trim().Contains(" "))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu đúng định dạng");
                return;
            }
            //Kiểm tra tài khoản và mật khẩu 
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT COUNT(*) FROM dbo.Users WHERE Username = @Username AND Password = @Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", txtTaiKhoan.Text.Trim());
            command.Parameters.AddWithValue("@Password", txtMatKhau.Text.Trim());
            connection.Open();
            int count = (int)command.ExecuteScalar();
            if (count <= 0)
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                return;
            }
            //lấy id của tài khoản và chuyển sang giao diện người dùng chính
            string query2 = "SELECT UserID FROM dbo.Users WHERE Username = @Username";
            SqlCommand command2 = new SqlCommand(query2, connection);
            command2.Parameters.AddWithValue("@Username", txtTaiKhoan.Text.Trim());
            object a = command2.ExecuteScalar();
            connection.Close();
            if (a != null)
            {
                Id = (int)a;
                Main f = new Main();
                this.Hide();
                f.Id = Id;
                f.ShowDialog();
                this.Close();
            }
            
        }

        private void fDangNhap_Load(object sender, EventArgs e)
        {
            //tạo dữ liệu gốc nếu chưa được tạo
            if (!IsDataInstalled())
            {
                InstallData();
            }
        }

        //sự kiện click vào lable quên mật khẩu
        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuenPass f = new QuenPass();
            f.ShowDialog();
            this.Close();
        }
        //kiểm tra bảng users đã được cài đặt chưa 
        private bool IsDataInstalled()
        {
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("IF OBJECT_ID('Users', 'U') IS NOT NULL SELECT 1 ELSE SELECT 0", connection);
                int result = Convert.ToInt32(command.ExecuteScalar());
                return result == 1;
            }
        }
        //tạo dữ liệu gốc(bảng users)
        private void InstallData()
        {
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("CREATE TABLE Users (UserID INT IDENTITY(1,1) PRIMARY KEY, Username NVARCHAR(50),Password NVARCHAR(50),Code VARCHAR(12))", connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
