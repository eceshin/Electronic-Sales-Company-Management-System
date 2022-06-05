
namespace ElektronikSatisSirketi
{
    partial class frmYoneticiSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYoneticiSil));
            this.btnCalisanSil = new System.Windows.Forms.Button();
            this.ListViewCalisan = new System.Windows.Forms.ListView();
            this.CalisanId = new System.Windows.Forms.ColumnHeader();
            this.Adi = new System.Windows.Forms.ColumnHeader();
            this.Soyadi = new System.Windows.Forms.ColumnHeader();
            this.Adres = new System.Windows.Forms.ColumnHeader();
            this.Telefon = new System.Windows.Forms.ColumnHeader();
            this.Eposta = new System.Windows.Forms.ColumnHeader();
            this.IseBaslamaTarihi = new System.Windows.Forms.ColumnHeader();
            this.DogumTarihi = new System.Windows.Forms.ColumnHeader();
            this.Yetki = new System.Windows.Forms.ColumnHeader();
            this.GirisId = new System.Windows.Forms.ColumnHeader();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalisanSil
            // 
            this.btnCalisanSil.BackColor = System.Drawing.Color.Transparent;
            this.btnCalisanSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalisanSil.BackgroundImage")));
            this.btnCalisanSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalisanSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanSil.Location = new System.Drawing.Point(507, 457);
            this.btnCalisanSil.Name = "btnCalisanSil";
            this.btnCalisanSil.Size = new System.Drawing.Size(121, 123);
            this.btnCalisanSil.TabIndex = 1;
            this.btnCalisanSil.UseVisualStyleBackColor = false;
            this.btnCalisanSil.Click += new System.EventHandler(this.btnCalisanSil_Click);
            // 
            // ListViewCalisan
            // 
            this.ListViewCalisan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CalisanId,
            this.Adi,
            this.Soyadi,
            this.Adres,
            this.Telefon,
            this.Eposta,
            this.IseBaslamaTarihi,
            this.DogumTarihi,
            this.Yetki,
            this.GirisId});
            this.ListViewCalisan.FullRowSelect = true;
            this.ListViewCalisan.GridLines = true;
            this.ListViewCalisan.HideSelection = false;
            this.ListViewCalisan.Location = new System.Drawing.Point(12, 12);
            this.ListViewCalisan.Name = "ListViewCalisan";
            this.ListViewCalisan.Size = new System.Drawing.Size(722, 439);
            this.ListViewCalisan.TabIndex = 13;
            this.ListViewCalisan.UseCompatibleStateImageBehavior = false;
            this.ListViewCalisan.View = System.Windows.Forms.View.Details;
            // 
            // CalisanId
            // 
            this.CalisanId.Text = " ID";
            // 
            // Adi
            // 
            this.Adi.Text = "Adı";
            this.Adi.Width = 100;
            // 
            // Soyadi
            // 
            this.Soyadi.Text = "Soyadı";
            this.Soyadi.Width = 100;
            // 
            // Adres
            // 
            this.Adres.Text = "Adres";
            this.Adres.Width = 200;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 100;
            // 
            // Eposta
            // 
            this.Eposta.Text = "Eposta";
            this.Eposta.Width = 200;
            // 
            // IseBaslamaTarihi
            // 
            this.IseBaslamaTarihi.Text = "İşe Başlama Tarihi";
            this.IseBaslamaTarihi.Width = 100;
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.Text = "Doğum Tarihi";
            this.DogumTarihi.Width = 100;
            // 
            // Yetki
            // 
            this.Yetki.Text = "Yetki";
            // 
            // GirisId
            // 
            this.GirisId.Text = "Giriş Id";
            // 
            // txtAdres
            // 
            this.txtAdres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAdres.Location = new System.Drawing.Point(399, -275);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(153, 31);
            this.txtAdres.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(634, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 64);
            this.button1.TabIndex = 57;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 457);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 129);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 625);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "label1";
            // 
            // frmYoneticiSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(745, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.ListViewCalisan);
            this.Controls.Add(this.btnCalisanSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmYoneticiSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yonetici";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalisanSil;
        private System.Windows.Forms.ListView ListViewCalisan;
        private System.Windows.Forms.ColumnHeader CalisanId;
        private System.Windows.Forms.ColumnHeader Adi;
        private System.Windows.Forms.ColumnHeader Soyadi;
        private System.Windows.Forms.ColumnHeader Adres;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Eposta;
        private System.Windows.Forms.ColumnHeader IseBaslamaTarihi;
        private System.Windows.Forms.ColumnHeader DogumTarihi;
        private System.Windows.Forms.ColumnHeader Yetki;
        private System.Windows.Forms.ColumnHeader GirisId;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}