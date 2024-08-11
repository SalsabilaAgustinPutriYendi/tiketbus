using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kel7_tiketBus
{

    public partial class FormDetail : Form
    {
        private DataGridView dataGridView1;

        public string NamaDetail { get; set; }
        public string NoTelpDetail { get; set; }
        public string TanggalDetail { get; set; }
        public string BulanDetail { get; set; }

        public string TahunDetail { get; set; }
        public string JamDetail { get; set; }
        public string TujuanDetail { get; set; }
        public string KelasDetail { get; set; }

        public double DiskonDetail { get; set; }
        public string JumlahTiketDetail { get; set; }

        public string HargaDetail { get; set; }
        public int TotalBayarDetail { get; set; }



        public double NilaiDiskonDetail { get; set; }

        public FormDetail(string nama, string noTelp, string tanggal, string bulan, string tahun, string jam, string tujuan, string kelas, int jumlahTiket, int hargaPerTiket, int totalBayar, double diskon, double nilaiDiskon)
        {
            InitializeComponent();


            NamaDetail = nama;
            NoTelpDetail = noTelp;
            TanggalDetail = tanggal;
            BulanDetail = bulan;
            TahunDetail = tahun;
            JamDetail = jam;
            TujuanDetail = tujuan;
            KelasDetail = kelas;
            JumlahTiketDetail = jumlahTiket.ToString();
            HargaDetail = hargaPerTiket.ToString();
            TotalBayarDetail = totalBayar;
            DiskonDetail = diskon;
            NilaiDiskonDetail = nilaiDiskon;


            DisplayDetails();


        }

        private void DisplayDetails()
        {
            // Logika tampilan data pada elemen-elemen form
            nama.Text = $"{NamaDetail}";
            telepon.Text = $"{NoTelpDetail}";
            kelas.Text = $"{KelasDetail}";
            tujuan.Text = $"{TujuanDetail}";
            tgl.Text = $"{TanggalDetail}-{BulanDetail}-{TahunDetail}"; // Sesuaikan format tanggal

            jam.Text = $"{JamDetail}";
            harga.Text = $"{HargaDetail}";
            jumlah.Text = $"{JumlahTiketDetail}";

            diskon.Text = $"{NilaiDiskonDetail:C}"; // Menampilkan nilai diskon dalam format mata uang atau format angka yang sesuai

            double totalBayarSetelahDiskon = TotalBayarDetail - NilaiDiskonDetail;
            total.Text = $"{totalBayarSetelahDiskon:C}";

            if (dataGridView1 != null)
            {
                dataGridView1.DataSource = GetDataTable();
            }
        }


        private DataTable GetDataTable()
        {
            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataAdapter da;
            DataTable dt = new DataTable();

            string path = "Data Source=localhost; uid=root;pwd=;database=dbbus";

            try
            {
                con = new MySqlConnection(path);
                con.Open();

               
                // Perbarui query SQL untuk mengambil hanya data dengan tanggal_berangkat yang sesuai
                string query = "SELECT nama, no_telp,tgl_berangkat, tujuan, kelas, jumlah, total_bayar FROM tabeltiket";
                cmd = new MySqlCommand(query, con);
               
                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return dt;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // ...
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTiket formTiket = new FormTiket();
            formTiket.ShowDialog();
            this.Show();
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            SimpanDataKeDatabase();

            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataAdapter da;
            DataTable dt;

            string path = "Data Source=localhost; uid=root;pwd=;database=dbbus";

            try
            {
                con = new MySqlConnection(path);
                con.Open();

                string query = "SELECT nama, no_telp,tgl_berangkat, tujuan, kelas, jumlah, total_bayar FROM tabeltiket";
                cmd = new MySqlCommand(query, con);

                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();

                da.Fill(dt);

                // Kirim data ke FormData
                FormData formData = new FormData();
                formData.LoadData();  // Tambahkan metode baru di FormData untuk memuat data
                formData.Show();

                // Tampilkan data di dataGridView1 pada FormDetail
                DisplayDetails();

                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void SimpanDataKeDatabase()
        {
            using (MySqlConnection connection = new MySqlConnection("Data Source=localhost; uid=root;pwd=;database=dbbus"))
            {
                connection.Open();

                try
                {
                    // Contoh perintah SQL untuk menyimpan data ke tabeltiket
                    string query = "INSERT INTO tabeltiket (nama, no_telp, tgl_berangkat, tujuan, kelas, jumlah, total_bayar) " +
                                   "VALUES (@NamaDetail, @NoTelpDetail, @TanggalBerangkat, @TujuanDetail, @KelasDetail, @JumlahTiketDetail, @TotalBayarDetail)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Tambahkan parameter-parameter dengan tipe data yang sesuai
                        command.Parameters.AddWithValue("@NamaDetail", NamaDetail);
                        command.Parameters.AddWithValue("@NoTelpDetail", NoTelpDetail);
                        command.Parameters.AddWithValue("@TanggalBerangkat", $"{TanggalDetail}/{BulanDetail}/{TahunDetail}");
                        command.Parameters.AddWithValue("@TujuanDetail", TujuanDetail);
                        command.Parameters.AddWithValue("@KelasDetail", KelasDetail);
                        command.Parameters.AddWithValue("@JumlahTiketDetail", JumlahTiketDetail);
                        command.Parameters.AddWithValue("@TotalBayarDetail", TotalBayarDetail);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



    }
}

