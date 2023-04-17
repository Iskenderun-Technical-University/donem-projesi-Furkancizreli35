namespace Kütüphane
{
    partial class Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.silkullanıcıbtn = new System.Windows.Forms.Button();
            this.düzenlekullanıcıbtn = new System.Windows.Forms.Button();
            this.eklekullanıcıbtn = new System.Windows.Forms.Button();
            this.kullanıcılarbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.silkullanıcıbtn);
            this.panel1.Controls.Add(this.düzenlekullanıcıbtn);
            this.panel1.Controls.Add(this.eklekullanıcıbtn);
            this.panel1.Controls.Add(this.kullanıcılarbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 576);
            this.panel1.TabIndex = 0;
            // 
            // silkullanıcıbtn
            // 
            this.silkullanıcıbtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.silkullanıcıbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.silkullanıcıbtn.Image = ((System.Drawing.Image)(resources.GetObject("silkullanıcıbtn.Image")));
            this.silkullanıcıbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.silkullanıcıbtn.Location = new System.Drawing.Point(0, 226);
            this.silkullanıcıbtn.Name = "silkullanıcıbtn";
            this.silkullanıcıbtn.Size = new System.Drawing.Size(200, 75);
            this.silkullanıcıbtn.TabIndex = 3;
            this.silkullanıcıbtn.Text = "            Sil";
            this.silkullanıcıbtn.UseVisualStyleBackColor = false;
            // 
            // düzenlekullanıcıbtn
            // 
            this.düzenlekullanıcıbtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.düzenlekullanıcıbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.düzenlekullanıcıbtn.Image = ((System.Drawing.Image)(resources.GetObject("düzenlekullanıcıbtn.Image")));
            this.düzenlekullanıcıbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.düzenlekullanıcıbtn.Location = new System.Drawing.Point(0, 151);
            this.düzenlekullanıcıbtn.Name = "düzenlekullanıcıbtn";
            this.düzenlekullanıcıbtn.Size = new System.Drawing.Size(200, 75);
            this.düzenlekullanıcıbtn.TabIndex = 2;
            this.düzenlekullanıcıbtn.Text = "            Düzenle";
            this.düzenlekullanıcıbtn.UseVisualStyleBackColor = false;
            this.düzenlekullanıcıbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // eklekullanıcıbtn
            // 
            this.eklekullanıcıbtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eklekullanıcıbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.eklekullanıcıbtn.Image = ((System.Drawing.Image)(resources.GetObject("eklekullanıcıbtn.Image")));
            this.eklekullanıcıbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eklekullanıcıbtn.Location = new System.Drawing.Point(0, 76);
            this.eklekullanıcıbtn.Name = "eklekullanıcıbtn";
            this.eklekullanıcıbtn.Size = new System.Drawing.Size(200, 75);
            this.eklekullanıcıbtn.TabIndex = 1;
            this.eklekullanıcıbtn.Text = "            Ekle";
            this.eklekullanıcıbtn.UseVisualStyleBackColor = false;
            // 
            // kullanıcılarbtn
            // 
            this.kullanıcılarbtn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.kullanıcılarbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kullanıcılarbtn.BackgroundImage")));
            this.kullanıcılarbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kullanıcılarbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.kullanıcılarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kullanıcılarbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.kullanıcılarbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kullanıcılarbtn.Location = new System.Drawing.Point(0, 0);
            this.kullanıcılarbtn.Name = "kullanıcılarbtn";
            this.kullanıcılarbtn.Size = new System.Drawing.Size(200, 76);
            this.kullanıcılarbtn.TabIndex = 0;
            this.kullanıcılarbtn.Text = "             Kullanıcılar";
            this.kullanıcılarbtn.UseVisualStyleBackColor = false;
            this.kullanıcılarbtn.Click += new System.EventHandler(this.kullanıcılarbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 59);
            this.panel2.TabIndex = 1;
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Panel";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.Panel_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button eklekullanıcıbtn;
        private System.Windows.Forms.Button kullanıcılarbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button silkullanıcıbtn;
        private System.Windows.Forms.Button düzenlekullanıcıbtn;
    }
}