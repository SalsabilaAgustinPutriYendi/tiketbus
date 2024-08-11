namespace kel7_tiketBus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnpemesanan = new Button();
            btnlist = new Button();
            btnexit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnpemesanan
            // 
            btnpemesanan.BackColor = SystemColors.GradientInactiveCaption;
            btnpemesanan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnpemesanan.Location = new Point(670, 349);
            btnpemesanan.Name = "btnpemesanan";
            btnpemesanan.Size = new Size(163, 57);
            btnpemesanan.TabIndex = 1;
            btnpemesanan.Text = "pemesanan tiket";
            btnpemesanan.UseVisualStyleBackColor = false;
            btnpemesanan.Click += btnpemesanan_Click;
            // 
            // btnlist
            // 
            btnlist.BackColor = SystemColors.GradientInactiveCaption;
            btnlist.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnlist.Location = new Point(670, 243);
            btnlist.Name = "btnlist";
            btnlist.Size = new Size(163, 57);
            btnlist.TabIndex = 2;
            btnlist.Text = "list pemesanan tiket";
            btnlist.UseVisualStyleBackColor = false;
            btnlist.Click += btnlist_Click;
            // 
            // btnexit
            // 
            btnexit.BackColor = SystemColors.GradientInactiveCaption;
            btnexit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnexit.Location = new Point(670, 443);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(163, 57);
            btnexit.TabIndex = 3;
            btnexit.Text = "exit";
            btnexit.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(91, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(455, 459);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1102, 714);
            Controls.Add(pictureBox1);
            Controls.Add(btnexit);
            Controls.Add(btnlist);
            Controls.Add(btnpemesanan);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnpemesanan;
        private Button btnlist;
        private Button btnexit;
        private PictureBox pictureBox1;
    }
}