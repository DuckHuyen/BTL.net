using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class Main : Form
    {
        //id dùng để lưu lại id người dùng
        public int Id;
        public Main()
        {
            InitializeComponent();
        }
        //phương thức để xóa form cũ và thêm form mới vào panel chính
        private void AddFormToPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form); 
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        //sự kiện click vào item tài sản
        private void item1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            
            TaiSan f = new TaiSan();
            f.Id = Id;
            AddFormToPanel(f);
        }
        //sự kiện click vào item đơn vị
        private void item2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
           
            DonVi f = new DonVi();
            f.Id = Id;
            AddFormToPanel(f);
        }
        //sự kiện click vào item loại tài sản
        private void item3_Click(object sender, EventArgs e)
        {    
            panel1.Controls.Clear();
            
            LoaiTaiSan f = new LoaiTaiSan();
            f.Id = Id;
            AddFormToPanel(f);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // sự kiện click vào item đăng xuất
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap f = new DangNhap();
            f.ShowDialog();
            this.Close();
        }
        //sự kiện click vào item đổi mật khẩu
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            TaiKhoan f = new TaiKhoan();
            f.Id = Id;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.None;
            panel1.Controls.Add(f);
            f.Show();
        }

        private void item1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void item1_MouseLeave(object sender, EventArgs e)
        {
          
        }
    }
}
