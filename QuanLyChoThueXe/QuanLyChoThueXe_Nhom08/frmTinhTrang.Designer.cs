﻿
namespace QuanLyChoThueXe_Nhom08
{
    partial class frmTinhTrang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTinhTrang));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTinhTrang = new System.Windows.Forms.DataGridView();
            this.MaTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienSoXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DongCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MayLanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguonDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianCapNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbDongCo = new System.Windows.Forms.ComboBox();
            this.cbbMayLanh = new System.Windows.Forms.ComboBox();
            this.cbbCuaXe = new System.Windows.Forms.ComboBox();
            this.dtThoiGianCN = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNguonDien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbbBienSoXe = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTrang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(133)))));
            this.groupBox2.Location = new System.Drawing.Point(55, 483);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 93);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(133)))));
            this.label9.Location = new System.Drawing.Point(1, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nhập thông tin";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(133)))));
            this.btnTimKiem.Location = new System.Drawing.Point(306, 44);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(95, 33);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(133)))));
            this.txtTimKiem.Location = new System.Drawing.Point(153, 46);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(147, 30);
            this.txtTimKiem.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.groupBox3.Controls.Add(this.dgvTinhTrang);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(133)))));
            this.groupBox3.Location = new System.Drawing.Point(478, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(730, 480);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tổng quan";
            // 
            // dgvTinhTrang
            // 
            this.dgvTinhTrang.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dgvTinhTrang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTinhTrang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTinhTrang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.dgvTinhTrang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTinhTrang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTinhTrang,
            this.BienSoXe,
            this.DongCo,
            this.MayLanh,
            this.NguonDien,
            this.CuaXe,
            this.ThoiGianCapNhap});
            this.dgvTinhTrang.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTinhTrang.Location = new System.Drawing.Point(28, 30);
            this.dgvTinhTrang.Name = "dgvTinhTrang";
            this.dgvTinhTrang.RowHeadersWidth = 51;
            this.dgvTinhTrang.Size = new System.Drawing.Size(678, 422);
            this.dgvTinhTrang.TabIndex = 0;
            this.dgvTinhTrang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTinhTrang_CellClick);
            // 
            // MaTinhTrang
            // 
            this.MaTinhTrang.DataPropertyName = "MaTinhTrang";
            this.MaTinhTrang.FillWeight = 4.289774F;
            this.MaTinhTrang.HeaderText = "Mã tình trạng";
            this.MaTinhTrang.MinimumWidth = 6;
            this.MaTinhTrang.Name = "MaTinhTrang";
            // 
            // BienSoXe
            // 
            this.BienSoXe.DataPropertyName = "BienSoXe";
            this.BienSoXe.FillWeight = 6F;
            this.BienSoXe.HeaderText = "Biển số xe";
            this.BienSoXe.MinimumWidth = 6;
            this.BienSoXe.Name = "BienSoXe";
            // 
            // DongCo
            // 
            this.DongCo.DataPropertyName = "DongCo";
            this.DongCo.FillWeight = 2.5F;
            this.DongCo.HeaderText = "Động cơ";
            this.DongCo.MinimumWidth = 6;
            this.DongCo.Name = "DongCo";
            // 
            // MayLanh
            // 
            this.MayLanh.DataPropertyName = "MayLanh";
            this.MayLanh.FillWeight = 2.5F;
            this.MayLanh.HeaderText = "Máy Lạnh";
            this.MayLanh.MinimumWidth = 6;
            this.MayLanh.Name = "MayLanh";
            // 
            // NguonDien
            // 
            this.NguonDien.DataPropertyName = "NguonDien";
            this.NguonDien.FillWeight = 3F;
            this.NguonDien.HeaderText = "Nguồn điện";
            this.NguonDien.MinimumWidth = 6;
            this.NguonDien.Name = "NguonDien";
            // 
            // CuaXe
            // 
            this.CuaXe.DataPropertyName = "CuaXe";
            this.CuaXe.FillWeight = 2.5F;
            this.CuaXe.HeaderText = "Cửa xe";
            this.CuaXe.MinimumWidth = 6;
            this.CuaXe.Name = "CuaXe";
            // 
            // ThoiGianCapNhap
            // 
            this.ThoiGianCapNhap.DataPropertyName = "ThoiGianCapNhap";
            this.ThoiGianCapNhap.FillWeight = 4.313613F;
            this.ThoiGianCapNhap.HeaderText = "Thời gian";
            this.ThoiGianCapNhap.MinimumWidth = 6;
            this.ThoiGianCapNhap.Name = "ThoiGianCapNhap";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(133)))));
            this.groupBox1.Controls.Add(this.cbbBienSoXe);
            this.groupBox1.Controls.Add(this.cbbDongCo);
            this.groupBox1.Controls.Add(this.cbbMayLanh);
            this.groupBox1.Controls.Add(this.cbbCuaXe);
            this.groupBox1.Controls.Add(this.dtThoiGianCN);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNguonDien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtMaTT);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(55, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 372);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbbDongCo
            // 
            this.cbbDongCo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDongCo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(133)))));
            this.cbbDongCo.FormattingEnabled = true;
            this.cbbDongCo.Items.AddRange(new object[] {
            "Tắt",
            "Nổ"});
            this.cbbDongCo.Location = new System.Drawing.Point(186, 117);
            this.cbbDongCo.Margin = new System.Windows.Forms.Padding(2);
            this.cbbDongCo.Name = "cbbDongCo";
            this.cbbDongCo.Size = new System.Drawing.Size(182, 33);
            this.cbbDongCo.TabIndex = 2;
            // 
            // cbbMayLanh
            // 
            this.cbbMayLanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMayLanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(133)))));
            this.cbbMayLanh.FormattingEnabled = true;
            this.cbbMayLanh.Items.AddRange(new object[] {
            "Bật ",
            "Tắt"});
            this.cbbMayLanh.Location = new System.Drawing.Point(186, 154);
            this.cbbMayLanh.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMayLanh.Name = "cbbMayLanh";
            this.cbbMayLanh.Size = new System.Drawing.Size(182, 33);
            this.cbbMayLanh.TabIndex = 3;
            // 
            // cbbCuaXe
            // 
            this.cbbCuaXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCuaXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(133)))));
            this.cbbCuaXe.FormattingEnabled = true;
            this.cbbCuaXe.Items.AddRange(new object[] {
            "Đóng ",
            "Mở"});
            this.cbbCuaXe.Location = new System.Drawing.Point(186, 228);
            this.cbbCuaXe.Margin = new System.Windows.Forms.Padding(2);
            this.cbbCuaXe.Name = "cbbCuaXe";
            this.cbbCuaXe.Size = new System.Drawing.Size(182, 33);
            this.cbbCuaXe.TabIndex = 4;
            // 
            // dtThoiGianCN
            // 
            this.dtThoiGianCN.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(133)))));
            this.dtThoiGianCN.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.dtThoiGianCN.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(133)))));
            this.dtThoiGianCN.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.dtThoiGianCN.CustomFormat = "HH:mm:ss";
            this.dtThoiGianCN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThoiGianCN.Location = new System.Drawing.Point(186, 264);
            this.dtThoiGianCN.Name = "dtThoiGianCN";
            this.dtThoiGianCN.Size = new System.Drawing.Size(182, 30);
            this.dtThoiGianCN.TabIndex = 5;
            this.dtThoiGianCN.Value = new System.DateTime(2021, 11, 13, 0, 36, 20, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Thời gian CN";
            // 
            // txtNguonDien
            // 
            this.txtNguonDien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(133)))));
            this.txtNguonDien.Location = new System.Drawing.Point(186, 190);
            this.txtNguonDien.Name = "txtNguonDien";
            this.txtNguonDien.Size = new System.Drawing.Size(182, 30);
            this.txtNguonDien.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cửa xe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nguồn điện";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(133)))));
            this.btnThem.Location = new System.Drawing.Point(39, 318);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 33);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaTT
            // 
            this.txtMaTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(133)))));
            this.txtMaTT.Location = new System.Drawing.Point(186, 43);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(182, 30);
            this.txtMaTT.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(133)))));
            this.btnReset.Location = new System.Drawing.Point(290, 318);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(76, 33);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Tải lại";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(133)))));
            this.btnXoa.Location = new System.Drawing.Point(208, 318);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 33);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(133)))));
            this.btnSua.Location = new System.Drawing.Point(128, 318);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(71, 33);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã tình trạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Máy lạnh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Động cơ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Biển số xe";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(108)))), ((int)(((byte)(133)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1241, 93);
            this.label1.TabIndex = 15;
            this.label1.Text = "QUẢN LÝ TÌNH TRẠNG XE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.btnThoat.BackgroundImage = global::QuanLyChoThueXe_Nhom08.Properties.Resources.q;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.btnThoat.Location = new System.Drawing.Point(1145, 38);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(63, 50);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbbBienSoXe
            // 
            this.cbbBienSoXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBienSoXe.FormattingEnabled = true;
            this.cbbBienSoXe.Location = new System.Drawing.Point(186, 79);
            this.cbbBienSoXe.Name = "cbbBienSoXe";
            this.cbbBienSoXe.Size = new System.Drawing.Size(182, 33);
            this.cbbBienSoXe.TabIndex = 1;
            // 
            // frmTinhTrang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1241, 610);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTinhTrang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ TÌNH TRẠNG";
            this.Load += new System.EventHandler(this.frmTinhTrang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTrang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvTinhTrang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNguonDien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtThoiGianCN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbbDongCo;
        private System.Windows.Forms.ComboBox cbbMayLanh;
        private System.Windows.Forms.ComboBox cbbCuaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSoXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DongCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MayLanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguonDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianCapNhap;
        private System.Windows.Forms.ComboBox cbbBienSoXe;
    }
}