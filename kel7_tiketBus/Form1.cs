using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace kel7_tiketBus
{
    public partial class Form1 : Form
    {
        private DataGridView dataGridView1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnpemesanan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTiket formTiket = new FormTiket();
            formTiket.ShowDialog();
            this.Show();
        }

        private void btnlist_Click(object sender, EventArgs e);
        {
            this.Hide();
            FormData formData = new FormData();
            
            MySqlConnection con = null;
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

                // Mengisi DataTable dengan data dari database
                da.Fill(dt);

                // Menampilkan data dalam DataGridView di FormData
                formData.myDataGridView.DataSource = dt; // Menggunakan MyDataGridView yang sudah diperbaiki

                // Menampilkan FormData sebagai dialog
                formData.ShowDialog();

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Pastikan untuk selalu menutup koneksi, bahkan jika terjadi kesalahan.
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e);

        }
    }
}
