using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HOANGAN
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private string connect = "server=localhost;user id=root;password=;database=music";
        
        private void From2_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connect);
            
                // Load danh sách category
                string sqlCategory = "SELECT * FROM category";
                MySqlDataAdapter adapterCategory = new MySqlDataAdapter(sqlCategory, connection);
                DataSet itemCategory = new DataSet();
                adapterCategory.Fill(itemCategory, "category");
                dgvCat.DataSource = itemCategory.Tables["category"].DefaultView;

                // Load danh sách artist
                string sqlArtist = "SELECT * FROM artist";
                MySqlDataAdapter adapterArtist = new MySqlDataAdapter(sqlArtist, connection);
                DataTable itemArtist = new DataTable();
                adapterArtist.Fill(itemArtist);
                dgvArtist.DataSource = itemArtist;

                // Load danh sách song
                string sqlSong = "SELECT s.song_id, s.song_title, a.artist_name, c.cat_name, s.release_date, s.duration, s.lyrics, s.album " +
                                 "FROM song s " +
                                 "INNER JOIN artist a ON s.artist_id = a.artist_id " +
                                 "INNER JOIN category c ON s.cat_id = c.cat_id " +
                                 "ORDER BY s.song_id ASC";
                MySqlDataAdapter adapterSong = new MySqlDataAdapter(sqlSong, connection);
                DataTable itemSong = new DataTable();
                adapterSong.Fill(itemSong);
                dgvSong.DataSource = itemSong;
        }


        private void btnAddCat_Click(object sender, EventArgs e)
        {
            lbCatName.Enabled = true;
            lbCatDescription.Enabled = true;
            tbCatName.Enabled = true;
            tbCatDescription.Enabled = true;
            
            btnSaveCat.Enabled = true;
            btnEditCat.Enabled = true;
            btnDeleteCat.Enabled = true;
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            string nameCat = tbCatName.Text;
            string descriptionCat = tbCatDescription.Text;

            MySqlConnection connection = new MySqlConnection(connect);

            string sql = "INSERT INTO category (cat_name, cat_description) VALUES ('" + nameCat + "', '" + descriptionCat + "')";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            From2_Load(null, null);

            tbCatName.Text = "";
            tbCatDescription.Text = "";
        }

        private void btnEditCat_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbCatId.Text);
            string nameCat = tbCatName.Text;
            string descriptionCat = tbCatDescription.Text;

            MySqlConnection connection = new MySqlConnection(connect);
            string sql = "UPDATE category SET cat_name = '" + nameCat + "', cat_description = '" + descriptionCat + "' WHERE cat_id = '" + id + "'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            From2_Load(null, null);
            tbCatId.Text = "";
            tbCatName.Text = "";
            tbCatDescription.Text = "";
        }

        private void dgvCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbCatName.Enabled = true;
            lbCatDescription.Enabled = true;

            tbCatName.Enabled = true;
            tbCatDescription.Enabled = true;

            btnEditCat.Enabled = true;
            btnDeleteCat.Enabled = true;

            string nameCat = dgvCat.Rows[e.RowIndex].Cells["cat_name"].Value.ToString();
            string descriptionCat = dgvCat.Rows[e.RowIndex].Cells["cat_description"].Value.ToString();
            string id = dgvCat.Rows[e.RowIndex].Cells["cat_id"].Value.ToString();

            tbCatName.Text = nameCat;
            tbCatDescription.Text = descriptionCat;
            tbCatId.Text = id;
        }

        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbCatId.Text);

            MySqlConnection connection = new MySqlConnection(connect);

            string sql = "DELETE FROM category WHERE cat_id = '" + id + "'";
            MySqlCommand command = new MySqlCommand(sql, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            From2_Load(null, null);

            tbCatId.Text = "";
            tbCatName.Text = "";
            tbCatDescription.Text = "";
        }
        //
        // THAO TÁC VỚI FORM TÁC GIẢ
        //

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            lbArtistName.Enabled = true;
            lbArtistGenre.Enabled = true;
            lbArtistBirthDate.Enabled = true;
            lbArtistCountry.Enabled = true;
            lbArtistBiography.Enabled = true;

            tbArtistName.Enabled = true;
            tbArtistGenre.Enabled = true;
            dtpArtistBirthDate.Enabled = true;
            tbArtistCountry.Enabled = true;
            rtbArtistBiography.Enabled = true;

            btnSaveArtist.Enabled = true;
            btnEditArtist.Enabled = true;
            btnDeleteArtist.Enabled = true;
        }

        private void btnSaveArtist_Click(object sender, EventArgs e)
        {
            string nameArtist = tbArtistName.Text;
            string genreArtist = tbArtistGenre.Text;
            DateTime birthDateArtist = dtpArtistBirthDate.Value.Date;
            string countryArtist = tbArtistCountry.Text;
            string biographyArtist = rtbArtistBiography.Text;

            MySqlConnection connection = new MySqlConnection(connect);

            string sql = "INSERT INTO artist (artist_name, genre, birth_date, country, biography) VALUES ('" + nameArtist + "', '" + genreArtist + "', '" + birthDateArtist.ToString("yyyy-MM-dd") + "', '" + countryArtist + "', '" + biographyArtist + "')";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            From2_Load(null, null);

            tbArtistName.Text = "";
            tbArtistGenre.Text = "";
            dtpArtistBirthDate.Value = DateTime.Now;
            tbArtistCountry.Text = "";
            rtbArtistBiography.Text = "";
        }

        private void btnEditArtist_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbArtistId.Text);
            string nameArtist = tbArtistName.Text;
            string genreArtist = tbArtistGenre.Text;
            DateTime birthDateArtist = dtpArtistBirthDate.Value.Date;
            string countryArtist = tbArtistCountry.Text;
            string biographyArtist = rtbArtistBiography.Text;

            MySqlConnection connection = new MySqlConnection(connect);

            string sql = "UPDATE artist SET artist_name = '" + nameArtist + "', genre = '" + genreArtist + "', birth_date = '" + birthDateArtist.ToString("yyyy-MM-dd") + "', country = '" + countryArtist + "', biography = '" + biographyArtist + "' WHERE artist_id = '" + id + "'";

            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            From2_Load(null, null);

            tbArtistId.Text = "";
            tbArtistName.Text = "";
            tbArtistGenre.Text = "";
            dtpArtistBirthDate.Value = DateTime.Now;
            tbArtistCountry.Text = "";
            rtbArtistBiography.Text = "";
        }


        private void dgvArtist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbArtistName.Enabled = true;
            lbArtistGenre.Enabled = true;
            lbArtistBirthDate.Enabled = true;
            lbArtistCountry.Enabled = true;
            lbArtistBiography.Enabled = true;

            tbArtistName.Enabled = true;
            tbArtistGenre.Enabled = true;
            dtpArtistBirthDate.Enabled = true;
            tbArtistCountry.Enabled = true;
            rtbArtistBiography.Enabled = true;

            btnEditArtist.Enabled = true;
            btnDeleteArtist.Enabled = true;

            string nameArtist = dgvArtist.Rows[e.RowIndex].Cells["artist_name"].Value.ToString();
            string genreArtist = dgvArtist.Rows[e.RowIndex].Cells["genre"].Value.ToString();
            DateTime birthDateArtist = DateTime.Parse(dgvArtist.Rows[e.RowIndex].Cells["birth_date"].Value.ToString());
            string countryArtist = dgvArtist.Rows[e.RowIndex].Cells["country"].Value.ToString();
            string biographyArtist = dgvArtist.Rows[e.RowIndex].Cells["biography"].Value.ToString();
            string id = dgvArtist.Rows[e.RowIndex].Cells["artist_id"].Value.ToString();

            tbArtistName.Text = nameArtist;
            tbArtistGenre.Text = genreArtist;
            dtpArtistBirthDate.Value = birthDateArtist;
            tbArtistCountry.Text = countryArtist;
            rtbArtistBiography.Text = biographyArtist;
            tbArtistId.Text = id;
        }

        private void btnDeleteArtist_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbArtistId.Text);

            MySqlConnection connection = new MySqlConnection(connect);

            string sql = "DELETE FROM artist WHERE artist_id = '" + id + "'";
            MySqlCommand command = new MySqlCommand(sql, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            From2_Load(null, null);

            tbArtistId.Text = "";
            tbArtistName.Text = "";
            tbArtistGenre.Text = "";
            dtpArtistBirthDate.Value = DateTime.Now;
            tbArtistCountry.Text = "";
            rtbArtistBiography.Text = "";
        }
        //
        //
        //
        private void getCategorise()
        {
            MySqlConnection connection = new MySqlConnection(connect);
            string sql = "SELECT * FROM category";
            MySqlDataAdapter query = new MySqlDataAdapter(sql, connection);
            DataTable item = new DataTable();
            query.Fill(item);
            comboBox1.DataSource = item;
            comboBox1.DisplayMember = "cat_name";
            comboBox1.ValueMember = "cat_id";
        } 
        private void getArtist()
        {
            MySqlConnection connection = new MySqlConnection(connect);
            string sql = "SELECT * FROM artist";
            MySqlDataAdapter query = new MySqlDataAdapter(sql, connection);
            DataTable item = new DataTable();
            query.Fill(item);
            comboBox2.DataSource = item;
            comboBox2.DisplayMember = "artist_name";
            comboBox2.ValueMember = "artist_id";
        }
        //
        //
        //

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            lbSongTitle.Enabled = true;
            lbSongArtistId.Enabled = true;
            lbSongCatId.Enabled = true;
            lbSongReleaseDate.Enabled = true;
            lbSongDuration.Enabled = true;
            lbSongLyrics.Enabled = true;
            lbSongAlbum.Enabled = true;

            tbSongTitle.Enabled = true;
            comboBox2.Enabled = true;
            comboBox1.Enabled = true;
            dtpSongReleaseDate.Enabled = true;
            tbSongDuration.Enabled = true;
            rtbSongLyrics.Enabled = true;
            tbSongAlbum.Enabled = true;

            btnSaveSong.Enabled = true;
            btnEditSong.Enabled = true;
            btnDeleteSong.Enabled = true;
            //
            getCategorise();
            getArtist();
        }

        private void btnSaveSong_Click(object sender, EventArgs e)
        {
            
            string titleSong = tbSongTitle.Text;
            string artistIdSong = comboBox2.SelectedValue.ToString();
            string categoryIdSong = comboBox1.SelectedValue.ToString();
            DateTime releaseDateSong = dtpSongReleaseDate.Value.Date;
            string durationSong = tbSongDuration.Text;
            string lyricsSong = rtbSongLyrics.Text;
            string albumSong = tbSongAlbum.Text;

            MySqlConnection connection = new MySqlConnection(connect);

            string sql = "INSERT INTO song (song_title, artist_id, cat_id, release_date, duration, lyrics, album) VALUES ('" + titleSong + "', '" + artistIdSong + "', '" + categoryIdSong + "', '" + releaseDateSong.ToString("yyyy-MM-dd") + "', '" + durationSong + "', '" + lyricsSong + "', '" + albumSong + "')";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            From2_Load(null, null);

            tbSongTitle.Text = "";
            comboBox2.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            dtpSongReleaseDate.Value = DateTime.Now;
            tbSongDuration.Text = "";
            rtbSongLyrics.Text = "";
            tbSongAlbum.Text = "";
        }

        private void btnEditSong_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbSongId.Text);
            string titleSong = tbSongTitle.Text;
            
            string artistIdSong = comboBox2.SelectedValue.ToString();
            string categoryIdSong = comboBox1.SelectedValue.ToString();
            DateTime releaseDateSong = dtpSongReleaseDate.Value.Date;
            string durationSong = tbSongDuration.Text;
            string lyricsSong = rtbSongLyrics.Text;
            string albumSong = tbSongAlbum.Text;

            MySqlConnection connection = new MySqlConnection(connect);

            string sql = "UPDATE song SET song_title = '" + titleSong + "', artist_id = '" + artistIdSong + "', cat_id = '" + categoryIdSong + "', release_date = '" + releaseDateSong.ToString("yyyy-MM-dd") + "', duration = '" + durationSong + "', lyrics = '" + lyricsSong + "', album = '" + albumSong + "' WHERE song_id = '" + id + "'";

            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            From2_Load(null, null);

            tbSongId.Text = "";
            tbSongTitle.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
            dtpSongReleaseDate.Value = DateTime.Now;
            tbSongDuration.Text = "";
            rtbSongLyrics.Text = "";
            tbSongAlbum.Text = "";
            
            comboBox1.ResetText();
            comboBox2.ResetText();
        }

        private void dgvSong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbSongTitle.Enabled = true;
            lbSongArtistId.Enabled = true;
            lbSongCatId.Enabled = true;
            lbSongReleaseDate.Enabled = true;
            lbSongDuration.Enabled = true;
            lbSongLyrics.Enabled = true;
            lbSongAlbum.Enabled = true;

            tbSongTitle.Enabled = true;
            comboBox2.Enabled = true;
            comboBox1.Enabled = true;
            dtpSongReleaseDate.Enabled = true;
            tbSongDuration.Enabled = true;
            rtbSongLyrics.Enabled = true;
            tbSongAlbum.Enabled = true;

            btnEditSong.Enabled = true;
            btnDeleteSong.Enabled = true;

            string titleSong = dgvSong.Rows[e.RowIndex].Cells["song_title"].Value.ToString();
            string artistIdSong = dgvSong.Rows[e.RowIndex].Cells["artist_name"].Value.ToString();
            string catIdSong = dgvSong.Rows[e.RowIndex].Cells["cat_name"].Value.ToString();
            DateTime releaseDateSong = DateTime.Parse(dgvSong.Rows[e.RowIndex].Cells["release_date"].Value.ToString());
            string durationSong = dgvSong.Rows[e.RowIndex].Cells["duration"].Value.ToString();
            string lyricsSong = dgvSong.Rows[e.RowIndex].Cells["lyrics"].Value.ToString();
            string albumSong = dgvSong.Rows[e.RowIndex].Cells["album"].Value.ToString();
            string id = dgvSong.Rows[e.RowIndex].Cells["song_id"].Value.ToString();

            tbSongTitle.Text = titleSong;
            comboBox2.Text = artistIdSong;
            comboBox1.Text = catIdSong;
            dtpSongReleaseDate.Value = releaseDateSong;
            tbSongDuration.Text = durationSong;
            rtbSongLyrics.Text = lyricsSong;
            tbSongAlbum.Text = albumSong;
            tbSongId.Text = id;
            getCategorise();
            comboBox1.SelectedValue = comboBox1.FindStringExact(catIdSong);
            getArtist();
            comboBox2.SelectedValue = comboBox2.FindStringExact(artistIdSong);
            //int index = comboBox1.FindStringExact(catIdSong);
            //if (index != -1)
            //{
            //    comboBox1.SelectedIndex = index;
            //}
        }

        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbSongId.Text);

            MySqlConnection connection = new MySqlConnection(connect);

            string sql = "DELETE FROM song WHERE song_id = '" + id + "'";
            MySqlCommand command = new MySqlCommand(sql, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            From2_Load(null, null);

            tbSongId.Text = "";
            tbSongTitle.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
            dtpSongReleaseDate.Value = DateTime.Now;
            tbSongDuration.Text = "";
            rtbSongLyrics.Text = "";
            tbSongAlbum.Text = "";
            
            comboBox1.ResetText();
            comboBox2.ResetText();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Lựa chọn "Có" được chọn
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                login = null;
                this.Show();
            }
            // Nếu lựa chọn là "Không", không có hành động nào được thực hiện.;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Lựa chọn "Có" được chọn
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                login = null;
                this.Show();
            }
            // Nếu lựa chọn là "Không", không có hành động nào được thực hiện.;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Lựa chọn "Có" được chọn
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                login = null;
                this.Show();
            }
            // Nếu lựa chọn là "Không", không có hành động nào được thực hiện.;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox tìm kiếm và loại bỏ các khoảng trắng thừa
            string search = tbSearch.Text.Trim();

            // Tạo câu truy vấn tìm kiếm với tiêu đề (title)
            string sqlSearch = "SELECT s.song_id, s.song_title, a.artist_name, c.cat_name, s.release_date, s.duration, s.lyrics, s.album " +
                               "FROM song s " +
                               "INNER JOIN artist a ON s.artist_id = a.artist_id " +
                               "INNER JOIN category c ON s.cat_id = c.cat_id " +
                               "WHERE s.song_title LIKE '%" + search + "%' " +
                               "ORDER BY s.song_id ASC";

            MySqlConnection connection = new MySqlConnection(connect); // Tạo kết nối đến cơ sở dữ liệu MySQL
            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlSearch, connection);// Tạo adapter để thực hiện truy vấn và điền kết quả vào DataTable
            DataTable searchData = new DataTable();// khởi tạo một đối tượng
            adapter.Fill(searchData);// Gán kết quả tìm kiếm vào bảng DataGridView để hiển thị
            dgvSong.DataSource = searchData;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            // Xóa dữ liệu hiện có trong bảng (DataGridView)
            dgvSong.DataSource = null;
        }
    }
}