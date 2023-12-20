namespace BTL
{
    partial class LoaiTaiSan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiTaiSan));
            this.bttTimKiemLoaiTaiSan = new System.Windows.Forms.Button();
            this.bttThemLoaiTaiSan = new System.Windows.Forms.Button();
            this.txtTenTaiSan = new System.Windows.Forms.TextBox();
            this.txtMaLoaiTaiSan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNamKhauHao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bttReset = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaLoạiTàiSảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttTimKiemLoaiTaiSan
            // 
            this.bttTimKiemLoaiTaiSan.Location = new System.Drawing.Point(478, 95);
            this.bttTimKiemLoaiTaiSan.Name = "bttTimKiemLoaiTaiSan";
            this.bttTimKiemLoaiTaiSan.Size = new System.Drawing.Size(130, 33);
            this.bttTimKiemLoaiTaiSan.TabIndex = 13;
            this.bttTimKiemLoaiTaiSan.Text = "Tìm kiếm";
            this.bttTimKiemLoaiTaiSan.UseVisualStyleBackColor = true;
            this.bttTimKiemLoaiTaiSan.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttThemLoaiTaiSan
            // 
            this.bttThemLoaiTaiSan.Location = new System.Drawing.Point(207, 95);
            this.bttThemLoaiTaiSan.Name = "bttThemLoaiTaiSan";
            this.bttThemLoaiTaiSan.Size = new System.Drawing.Size(130, 33);
            this.bttThemLoaiTaiSan.TabIndex = 12;
            this.bttThemLoaiTaiSan.Text = "Thêm loại tài sản";
            this.bttThemLoaiTaiSan.UseVisualStyleBackColor = true;
            this.bttThemLoaiTaiSan.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTenTaiSan
            // 
            this.txtTenTaiSan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenTaiSan.Location = new System.Drawing.Point(593, 28);
            this.txtTenTaiSan.Name = "txtTenTaiSan";
            this.txtTenTaiSan.Size = new System.Drawing.Size(276, 22);
            this.txtTenTaiSan.TabIndex = 11;
            // 
            // txtMaLoaiTaiSan
            // 
            this.txtMaLoaiTaiSan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaLoaiTaiSan.Location = new System.Drawing.Point(146, 26);
            this.txtMaLoaiTaiSan.Name = "txtMaLoaiTaiSan";
            this.txtMaLoaiTaiSan.Size = new System.Drawing.Size(229, 22);
            this.txtMaLoaiTaiSan.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã Loại Tài Sản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên loại Tài Sản";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 162);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1347, 374);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số Thứ Tự";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Loại Tài Sản";
            this.columnHeader2.Width = 203;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Loại Tài Sản";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Năm Trích Khấu Hao";
            this.columnHeader4.Width = 251;
            // 
            // txtNamKhauHao
            // 
            this.txtNamKhauHao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamKhauHao.Location = new System.Drawing.Point(1105, 26);
            this.txtNamKhauHao.Name = "txtNamKhauHao";
            this.txtNamKhauHao.Size = new System.Drawing.Size(97, 22);
            this.txtNamKhauHao.TabIndex = 16;
            this.txtNamKhauHao.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(949, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số năm trích khấu hao";
            // 
            // bttReset
            // 
            this.bttReset.Location = new System.Drawing.Point(791, 95);
            this.bttReset.Name = "bttReset";
            this.bttReset.Size = new System.Drawing.Size(130, 33);
            this.bttReset.TabIndex = 17;
            this.bttReset.Text = "Reset";
            this.bttReset.UseVisualStyleBackColor = true;
            this.bttReset.Click += new System.EventHandler(this.button4_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaLoạiTàiSảnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 28);
            // 
            // xóaLoạiTàiSảnToolStripMenuItem
            // 
            this.xóaLoạiTàiSảnToolStripMenuItem.Name = "xóaLoạiTàiSảnToolStripMenuItem";
            this.xóaLoạiTàiSảnToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.xóaLoạiTàiSảnToolStripMenuItem.Text = "Xóa loại tài sản";
            this.xóaLoạiTàiSảnToolStripMenuItem.Click += new System.EventHandler(this.xóaLoạiTàiSảnToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(1, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "BẢNG HIỂN THỊ";
            // 
            // LoaiTaiSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 532);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bttReset);
            this.Controls.Add(this.txtNamKhauHao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttTimKiemLoaiTaiSan);
            this.Controls.Add(this.bttThemLoaiTaiSan);
            this.Controls.Add(this.txtTenTaiSan);
            this.Controls.Add(this.txtMaLoaiTaiSan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoaiTaiSan";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttTimKiemLoaiTaiSan;
        private System.Windows.Forms.Button bttThemLoaiTaiSan;
        private System.Windows.Forms.TextBox txtTenTaiSan;
        private System.Windows.Forms.TextBox txtMaLoaiTaiSan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtNamKhauHao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button bttReset;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaLoạiTàiSảnToolStripMenuItem;
        private System.Windows.Forms.Label label8;
    }
}