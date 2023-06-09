using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HOANGAN
{
    public partial class Login : Form
    {
        private string connect = "server=localhost;user id=root;password=;database=music";

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            if (AuthenticateUser(username, password))
            {
                this.Hide();
                Home home = new Home();
                home.ShowDialog();
                home = null;
                this.Show();
                

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại thông tin đăng nhập.");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            MySqlConnection connection = new MySqlConnection(connect);
            string query = "SELECT COUNT(*) FROM login WHERE username = '"+username+"' AND password = '"+password+"'";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);// Thêm giá trị của tham số
                command.Parameters.AddWithValue("@password", password);

                connection.Open();//Mở kết nối đến cơ sở dữ liệu để thực thi câu truy vấn.
                int count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();

                return count > 0;// Trả về true nếu tồn tại người dùng có thông tin đăng nhập hợp lệ, ngược lại trả về false
            }        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}