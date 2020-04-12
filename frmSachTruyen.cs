using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace quanlythuesach
{
    public partial class frmSachTruyen : Form
    {
        SqlConnection con = new SqlConnection();
        public frmSachTruyen()
        {
            InitializeComponent();
        }
        private void frmSachTruyen_Load(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-1K4VPR0\\SQLEXPRESS;Initial Catalog=cuahangchothuesach;Integrated Security=True";
            con.ConnectionString = connectionstring;
            con.Open();
            loaddatagridview();
        }
        private void loaddatagridview()
        {
            string sql = "select * from sachtruyen";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tablesachtruyen = new DataTable();
            adp.Fill(tablesachtruyen);
            dataGridView_SachTruyen.DataSource = tablesachtruyen;
        }
        private void dataGridView_SachTruyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach.Text = dataGridView_SachTruyen.CurrentRow.Cells["masach"].Value.ToString();
            txtTenSach.Text = dataGridView_SachTruyen.CurrentRow.Cells["tensach"].Value.ToString();
            txtMaLoaiSach.Text = dataGridView_SachTruyen.CurrentRow.Cells["maloaisach"].Value.ToString();
            txtAnh.Text = dataGridView_SachTruyen.CurrentRow.Cells["anh"].Value.ToString();
            txtDonGiaThue.Text = dataGridView_SachTruyen.CurrentRow.Cells["dongiathue"].Value.ToString();
            txtGhiChu.Text = dataGridView_SachTruyen.CurrentRow.Cells["ghichu"].Value.ToString();
            txtGiaSach.Text = dataGridView_SachTruyen.CurrentRow.Cells["giasach"].Value.ToString();
            txtMaLinhVuc.Text = dataGridView_SachTruyen.CurrentRow.Cells["malinhvuc"].Value.ToString();
            txtMaNgonNgu.Text = dataGridView_SachTruyen.CurrentRow.Cells["mangonngu"].Value.ToString();
            TxtMaNhaXB.Text = dataGridView_SachTruyen.CurrentRow.Cells["manhaxuatban"].Value.ToString();
            txtMaTacGia.Text = dataGridView_SachTruyen.CurrentRow.Cells["matacgia"].Value.ToString();
            txtSoLuong.Text = dataGridView_SachTruyen.CurrentRow.Cells["soluong"].Value.ToString();
            txtSoTrang.Text = dataGridView_SachTruyen.CurrentRow.Cells["sotrang"].Value.ToString();
            txtMaSach.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtMaLoaiSach.Text = "";
            txtAnh.Text = "";
            txtDonGiaThue.Text = "";
            txtGhiChu.Text = "";
            txtGiaSach.Text = "";
            txtMaLinhVuc.Text = "";
            txtMaNgonNgu.Text = "";
            TxtMaNhaXB.Text = "";
            txtMaTacGia.Text = "";
            txtSoLuong.Text = "";
            txtSoTrang.Text = "";
            txtMaSach.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from sachtruyen where masach = '" + txtMaSach.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            loaddatagridview();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên sách");
                txtTenSach.Focus();
                return;
            }
            if (txtMaLoaiSach.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã loại sách");
                txtMaLoaiSach.Focus();
                return;
            }
            else
            {
                string sql = "update sachtruyen set tensach=@tensach, maloaisach=@maloaisach malinhvuc=@malinhvuc matacgia=@matacgia manhaxuatban=@manhaxuatban mangonngu=@mangonngu sotrang=@sotrang giasach=@giasach dongiathue=@dongiathue soluong=@soluong anh=@anh ghichu=@ghichu where masach =@masach";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("masach", txtMaSach.Text);
                cmd.Parameters.AddWithValue("tensach", txtTenSach.Text);
                cmd.Parameters.AddWithValue("maloaisach", txtMaLoaiSach.Text);
                cmd.Parameters.AddWithValue("malinhvuc", txtMaLinhVuc.Text);
                cmd.Parameters.AddWithValue("matacgia", txtMaTacGia.Text);
                cmd.Parameters.AddWithValue("manhaxuatban", TxtMaNhaXB.Text);
                cmd.Parameters.AddWithValue("mangonngu", txtMaNgonNgu.Text);
                cmd.Parameters.AddWithValue("sotrang", txtSoTrang.Text);
                cmd.Parameters.AddWithValue("giasach", txtGiaSach.Text);
                cmd.Parameters.AddWithValue("dongiathue", txtDonGiaThue.Text);
                cmd.Parameters.AddWithValue("soluong", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("anh", txtAnh.Text);
                cmd.Parameters.AddWithValue("ghichu", txtGhiChu.Text);
                cmd.ExecuteNonQuery();
                loaddatagridview();
            }

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            txtMaSach.Text = "";
            txtTenSach.Text = "";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
            {
            MessageBox.Show("bạn chưa nhập mã sách");
            txtMaSach.Focus();
            return;
            }
            if (txtTenSach.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên sách");
                txtTenSach.Focus();
                return;
            }
            else
              {
                try
                {
            string sql = "insert into sachtruyen values ('" + txtMaSach.Text + "', '" +
            txtTenSach.Text + "'";
            if (txtAnh.Text != "")
                sql = sql + "," + txtAnh.Text.Trim();
            if (txtDonGiaThue.Text != "")
                 sql = sql + "," + txtAnh.Text.Trim();
            if (txtGhiChu.Text != "")
                sql = sql + "," + txtAnh.Text.Trim();
            if (txtGiaSach.Text != "")
                sql = sql + "," + txtAnh.Text.Trim();
            if (txtMaLinhVuc.Text != "")
                sql = sql + "," + txtAnh.Text.Trim();
            if (txtMaLoaiSach.Text != "")
                sql = sql + "," + txtAnh.Text.Trim();
            if (txtMaNgonNgu.Text != "")
                sql = sql + "," + txtAnh.Text.Trim();
            if (TxtMaNhaXB.Text != "")
                sql = sql + "," + txtAnh.Text.Trim();
            if (txtMaTacGia.Text != "")
                sql = sql + "," + txtAnh.Text.Trim();
            if (txtSoLuong.Text != "")
                sql = sql + "," + txtAnh.Text.Trim();
            if (txtSoTrang.Text != "")
                sql = sql + "," + txtAnh.Text.Trim();
             sql = sql + ")";
            MessageBox.Show(sql);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            loaddatagridview();
                }
                catch (Exception d)
                {
                    MessageBox.Show(d.ToString());
                }
            }
            }
        }

        
        }

