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
    public partial class DonVi : Form
    {
        //lưu trữ id của người dùng
        public int Id;
        public DonVi()
        {
            InitializeComponent();
        }
        //sự kiện khi click vào button thêm loại tài sản mới
        private void button1_Click(object sender, EventArgs e)
        {
            //xử lý trường hợp để trống
            if (txtMaDonVi.Text.Trim() == "" || txtTenDonVi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng không để trống");
                return;
            }
            //kiểm tra mã đơn vị đã tồn tại hay chưa, nếu rồi thông báo để người dùng nhập lại
            if (User.CheckExists("Id" + Id + "DonVi", "MaDonVi", txtMaDonVi.Text.Trim()) == true)
            {
                MessageBox.Show("Mã đơn vị đã tồn tại, vui lòng đặt bằng mã khác");
                return;
            }
            //kiểm tra tên đơn vị đã tồn tại hay chưa, nếu rồi thông báo để người dùng nhập lại
            if (User.CheckExists("Id" + Id + "DonVi", "TenDonVi", txtTenDonVi.Text.Trim()) == true)
            {
                MessageBox.Show("Tên đơn vị đã tồn tại, vui lòng đặt bằng tên khác");
                return;
            }
            //thêm đơn vị vào cơ sở dữ liệu và thông báo thành công
            User.InsertUnit(Id, txtMaDonVi.Text.Trim(), txtTenDonVi.Text.Trim(),txtQuanLyDonVi.Text.Trim());
            MessageBox.Show("Thêm đơn vị thành công");
            Form1_Load(this, EventArgs.Empty);
        }

        //tải lên dữ liệu đơn vị của người dùng lên listview
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            LoadDataIntoComboBox(Id, toolStripComboBox1.ComboBox, "DonVi", "TenDonVi");
            DataTable dataTable = GetDataFromDatabase();
            int i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                i = i + 1;
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                listView1.Items.Add(item);
            }
        }
        //phương thức trả về bảng đơn vị của người dùng
        private DataTable GetDataFromDatabase()
        {
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            string query = "SELECT * FROM Id" + Id + "DonVi";

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

        //sự kiện khi click vào button tìm kiếm đơn vị
        private void button2_Click(object sender, EventArgs e)
        {
            //xử lý trường hợp để trống
            if (txtMaDonVi.Text.Trim() == "" && txtTenDonVi.Text.Trim() == "" && txtQuanLyDonVi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng không để trống thông tin khi tìm kiếm");
                return;
            }
            //tìm kiếm các đơn vị theo thông tin của người dùng và tải lên listview
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            string table = "Id" + Id + "DonVi";
            string query = "SELECT * FROM " + table + " WHERE 1 = 1";
            if (txtMaDonVi.Text.Trim() != "") query += " AND MaDonVi LIKE @Ma";
            if (txtTenDonVi.Text.Trim() != "") query += " AND TenDonVi LIKE @Ten";
            if (txtQuanLyDonVi.Text.Trim() != "") query += " AND QuanLy LIKE @QuanLy";
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (txtMaDonVi.Text.Trim() != "") command.Parameters.AddWithValue("@Ma", txtMaDonVi.Text.Trim() + "%");
                if (txtTenDonVi.Text.Trim() != "") command.Parameters.AddWithValue("@Ten", txtTenDonVi.Text.Trim() + "%");
                if (txtQuanLyDonVi.Text.Trim() != "") command.Parameters.AddWithValue("@QuanLy", txtQuanLyDonVi.Text.Trim() + "%");
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
                item.SubItems.Add(row[3].ToString());
                listView1.Items.Add(item);
            }
        }

        //sự kiện khi click vào button reset
        private void button5_Click(object sender, EventArgs e)
        {
            Form1_Load(this, EventArgs.Empty);
        }

        //sự kiện khi click chuột phải sau khi đã chọn các hàng trên list view
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //sự kiện khi click chuột phải sau khi đã chọn các hàng trên list view
        private void listView1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    contextMenuStrip1.Show(listView1, e.Location);
                }
            }

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        //sự kiện khi click vào menuitem xóa bỏ các đơn vị được chọn
        private void xôaĐơnVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //xác nhận của người dùng về việc xóa bỏ đơn vị
            DialogResult result = MessageBox.Show("Bạn xác nhận xóa bỏ đơn vị này, đồng thời các tài sản thuộc đơn vị này cũng bị xóa bỏ?", "Xác Nhận Xóa Tài Sản", MessageBoxButtons.OKCancel);

            //xóa bỏ các đơn vị khỏi csdl, đồng thời các tài sản mang mã đơn vị này cũng bị xóa bỏ và thông báo thành công
            if (result == DialogResult.OK)
            {
             
                string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    string query = "DELETE FROM Id" + Id + "DonVi WHERE MaDonVi = " + "'" + item.SubItems[1].Text.Trim() + "'";
                    string query2 = "DELETE FROM Id" + Id + "TaiSan WHERE DonViThuoc = " + "'" + item.SubItems[2].Text.Trim() + "'";
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

        private void điềuChuyểnVàToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //sự kiện khi click và menuitem xóa bỏ dữ liệu của đơn vị được chọn
        private void xóaDữLiệuĐơnVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //xác nhận của người dùng về việc xóa dữ liệu đơn vị
            DialogResult result = MessageBox.Show("Bạn xác nhận xóa tất cả tài sản thuộc đơn vị này?", "Xác Nhận", MessageBoxButtons.OKCancel);

            //xóa bỏ các tài sản mang mã đơn vị của các đơn vị này và thông báo thành công
            if (result == DialogResult.OK)
            {
                string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    string query = "DELETE FROM Id" + Id + "TaiSan WHERE DonViThuoc = " + "'" + item.SubItems[2].Text.Trim() + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
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
        //tải lên dữ liệu các đơn vị lên combobox để người dùng lựa chọn
        private void LoadDataIntoComboBox(int id, ComboBox yourComboBox, string table, string column)
        {
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT " + column + " FROM Id" + id.ToString() + table;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        yourComboBox.Items.Clear();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                yourComboBox.Items.Add(reader[column].ToString());
                            }
                        }
                    }
                }
            }
        }

        // xóa các đơn vị được chọn khỏi combobox điều chuyển để người dùng chọn đơn vị khác
        private void điềuChuyểnVàXóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                toolStripComboBox1.ComboBox.Items.Remove(item.SubItems[2].Text);
            }
        }
        
        //sự kiện khi click vào menustrip điều chuyển và xóa 
        private void điềuChuyểnXóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //xử lý trường hợp để trống
            if(toolStripComboBox1.ComboBox.Text.Trim()=="")
            {
                MessageBox.Show("Vui lòng không được để trống");
                return;
            }
            //xử lý trường hợp người dùng nhập đơn vị không có trên hệ thống 
            if (User.CheckExists("Id" + Id + "DonVi", "TenDonVi", toolStripComboBox1.ComboBox.Text.Trim()) != true)
            {
                MessageBox.Show("Vui lòng nhập đơn vị chuyển giao hợp lệ(phải có trong hệ thống)");
                return;
            }
            //xác nhận của người dùng về việc điều chuyển và xóa
            DialogResult result = MessageBox.Show("Bạn xác nhận điều chuyển tất cả tài sản những đơn vị này sang đơn vị '"+toolStripComboBox1.ComboBox.Text+"' ?", "Xác Nhận", MessageBoxButtons.OKCancel);
            //xóa đơn vị khỏi cơ sở dữ liệu, sau đó điều chuyển các tài sản sang đơn vị được chọn và thông báo thành công 
            if (result == DialogResult.OK)
            {
                string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    string query = "DELETE FROM Id" + Id + "DonVi WHERE MaDonVi = " + "'" + item.SubItems[1].Text.Trim() + "'";
                    string query2 = "UPDATE Id" + Id + "TaiSan SET DonViThuoc = @Donvi WHERE DonViThuoc = @Ten";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    SqlCommand command2 = new SqlCommand(query2, connection);
                    command2.Parameters.AddWithValue("@Donvi", toolStripComboBox1.ComboBox.Text.Trim());
                    command2.Parameters.AddWithValue("@Ten", item.SubItems[2].Text.Trim());
                    command2.ExecuteNonQuery();
                    listView1.Items.Remove(item);
                }
                connection.Close();
                MessageBox.Show("Xóa và điều chuyển thành công");
                toolStripComboBox1.ComboBox.Text = "";
                LoadDataIntoComboBox(Id, toolStripComboBox1.ComboBox, "DonVi", "TenDonVi");
            }
            else if (result == DialogResult.Cancel)
            {
                toolStripComboBox1.ComboBox.Text = "";
                LoadDataIntoComboBox(Id, toolStripComboBox1.ComboBox, "DonVi", "TenDonVi");
                return;
            }

        }
        //xóa dữ liệu combobox để cập nhập dữ liệu mới
        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            toolStripComboBox1.ComboBox.Items.Clear();
        }
    }
}
