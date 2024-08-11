using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kel7_tiketBus
{
    public partial class FormData : Form
    {
        // Ganti nama property dataGridView1 menjadi myDataGridView
        public DataGridView myDataGridView { get; set; }

        public FormData()
        {
            InitializeComponent();

            // Inisialisasi myDataGridView di sini
            myDataGridView = new DataGridView();
            myDataGridView.AutoGenerateColumns = true;

            // Atur properti dan tata letak myDataGridView
            myDataGridView.Location = new System.Drawing.Point(88, 149);
            myDataGridView.Size = new System.Drawing.Size(1450, 386);
            myDataGridView.Anchor = AnchorStyles.None;
            myDataGridView.Location = new Point((this.ClientSize.Width - myDataGridView.Width) / 2, (this.ClientSize.Height - myDataGridView.Height) / 2);


            // Tambahkan myDataGridView ke Controls Form
            Controls.Add(myDataGridView);

            // Panggil metode LoadData saat konstruktor dijalankan
            LoadData();
        }

        // ... (code lainnya tetap sama)

        public void LoadData()
        {
            // Dapatkan data dari database dan isi myDataGridView
            DataTable data = GetDataFromDatabase();

            // Ganti dataGridView1 menjadi myDataGridView
            if (myDataGridView != null) // Periksa apakah myDataGridView sudah diinisialisasi
            {
                myDataGridView.DataSource = data;
            }
        }
        private DataTable GetDataFromDatabase()
        {
            DataTable data = new DataTable();

            using (MySqlConnection connection = new MySqlConnection("Data Source=localhost; uid=root;pwd=;database=dbbus"))
            {
                connection.Open();

                // Perintah SQL untuk mengambil data dari tabeltiket
                string query = "SELECT nama, no_telp,tgl_berangkat, tujuan, kelas, jumlah, total_bayar FROM tabeltiket";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Menggunakan MySqlDataAdapter untuk mengisi DataTable dengan hasil query
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        // Mengisi DataTable dengan data dari database
                        adapter.Fill(data);
                    }
                }
            }

            return data;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (myDataGridView.SelectedRows.Count > 0)
                {
                    int rowIndex = myDataGridView.SelectedRows[0].Index;
                    DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        HapusDataDariDatabase(rowIndex);
                        LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Pilih baris yang ingin dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void HapusDataDariDatabase(int rowIndex)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Data Source=localhost; uid=root;pwd=;database=dbbus");
                connection.Open();

                string nama = myDataGridView.Rows[rowIndex].Cells["nama"].Value.ToString();
                string noTelp = myDataGridView.Rows[rowIndex].Cells["no_telp"].Value.ToString();

                string query = "DELETE FROM tabeltiket WHERE nama = @Nama AND no_telp = @NoTelp";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nama", nama);
                    command.Parameters.AddWithValue("@NoTelp", noTelp);

                    int affectedRows = command.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan atau tidak berhasil dihapus", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Show();
        }
    }
}
