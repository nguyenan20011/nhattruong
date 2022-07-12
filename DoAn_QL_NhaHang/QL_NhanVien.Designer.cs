
namespace DoAn_QL_NhaHang
{
    partial class QL_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_NhanVien));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemLươngNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_themnv = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.cbb_chucvu = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpicker_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbb_gioitinh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDSTKhoan = new System.Windows.Forms.Button();
            this.layoutTimkiem = new System.Windows.Forms.TableLayoutPanel();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnClearFind = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnRaCa = new System.Windows.Forms.Button();
            this.btnVaoCa = new System.Windows.Forms.Button();
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dangNhap1 = new DAO_NhaHang.DangNhap(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox_themnv.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.layoutTimkiem.SuspendLayout();
            this.layoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemLươngNhânViênToolStripMenuItem,
            this.tàiKhoảnNhânViênToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(227, 52);
            // 
            // xemLươngNhânViênToolStripMenuItem
            // 
            this.xemLươngNhânViênToolStripMenuItem.Name = "xemLươngNhânViênToolStripMenuItem";
            this.xemLươngNhânViênToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.xemLươngNhânViênToolStripMenuItem.Text = "Xem Lương Nhân Viên";
            this.xemLươngNhânViênToolStripMenuItem.Click += new System.EventHandler(this.xemLươngNhânViênToolStripMenuItem_Click);
            // 
            // tàiKhoảnNhânViênToolStripMenuItem
            // 
            this.tàiKhoảnNhânViênToolStripMenuItem.Name = "tàiKhoảnNhânViênToolStripMenuItem";
            this.tàiKhoảnNhânViênToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.tàiKhoảnNhânViênToolStripMenuItem.Text = "Tài Khoản Nhân Viên";
            this.tàiKhoảnNhânViênToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnNhânViênToolStripMenuItem_Click);
            // 
            // groupBox_themnv
            // 
            this.groupBox_themnv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_themnv.Controls.Add(this.tableLayoutPanel2);
            this.groupBox_themnv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_themnv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_themnv.Location = new System.Drawing.Point(1408, 3);
            this.groupBox_themnv.Name = "groupBox_themnv";
            this.layoutMain.SetRowSpan(this.groupBox_themnv, 2);
            this.groupBox_themnv.Size = new System.Drawing.Size(299, 728);
            this.groupBox_themnv.TabIndex = 29;
            this.groupBox_themnv.TabStop = false;
            this.groupBox_themnv.Text = "Thêm Nhân Viên";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.txtSdt, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.txtManv, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbb_chucvu, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.txtDiaChi, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.txtHoten, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.dtpicker_ngaysinh, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.cbb_gioitinh, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.btnXoa, 1, 12);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdate, 2, 12);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.txtLuongCB, 0, 11);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 13;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692426F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692426F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692426F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692426F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692426F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692426F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692426F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692426F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692426F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692426F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692426F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.82906F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(302, 702);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // txtSdt
            // 
            this.txtSdt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.txtSdt, 3);
            this.txtSdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.ForeColor = System.Drawing.Color.Silver;
            this.txtSdt.Location = new System.Drawing.Point(3, 381);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(296, 30);
            this.txtSdt.TabIndex = 30;
            this.txtSdt.Text = "Nhập Sđt";
            this.txtSdt.Click += new System.EventHandler(this.txtSdt_Click);
            this.txtSdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSdt_KeyPress);
            this.txtSdt.Leave += new System.EventHandler(this.txtSdt_Leave);
            // 
            // txtManv
            // 
            this.txtManv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.txtManv, 3);
            this.txtManv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManv.ForeColor = System.Drawing.Color.Silver;
            this.txtManv.Location = new System.Drawing.Point(3, 3);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(296, 30);
            this.txtManv.TabIndex = 13;
            this.txtManv.Text = "Nhập MaNV";
            this.txtManv.Click += new System.EventHandler(this.txtManv_Click);
            this.txtManv.Leave += new System.EventHandler(this.txtManv_Leave);
            // 
            // cbb_chucvu
            // 
            this.cbb_chucvu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.cbb_chucvu, 3);
            this.cbb_chucvu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_chucvu.ForeColor = System.Drawing.Color.Black;
            this.cbb_chucvu.FormattingEnabled = true;
            this.cbb_chucvu.Location = new System.Drawing.Point(3, 489);
            this.cbb_chucvu.Name = "cbb_chucvu";
            this.cbb_chucvu.Size = new System.Drawing.Size(296, 31);
            this.cbb_chucvu.TabIndex = 25;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.txtDiaChi, 3);
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.Silver;
            this.txtDiaChi.Location = new System.Drawing.Point(3, 111);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(296, 30);
            this.txtDiaChi.TabIndex = 28;
            this.txtDiaChi.Text = "Nhập Địa Chỉ";
            this.txtDiaChi.Click += new System.EventHandler(this.txtDiaChi_Click);
            this.txtDiaChi.Leave += new System.EventHandler(this.txtDiaChi_Leave);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label8, 3);
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(3, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(296, 54);
            this.label8.TabIndex = 24;
            this.label8.Text = "Chức Vụ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHoten
            // 
            this.txtHoten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.txtHoten, 3);
            this.txtHoten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.ForeColor = System.Drawing.Color.Silver;
            this.txtHoten.Location = new System.Drawing.Point(3, 57);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(296, 30);
            this.txtHoten.TabIndex = 29;
            this.txtHoten.Text = "Nhập Họ Tên";
            this.txtHoten.Click += new System.EventHandler(this.txtHoten_Click);
            this.txtHoten.Leave += new System.EventHandler(this.txtHoten_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label5, 3);
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(3, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 54);
            this.label5.TabIndex = 21;
            this.label5.Text = "Giới Tính";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpicker_ngaysinh
            // 
            this.dtpicker_ngaysinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.dtpicker_ngaysinh, 3);
            this.dtpicker_ngaysinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker_ngaysinh.Location = new System.Drawing.Point(3, 327);
            this.dtpicker_ngaysinh.Name = "dtpicker_ngaysinh";
            this.dtpicker_ngaysinh.Size = new System.Drawing.Size(296, 30);
            this.dtpicker_ngaysinh.TabIndex = 26;
            // 
            // cbb_gioitinh
            // 
            this.cbb_gioitinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.cbb_gioitinh, 3);
            this.cbb_gioitinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_gioitinh.FormattingEnabled = true;
            this.cbb_gioitinh.Location = new System.Drawing.Point(3, 219);
            this.cbb_gioitinh.Name = "cbb_gioitinh";
            this.cbb_gioitinh.Size = new System.Drawing.Size(296, 31);
            this.cbb_gioitinh.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label6, 3);
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(3, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 54);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ngày Sinh";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(10, 635);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 56);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(110, 635);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 56);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(210, 635);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 56);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label2, 3);
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 54);
            this.label2.TabIndex = 31;
            this.label2.Text = "Lương Cơ Bản";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.txtLuongCB, 3);
            this.txtLuongCB.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongCB.ForeColor = System.Drawing.Color.Black;
            this.txtLuongCB.Location = new System.Drawing.Point(3, 597);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(296, 28);
            this.txtLuongCB.TabIndex = 32;
            this.txtLuongCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSdt_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(666, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnDSTKhoan);
            this.groupBox2.Controls.Add(this.layoutTimkiem);
            this.groupBox2.Controls.Add(this.btnRaCa);
            this.groupBox2.Controls.Add(this.btnVaoCa);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.layoutMain.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(199, 728);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Nhân Viên";
            // 
            // btnDSTKhoan
            // 
            this.btnDSTKhoan.AutoSize = true;
            this.btnDSTKhoan.BackColor = System.Drawing.Color.White;
            this.btnDSTKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDSTKhoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDSTKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnDSTKhoan.Image")));
            this.btnDSTKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSTKhoan.Location = new System.Drawing.Point(17, 201);
            this.btnDSTKhoan.Name = "btnDSTKhoan";
            this.btnDSTKhoan.Size = new System.Drawing.Size(166, 44);
            this.btnDSTKhoan.TabIndex = 11;
            this.btnDSTKhoan.Text = "Tài Khoản";
            this.btnDSTKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDSTKhoan.UseVisualStyleBackColor = false;
            this.btnDSTKhoan.Click += new System.EventHandler(this.btnDSTKhoan_Click);
            // 
            // layoutTimkiem
            // 
            this.layoutTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutTimkiem.ColumnCount = 3;
            this.layoutTimkiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.93798F));
            this.layoutTimkiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.06202F));
            this.layoutTimkiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.layoutTimkiem.Controls.Add(this.txtFind, 0, 0);
            this.layoutTimkiem.Controls.Add(this.btnClearFind, 0, 1);
            this.layoutTimkiem.Controls.Add(this.btnFind, 2, 1);
            this.layoutTimkiem.Location = new System.Drawing.Point(0, 41);
            this.layoutTimkiem.Name = "layoutTimkiem";
            this.layoutTimkiem.RowCount = 2;
            this.layoutTimkiem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutTimkiem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutTimkiem.Size = new System.Drawing.Size(193, 116);
            this.layoutTimkiem.TabIndex = 11;
            // 
            // txtFind
            // 
            this.layoutTimkiem.SetColumnSpan(this.txtFind, 3);
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(3, 3);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(187, 28);
            this.txtFind.TabIndex = 1;
            // 
            // btnClearFind
            // 
            this.btnClearFind.BackColor = System.Drawing.Color.White;
            this.btnClearFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearFind.BackgroundImage")));
            this.btnClearFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearFind.Location = new System.Drawing.Point(3, 61);
            this.btnClearFind.Name = "btnClearFind";
            this.btnClearFind.Size = new System.Drawing.Size(57, 44);
            this.btnClearFind.TabIndex = 10;
            this.btnClearFind.UseVisualStyleBackColor = false;
            this.btnClearFind.Click += new System.EventHandler(this.btnClearFind_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.Location = new System.Drawing.Point(124, 61);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(58, 44);
            this.btnFind.TabIndex = 6;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnRaCa
            // 
            this.btnRaCa.BackColor = System.Drawing.Color.DarkRed;
            this.btnRaCa.ForeColor = System.Drawing.Color.White;
            this.btnRaCa.Location = new System.Drawing.Point(52, 346);
            this.btnRaCa.Name = "btnRaCa";
            this.btnRaCa.Size = new System.Drawing.Size(98, 44);
            this.btnRaCa.TabIndex = 13;
            this.btnRaCa.Text = "Ra Ca";
            this.btnRaCa.UseVisualStyleBackColor = false;
            this.btnRaCa.Click += new System.EventHandler(this.btnRaCa_Click);
            // 
            // btnVaoCa
            // 
            this.btnVaoCa.BackColor = System.Drawing.Color.Green;
            this.btnVaoCa.ForeColor = System.Drawing.Color.White;
            this.btnVaoCa.Location = new System.Drawing.Point(52, 299);
            this.btnVaoCa.Name = "btnVaoCa";
            this.btnVaoCa.Size = new System.Drawing.Size(98, 41);
            this.btnVaoCa.TabIndex = 12;
            this.btnVaoCa.Text = "Vào Ca";
            this.btnVaoCa.UseVisualStyleBackColor = false;
            this.btnVaoCa.Click += new System.EventHandler(this.btnVaoCa_Click);
            // 
            // layoutMain
            // 
            this.layoutMain.BackColor = System.Drawing.Color.Transparent;
            this.layoutMain.ColumnCount = 3;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.59754F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.40246F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 304F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutMain.Controls.Add(this.groupBox2, 0, 0);
            this.layoutMain.Controls.Add(this.label1, 1, 0);
            this.layoutMain.Controls.Add(this.groupBox_themnv, 2, 0);
            this.layoutMain.Controls.Add(this.dataGridView1, 1, 1);
            this.layoutMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.layoutMain.Location = new System.Drawing.Point(12, 12);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 2;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.73457F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.26543F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.layoutMain.Size = new System.Drawing.Size(1710, 734);
            this.layoutMain.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(208, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1194, 628);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // QL_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1729, 756);
            this.Controls.Add(this.layoutMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QL_NhanVien";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL_NhanVien";
            this.Load += new System.EventHandler(this.QL_NhanVien_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox_themnv.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.layoutTimkiem.ResumeLayout(false);
            this.layoutTimkiem.PerformLayout();
            this.layoutMain.ResumeLayout(false);
            this.layoutMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xemLươngNhânViênToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnClearFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_themnv;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.ComboBox cbb_chucvu;
        private System.Windows.Forms.DateTimePicker dtpicker_ngaysinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_gioitinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DAO_NhaHang.DangNhap dangNhap1;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel layoutTimkiem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnNhânViênToolStripMenuItem;
        private System.Windows.Forms.Button btnRaCa;
        private System.Windows.Forms.Button btnVaoCa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Button btnDSTKhoan;
    }
}