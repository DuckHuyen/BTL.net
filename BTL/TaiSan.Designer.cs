namespace BTL
{
    partial class TaiSan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMaTaiSan = new System.Windows.Forms.TextBox();
            this.textTenTaiSan = new System.Windows.Forms.TextBox();
            this.txtNguyenGia = new System.Windows.Forms.TextBox();
            this.bttThemTaiSan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bttThongKeTaiSan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDonViThuoc = new System.Windows.Forms.ComboBox();
            this.cbDaKhauHao = new System.Windows.Forms.ComboBox();
            this.bttDieuChuyenTaiSan = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbLoaiTaiSan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bttReset = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaTàiSảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điềuChuyểnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chọnĐơnVịMuốnĐiềuChuyểnSangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.xácNhậnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.FullRowSelect = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView1.Location = new System.Drawing.Point(2, 204);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1343, 469);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số thứ tự";
            this.columnHeader1.Width = 64;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã tài sản";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên tài sản";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 231;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Loại tài sản";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 212;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nguyên giá";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 165;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Đã khấu hao";
            this.columnHeader6.Width = 144;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Giá trị hiện tại";
            this.columnHeader7.Width = 109;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Đơn vị thuộc";
            this.columnHeader8.Width = 128;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ngày nhập";
            this.columnHeader9.Width = 107;
            // 
            // txtMaTaiSan
            // 
            this.txtMaTaiSan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaTaiSan.Location = new System.Drawing.Point(12, 43);
            this.txtMaTaiSan.Name = "txtMaTaiSan";
            this.txtMaTaiSan.Size = new System.Drawing.Size(130, 22);
            this.txtMaTaiSan.TabIndex = 1;
            // 
            // textTenTaiSan
            // 
            this.textTenTaiSan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTenTaiSan.Location = new System.Drawing.Point(176, 43);
            this.textTenTaiSan.Name = "textTenTaiSan";
            this.textTenTaiSan.Size = new System.Drawing.Size(243, 22);
            this.textTenTaiSan.TabIndex = 2;
            this.textTenTaiSan.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNguyenGia
            // 
            this.txtNguyenGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNguyenGia.Location = new System.Drawing.Point(643, 43);
            this.txtNguyenGia.Name = "txtNguyenGia";
            this.txtNguyenGia.Size = new System.Drawing.Size(158, 22);
            this.txtNguyenGia.TabIndex = 3;
            this.txtNguyenGia.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // bttThemTaiSan
            // 
            this.bttThemTaiSan.Location = new System.Drawing.Point(75, 100);
            this.bttThemTaiSan.Name = "bttThemTaiSan";
            this.bttThemTaiSan.Size = new System.Drawing.Size(115, 31);
            this.bttThemTaiSan.TabIndex = 5;
            this.bttThemTaiSan.Text = "Thêm tài sản";
            this.bttThemTaiSan.UseVisualStyleBackColor = true;
            this.bttThemTaiSan.Click += new System.EventHandler(this.button1_Click);
            this.bttThemTaiSan.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.bttThemTaiSan.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thanh lý tài sản";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // bttThongKeTaiSan
            // 
            this.bttThongKeTaiSan.Location = new System.Drawing.Point(243, 100);
            this.bttThongKeTaiSan.Name = "bttThongKeTaiSan";
            this.bttThongKeTaiSan.Size = new System.Drawing.Size(115, 31);
            this.bttThongKeTaiSan.TabIndex = 7;
            this.bttThongKeTaiSan.Text = "Thống kê";
            this.bttThongKeTaiSan.UseVisualStyleBackColor = true;
            this.bttThongKeTaiSan.Click += new System.EventHandler(this.button3_Click);
            this.bttThongKeTaiSan.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.bttThongKeTaiSan.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã tài sản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên tài sản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đơn vị thuộc";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(640, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = " Giá trị nguyên giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(841, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Đã khấu hao";
            // 
            // cbDonViThuoc
            // 
            this.cbDonViThuoc.FormattingEnabled = true;
            this.cbDonViThuoc.Location = new System.Drawing.Point(451, 42);
            this.cbDonViThuoc.Name = "cbDonViThuoc";
            this.cbDonViThuoc.Size = new System.Drawing.Size(158, 24);
            this.cbDonViThuoc.TabIndex = 18;
            this.cbDonViThuoc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbDonViThuoc.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cbDaKhauHao
            // 
            this.cbDaKhauHao.FormattingEnabled = true;
            this.cbDaKhauHao.Items.AddRange(new object[] {
            "Chưa khấu hao"});
            this.cbDaKhauHao.Location = new System.Drawing.Point(844, 42);
            this.cbDaKhauHao.Name = "cbDaKhauHao";
            this.cbDaKhauHao.Size = new System.Drawing.Size(158, 24);
            this.cbDaKhauHao.TabIndex = 19;
            // 
            // bttDieuChuyenTaiSan
            // 
            this.bttDieuChuyenTaiSan.Location = new System.Drawing.Point(811, 99);
            this.bttDieuChuyenTaiSan.Name = "bttDieuChuyenTaiSan";
            this.bttDieuChuyenTaiSan.Size = new System.Drawing.Size(115, 31);
            this.bttDieuChuyenTaiSan.TabIndex = 20;
            this.bttDieuChuyenTaiSan.Text = "Điều chuyển";
            this.bttDieuChuyenTaiSan.UseVisualStyleBackColor = true;
            this.bttDieuChuyenTaiSan.Click += new System.EventHandler(this.button4_Click);
            this.bttDieuChuyenTaiSan.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.bttDieuChuyenTaiSan.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(0, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "BẢNG HIỂN THỊ";
            // 
            // cbLoaiTaiSan
            // 
            this.cbLoaiTaiSan.FormattingEnabled = true;
            this.cbLoaiTaiSan.Items.AddRange(new object[] {
            "Chưa khấu hao"});
            this.cbLoaiTaiSan.Location = new System.Drawing.Point(1059, 43);
            this.cbLoaiTaiSan.Name = "cbLoaiTaiSan";
            this.cbLoaiTaiSan.Size = new System.Drawing.Size(213, 24);
            this.cbLoaiTaiSan.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1056, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Loại tài sản";
            // 
            // bttReset
            // 
            this.bttReset.Location = new System.Drawing.Point(1000, 100);
            this.bttReset.Name = "bttReset";
            this.bttReset.Size = new System.Drawing.Size(115, 31);
            this.bttReset.TabIndex = 24;
            this.bttReset.Text = "Reset";
            this.bttReset.UseVisualStyleBackColor = true;
            this.bttReset.Click += new System.EventHandler(this.button5_Click);
            this.bttReset.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.bttReset.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaTàiSảnToolStripMenuItem,
            this.điềuChuyểnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 52);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // xóaTàiSảnToolStripMenuItem
            // 
            this.xóaTàiSảnToolStripMenuItem.Name = "xóaTàiSảnToolStripMenuItem";
            this.xóaTàiSảnToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.xóaTàiSảnToolStripMenuItem.Text = "Thanh Lý";
            this.xóaTàiSảnToolStripMenuItem.Click += new System.EventHandler(this.xóaTàiSảnToolStripMenuItem_Click);
            // 
            // điềuChuyểnToolStripMenuItem
            // 
            this.điềuChuyểnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chọnĐơnVịMuốnĐiềuChuyểnSangToolStripMenuItem,
            this.toolStripComboBox1,
            this.xácNhậnToolStripMenuItem});
            this.điềuChuyểnToolStripMenuItem.Name = "điềuChuyểnToolStripMenuItem";
            this.điềuChuyểnToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.điềuChuyểnToolStripMenuItem.Text = "Điều Chuyển";
            this.điềuChuyểnToolStripMenuItem.Click += new System.EventHandler(this.điềuChuyểnToolStripMenuItem_Click);
            // 
            // chọnĐơnVịMuốnĐiềuChuyểnSangToolStripMenuItem
            // 
            this.chọnĐơnVịMuốnĐiềuChuyểnSangToolStripMenuItem.Name = "chọnĐơnVịMuốnĐiềuChuyểnSangToolStripMenuItem";
            this.chọnĐơnVịMuốnĐiềuChuyểnSangToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.chọnĐơnVịMuốnĐiềuChuyểnSangToolStripMenuItem.Text = "Chọn đơn vị muốn điều chuyển sang";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // xácNhậnToolStripMenuItem
            // 
            this.xácNhậnToolStripMenuItem.Name = "xácNhậnToolStripMenuItem";
            this.xácNhậnToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.xácNhậnToolStripMenuItem.Text = "Xác Nhận";
            this.xácNhậnToolStripMenuItem.Click += new System.EventHandler(this.xácNhậnToolStripMenuItem_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(589, 101);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(222, 24);
            this.comboBox4.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(586, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Đơn vị muốn điều chuyển";
            // 
            // TaiSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1346, 676);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bttReset);
            this.Controls.Add(this.cbLoaiTaiSan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bttDieuChuyenTaiSan);
            this.Controls.Add(this.cbDaKhauHao);
            this.Controls.Add(this.cbDonViThuoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttThongKeTaiSan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bttThemTaiSan);
            this.Controls.Add(this.txtNguyenGia);
            this.Controls.Add(this.textTenTaiSan);
            this.Controls.Add(this.txtMaTaiSan);
            this.Controls.Add(this.listView1);
            this.Name = "TaiSan";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtMaTaiSan;
        private System.Windows.Forms.TextBox textTenTaiSan;
        private System.Windows.Forms.TextBox txtNguyenGia;
        private System.Windows.Forms.Button bttThemTaiSan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bttThongKeTaiSan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDonViThuoc;
        private System.Windows.Forms.ComboBox cbDaKhauHao;
        private System.Windows.Forms.Button bttDieuChuyenTaiSan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbLoaiTaiSan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button bttReset;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaTàiSảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điềuChuyểnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chọnĐơnVịMuốnĐiềuChuyểnSangToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem xácNhậnToolStripMenuItem;
    }
}