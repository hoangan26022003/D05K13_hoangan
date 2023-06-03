using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class TrangChu : Form
    {
        private string Conn = "server = localhost; user id = root; password = ;  database = quanlythuvien";
        SqlConnection mySqlconnection;
        SqlCommand mySqlCommand;
        int bien = 1;

        public TrangChu()
        {
            InitializeComponent();
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            mySqlconnection = new SqlConnection(Conn);
            mySqlconnection.Open();

            // DocGia();
            // NhanVien();
            // Muontra();
            // cbMuontra();
            // thongke();

        }
        private void btnSachh_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sach S = new Sach();
            S.ShowDialog();
            S = null;
            this.Show();
        }

        private void btnLS_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoaiSach LS = new LoaiSach();
            LS.ShowDialog();
            LS = null;
            this.Show();
        }

        private void btnTG_Click(object sender, EventArgs e)
        {
            this.Hide();
            TacGia TG = new TacGia();
            TG.ShowDialog();
            TG = null;
            this.Show();
        }
        private void btnXBB_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        
        private void DocGia()
        {
            string sql = "select * from sinhvien";
            mySqlCommand = new SqlCommand(sql, mySqlconnection);
            SqlDataReader dr = mySqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvSinhVien.DataSource = dt;
            SetControls(false);
        }

        private void SetControls(bool b)
        {
            throw new NotImplementedException();
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            txtMaSinhVien.Clear();
            txtHoTen.Clear();
            txtNganhHoc.Clear();
            txtSDT.Clear();
            txtMaSinhVien.Focus();
            bien = 1;

            SetControls(true);
        }

        

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            txtHoTen.Focus();
            bien = 2;

            SetControls(true);
            txtMaSinhVien.Enabled = false;
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlr = new DialogResult();
                dlr = MessageBox.Show("Ban co chac chan muon xoa? ", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.No) return;
                int row = dgvSinhVien.CurrentRow.Index;
                string MaSV = dgvSinhVien.Rows[row].Cells[0].Value.ToString();
                string query3 = "delete from SinhVien where MaSV = " + MaSV;
                mySqlCommand = new SqlCommand(query3, mySqlconnection);
                mySqlCommand.ExecuteNonQuery();
                DocGia();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xoá. Sinh này đang mượn sách", "Thông Báo");
            }
        }

        private void btnGhiSV_Click(object sender, EventArgs e)
        {
            if (bien == 1)
            {
                if (txtMaSinhVien.Text.Trim() == "" || txtHoTen.Text.Trim() == "" || txtNganhHoc.Text.Trim() == "" || txtKhoa.Text.Trim() == "" || txtSDT.Text.Trim() == "" || txtMaSinhVien.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập lại !!!");
                }
                else
                {
                    for (int i = 0; i < dgvSinhVien.RowCount; i++)
                    {
                        if (txtMaSinhVien.Text == dgvSinhVien.Rows[i].Cells[0].Value.ToString())
                        {
                            MessageBox.Show("Trùng mã sinh viên. Vui lòng Nhập lại", "Thông báo");
                            return;
                        }
                    }
                    double x;
                    bool kt = double.TryParse(txtMaSinhVien.Text, out x);
                    if (kt == false)
                    {
                        MessageBox.Show("Vui lòng Nhập lại dưới dạng số!", "Thông báo");
                        return;
                    }
                    string query1 = "insert into SinhVien(MaSV,TenSV, NganhHoc, KhoaHoc, SoDienThoai) values('" + txtMaSinhVien.Text + "',N'" + txtHoTen.Text + "',N'" + txtNganhHoc.Text + "', N'" + txtKhoa.Text + "', N'" + txtSDT.Text + "')";
                    mySqlCommand = new SqlCommand(query1, mySqlconnection);
                    mySqlCommand.ExecuteNonQuery();
                    DocGia();
                    MessageBox.Show("Thên sinh viên thành công", "Thông báo");
                }
            }
            else
            {
                if (txtMaSinhVien.Text.Trim() == "" || txtHoTen.Text.Trim() == "" || txtNganhHoc.Text.Trim() == "" || txtKhoa.Text.Trim() == "" || txtSDT.Text.Trim() == "" || txtMaSinhVien.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập lại !!!");
                }
                else
                {
                    int row = dgvSinhVien.CurrentRow.Index;
                    string MaSV = dgvSinhVien.Rows[row].Cells[0].Value.ToString();
                    string query2 = "update SinhVien set MaSV = '" + txtMaSinhVien.Text + "', TenSV = N'" + txtHoTen.Text + "', NganhHoc = N'" + txtNganhHoc.Text + "', KhoaHoc = N'" + txtKhoa.Text + "', SoDienThoai = N'" + txtSDT.Text + "' where MaSV = " + MaSV;
                    mySqlCommand = new SqlCommand(query2, mySqlconnection);
                    mySqlCommand.ExecuteNonQuery();
                    DocGia();
                    MessageBox.Show("Sửa sinh viên thành công", "Thông báo");
                }
            }
        }

        private void btnHuySV_Click(object sender, EventArgs e)
        {
            SetControls(false);
        }

        private void dgvSinhVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            txtMaSinhVien.Text = dgvSinhVien.Rows[r].Cells[0].Value.ToString();
            txtHoTen.Text = dgvSinhVien.Rows[r].Cells[1].Value.ToString();
            txtNganhHoc.Text = dgvSinhVien.Rows[r].Cells[2].Value.ToString();
            txtKhoa.Text = dgvSinhVien.Rows[r].Cells[3].Value.ToString();
            txtSDT.Text = dgvSinhVien.Rows[r].Cells[4].Value.ToString();
        }

        private void txtTimKiemSV_KeyUp(object sender, KeyEventArgs e)
        {
            if (btnMSV.Checked)
            {
                string query = "select * from SinhVien where MaSV like N'%" + txtTimKiemSV.Text + "%'";
                mySqlCommand = new SqlCommand(query, mySqlconnection);
                mySqlCommand.ExecuteNonQuery();
                SqlDataReader dr = mySqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvSinhVien.DataSource = dt;
            }

            if (btnTSV.Checked)
            {
                string query = "select * from SinhVien where TenSV like N'%" + txtTimKiemSV.Text + "%'";
                mySqlCommand = new SqlCommand(query, mySqlconnection);
                mySqlCommand.ExecuteNonQuery();
                SqlDataReader dr = mySqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvSinhVien.DataSource = dt;
            }
        }
        public void NhanVien() {
            string query = "select MaNhanVien, TenNhanVien, SoDienThoai, GioiTinh, DiaChi from NhanVien";
            mySqlCommand = new SqlCommand(query, mySqlconnection);
            SqlDataReader dr = mySqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvQuanLy.DataSource = dt;
            
        }

        
       
        
        public void NhanVienn()
        {
            string sSql1 = "select count(*) from NhanVien";
            mySqlCommand = new SqlCommand(sSql1, mySqlconnection);
            mySqlCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(mySqlCommand);
            da.Fill(dt);
            TkAdmin.Text = dt.Rows[0][0].ToString();
        }
        public void SinhVien()
        {
            string sSql1 = "select count(*) from SinhVien";
            mySqlCommand = new SqlCommand(sSql1, mySqlconnection);
            mySqlCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(mySqlCommand);
            da.Fill(dt);
            TkSinhVien.Text = dt.Rows[0][0].ToString();
        }
        public void Sach()
        {
            string sSql1 = "select count(*) from Sach";
            mySqlCommand = new SqlCommand(sSql1, mySqlconnection);
            mySqlCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(mySqlCommand);
            da.Fill(dt);
            TkSach.Text = dt.Rows[0][0].ToString();
        }
        public void MuonTraSach()
        {
            string sSql1 = "select count(*) from MuonTraSach";
            mySqlCommand = new SqlCommand(sSql1, mySqlconnection);
            mySqlCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(mySqlCommand);
            da.Fill(dt);
            TkMuonSach.Text = dt.Rows[0][0].ToString();
        }
        public void LoaiSach()
        {
            string sSql1 = "select count(*) from LoaiSach";
            mySqlCommand = new SqlCommand(sSql1, mySqlconnection);
            mySqlCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(mySqlCommand);
            da.Fill(dt);
            TKLoaiSach.Text = dt.Rows[0][0].ToString();
        }
        public void TacGia()
        {
            string sSql1 = "select count(*) from TacGia";
            mySqlCommand = new SqlCommand(sSql1, mySqlconnection);
            mySqlCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(mySqlCommand);
            da.Fill(dt);
            TKTacGia.Text = dt.Rows[0][0].ToString();
        }
        public void NhaXuatBan()
        {
            string sSql1 = "select count(*) from NhaXuatBan";
            mySqlCommand = new SqlCommand(sSql1, mySqlconnection);
            mySqlCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(mySqlCommand);
            da.Fill(dt);
            TKNhaXB.Text = dt.Rows[0][0].ToString();
        }

      
        //out
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dlr = new DialogResult();
            dlr = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) return;
            this.Hide();
            Login DN = new Login();
            DN.Show();
        }

        
    }
}
