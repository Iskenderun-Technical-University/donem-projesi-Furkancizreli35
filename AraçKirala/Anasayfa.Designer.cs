namespace AraçKirala
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.btnAracListele = new System.Windows.Forms.Button();
            this.btnSözlesme = new System.Windows.Forms.Button();
            this.btnSatislar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(863, 672);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1005, 500);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriEkle.Image")));
            this.btnMusteriEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriEkle.Location = new System.Drawing.Point(12, 33);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(147, 77);
            this.btnMusteriEkle.TabIndex = 2;
            this.btnMusteriEkle.Text = "                      Müşteri ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriListele.Image")));
            this.btnMusteriListele.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMusteriListele.Location = new System.Drawing.Point(12, 116);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(147, 77);
            this.btnMusteriListele.TabIndex = 3;
            this.btnMusteriListele.Text = "                    Müşteri Listele";
            this.btnMusteriListele.UseVisualStyleBackColor = true;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnAracEkle.Image")));
            this.btnAracEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAracEkle.Location = new System.Drawing.Point(12, 199);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(147, 77);
            this.btnAracEkle.TabIndex = 4;
            this.btnAracEkle.Text = "                   Araç Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = true;
            // 
            // btnAracListele
            // 
            this.btnAracListele.Image = ((System.Drawing.Image)(resources.GetObject("btnAracListele.Image")));
            this.btnAracListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAracListele.Location = new System.Drawing.Point(12, 282);
            this.btnAracListele.Name = "btnAracListele";
            this.btnAracListele.Size = new System.Drawing.Size(147, 77);
            this.btnAracListele.TabIndex = 5;
            this.btnAracListele.Text = "                   Araç Listele";
            this.btnAracListele.UseVisualStyleBackColor = true;
            // 
            // btnSözlesme
            // 
            this.btnSözlesme.Image = ((System.Drawing.Image)(resources.GetObject("btnSözlesme.Image")));
            this.btnSözlesme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSözlesme.Location = new System.Drawing.Point(12, 365);
            this.btnSözlesme.Name = "btnSözlesme";
            this.btnSözlesme.Size = new System.Drawing.Size(147, 77);
            this.btnSözlesme.TabIndex = 6;
            this.btnSözlesme.Text = "                  Sözleşme";
            this.btnSözlesme.UseVisualStyleBackColor = true;
            // 
            // btnSatislar
            // 
            this.btnSatislar.Image = ((System.Drawing.Image)(resources.GetObject("btnSatislar.Image")));
            this.btnSatislar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatislar.Location = new System.Drawing.Point(12, 448);
            this.btnSatislar.Name = "btnSatislar";
            this.btnSatislar.Size = new System.Drawing.Size(147, 77);
            this.btnSatislar.TabIndex = 7;
            this.btnSatislar.Text = "                   Araç Satış";
            this.btnSatislar.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(42, 583);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 77);
            this.btnExit.TabIndex = 8;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1036, 672);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSatislar);
            this.Controls.Add(this.btnSözlesme);
            this.Controls.Add(this.btnAracListele);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.btnMusteriListele);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.Button btnAracListele;
        private System.Windows.Forms.Button btnSözlesme;
        private System.Windows.Forms.Button btnSatislar;
        private System.Windows.Forms.Button btnExit;
    }
}

