using System.ComponentModel;

namespace HOANGAN
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dgvCat = new System.Windows.Forms.DataGridView();
            this.btnEditCat = new System.Windows.Forms.Button();
            this.btnSaveCat = new System.Windows.Forms.Button();
            this.btnDeleteCat = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.tbCatDescription = new System.Windows.Forms.TextBox();
            this.tbCatName = new System.Windows.Forms.TextBox();
            this.tbCatId = new System.Windows.Forms.TextBox();
            this.lbCatDescription = new System.Windows.Forms.Label();
            this.lbCatName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.rtbArtistBiography = new System.Windows.Forms.RichTextBox();
            this.dtpArtistBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteArtist = new System.Windows.Forms.Button();
            this.btnEditArtist = new System.Windows.Forms.Button();
            this.btnSaveArtist = new System.Windows.Forms.Button();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.tbArtistId = new System.Windows.Forms.TextBox();
            this.tbArtistGenre = new System.Windows.Forms.TextBox();
            this.tbArtistCountry = new System.Windows.Forms.TextBox();
            this.tbArtistName = new System.Windows.Forms.TextBox();
            this.lbArtistGenre = new System.Windows.Forms.Label();
            this.lbArtistBirthDate = new System.Windows.Forms.Label();
            this.lbArtistCountryj = new System.Windows.Forms.Label();
            this.lbArtistBiography = new System.Windows.Forms.Label();
            this.lbArtistName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvArtist = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtpSongReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.tbSongTitle = new System.Windows.Forms.TextBox();
            this.lbSongLyrics = new System.Windows.Forms.Label();
            this.tbSongId = new System.Windows.Forms.TextBox();
            this.btnSaveSong = new System.Windows.Forms.Button();
            this.btnEditSong = new System.Windows.Forms.Button();
            this.btnDeleteSong = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.rtbSongLyrics = new System.Windows.Forms.TextBox();
            this.tbSongDuration = new System.Windows.Forms.TextBox();
            this.tbSongAlbum = new System.Windows.Forms.TextBox();
            this.lbSongReleaseDate = new System.Windows.Forms.Label();
            this.lbSongDuration = new System.Windows.Forms.Label();
            this.lbSongArtistId = new System.Windows.Forms.Label();
            this.lbSongCatId = new System.Windows.Forms.Label();
            this.lbSongAlbum = new System.Windows.Forms.Label();
            this.lbSongTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvSong = new System.Windows.Forms.DataGridView();
            this.lbArtistCountry = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(817, 476);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.dgvCat);
            this.tabPage1.Controls.Add(this.btnEditCat);
            this.tabPage1.Controls.Add(this.btnSaveCat);
            this.tabPage1.Controls.Add(this.btnDeleteCat);
            this.tabPage1.Controls.Add(this.btnAddCat);
            this.tabPage1.Controls.Add(this.tbCatDescription);
            this.tabPage1.Controls.Add(this.tbCatName);
            this.tabPage1.Controls.Add(this.tbCatId);
            this.tabPage1.Controls.Add(this.lbCatDescription);
            this.tabPage1.Controls.Add(this.lbCatName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(809, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Category";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(772, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // dgvCat
            // 
            this.dgvCat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCat.Location = new System.Drawing.Point(374, 78);
            this.dgvCat.Name = "dgvCat";
            this.dgvCat.Size = new System.Drawing.Size(410, 306);
            this.dgvCat.TabIndex = 10;
            this.dgvCat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCat_CellClick);
            // 
            // btnEditCat
            // 
            this.btnEditCat.Enabled = false;
            this.btnEditCat.Location = new System.Drawing.Point(100, 342);
            this.btnEditCat.Name = "btnEditCat";
            this.btnEditCat.Size = new System.Drawing.Size(100, 42);
            this.btnEditCat.TabIndex = 9;
            this.btnEditCat.Text = "Sửa Đổi";
            this.btnEditCat.UseVisualStyleBackColor = true;
            this.btnEditCat.Click += new System.EventHandler(this.btnEditCat_Click);
            // 
            // btnSaveCat
            // 
            this.btnSaveCat.Enabled = false;
            this.btnSaveCat.Location = new System.Drawing.Point(254, 275);
            this.btnSaveCat.Name = "btnSaveCat";
            this.btnSaveCat.Size = new System.Drawing.Size(100, 42);
            this.btnSaveCat.TabIndex = 8;
            this.btnSaveCat.Text = "Lưu";
            this.btnSaveCat.UseVisualStyleBackColor = true;
            this.btnSaveCat.Click += new System.EventHandler(this.btnSaveCat_Click);
            // 
            // btnDeleteCat
            // 
            this.btnDeleteCat.Enabled = false;
            this.btnDeleteCat.Location = new System.Drawing.Point(254, 342);
            this.btnDeleteCat.Name = "btnDeleteCat";
            this.btnDeleteCat.Size = new System.Drawing.Size(100, 42);
            this.btnDeleteCat.TabIndex = 7;
            this.btnDeleteCat.Text = "Xóa";
            this.btnDeleteCat.UseVisualStyleBackColor = true;
            this.btnDeleteCat.Click += new System.EventHandler(this.btnDeleteCat_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.Location = new System.Drawing.Point(100, 275);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(100, 42);
            this.btnAddCat.TabIndex = 6;
            this.btnAddCat.Text = "Thêm Mới";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // tbCatDescription
            // 
            this.tbCatDescription.Enabled = false;
            this.tbCatDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCatDescription.Location = new System.Drawing.Point(100, 132);
            this.tbCatDescription.Multiline = true;
            this.tbCatDescription.Name = "tbCatDescription";
            this.tbCatDescription.Size = new System.Drawing.Size(254, 111);
            this.tbCatDescription.TabIndex = 5;
            // 
            // tbCatName
            // 
            this.tbCatName.Enabled = false;
            this.tbCatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCatName.Location = new System.Drawing.Point(100, 78);
            this.tbCatName.Name = "tbCatName";
            this.tbCatName.Size = new System.Drawing.Size(254, 24);
            this.tbCatName.TabIndex = 4;
            // 
            // tbCatId
            // 
            this.tbCatId.Location = new System.Drawing.Point(12, 12);
            this.tbCatId.Name = "tbCatId";
            this.tbCatId.Size = new System.Drawing.Size(41, 20);
            this.tbCatId.TabIndex = 3;
            this.tbCatId.Visible = false;
            // 
            // lbCatDescription
            // 
            this.lbCatDescription.Enabled = false;
            this.lbCatDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCatDescription.Location = new System.Drawing.Point(12, 132);
            this.lbCatDescription.Name = "lbCatDescription";
            this.lbCatDescription.Size = new System.Drawing.Size(56, 22);
            this.lbCatDescription.TabIndex = 2;
            this.lbCatDescription.Text = "Mô Tả:";
            // 
            // lbCatName
            // 
            this.lbCatName.Enabled = false;
            this.lbCatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCatName.Location = new System.Drawing.Point(12, 78);
            this.lbCatName.Name = "lbCatName";
            this.lbCatName.Size = new System.Drawing.Size(82, 22);
            this.lbCatName.TabIndex = 1;
            this.lbCatName.Text = "Danh Mục:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(281, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC MUSIC";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.rtbArtistBiography);
            this.tabPage2.Controls.Add(this.dtpArtistBirthDate);
            this.tabPage2.Controls.Add(this.btnDeleteArtist);
            this.tabPage2.Controls.Add(this.btnEditArtist);
            this.tabPage2.Controls.Add(this.btnSaveArtist);
            this.tabPage2.Controls.Add(this.btnAddArtist);
            this.tabPage2.Controls.Add(this.tbArtistId);
            this.tabPage2.Controls.Add(this.tbArtistGenre);
            this.tabPage2.Controls.Add(this.tbArtistCountry);
            this.tabPage2.Controls.Add(this.tbArtistName);
            this.tabPage2.Controls.Add(this.lbArtistGenre);
            this.tabPage2.Controls.Add(this.lbArtistBirthDate);
            this.tabPage2.Controls.Add(this.lbArtistCountryj);
            this.tabPage2.Controls.Add(this.lbArtistBiography);
            this.tabPage2.Controls.Add(this.lbArtistName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dgvArtist);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(809, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Artist";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(772, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // rtbArtistBiography
            // 
            this.rtbArtistBiography.Enabled = false;
            this.rtbArtistBiography.Location = new System.Drawing.Point(423, 98);
            this.rtbArtistBiography.Name = "rtbArtistBiography";
            this.rtbArtistBiography.Size = new System.Drawing.Size(214, 93);
            this.rtbArtistBiography.TabIndex = 20;
            this.rtbArtistBiography.Text = "";
            // 
            // dtpArtistBirthDate
            // 
            this.dtpArtistBirthDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpArtistBirthDate.Enabled = false;
            this.dtpArtistBirthDate.Location = new System.Drawing.Point(226, 138);
            this.dtpArtistBirthDate.Name = "dtpArtistBirthDate";
            this.dtpArtistBirthDate.Size = new System.Drawing.Size(170, 20);
            this.dtpArtistBirthDate.TabIndex = 19;
            // 
            // btnDeleteArtist
            // 
            this.btnDeleteArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDeleteArtist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteArtist.Enabled = false;
            this.btnDeleteArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteArtist.Location = new System.Drawing.Point(666, 167);
            this.btnDeleteArtist.Name = "btnDeleteArtist";
            this.btnDeleteArtist.Size = new System.Drawing.Size(92, 27);
            this.btnDeleteArtist.TabIndex = 18;
            this.btnDeleteArtist.Text = "Xóa";
            this.btnDeleteArtist.UseVisualStyleBackColor = false;
            this.btnDeleteArtist.Click += new System.EventHandler(this.btnDeleteArtist_Click);
            // 
            // btnEditArtist
            // 
            this.btnEditArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditArtist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditArtist.Enabled = false;
            this.btnEditArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditArtist.Location = new System.Drawing.Point(666, 132);
            this.btnEditArtist.Name = "btnEditArtist";
            this.btnEditArtist.Size = new System.Drawing.Size(92, 27);
            this.btnEditArtist.TabIndex = 17;
            this.btnEditArtist.Text = "Sửa";
            this.btnEditArtist.UseVisualStyleBackColor = false;
            this.btnEditArtist.Click += new System.EventHandler(this.btnEditArtist_Click);
            // 
            // btnSaveArtist
            // 
            this.btnSaveArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveArtist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveArtist.Enabled = false;
            this.btnSaveArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveArtist.Location = new System.Drawing.Point(666, 99);
            this.btnSaveArtist.Name = "btnSaveArtist";
            this.btnSaveArtist.Size = new System.Drawing.Size(92, 27);
            this.btnSaveArtist.TabIndex = 16;
            this.btnSaveArtist.Text = "Lưu";
            this.btnSaveArtist.UseVisualStyleBackColor = false;
            this.btnSaveArtist.Click += new System.EventHandler(this.btnSaveArtist_Click);
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddArtist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArtist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddArtist.Location = new System.Drawing.Point(666, 66);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddArtist.Size = new System.Drawing.Size(92, 26);
            this.btnAddArtist.TabIndex = 14;
            this.btnAddArtist.Text = "Thêm mới";
            this.btnAddArtist.UseVisualStyleBackColor = false;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // tbArtistId
            // 
            this.tbArtistId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArtistId.Location = new System.Drawing.Point(8, 13);
            this.tbArtistId.Name = "tbArtistId";
            this.tbArtistId.Size = new System.Drawing.Size(25, 24);
            this.tbArtistId.TabIndex = 13;
            this.tbArtistId.Visible = false;
            // 
            // tbArtistGenre
            // 
            this.tbArtistGenre.Enabled = false;
            this.tbArtistGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArtistGenre.Location = new System.Drawing.Point(226, 102);
            this.tbArtistGenre.Name = "tbArtistGenre";
            this.tbArtistGenre.Size = new System.Drawing.Size(170, 24);
            this.tbArtistGenre.TabIndex = 11;
            // 
            // tbArtistCountry
            // 
            this.tbArtistCountry.Enabled = false;
            this.tbArtistCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArtistCountry.Location = new System.Drawing.Point(226, 167);
            this.tbArtistCountry.Name = "tbArtistCountry";
            this.tbArtistCountry.Size = new System.Drawing.Size(170, 24);
            this.tbArtistCountry.TabIndex = 9;
            // 
            // tbArtistName
            // 
            this.tbArtistName.Enabled = false;
            this.tbArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArtistName.Location = new System.Drawing.Point(226, 66);
            this.tbArtistName.Name = "tbArtistName";
            this.tbArtistName.Size = new System.Drawing.Size(170, 24);
            this.tbArtistName.TabIndex = 8;
            // 
            // lbArtistGenre
            // 
            this.lbArtistGenre.Enabled = false;
            this.lbArtistGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtistGenre.Location = new System.Drawing.Point(120, 105);
            this.lbArtistGenre.Name = "lbArtistGenre";
            this.lbArtistGenre.Size = new System.Drawing.Size(100, 23);
            this.lbArtistGenre.TabIndex = 7;
            this.lbArtistGenre.Text = "Genre:";
            // 
            // lbArtistBirthDate
            // 
            this.lbArtistBirthDate.Enabled = false;
            this.lbArtistBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtistBirthDate.Location = new System.Drawing.Point(120, 135);
            this.lbArtistBirthDate.Name = "lbArtistBirthDate";
            this.lbArtistBirthDate.Size = new System.Drawing.Size(100, 23);
            this.lbArtistBirthDate.TabIndex = 6;
            this.lbArtistBirthDate.Text = "Ngày Sinh:";
            // 
            // lbArtistCountryj
            // 
            this.lbArtistCountryj.BackColor = System.Drawing.Color.White;
            this.lbArtistCountryj.Enabled = false;
            this.lbArtistCountryj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtistCountryj.Location = new System.Drawing.Point(120, 168);
            this.lbArtistCountryj.Name = "lbArtistCountryj";
            this.lbArtistCountryj.Size = new System.Drawing.Size(100, 23);
            this.lbArtistCountryj.TabIndex = 5;
            this.lbArtistCountryj.Text = "Quốc Gia:";
            // 
            // lbArtistBiography
            // 
            this.lbArtistBiography.Enabled = false;
            this.lbArtistBiography.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtistBiography.Location = new System.Drawing.Point(413, 69);
            this.lbArtistBiography.Name = "lbArtistBiography";
            this.lbArtistBiography.Size = new System.Drawing.Size(67, 23);
            this.lbArtistBiography.TabIndex = 4;
            this.lbArtistBiography.Text = "Tiểu Sử:";
            // 
            // lbArtistName
            // 
            this.lbArtistName.Enabled = false;
            this.lbArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtistName.Location = new System.Drawing.Point(120, 69);
            this.lbArtistName.Name = "lbArtistName";
            this.lbArtistName.Size = new System.Drawing.Size(100, 23);
            this.lbArtistName.TabIndex = 3;
            this.lbArtistName.Text = "Tên Nghệ Sĩ:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(327, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "NGHỆ SĨ";
            // 
            // dgvArtist
            // 
            this.dgvArtist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvArtist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvArtist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvArtist.Location = new System.Drawing.Point(3, 215);
            this.dgvArtist.Name = "dgvArtist";
            this.dgvArtist.Size = new System.Drawing.Size(803, 232);
            this.dgvArtist.TabIndex = 1;
            this.dgvArtist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtist_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 1024);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSearch);
            this.tabPage3.Controls.Add(this.tbSearch);
            this.tabPage3.Controls.Add(this.pictureBox5);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.dtpSongReleaseDate);
            this.tabPage3.Controls.Add(this.tbSongTitle);
            this.tabPage3.Controls.Add(this.lbSongLyrics);
            this.tabPage3.Controls.Add(this.tbSongId);
            this.tabPage3.Controls.Add(this.btnSaveSong);
            this.tabPage3.Controls.Add(this.btnEditSong);
            this.tabPage3.Controls.Add(this.btnDeleteSong);
            this.tabPage3.Controls.Add(this.btnAddSong);
            this.tabPage3.Controls.Add(this.rtbSongLyrics);
            this.tabPage3.Controls.Add(this.tbSongDuration);
            this.tabPage3.Controls.Add(this.tbSongAlbum);
            this.tabPage3.Controls.Add(this.lbSongReleaseDate);
            this.tabPage3.Controls.Add(this.lbSongDuration);
            this.tabPage3.Controls.Add(this.lbSongArtistId);
            this.tabPage3.Controls.Add(this.lbSongCatId);
            this.tabPage3.Controls.Add(this.lbSongAlbum);
            this.tabPage3.Controls.Add(this.lbSongTitle);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.dgvSong);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(809, 450);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Song";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(227, 179);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(73, 181);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(137, 26);
            this.tbSearch.TabIndex = 29;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(773, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(125, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(177, 24);
            this.comboBox2.TabIndex = 27;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 24);
            this.comboBox1.TabIndex = 26;
            // 
            // dtpSongReleaseDate
            // 
            this.dtpSongReleaseDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSongReleaseDate.Enabled = false;
            this.dtpSongReleaseDate.Location = new System.Drawing.Point(125, 68);
            this.dtpSongReleaseDate.Name = "dtpSongReleaseDate";
            this.dtpSongReleaseDate.Size = new System.Drawing.Size(177, 20);
            this.dtpSongReleaseDate.TabIndex = 25;
            // 
            // tbSongTitle
            // 
            this.tbSongTitle.Enabled = false;
            this.tbSongTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSongTitle.Location = new System.Drawing.Point(125, 22);
            this.tbSongTitle.Name = "tbSongTitle";
            this.tbSongTitle.Size = new System.Drawing.Size(177, 21);
            this.tbSongTitle.TabIndex = 24;
            // 
            // lbSongLyrics
            // 
            this.lbSongLyrics.Enabled = false;
            this.lbSongLyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongLyrics.Location = new System.Drawing.Point(515, 22);
            this.lbSongLyrics.Name = "lbSongLyrics";
            this.lbSongLyrics.Size = new System.Drawing.Size(63, 23);
            this.lbSongLyrics.TabIndex = 23;
            this.lbSongLyrics.Text = "Lyrics:";
            // 
            // tbSongId
            // 
            this.tbSongId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSongId.Location = new System.Drawing.Point(8, 6);
            this.tbSongId.Name = "tbSongId";
            this.tbSongId.Size = new System.Drawing.Size(32, 21);
            this.tbSongId.TabIndex = 22;
            this.tbSongId.Visible = false;
            // 
            // btnSaveSong
            // 
            this.btnSaveSong.Enabled = false;
            this.btnSaveSong.Location = new System.Drawing.Point(663, 134);
            this.btnSaveSong.Name = "btnSaveSong";
            this.btnSaveSong.Size = new System.Drawing.Size(75, 30);
            this.btnSaveSong.TabIndex = 21;
            this.btnSaveSong.Text = "Lưu";
            this.btnSaveSong.UseVisualStyleBackColor = true;
            this.btnSaveSong.Click += new System.EventHandler(this.btnSaveSong_Click);
            // 
            // btnEditSong
            // 
            this.btnEditSong.Enabled = false;
            this.btnEditSong.Location = new System.Drawing.Point(564, 177);
            this.btnEditSong.Name = "btnEditSong";
            this.btnEditSong.Size = new System.Drawing.Size(75, 31);
            this.btnEditSong.TabIndex = 20;
            this.btnEditSong.Text = "Sửa";
            this.btnEditSong.UseVisualStyleBackColor = true;
            this.btnEditSong.Click += new System.EventHandler(this.btnEditSong_Click);
            // 
            // btnDeleteSong
            // 
            this.btnDeleteSong.Enabled = false;
            this.btnDeleteSong.Location = new System.Drawing.Point(663, 177);
            this.btnDeleteSong.Name = "btnDeleteSong";
            this.btnDeleteSong.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteSong.TabIndex = 19;
            this.btnDeleteSong.Text = "Xóa";
            this.btnDeleteSong.UseVisualStyleBackColor = true;
            this.btnDeleteSong.Click += new System.EventHandler(this.btnDeleteSong_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddSong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddSong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddSong.Location = new System.Drawing.Point(564, 134);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(75, 30);
            this.btnAddSong.TabIndex = 18;
            this.btnAddSong.Text = "Thêm mới";
            this.btnAddSong.UseVisualStyleBackColor = false;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // rtbSongLyrics
            // 
            this.rtbSongLyrics.Enabled = false;
            this.rtbSongLyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSongLyrics.Location = new System.Drawing.Point(515, 48);
            this.rtbSongLyrics.Multiline = true;
            this.rtbSongLyrics.Name = "rtbSongLyrics";
            this.rtbSongLyrics.Size = new System.Drawing.Size(269, 80);
            this.rtbSongLyrics.TabIndex = 17;
            // 
            // tbSongDuration
            // 
            this.tbSongDuration.Enabled = false;
            this.tbSongDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSongDuration.Location = new System.Drawing.Point(125, 91);
            this.tbSongDuration.Name = "tbSongDuration";
            this.tbSongDuration.Size = new System.Drawing.Size(177, 21);
            this.tbSongDuration.TabIndex = 14;
            // 
            // tbSongAlbum
            // 
            this.tbSongAlbum.Enabled = false;
            this.tbSongAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSongAlbum.Location = new System.Drawing.Point(125, 45);
            this.tbSongAlbum.Name = "tbSongAlbum";
            this.tbSongAlbum.Size = new System.Drawing.Size(177, 21);
            this.tbSongAlbum.TabIndex = 12;
            // 
            // lbSongReleaseDate
            // 
            this.lbSongReleaseDate.Enabled = false;
            this.lbSongReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongReleaseDate.Location = new System.Drawing.Point(21, 68);
            this.lbSongReleaseDate.Name = "lbSongReleaseDate";
            this.lbSongReleaseDate.Size = new System.Drawing.Size(100, 23);
            this.lbSongReleaseDate.TabIndex = 10;
            this.lbSongReleaseDate.Text = "Ngày Phát Hành";
            // 
            // lbSongDuration
            // 
            this.lbSongDuration.Enabled = false;
            this.lbSongDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongDuration.Location = new System.Drawing.Point(21, 91);
            this.lbSongDuration.Name = "lbSongDuration";
            this.lbSongDuration.Size = new System.Drawing.Size(70, 23);
            this.lbSongDuration.TabIndex = 9;
            this.lbSongDuration.Text = "Thời Lượng";
            // 
            // lbSongArtistId
            // 
            this.lbSongArtistId.Enabled = false;
            this.lbSongArtistId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongArtistId.Location = new System.Drawing.Point(21, 118);
            this.lbSongArtistId.Name = "lbSongArtistId";
            this.lbSongArtistId.Size = new System.Drawing.Size(70, 22);
            this.lbSongArtistId.TabIndex = 7;
            this.lbSongArtistId.Text = "Nghệ Sĩ:";
            // 
            // lbSongCatId
            // 
            this.lbSongCatId.Enabled = false;
            this.lbSongCatId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongCatId.Location = new System.Drawing.Point(19, 140);
            this.lbSongCatId.Name = "lbSongCatId";
            this.lbSongCatId.Size = new System.Drawing.Size(100, 23);
            this.lbSongCatId.TabIndex = 6;
            this.lbSongCatId.Text = "Danh Mục:";
            // 
            // lbSongAlbum
            // 
            this.lbSongAlbum.Enabled = false;
            this.lbSongAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongAlbum.Location = new System.Drawing.Point(21, 45);
            this.lbSongAlbum.Name = "lbSongAlbum";
            this.lbSongAlbum.Size = new System.Drawing.Size(63, 23);
            this.lbSongAlbum.TabIndex = 5;
            this.lbSongAlbum.Text = "Album";
            // 
            // lbSongTitle
            // 
            this.lbSongTitle.Enabled = false;
            this.lbSongTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongTitle.Location = new System.Drawing.Point(21, 22);
            this.lbSongTitle.Name = "lbSongTitle";
            this.lbSongTitle.Size = new System.Drawing.Size(63, 23);
            this.lbSongTitle.TabIndex = 4;
            this.lbSongTitle.Text = "Tiêu Đề:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(803, 212);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // dgvSong
            // 
            this.dgvSong.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSong.Location = new System.Drawing.Point(3, 214);
            this.dgvSong.Name = "dgvSong";
            this.dgvSong.Size = new System.Drawing.Size(803, 233);
            this.dgvSong.TabIndex = 1;
            this.dgvSong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSong_CellClick);
            // 
            // lbArtistCountry
            // 
            this.lbArtistCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtistCountry.Location = new System.Drawing.Point(28, 182);
            this.lbArtistCountry.Name = "lbArtistCountry";
            this.lbArtistCountry.Size = new System.Drawing.Size(100, 23);
            this.lbArtistCountry.TabIndex = 5;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(817, 476);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.From2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.PictureBox pictureBox5;

        private System.Windows.Forms.PictureBox pictureBox4;

        private System.Windows.Forms.PictureBox pictureBox3;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;

        private System.Windows.Forms.RichTextBox richTextBox1;

        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        private System.Windows.Forms.Label lbSongLyrics;

        private System.Windows.Forms.TextBox tbSongId;

        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnDeleteSong;
        private System.Windows.Forms.Button btnEditSong;
        private System.Windows.Forms.Button btnSaveSong;

        private System.Windows.Forms.TextBox tbSongAlbum;
        private System.Windows.Forms.TextBox tbSongDuration;
        private System.Windows.Forms.DateTimePicker dtpSongReleaseDate;
        private System.Windows.Forms.TextBox rtbSongLyrics;

        private System.Windows.Forms.TextBox tbSongTitle;

        private System.Windows.Forms.Label lbSongAlbum;
        private System.Windows.Forms.Label lbSongCatId;
        private System.Windows.Forms.Label lbSongArtistId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbSongDuration;
        private System.Windows.Forms.Label lbSongReleaseDate;

        private System.Windows.Forms.Label lbSongTitle;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.DataGridView dgvSong;

        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.Button btnSaveArtist;
        private System.Windows.Forms.Button btnEditArtist;
        private System.Windows.Forms.Button btnDeleteArtist;

        private System.Windows.Forms.TextBox tbArtistId;

        private System.Windows.Forms.DateTimePicker dtpArtistBirthDate;
        private System.Windows.Forms.TextBox tbArtistGenre;
        private System.Windows.Forms.RichTextBox rtbArtistBiography;

        private System.Windows.Forms.DataGridView dgvArtist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbArtistBiography;
        private System.Windows.Forms.Label lbArtistName;
        private System.Windows.Forms.Label lbArtistGenre;
        private System.Windows.Forms.Label lbArtistBirthDate;
        private System.Windows.Forms.Label lbArtistCountryj;

        private System.Windows.Forms.Label lbArtistCountry;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.DataGridView dgvCat;

        private System.Windows.Forms.TextBox tbCatDescription;

        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.Button btnDeleteCat;
        private System.Windows.Forms.Button btnSaveCat;
        private System.Windows.Forms.Button btnEditCat;

        private System.Windows.Forms.TextBox tbCatName;

        private System.Windows.Forms.TextBox tbArtistCountry;

        private System.Windows.Forms.TextBox tbCatId;
        private System.Windows.Forms.TextBox tbArtistName;

        private System.Windows.Forms.Label lbCatDescription;

        private System.Windows.Forms.Label lbCatName;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TabPage tabPage3;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        #endregion
    }
}