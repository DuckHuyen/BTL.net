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
    public partial class LoaiTaiSan : Form
    {
        //lưu trữ id của người dùng
        public int Id;
        public LoaiTaiSan()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //tải lên dữ liệu các loại tài sản của người dùng
        private void Form2_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            DataTable dataTable = GetDataFromDatabase();
            int i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                i = i + 1;
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                listView1.Items.Add(item);
            }
        }
        //sự kiện khi click vào button thêm loại tài sản mới
        private void button1_Click(object sender, EventArgs e)
        {
            //xử lý trường hợp để trống
            if (txtMaLoaiTaiSan.Text.Trim() == "" || txtTenTaiSan.Text.Trim() == ""||txtNamKhauHao.Text.Trim()=="")
            {
                MessageBox.Show("Vui lòng không để trống");
                return;
            }
            //kiểm tra định dạng của số năm khấu hao
            try
            {
                int a = int.Parse(txtNamKhauHao.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số năm trích khấu hao đúng định dạng");
                return;
            }
            //kiểm tra mã tài sản đã tồn tại hay chưa, nếu tồn tại thông báo để người dùng nhập lại
            if (User.CheckExists("Id" + Id + "LoaiTaiSan", "MaLoai", txtMaLoaiTaiSan.Text.Trim()) == true)
            {
                MessageBox.Show("Mã loại tài sản này đã tồn tại, vui lòng đặt bằng mã khác");
                return;
            }
            //kiểm tra tên loại tài sản này đã tồn tại hay chưa, nếu tồn tại thông báo người dùng nhập lại
            if (User.CheckExists("Id" + Id + "LoaiTaiSan", "TenLoai", txtTenTaiSan.Text.Trim()) == true)
            {
                MessageBox.Show("Tên loại tài sản này đã tồn tại, vui lòng đặt bằng tên khác");
                return;
            }
            //thêm loại tài sản mới và thông báo thành công
            int Nam=int.Parse(txtNamKhauHao.Text.Trim());
            User.InsertAssetsType(Id, txtMaLoaiTaiSan.Text.Trim(), txtTenTaiSan.Text.Trim(), Nam);
            MessageBox.Show("Thêm loại tài sản thành công");
            Form2_Load(this, EventArgs.Empty);
        }
        //phương thức trả về dữ liệu bảng loại tài sản
        private DataTable GetDataFromDatabase()
        {
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            string query = "SELECT * FROM Id" + Id + "LoaiTaiSan";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        //sự kiện khi click vào button tìm kiếm loại tài sản
        private void button2_Click(object sender, EventArgs e)
        {
            //kiểm tra kiểu dữ liệu của năm khấu hao nếu nó có tồn tại
            try
            {
                if (txtNamKhauHao.Text.Trim() != "")
                {
                    int a = int.Parse(txtNamKhauHao.Text.Trim());
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số năm trích khấu hao đúng định dạng");
                return;
            }
            //xử lý trường hợp để trống
            if (txtMaLoaiTaiSan.Text.Trim() == "" && txtTenTaiSan.Text.Trim() == "" && txtNamKhauHao.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng không để trống thông tin khi tìm kiếm");
                return;
            }
            //tìm kiếm và hiển thị dữ liệu tìm kiếm được ra listview
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            string table = "Id" + Id + "LoaiTaiSan";
            string query = "SELECT * FROM " + table + " WHERE 1 = 1";
            if (txtMaLoaiTaiSan.Text.Trim() != "") query += " AND MaLoai LIKE @Ma";
            if (txtTenTaiSan.Text.Trim() != "") query += " AND TenLoai LIKE @Ten";
            if (txtNamKhauHao.Text.Trim() != "") query += " AND ThoiGianTrichKhauHao LIKE @ThoiGianTrich";
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (txtMaLoaiTaiSan.Text.Trim() != "") command.Parameters.AddWithValue("@Ma", txtMaLoaiTaiSan.Text.Trim() + "%");
                if (txtTenTaiSan.Text.Trim() != "") command.Parameters.AddWithValue("@Ten", txtTenTaiSan.Text.Trim() + "%");
                if (txtNamKhauHao.Text.Trim() != "") command.Parameters.AddWithValue("@ThoiGianTrich", txtNamKhauHao.Text.Trim() + "%");
                listView1.Items.Clear();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
            int i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                i = i + 1;
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                listView1.Items.Add(item);
            }
        }
        //sự kiện khi click vào button reset
        private void button4_Click(object sender, EventArgs e)
        {
            Form2_Load(this, EventArgs.Empty);
        }
        //sự kiện khi click chuột phải khi đã bôi đen các hàng trên listview
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    contextMenuStrip1.Show(listView1, e.Location);
                }
            }
        }
        

        //sự kiện khi click vào menuitem xóa các lọại tài sản được chọn
        private void xóaLoạiTàiSảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //xác nhận của người dùng về việc xoá loại tài sản
            DialogResult result = MessageBox.Show("Bạn xác nhận xóa bỏ loại tài sản này, đồng thời các tài sản thuộc loại tài sản này cũng bị xóa bỏ?", "Xác Nhận Xóa Tài Sản", MessageBoxButtons.OKCancel);

            //xóa các loại tài sản, đồng thời cũng xóa các tài sản mang mã loại đấy và thông báo thành công
            if (result == DialogResult.OK)
            {
                string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    string query = "DELETE FROM Id" + Id + "LoaiTaiSan WHERE MaLoai = " + "'" + item.SubItems[1].Text.Trim() + "'";
                    string query2 = "DELETE FROM Id" + Id + "TaiSan WHERE TenLoai = " + "'" + item.SubItems[2].Text.Trim() + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    SqlCommand command2 = new SqlCommand(query2, connection);
                    command2.ExecuteNonQuery();
                    listView1.Items.Remove(item);
                }
                connection.Close();
                MessageBox.Show("Xóa thành công");
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }
            
        }
    }
}
