namespace BTL
{
    partial class DonVi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonVi));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDonVi = new System.Windows.Forms.TextBox();
            this.txtTenDonVi = new System.Windows.Forms.TextBox();
            this.bttTaoDonVi = new System.Windows.Forms.Button();
            this.bttTimKiemDonVi = new System.Windows.Forms.Button();
            this.txtQuanLyDonVi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bttReset = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xôaĐơnVịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaDữLiệuĐơnVịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điềuChuyểnVàXóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chọnĐơnVịMuốnĐiềuChuyểnSangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.điềuChuyểnXóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(-3, 186);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1347, 370);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số thứ tự";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Đơn Vị";
            this.columnHeader2.Width = 192;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Đơn Vị";
            this.columnHeader3.Width = 263;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quản Lý Đơn Vị";
            this.columnHeader4.Width = 279;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày Thành Lập";
            this.columnHeader5.Width = 272;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Đơn Vị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Đơn Vị";
            // 
            // txtMaDonVi
            // 
            this.txtMaDonVi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDonVi.Location = new System.Drawing.Point(204, 9);
            this.txtMaDonVi.Name = "txtMaDonVi";
            this.txtMaDonVi.Size = new System.Drawing.Size(229, 22);
            this.txtMaDonVi.TabIndex = 3;
            // 
            // txtTenDonVi
            // 
            this.txtTenDonVi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDonVi.Location = new System.Drawing.Point(204, 54);
            this.txtTenDonVi.Name = "txtTenDonVi";
            this.txtTenDonVi.Size = new System.Drawing.Size(276, 22);
            this.txtTenDonVi.TabIndex = 4;
            // 
            // bttTaoDonVi
            // 
            this.bttTaoDonVi.Location = new System.Drawing.Point(92, 53);
            this.bttTaoDonVi.Name = "bttTaoDonVi";
            this.bttTaoDonVi.Size = new System.Drawing.Size(130, 33);
            this.bttTaoDonVi.TabIndex = 5;
            this.bttTaoDonVi.Text = "Tạo đơn vị";
            this.bttTaoDonVi.UseVisualStyleBackColor = true;
            this.bttTaoDonVi.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttTimKiemDonVi
            // 
            this.bttTimKiemDonVi.Location = new System.Drawing.Point(293, 53);
            this.bttTimKiemDonVi.Name = "bttTimKiemDonVi";
            this.bttTimKiemDonVi.Size = new System.Drawing.Size(130, 33);
            this.bttTimKiemDonVi.TabIndex = 6;
            this.bttTimKiemDonVi.Text = "Tìm kiếm";
            this.bttTimKiemDonVi.UseVisualStyleBackColor = true;
            this.bttTimKiemDonVi.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtQuanLyDonVi
            // 
            this.txtQuanLyDonVi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuanLyDonVi.Location = new System.Drawing.Point(204, 104);
            this.txtQuanLyDonVi.Name = "txtQuanLyDonVi";
            this.txtQuanLyDonVi.Size = new System.Drawing.Size(276, 22);
            this.txtQuanLyDonVi.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chủ đơn vị";
            // 
            // bttReset
            // 
            this.bttReset.Location = new System.Drawing.Point(493, 53);
            this.bttReset.Name = "bttReset";
            this.bttReset.Size = new System.Drawing.Size(130, 33);
            this.bttReset.TabIndex = 14;
            this.bttReset.Text = "Reset";
            this.bttReset.UseVisualStyleBackColor = true;
            this.bttReset.Click += new System.EventHandler(this.button5_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xôaĐơnVịToolStripMenuItem,
            this.xóaDữLiệuĐơnVịToolStripMenuItem,
            this.điềuChuyểnVàXóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(207, 76);
            this.contextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
            // 
            // xôaĐơnVịToolStripMenuItem
            // 
            this.xôaĐơnVịToolStripMenuItem.Name = "xôaĐơnVịToolStripMenuItem";
            this.xôaĐơnVịToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.xôaĐơnVịToolStripMenuItem.Text = "Xôa đơn vị";
            this.xôaĐơnVịToolStripMenuItem.Click += new System.EventHandler(this.xôaĐơnVịToolStripMenuItem_Click);
            // 
            // xóaDữLiệuĐơnVịToolStripMenuItem
            // 
            this.xóaDữLiệuĐơnVịToolStripMenuItem.Name = "xóaDữLiệuĐơnVịToolStripMenuItem";
            this.xóaDữLiệuĐơnVịToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.xóaDữLiệuĐơnVịToolStripMenuItem.Text = "Xóa dữ liệu đơn vị";
            this.xóaDữLiệuĐơnVịToolStripMenuItem.Click += new System.EventHandler(this.xóaDữLiệuĐơnVịToolStripMenuItem_Click);
            // 
            // điềuChuyểnVàXóaToolStripMenuItem
            // 
            this.điềuChuyểnVàXóaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chọnĐơnVịMuốnĐiềuChuyểnSangToolStripMenuItem,
            this.toolStripComboBox1,
            this.điềuChuyểnXóaToolStripMenuItem});
            this.điềuChuyểnVàXóaToolStripMenuItem.Name = "điềuChuyểnVàXóaToolStripMenuItem";
            this.điềuChuyểnVàXóaToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.điềuChuyểnVàXóaToolStripMenuItem.Text = "Điều chuyển và xóa";
            this.điềuChuyểnVàXóaToolStripMenuItem.Click += new System.EventHandler(this.điềuChuyểnVàXóaToolStripMenuItem_Click);
            // 
            // chọnĐơnVịMuốnĐiềuChuyểnSangToolStripMenuItem
            // 
            this.chọnĐơnVịMuốnĐiềuChuyểnSangToolStripMenuItem.Name = "chọnĐơnVịMuốnĐiềuChuyểnSangToolStripMenuItem";
            this.chọnĐơnVịMuốnĐiềuChuyểnSangToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.chọnĐơnVịMuốnĐiềuChuyểnSangToolStripMenuItem.Text = "Chọn đơn vị muốn điều chuyển sang";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // điềuChuyểnXóaToolStripMenuItem
            // 
            this.điềuChuyểnXóaToolStripMenuItem.Name = "điềuChuyểnXóaToolStripMenuItem";
            this.điềuChuyểnXóaToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.điềuChuyểnXóaToolStripMenuItem.Text = "Điều chuyển + Xóa";
            this.điềuChuyểnXóaToolStripMenuItem.Click += new System.EventHandler(this.điềuChuyểnXóaToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(-1, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "BẢNG HIỂN THỊ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtQuanLyDonVi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTenDonVi);
            this.panel1.Controls.Add(this.txtMaDonVi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 144);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bttReset);
            this.panel2.Controls.Add(this.bttTimKiemDonVi);
            this.panel2.Controls.Add(this.bttTaoDonVi);
            this.panel2.Location = new System.Drawing.Point(559, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 146);
            this.panel2.TabIndex = 24;
            // 
            // DonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1346, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DonVi";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDonVi;
        private System.Windows.Forms.TextBox txtTenDonVi;
        private System.Windows.Forms.Button bttTaoDonVi;
        private System.Windows.Forms.Button bttTimKiemDonVi;
        private System.Windows.Forms.TextBox txtQuanLyDonVi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button bttReset;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xôaĐơnVịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaDữLiệuĐơnVịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điềuChuyểnVàXóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chọnĐơnVịMuốnĐiềuChuyểnSangToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem điềuChuyểnXóaToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}