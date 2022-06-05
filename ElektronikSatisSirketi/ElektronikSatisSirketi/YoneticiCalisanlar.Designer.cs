
namespace ElektronikSatisSirketi
{
    partial class frmCalisanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalisanlar));
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.ListViewCalisan.Size = new System.Drawing.Size(1085, 393);
            this.ListViewCalisan.TabIndex = 14;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1001, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 55);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // frmCalisanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(86)))), ((int)(((byte)(241)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1109, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListViewCalisan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalisanlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calisanlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}