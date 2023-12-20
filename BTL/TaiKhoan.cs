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
    public partial class TaiKhoan : Form
    {
        public int Id;
        public TaiKhoan()
        {
            InitializeComponent();
        }
        // sự kiện click vào button đổi tài khoản
        private void button1_Click(object sender, EventArgs e)
        {
            //xử lý trường hợp rỗng
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            //xử lý trường hợp mật khẩu không khớp
            if (textBox2.Text.Trim()!= textBox3.Text.Trim())
            {
                MessageBox.Show("Mật khẩu không được khớp, vui lòng nhập lại");
                return;
            }
            //lấy ra pass cũ từ csdl và kiểm tra 
            string pass = "";
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT Password FROM Users WHERE UserID = @Id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", Id);
                connection.Open();
                pass = (string)command.ExecuteScalar();
                connection.Close();
            }
            if (textBox1.Text.Trim() != pass)
            {
                MessageBox.Show("Mật khẩu bạn nhập không chính xác");
                return;
            }
            //cập nhật mật khẩu mới của người dùng và thông báo thành công
            string query2 = "UPDATE Users SET Password = '" + textBox2.Text.Trim() + "' WHERE UserID = '"+Id.ToString()+"';";
            using (SqlCommand command2 = new SqlCommand(query2, connection))
            {
                connection.Open();
                command2.ExecuteNonQuery();
                connection.Close();
            }
            MessageBox.Show("Đổi mật khẩu thành công");

        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            
        }
    }
}
