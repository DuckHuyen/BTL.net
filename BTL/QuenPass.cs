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
    public partial class QuenPass : Form
    {
        public QuenPass()
        {
            InitializeComponent();
        }

        private void QuenPass_Load(object sender, EventArgs e)
        {

        }
        //sự kiện click vào button xác nhận
        private void button1_Click(object sender, EventArgs e)
        {
            //kiểm tra mã code tồn tại hay không
            if (User.CheckExists("Users", "Code", txtCodeQuenPass.Text.Trim()) != true)
            {
                MessageBox.Show("Mã code bí mật bạn nhập không chính xác, xin vui lòng thử lại");
                return;
            }
            //đẩy mã code lên textbox cho người dùng
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT Username FROM Users WHERE Code = @Code;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Code", txtCodeQuenPass.Text.Trim());
            connection.Open();
            txtTaiKhoan.Text = (string)command.ExecuteScalar();
            connection.Close();
            string query2 = "SELECT Password FROM Users WHERE Code = @Code;";
            SqlCommand command2 = new SqlCommand(query2, connection);
            command2.Parameters.AddWithValue("@Code", txtCodeQuenPass.Text.Trim());
            connection.Open();
            txtMatKhau.Text = (string)command2.ExecuteScalar();
            connection.Close();
        }

        //sự kiện click vào picturebox để quay lại form đăng nhập
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap f = new DangNhap();
            f.ShowDialog();
            this.Close();
        }
    }
}
