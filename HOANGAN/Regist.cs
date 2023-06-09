using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HOANGAN
{
    public partial class Regist : Form
    {
        public Regist()
        {
            InitializeComponent();
        }
        private string connect = "server=localhost;user id=root;password=;database=music";

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbUser.Text;
            string password = tbPass.Text;
            string email = tbEmail.Text;
            string phoneNumber = tbSDT.Text;

            // Kiểm tra xem các trường thông tin đã được nhập đầy đủ hay chưa
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kết nối tới cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connect))
            {
                try
                {
                    connection.Open();

                    // Tạo câu truy vấn SQL để chèn dữ liệu vào cơ sở dữ liệu
                    string query = "INSERT INTO login (username, password, email, sdt) VALUES ('" + name + "', '" + password + "', '" + email +"', '" + phoneNumber+"')";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Gán giá trị tham số
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                        // Thực thi truy vấn
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa dữ liệu trong các ô textbox
                    tbUser.Text = "";
                    tbPass.Text = "";
                    tbEmail.Text = "";
                    tbSDT.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}