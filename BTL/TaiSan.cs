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
    public partial class TaiSan : Form
    {
        //id dùng để lưu id người dùng
        public int Id;
        public TaiSan()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        // sự kiện thống kê tài sản
        private void button3_Click(object sender, EventArgs e)
        {
           //khấu hao sẽ không được dùng để thống kê
            if (cbDaKhauHao.Text.Trim() != "")
            {
                MessageBox.Show("\"Đã khấu hao\" không dùng để thống kê tài sản, vui lòng để trống");
                return;
            }

            if (txtMaTaiSan.Text.Trim() == "" &&textTenTaiSan.Text.Trim() == "" && txtNguyenGia.Text.Trim() == "" && cbDonViThuoc.Text.Trim() == ""&& cbLoaiTaiSan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng không để trống thông tin khi thống kê tài sản");
                return;
            }
            //thống kê tài sản theo các giá trị người dùng nhập
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            string table = "Id" + Id + "TaiSan";
            string query = "SELECT * FROM "+table+" WHERE 1 = 1";

            if (txtMaTaiSan.Text.Trim() != "") query += " AND MaTaiSan LIKE @MaTaiSan";
            if (textTenTaiSan.Text.Trim() != "") query += " AND TenTaiSan LIKE @TenTaiSan";
            if (cbDonViThuoc.Text.Trim() != "") query += " AND DonViThuoc LIKE @DonViThuoc";
            if (txtNguyenGia.Text.Trim() != "") query += " AND NguyenGiaTaiSan LIKE @NguyenGiaTaiSan";
            if (cbLoaiTaiSan.Text.Trim() != "") query += " AND TenLoai LIKE @TenLoai";
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (txtMaTaiSan.Text.Trim() != "") command.Parameters.AddWithValue("@MaTaiSan", txtMaTaiSan.Text.Trim() + "%");
                if (textTenTaiSan.Text.Trim() != "") command.Parameters.AddWithValue("@TenTaiSan", textTenTaiSan.Text.Trim() + "%");
                if (cbDonViThuoc.Text.Trim() != "") command.Parameters.AddWithValue("@DonViThuoc", cbDonViThuoc.Text.Trim() + "%");
                if (txtNguyenGia.Text.Trim() != "") command.Parameters.AddWithValue("@NguyenGiaTaiSan", txtNguyenGia.Text.Trim() + "%");
                if (cbLoaiTaiSan.Text.Trim() != "") command.Parameters.AddWithValue("@TenLoai", cbLoaiTaiSan.Text.Trim() + "%");

                listView1.Items.Clear();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
            //hiển thị bảng sau khi đã thống kê
            int i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                i = i + 1;
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[5].ToString());
                DateTime currentDate = DateTime.Now;
                string time = row[6].ToString();
                DateTime sqlDate;
                int monthsDiff = 0;
                DateTime.TryParseExact(time, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out sqlDate);
                monthsDiff = (currentDate.Year - sqlDate.Year) * 12 + currentDate.Month - sqlDate.Month;
                int khauHao = int.Parse(row[3].ToString()) + monthsDiff * ((int.Parse(row[2].ToString()) / int.Parse(row[7].ToString())) / 12);
                if (khauHao > int.Parse(row[2].ToString())) khauHao = int.Parse(row[2].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(khauHao.ToString());
                item.SubItems.Add((int.Parse(row[2].ToString()) - khauHao).ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[6].ToString());
                listView1.Items.Add(item);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //load các đơn vị , loại tài sản vào combo box để người dùng có thể lựa chọn
        private void LoadDataIntoComboBox(int id,ComboBox yourComboBox,string table,string column)
        {
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT "+column+" FROM Id"+id.ToString()+table;
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

        //tải lên các dữ liệu cần thiết
        private void Form4_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox(Id, cbDonViThuoc, "DonVi", "TenDonVi");
            LoadDataIntoComboBox(Id, toolStripComboBox1.ComboBox, "DonVi", "TenDonVi");
            LoadDataIntoComboBox(Id, comboBox4, "DonVi", "TenDonVi");
            LoadDataIntoComboBox(Id, cbLoaiTaiSan, "LoaiTaiSan", "TenLoai");
            listView1.Items.Clear();
            DataTable dataTable = GetDataFromDatabase();
            int i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                i = i + 1;
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[5].ToString());
                DateTime currentDate = DateTime.Now;
                string time = row[6].ToString();
                DateTime sqlDate;
                int monthsDiff = 0;
                DateTime.TryParseExact(time, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out sqlDate);
                monthsDiff = (currentDate.Year - sqlDate.Year) * 12 + currentDate.Month - sqlDate.Month;
                int khauHao = int.Parse(row[3].ToString()) + monthsDiff * ((int.Parse(row[2].ToString()) / int.Parse(row[7].ToString()))/12);
                if(khauHao>int.Parse(row[2].ToString())) khauHao = int.Parse(row[2].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(khauHao.ToString());
                item.SubItems.Add((int.Parse(row[2].ToString())-khauHao).ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[6].ToString());
                listView1.Items.Add(item);
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //điều chuyển tài sản trong bảng hiển thị
        private void button4_Click(object sender, EventArgs e)
        {
            //xử lý trường hợp để trống
            if (comboBox4.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng không để trống");
                return;
            }
            //xác nhận người dùng có chắc chắn điều chuyển hay không
            DialogResult result = MessageBox.Show("Bạn xác nhận điều chuyển tất cả tài sản trong bảng hiển thị?", "Xác Nhận Điều Chuyển", MessageBoxButtons.OKCancel);
            //kiểm tra loại tài sản người dùng nhập có tồn tại trong hệ thống không, nếu không thông báo đẻ người dùng nhập lại
            if (User.CheckExists("Id" + Id + "DonVi", "TenDonVi", comboBox4.Text.Trim()) == false)
            {
                MessageBox.Show("Đơn vị \"" + comboBox4.Text.Trim() + "\" không tồn tại, vui lòng nhập đúng đơn vị có sẵn hoặc thêm đơn vị mới");
                return;
            }
            if (result == DialogResult.OK)
            {
                //điều chuyển tất cả tài sản ở bảng hiển thị sang đơn vị mà người dùng lựa chọn
                string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                foreach (ListViewItem item in listView1.Items)
                {
                    string query = "UPDATE Id" + Id + "TaiSan SET DonViThuoc = @Donvi WHERE MaTaiSan = @Ma";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Donvi", comboBox4.Text.Trim());
                    command.Parameters.AddWithValue("@Ma", item.SubItems[1].Text.Trim());
                    command.ExecuteNonQuery();
                    item.SubItems[7].Text = comboBox4.Text.Trim();
                }
                connection.Close();
                //thông báo thành công
                MessageBox.Show("Điều chuyển thành công");
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        //sự kiện click vào button thêm tài sản
        private void button1_Click(object sender, EventArgs e)
        {
            //kiểm tra kiểu dữ liệu của nguyên giá và khấu hao
            try
            {
                long a = long.Parse(txtNguyenGia.Text.Trim());
                if (cbDaKhauHao.Text.Trim() != "Chưa khấu hao")
                {
                    long b = long.Parse(cbDaKhauHao.Text.Trim());
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập giá trị nguyên giá và khấu hao hợp lệ(kiểu số nguyên)");
                return;
            }
            //xử lý trường hợp để trống
            if (txtMaTaiSan.Text.Trim()==""|| textTenTaiSan.Text.Trim()==""|| txtNguyenGia.Text.Trim()==""|| cbDonViThuoc.Text.Trim()==""|| cbDaKhauHao.Text.Trim()==""|| cbLoaiTaiSan.Text.Trim()=="")
            {
                MessageBox.Show("Vui lòng không để trống thông tin khi thêm tài sản");
                return;
            }
            //kiểm tra mã tài sản tồn tại hay chưa, nếu tồn tại thông báo để người dùng nhập lại
            if (User.CheckExists("Id" + Id + "TaiSan", "MaTaiSan", txtMaTaiSan.Text.Trim()) == true)
            {
                MessageBox.Show("Mã tài sản này đã tồn tại, vui lòng nhập mã khác");
                return;
            }
            //kiểm tra loại tài sản người dùng nhập có tồn tại trong hệ thống không, nếu không thông báo đẻ người dùng nhập lại
            if (User.CheckExists("Id" + Id + "LoaiTaiSan", "TenLoai", cbLoaiTaiSan.Text.Trim()) == false)
            {
                MessageBox.Show("Loại tài sản \"" + cbLoaiTaiSan.Text.Trim() + "\" không tồn tại, vui lòng nhập đúng loại tài sản có sẵn hoặc thêm loại tài sản mới");
                return;
            }
            //kiểm tra đơn vị người dùng nhập có tồn tại trong hệ thống hay không, nếu không thông báo để người dùng nhập lại
            if (User.CheckExists("Id" + Id + "DonVi", "TenDonVi", cbDonViThuoc.Text.Trim()) == false)
            {
                MessageBox.Show("Đơn vị \""+cbDonViThuoc.Text.Trim()+"\" không tồn tại, vui lòng chọn đơn vị phù hợp hoặc thêm đơn vị mới");
                return;
            }
            //nế giá trị khấu hao là chưa khấu hao thì sẽ mặc định là 0
            if (cbDaKhauHao.Text == "Chưa khấu hao")
            {
                User.InsertAssets(Id, txtMaTaiSan.Text, textTenTaiSan.Text, cbDonViThuoc.Text, long.Parse(txtNguyenGia.Text.Trim()),0, cbLoaiTaiSan.Text.Trim());
                MessageBox.Show("Thêm tài sản thành công");
                Form4_Load(this, EventArgs.Empty);
                return;
            }
            //thêm tài sản vào cơ sở dữ liệu và thông báo thành công
            User.InsertAssets(Id, txtMaTaiSan.Text, textTenTaiSan.Text, cbDonViThuoc.Text, long.Parse(txtNguyenGia.Text.Trim()), long.Parse(cbDaKhauHao.Text.Trim()), cbLoaiTaiSan.Text.Trim());
            MessageBox.Show("Thêm tài sản thành công");
            Form4_Load(this, EventArgs.Empty);
            
        }
        //phương thức để lấy dữ liệu từ sql
        private DataTable GetDataFromDatabase()
        {
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            string query = "SELECT * FROM Id"+Id+"TaiSan";

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
                connection.Close();
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        // sự kiện khi click vào button reset
        private void button5_Click(object sender, EventArgs e)
        {
            Form4_Load(this, EventArgs.Empty);
        }

        //sự kiện khi đã lựa chọn hàng và click chuột phải ở listview
        private void ListView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    contextMenuStrip1.Show(listView1, e.Location);
                }
            }
        }
        //sự kiện khi đã lựa chọn hàng và click chuột phải ở listview
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
        //sự kiện thanh lý những tài sản mà người dùng đã chọn
        private void xóaTàiSảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //xác nhận của người dùng về việc thanh lý tài sản 
            DialogResult result = MessageBox.Show("Bạn xác nhận thanh lý tất cả tài sản được chọn?", "Xác Nhận Thanh Lý", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                //xóa tài sản khỏi cơ sở dữ liệu
                string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    string query = "DELETE FROM Id" + Id + "TaiSan WHERE MaTaiSan = " + "'" + item.SubItems[1].Text.Trim() + "'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    listView1.Items.Remove(item);
                }
                connection.Close();
                //xóa và thông báo thành công
                MessageBox.Show("Thanh lý thành công");
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }
            
        }

        //sự kiện khi click vào button thanh lý tất cả tài sản trong bảng hiển thọ
        private void button2_Click(object sender, EventArgs e)
        {
            //xác nhận của người dùng về việc thanh lý tài sản
            DialogResult result = MessageBox.Show("Bạn xác nhận thanh lý tất cả tài sản trong bảng hiển thị?", "Xác Nhận Thanh Lý", MessageBoxButtons.OKCancel);
            //xóa tài sản khỏi cơ sở dữ liệu và thông báo thành công
            if (result == DialogResult.OK)
            {
                string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();
                foreach (ListViewItem item in listView1.Items)
                {
                    string query = "DELETE FROM Id" + Id + "TaiSan WHERE MaTaiSan = " + "'" + item.SubItems[1].Text.Trim() + "'";
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

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void điềuChuyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void điềuChuyểnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
        //sự kiện khi click vào button điều chuyển tài sản được chọn
        private void xácNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //xử lý trường hợp để trống
            if (toolStripComboBox1.ComboBox.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng không để trống");
                return;
            }
            //xác nhận của người dùng về việc điều chuyển tài sản 
            DialogResult result = MessageBox.Show("Bạn xác nhận điều chuyển tất cả tài sản được chọn?", "Xác Nhận Điều Chuyển", MessageBoxButtons.OKCancel);
            //điều chuyển và thông báo thành công
            if (result == DialogResult.OK)
            {
                string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    string query = "UPDATE Id" + Id + "TaiSan SET DonViThuoc = @Donvi WHERE MaTaiSan = @Ma";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Donvi", toolStripComboBox1.ComboBox.Text.Trim());
                    command.Parameters.AddWithValue("@Ma", item.SubItems[1].Text.Trim());
                    command.ExecuteNonQuery();
                    item.SubItems[7].Text = toolStripComboBox1.ComboBox.Text.Trim();
                }
                connection.Close();
                MessageBox.Show("Điều chuyển thành công");
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }
            
        }

        
    }
}
