using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kel7_tiketBus
{

    public partial class FormTiket : Form
    {


        private const int HARGA_EKSEKUTIF_BUKITTINGGI = 25000;
        private const int HARGA_EKSEKUTIF_PADANG = 20000;
        private const int HARGA_EKSEKUTIF_PAYAKUMBUH = 35000;

        private const int HARGA_PREMIUM_BUKITTINGGI = 75000;
        private const int HARGA_PREMIUM_PADANG = 50000;
        private const int HARGA_PREMIUM_PAYAKUMBUH = 90000;
        private object txtTotalBayar;

        public FormTiket()
        {
            InitializeComponent();



            // Isi ComboBox Tanggal
            for (int i = 1; i <= 31; i++)
            {
                cmbTanggal.Items.Add(i.ToString());
            }

            // Isi ComboBox Bulan
            string[] namaBulan = { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
            cmbBulan.Items.AddRange(namaBulan);


            for (int i = 2022; i <= 2030; i++)
            {
                cmbTahun.Items.Add(i.ToString());
            }


            cmbTanggal.SelectedIndex = 0;
            cmbBulan.SelectedIndex = 0;
            cmbTahun.SelectedIndex = 0;


            cmbTujuan.Items.Add("Padang");
            cmbTujuan.Items.Add("Bukittinggi");
            cmbTujuan.Items.Add("Payakumbuh");


            cmbKelas.Items.Add("Eksekutif");
            cmbKelas.Items.Add("Premium");


            cmbJam.Items.Add("08:00");
            cmbJam.Items.Add("08:45");
            cmbJam.Items.Add("09:00");
            cmbJam.Items.Add("09:45");
            cmbJam.Items.Add("10:00");
            cmbJam.Items.Add("10:45");


            cmbTujuan.SelectedIndex = 0;
            cmbKelas.SelectedIndex = 0;

            
            // jumlah tiket
            for (int i = 1; i <= 31; i++)
            {
                cmbjumlah.Items.Add(i.ToString());
            }


        }


        private void btnDetail_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text;
            string noTelp = txtNoTelp.Text;
            string tanggal = cmbTanggal.SelectedItem.ToString();
            string bulan = cmbBulan.SelectedItem.ToString();
            string tahun = cmbTahun.SelectedItem.ToString();
            string jam = (cmbJam.SelectedItem as string) ?? string.Empty;
            string tujuan = cmbTujuan.SelectedItem.ToString();
            string kelas = cmbKelas.SelectedItem.ToString();
            int jumlahTiket = Convert.ToInt32(cmbjumlah.ToString);


            int hargaPerTiket = O;

            if (kelas == "Eksekutif")
            {
                switch (tujuan)
                {
                    case "Bukittinggi":
                        hargaPerTiket = HARGA_EKSEKUTIF_BUKITTINGGI;
                        break;
                    case "Padang":
                        hargaPerTiket = HARGA_EKSEKUTIF_PADANG;
                        break;
                    case "Payakumbuh":
                        hargaPerTiket = HARGA_EKSEKUTIF_PAYAKUMBUH;
                        break;
                }
            }
            else if (kelas == "Premium")
            {
                switch (tujuan)
                {
                    case "Bukittinggi":
                        hargaPerTiket = HARGA_PREMIUM_BUKITTINGGI;
                        break;
                    case "Padang":
                        hargaPerTiket = HARGA_PREMIUM_PADANG;
                        break;
                    case "Payakumbuh":
                        hargaPerTiket = HARGA_PREMIUM_PAYAKUMBUH;
                        break;
                }
            }

            int totalBayar = jumlahTiket * hargaPerTiket;

            double diskon = (jumlahTiket >= 3) ? 0.1 : 0;
            double nilaiDiskon = totalBayar * diskon;
            totalBayar -= (int)nilaiDiskon;



            this.Hide();

            FormDetail formDetail = new FormDetail(
            nama,
            noTelp,
            tanggal,
            bulan,
            tahun,
            jam,
            tujuan,
            kelas,
            jumlahTiket,
            hargaPerTiket,
            totalBayar,
            diskon,
            nilaiDiskon
             );



            formDetail.ShowDialog();


            this.Show();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJumlahTiket_TextChanged(object sender, EventArgs e)
        {

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

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void cmbTujuan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTanggal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
