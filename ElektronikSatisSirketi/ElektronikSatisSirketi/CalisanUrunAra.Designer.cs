
namespace ElektronikSatisSirketi
{
    partial class frmCalisanUrunAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalisanUrunAra));
            this.txtada = new System.Windows.Forms.TextBox();
            this.txtstoga = new System.Windows.Forms.TextBox();
            this.txtfiyata = new System.Windows.Forms.TextBox();
            this.txttarihe = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.UrunID = new System.Windows.Forms.ColumnHeader();
            this.UrunAdi = new System.Windows.Forms.ColumnHeader();
            this.UrunFiyat = new System.Windows.Forms.ColumnHeader();
            this.UrunStok = new System.Windows.Forms.ColumnHeader();
            this.EklenmeTarihi = new System.Windows.Forms.ColumnHeader();
            this.btnGeri = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtada
            // 
            this.txtada.Location = new System.Drawing.Point(840, 51);
            this.txtada.Name = "txtada";
            this.txtada.Size = new System.Drawing.Size(160, 31);
            this.txtada.TabIndex = 0;
            // 
            // txtstoga
            // 
            this.txtstoga.Location = new System.Drawing.Point(579, 51);
            this.txtstoga.Name = "txtstoga";
            this.txtstoga.Size = new System.Drawing.Size(160, 31);
            this.txtstoga.TabIndex = 2;
            // 
            // txtfiyata
            // 
            this.txtfiyata.Location = new System.Drawing.Point(326, 51);
            this.txtfiyata.Name = "txtfiyata";
            this.txtfiyata.Size = new System.Drawing.Size(160, 31);
            this.txtfiyata.TabIndex = 3;
            // 
            // txttarihe
            // 
            this.txttarihe.Location = new System.Drawing.Point(67, 51);
            this.txttarihe.Name = "txttarihe";
            this.txttarihe.Size = new System.Drawing.Size(160, 31);
            this.txttarihe.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(390, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 69);
            this.button1.TabIndex = 6;
            this.button1.Text = "Arama Yap";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(869, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Adına Göre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(589, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Stoğuna Göre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(344, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fiyatına Göre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Eklenme Tarihine Göre";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UrunID,
            this.UrunAdi,
            this.UrunFiyat,
            this.UrunStok,
            this.EklenmeTarihi});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(42, 12);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1004, 280);
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // UrunID
            // 
            this.UrunID.Text = "UrunID";
            this.UrunID.Width = 200;
            // 
            // UrunAdi
            // 
            this.UrunAdi.Text = "Urun Adi";
            this.UrunAdi.Width = 200;
            // 
            // UrunFiyat
            // 
            this.UrunFiyat.Text = "Urun Fiyat";
            this.UrunFiyat.Width = 200;
            // 
            // UrunStok
            // 
            this.UrunStok.Text = "Urun Stok";
            this.UrunStok.Width = 200;
            // 
            // EklenmeTarihi
            // 
            this.EklenmeTarihi.Text = "Eklenme Tarihi";
            this.EklenmeTarihi.Width = 200;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.Location = new System.Drawing.Point(625, 30);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(62, 69);
            this.btnGeri.TabIndex = 14;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(86)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.btnGeri);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 474);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 122);
            this.panel1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "EceMarkt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Kunstler Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 78);
            this.label7.TabIndex = 19;
            this.label7.Text = "E";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1230, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "label5";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txttarihe);
            this.panel2.Controls.Add(this.txtfiyata);
            this.panel2.Controls.Add(this.txtstoga);
            this.panel2.Controls.Add(this.txtada);
            this.panel2.Location = new System.Drawing.Point(0, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1239, 153);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(620, 88);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(369, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(893, 88);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(69, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(545, 38);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 49);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // frmCalisanUrunAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(1)))), ((int)(((byte)(86)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1095, 596);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalisanUrunAra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalisanUrunAra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtada;
        private System.Windows.Forms.TextBox txtstoga;
        private System.Windows.Forms.TextBox txtfiyata;
        private System.Windows.Forms.TextBox txttarihe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader UrunID;
        private System.Windows.Forms.ColumnHeader UrunAdi;
        private System.Windows.Forms.ColumnHeader UrunFiyat;
        private System.Windows.Forms.ColumnHeader UrunStok;
        private System.Windows.Forms.ColumnHeader EklenmeTarihi;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}