namespace kel7_tiketBus
{
    partial class FormTiket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTiket));
            lblNama = new Label();
            groupBox1 = new GroupBox();
            cmbjumlah = new ComboBox();
            cmbJam = new ComboBox();
            cmbKelas = new ComboBox();
            cmbTujuan = new ComboBox();
            cmbTahun = new ComboBox();
            cmbBulan = new ComboBox();
            cmbTanggal = new ComboBox();
            txtNoTelp = new TextBox();
            txtNama = new TextBox();
            lblTujuan = new Label();
            lblKelas = new Label();
            lblJumlahTiket = new Label();
            lblJam = new Label();
            lblTanggal = new Label();
            lblNoTelp = new Label();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            btnDetail = new Button();
            btnBack = new Button();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNama.Location = new Point(31, 83);
            lblNama.Margin = new Padding(5, 0, 5, 0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(216, 40);
            lblNama.TabIndex = 0;
            lblNama.Text = "nama pemesan";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbjumlah);
            groupBox1.Controls.Add(cmbJam);
            groupBox1.Controls.Add(cmbKelas);
            groupBox1.Controls.Add(cmbTujuan);
            groupBox1.Controls.Add(cmbTahun);
            groupBox1.Controls.Add(cmbBulan);
            groupBox1.Controls.Add(cmbTanggal);
            groupBox1.Controls.Add(txtNoTelp);
            groupBox1.Controls.Add(txtNama);
            groupBox1.Controls.Add(lblTujuan);
            groupBox1.Controls.Add(lblKelas);
            groupBox1.Controls.Add(lblJumlahTiket);
            groupBox1.Controls.Add(lblJam);
            groupBox1.Controls.Add(lblTanggal);
            groupBox1.Controls.Add(lblNoTelp);
            groupBox1.Controls.Add(lblNama);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(239, 166);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(1365, 424);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "PEMESANAN TIKET";
            // 
            // cmbjumlah
            // 
            cmbjumlah.FormattingEnabled = true;
            cmbjumlah.Location = new Point(1053, 250);
            cmbjumlah.Margin = new Padding(5);
            cmbjumlah.Name = "cmbjumlah";
            cmbjumlah.Size = new Size(205, 40);
            cmbjumlah.TabIndex = 16;
            // 
            // cmbJam
            // 
            cmbJam.FormattingEnabled = true;
            cmbJam.Location = new Point(422, 333);
            cmbJam.Margin = new Padding(5);
            cmbJam.Name = "cmbJam";
            cmbJam.Size = new Size(147, 40);
            cmbJam.TabIndex = 15;
            // 
            // cmbKelas
            // 
            cmbKelas.FormattingEnabled = true;
            cmbKelas.Location = new Point(1053, 166);
            cmbKelas.Margin = new Padding(5);
            cmbKelas.Name = "cmbKelas";
            cmbKelas.Size = new Size(201, 40);
            cmbKelas.TabIndex = 14;
            // 
            // cmbTujuan
            // 
            cmbTujuan.FormattingEnabled = true;
            cmbTujuan.Location = new Point(1053, 85);
            cmbTujuan.Margin = new Padding(5);
            cmbTujuan.Name = "cmbTujuan";
            cmbTujuan.Size = new Size(201, 40);
            cmbTujuan.TabIndex = 13;
            cmbTujuan.SelectedIndexChanged += cmbTujuan_SelectedIndexChanged;
            // 
            // cmbTahun
            // 
            cmbTahun.FormattingEnabled = true;
            cmbTahun.Location = new Point(658, 251);
            cmbTahun.Margin = new Padding(5);
            cmbTahun.Name = "cmbTahun";
            cmbTahun.Size = new Size(113, 40);
            cmbTahun.TabIndex = 12;
            // 
            // cmbBulan
            // 
            cmbBulan.FormattingEnabled = true;
            cmbBulan.Location = new Point(499, 251);
            cmbBulan.Margin = new Padding(5);
            cmbBulan.Name = "cmbBulan";
            cmbBulan.Size = new Size(147, 40);
            cmbBulan.TabIndex = 11;
            // 
            // cmbTanggal
            // 
            cmbTanggal.FormattingEnabled = true;
            cmbTanggal.Location = new Point(422, 251);
            cmbTanggal.Margin = new Padding(5);
            cmbTanggal.Name = "cmbTanggal";
            cmbTanggal.Size = new Size(64, 40);
            cmbTanggal.TabIndex = 10;
            cmbTanggal.SelectedIndexChanged += cmbTanggal_SelectedIndexChanged;
            // 
            // txtNoTelp
            // 
            txtNoTelp.Location = new Point(422, 166);
            txtNoTelp.Margin = new Padding(5);
            txtNoTelp.Name = "txtNoTelp";
            txtNoTelp.Size = new Size(201, 39);
            txtNoTelp.TabIndex = 7;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(422, 85);
            txtNama.Margin = new Padding(5);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(201, 39);
            txtNama.TabIndex = 2;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // lblTujuan
            // 
            lblTujuan.AutoSize = true;
            lblTujuan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTujuan.Location = new Point(835, 83);
            lblTujuan.Margin = new Padding(5, 0, 5, 0);
            lblTujuan.Name = "lblTujuan";
            lblTujuan.Size = new Size(101, 40);
            lblTujuan.TabIndex = 6;
            lblTujuan.Text = "tujuan";
            // 
            // lblKelas
            // 
            lblKelas.AutoSize = true;
            lblKelas.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblKelas.Location = new Point(835, 165);
            lblKelas.Margin = new Padding(5, 0, 5, 0);
            lblKelas.Name = "lblKelas";
            lblKelas.Size = new Size(82, 40);
            lblKelas.TabIndex = 5;
            lblKelas.Text = "kelas";
            // 
            // lblJumlahTiket
            // 
            lblJumlahTiket.AutoSize = true;
            lblJumlahTiket.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblJumlahTiket.Location = new Point(835, 250);
            lblJumlahTiket.Margin = new Padding(5, 0, 5, 0);
            lblJumlahTiket.Name = "lblJumlahTiket";
            lblJumlahTiket.Size = new Size(173, 40);
            lblJumlahTiket.TabIndex = 4;
            lblJumlahTiket.Text = "jumlah tiket";
            // 
            // lblJam
            // 
            lblJam.AutoSize = true;
            lblJam.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblJam.Location = new Point(31, 338);
            lblJam.Margin = new Padding(5, 0, 5, 0);
            lblJam.Name = "lblJam";
            lblJam.Size = new Size(296, 40);
            lblJam.TabIndex = 3;
            lblJam.Text = "jam pemberangkatan";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTanggal.Location = new Point(31, 250);
            lblTanggal.Margin = new Padding(5, 0, 5, 0);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(346, 40);
            lblTanggal.TabIndex = 2;
            lblTanggal.Text = "tanggal pemberangkatan";
            // 
            // lblNoTelp
            // 
            lblNoTelp.AutoSize = true;
            lblNoTelp.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNoTelp.Location = new Point(31, 165);
            lblNoTelp.Margin = new Padding(5, 0, 5, 0);
            lblNoTelp.Name = "lblNoTelp";
            lblNoTelp.Size = new Size(158, 40);
            lblNoTelp.TabIndex = 1;
            lblNoTelp.Text = "no telepon";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(738, 619);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(866, 267);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "INFORMASI";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(648, 72);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(10, 117);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(663, 32);
            label8.TabIndex = 0;
            label8.Text = "jika memesan tiket lebih 3 atau lebih mendapat diskon 10%";
            // 
            // btnDetail
            // 
            btnDetail.BackColor = SystemColors.GradientActiveCaption;
            btnDetail.Location = new Point(307, 658);
            btnDetail.Margin = new Padding(5);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(167, 72);
            btnDetail.TabIndex = 3;
            btnDetail.Text = "detail tiket";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.GradientActiveCaption;
            btnBack.Location = new Point(517, 658);
            btnBack.Margin = new Padding(5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(167, 72);
            btnBack.TabIndex = 5;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.GradientActiveCaption;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(702, 75);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(445, 52);
            label9.TabIndex = 6;
            label9.Text = "PEMESANAN TIKET BUS";
            // 
            // FormTiket
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1896, 1106);
            Controls.Add(label9);
            Controls.Add(btnBack);
            Controls.Add(btnDetail);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(5);
            Name = "FormTiket";
            Text = "FormTiket";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbKelas;
        private ComboBox cmbTujuan;
        private ComboBox cmbTahun;
        private ComboBox cmbBulan;
        private ComboBox cmbTanggal;
        private TextBox txtJumlahTiket;
        private TextBox txtNoTelp;
        private TextBox txtNama;
        private GroupBox groupBox2;
        private Label label8;
        private Button btnDetail;
        private Button btnBack;
        private Label label9;
        private Label lblNama;
        private Label lblTujuan;
        private Label lblKelas;
        private Label lblJumlahTiket;
        private Label lblJam;
        private Label lblTanggal;
        private Label lblNoTelp;
        private ComboBox cmbJam;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private ComboBox cmbjumlah;
    }
}