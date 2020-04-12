namespace quanlythuesach
{
    partial class frmSachTruyen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtMaLoaiSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_SachTruyen = new System.Windows.Forms.DataGridView();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malinhvuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhaxuatban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mangonngu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giasach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiathue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloaisach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtSoTrang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNgonNgu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMaNhaXB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaTacGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaLinhVuc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiaSach = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDonGiaThue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SachTruyen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(139, 5);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(100, 20);
            this.txtMaSach.TabIndex = 1;
            // 
            // txtMaLoaiSach
            // 
            this.txtMaLoaiSach.Location = new System.Drawing.Point(139, 60);
            this.txtMaLoaiSach.Name = "txtMaLoaiSach";
            this.txtMaLoaiSach.Size = new System.Drawing.Size(100, 20);
            this.txtMaLoaiSach.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Loại Sách";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(139, 31);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(100, 20);
            this.txtTenSach.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên sách";
            // 
            // dataGridView_SachTruyen
            // 
            this.dataGridView_SachTruyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SachTruyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masach,
            this.malinhvuc,
            this.matacgia,
            this.manhaxuatban,
            this.mangonngu,
            this.sotrang,
            this.giasach,
            this.dongiathue,
            this.soluong,
            this.anh,
            this.ghichu,
            this.tensach,
            this.maloaisach});
            this.dataGridView_SachTruyen.Location = new System.Drawing.Point(301, 2);
            this.dataGridView_SachTruyen.Name = "dataGridView_SachTruyen";
            this.dataGridView_SachTruyen.Size = new System.Drawing.Size(423, 132);
            this.dataGridView_SachTruyen.TabIndex = 6;
            this.dataGridView_SachTruyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SachTruyen_CellClick);
            // 
            // masach
            // 
            this.masach.DataPropertyName = "masach";
            this.masach.HeaderText = "Mã sách";
            this.masach.Name = "masach";
            // 
            // malinhvuc
            // 
            this.malinhvuc.DataPropertyName = "malinhvuc";
            this.malinhvuc.HeaderText = "Mã lĩnh vực";
            this.malinhvuc.Name = "malinhvuc";
            // 
            // matacgia
            // 
            this.matacgia.DataPropertyName = "matacgia";
            this.matacgia.HeaderText = "Mã tác giả";
            this.matacgia.Name = "matacgia";
            // 
            // manhaxuatban
            // 
            this.manhaxuatban.DataPropertyName = "manhaxuatban";
            this.manhaxuatban.HeaderText = "Mã nhà xuất bản";
            this.manhaxuatban.Name = "manhaxuatban";
            // 
            // mangonngu
            // 
            this.mangonngu.DataPropertyName = "mangonngu";
            this.mangonngu.HeaderText = "Mã ngôn ngữ";
            this.mangonngu.Name = "mangonngu";
            // 
            // sotrang
            // 
            this.sotrang.DataPropertyName = "sotrang";
            this.sotrang.HeaderText = "Số trang";
            this.sotrang.Name = "sotrang";
            // 
            // giasach
            // 
            this.giasach.DataPropertyName = "giasach";
            this.giasach.HeaderText = "Giá sách";
            this.giasach.Name = "giasach";
            // 
            // dongiathue
            // 
            this.dongiathue.DataPropertyName = "dongiathue";
            this.dongiathue.HeaderText = "Đơn giá thuê";
            this.dongiathue.Name = "dongiathue";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // anh
            // 
            this.anh.DataPropertyName = "anh";
            this.anh.HeaderText = "Ảnh";
            this.anh.Name = "anh";
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.Name = "ghichu";
            // 
            // tensach
            // 
            this.tensach.DataPropertyName = "tensach";
            this.tensach.HeaderText = "Tên sách";
            this.tensach.Name = "tensach";
            // 
            // maloaisach
            // 
            this.maloaisach.DataPropertyName = "maloaisach";
            this.maloaisach.HeaderText = "Mã loại sách";
            this.maloaisach.Name = "maloaisach";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(376, 248);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(495, 248);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(270, 203);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(376, 201);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(495, 201);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(615, 201);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.Location = new System.Drawing.Point(139, 201);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.Size = new System.Drawing.Size(100, 20);
            this.txtSoTrang.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã tác giả";
            // 
            // txtMaNgonNgu
            // 
            this.txtMaNgonNgu.Location = new System.Drawing.Point(139, 168);
            this.txtMaNgonNgu.Name = "txtMaNgonNgu";
            this.txtMaNgonNgu.Size = new System.Drawing.Size(100, 20);
            this.txtMaNgonNgu.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mã lĩnh vực";
            // 
            // TxtMaNhaXB
            // 
            this.TxtMaNhaXB.Location = new System.Drawing.Point(139, 140);
            this.TxtMaNhaXB.Name = "TxtMaNhaXB";
            this.TxtMaNhaXB.Size = new System.Drawing.Size(100, 20);
            this.TxtMaNhaXB.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mã nhà xuất bản";
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.Location = new System.Drawing.Point(139, 114);
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.Size = new System.Drawing.Size(100, 20);
            this.txtMaTacGia.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mã ngôn ngữ";
            // 
            // txtMaLinhVuc
            // 
            this.txtMaLinhVuc.Location = new System.Drawing.Point(139, 88);
            this.txtMaLinhVuc.Name = "txtMaLinhVuc";
            this.txtMaLinhVuc.Size = new System.Drawing.Size(100, 20);
            this.txtMaLinhVuc.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Số trang";
            // 
            // txtGiaSach
            // 
            this.txtGiaSach.Location = new System.Drawing.Point(139, 229);
            this.txtGiaSach.Name = "txtGiaSach";
            this.txtGiaSach.Size = new System.Drawing.Size(100, 20);
            this.txtGiaSach.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Giá sách";
            // 
            // txtDonGiaThue
            // 
            this.txtDonGiaThue.Location = new System.Drawing.Point(139, 255);
            this.txtDonGiaThue.Name = "txtDonGiaThue";
            this.txtDonGiaThue.Size = new System.Drawing.Size(100, 20);
            this.txtDonGiaThue.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Đơn giá thuê";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(139, 281);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Số Lượng";
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(139, 307);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(100, 20);
            this.txtAnh.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(62, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Ảnh";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(139, 333);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(100, 20);
            this.txtGhiChu.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 336);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Ghi chú";
            // 
            // frmSachTruyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 385);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDonGiaThue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtGiaSach);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaLinhVuc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaTacGia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtMaNhaXB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaNgonNgu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoTrang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView_SachTruyen);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaLoaiSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label1);
            this.Name = "frmSachTruyen";
            this.Text = "Sách truyện";
            this.Load += new System.EventHandler(this.frmSachTruyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SachTruyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtMaLoaiSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_SachTruyen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtSoTrang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaNgonNgu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMaNhaXB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaTacGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaLinhVuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGiaSach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDonGiaThue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn malinhvuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn matacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhaxuatban;
        private System.Windows.Forms.DataGridViewTextBoxColumn mangonngu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn giasach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiathue;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaisach;
    }
}