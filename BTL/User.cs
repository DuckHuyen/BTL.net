using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BTL
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Code { get; set; }
        public User(string name, string pass)
        {
            Username = name;
            Password = pass;
            CreatCode();
            CreatAcc();
            CreatId();
            CreatData();
        }
        //Kiểm tra xem code bí mật random đã tồn tại hay chưa
        public bool CheckIfRandomCodeExists(string randomCode)
        {
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            SqlConnection connection = new SqlConnection(connectionString);   
            string query = "SELECT COUNT(*) FROM dbo.Users WHERE Code = @RandomCode";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RandomCode", randomCode);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    connection.Close();
                    return count > 0;
                }
            
        }
        //kiểm tra tên đăng nhập đã tồn tại chưa
        public static bool CheckIfUserNameExists(string Username)
        {
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);
            connection.Open();
            int count = (int)command.ExecuteScalar();
            connection.Close();
            return count > 0;
        }
        //Phương thức thuộc lớp dùng để kiểm tra 1 biến var đã tồn tại ở cột colum trong bảng tablename chưa, nếu tồn tại trả về true
        public static bool CheckExists(string TableName ,string Colum , string Var)
        {
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT COUNT(*) FROM "+TableName+" WHERE "+Colum+" = @Var";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Var", Var);
            connection.Open();
            int count = (int)command.ExecuteScalar();
            connection.Close();
            return count > 0;
        }
        public  Random random = new Random();
        //phương thức tạo code bí mật
        public void CreatCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder randomCode = new StringBuilder(12);
            for (int i = 0; i < 12; i++)
            {
                randomCode.Append(chars[random.Next(chars.Length)]);
            }
            while (CheckIfRandomCodeExists(randomCode.ToString()) == true)
            {
                for (int i = 0; i < 12; i++)
                {
                    randomCode.Append(chars[random.Next(chars.Length)]);
                }
            }
            Code = randomCode.ToString();

        }
        /// <summary>
        /// insert 1 row account của người dùng vào cơ sở dữ liệu
        /// </summary>
        public void CreatAcc()
        {
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO Users (Username, Password, Code) VALUES (@Username, @Password, @Code)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@Code", Code);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        /// <summary>
        ///insert 1 row loại tài sản của người dùng vào cơ sở dữ liệu 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="maLoaiTaiSan"></param>
        /// <param name="tenLoaiTaiSan"></param>
        /// <param name="soNamTrichKhauHao"></param>
        public static  void InsertAssetsType(int id,string maLoaiTaiSan, string tenLoaiTaiSan, int soNamTrichKhauHao)
        {
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO Id"+id.ToString()+"LoaiTaiSan (MaLoai,TenLoai,ThoiGianTrichKhauHao) VALUES (@Ma, @Ten, @Nam)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Ma", maLoaiTaiSan);
                command.Parameters.AddWithValue("@Ten", tenLoaiTaiSan);
                command.Parameters.AddWithValue("@Nam", soNamTrichKhauHao);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        /// <summary>
        /// insert 1 tài sản người dùng nhập vào cơ sở dữ liệu
        /// </summary>
        /// <param name="id"></param>
        /// <param name="maTaiSan"></param>
        /// <param name="tenTaiSan"></param>
        /// <param name="donViThuoc"></param>
        /// <param name="nguyenGia"></param>
        /// <param name="khauHao"></param>
        /// <param name="tenLoai"></param>
        public static void InsertAssets(int id, string maTaiSan, string tenTaiSan, string donViThuoc,long nguyenGia,long khauHao, string tenLoai)
        {
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            SqlConnection connection = new SqlConnection(connectionString);
            string query0 = "SELECT ThoiGianTrichKhauHao FROM Id"+id+"LoaiTaiSan WHERE TenLoai = @tenLoai;";
            SqlCommand command0 = new SqlCommand(query0, connection);
            command0.Parameters.AddWithValue("@tenLoai", tenLoai);
            connection.Open();
            int namKH = (int)command0.ExecuteScalar();
            connection.Close();

            string query = "INSERT INTO Id" + id.ToString() + "TaiSan (MaTaiSan,TenTaiSan,NguyenGiaTaiSan,KhauHao,DonViThuoc,TenLoai,NgayNhap,SoNamKhauHao) VALUES (@Ma, @Ten, @Gia,@Hao,@Thuoc,@Loai,@Ngay,@Nam)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Ma", maTaiSan);
                command.Parameters.AddWithValue("@Ten", tenTaiSan);
                command.Parameters.AddWithValue("@Gia", nguyenGia);
                command.Parameters.AddWithValue("@Hao", khauHao);
                command.Parameters.AddWithValue("@Thuoc", donViThuoc);
                command.Parameters.AddWithValue("@Loai", tenLoai);
                command.Parameters.AddWithValue("@Ngay", DateTime.Now.ToString("dd-MM-yyyy"));
                command.Parameters.AddWithValue("@Nam", namKH);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        /// <summary>
        /// insert 1 đơn vị người dùng nhập vào cơ sở dữ liệu
        /// </summary>
        /// <param name="id"></param>
        /// <param name="maDonVi"></param>
        /// <param name="tenDonVi"></param>
        /// <param name="QuanLy"></param>
        public static void InsertUnit(int id, string maDonVi, string tenDonVi, string QuanLy)
        {
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO Id" + id.ToString() + "DonVi (MaDonVi,TenDonVi,QuanLy,NgayTao) VALUES (@Ma, @Ten,@Chu,@Ngay)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Ma", maDonVi);
                command.Parameters.AddWithValue("@Ten", tenDonVi);
                command.Parameters.AddWithValue("@Chu", QuanLy);
                command.Parameters.AddWithValue("@Ngay", DateTime.Now.ToString("dd-MM-yyyy"));
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        /// <summary>
        /// Lấy số id trên cơ sở dữ liệu dùng để tạo data ngay khi khởi tạo 1 user
        /// </summary>
        public void CreatId()
        {
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT UserID FROM Users WHERE Username = @Username";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", Username);
                connection.Open();
                Id = (int)command.ExecuteScalar();
                connection.Close();
            }
        }
        /* Tạo data trên csdl bao gồm 3 bảng TaiSan, DonVi và LoaiTaiSan được đặt tên theo cấu trúc "Id"+id+ tên bảng, 
         * khi đăng nhập vào thì ta sẽ truy cập vào id acc đó
         * */
        public void CreatData()
        {
            string connectionString = "Data Source=DUCKHUYEN;Initial Catalog=QLTS;User ID=sa;Password=123;";
            SqlConnection connection = new SqlConnection(connectionString);
            string LoaiTaiSan ="Id"+Id.ToString()+ "LoaiTaiSan";
            string TaiSan = "Id" + Id.ToString() + "TaiSan";
            string DonVi = "Id" + Id.ToString() + "DonVi";
            string query = string.Format(@"
CREATE TABLE {0} (
    MaLoai VARCHAR(100) PRIMARY KEY,
    TenLoai NVARCHAR(100),
    ThoiGianTrichKhauHao INT
);
CREATE TABLE {2} (
    MaDonVi VARCHAR(100),
    TenDonVi NVARCHAR(100) ,
    QuanLy NVARCHAR(100),
    NgayTao VARCHAR(10) );
CREATE TABLE {1} (
    MaTaiSan VARCHAR(100) PRIMARY KEY,
    TenTaiSan NVARCHAR(100),
    NguyenGiaTaiSan BIGINT,
    KhauHao BIGINT,
    DonViThuoc NVARCHAR(100),
    TenLoai NVARCHAR(100),
    NgayNhap VARCHAR(10),
    SoNamKhauHao INT,
);", LoaiTaiSan, TaiSan, DonVi);
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        
    }

}
