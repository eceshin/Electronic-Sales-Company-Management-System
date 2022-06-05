using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ElektronikSatisSirketi
{
    public partial class frmYoneticiKullaniciEkle : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        public frmYoneticiKullaniciEkle(int id)
        {
            InitializeComponent();
            label5.Text = Convert.ToString(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "insert KullaniciBilgi(Adi,Soyadi,Adres,Telefon,Eposta,IseBaslamaTarihi,DogumTarihi,Yetki,fotoPath) values(@adi,@soyadi,@adres,@telefon,@eposta,@isebaslamatarihi,@dogumtarihi,@yetki,@fotopath)";
            cmd.Connection = con;

            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@adi", txtAdi.Text);
            cmd.Parameters.AddWithValue("@soyadi", txtSoyadi.Text);
            cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
            cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@eposta", txtEposta.Text);
            cmd.Parameters.AddWithValue("@isebaslamatarihi", dtIseBaslama.Value);
            cmd.Parameters.AddWithValue("@dogumtarihi", dtDogumTarihi.Value);
            cmd.Parameters.AddWithValue("@yetki", cmbYetki.Text);
          
            cmd.Parameters.AddWithValue("@fotopath", photoPath);


            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                int sonuc = cmd.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Başaryla Eklendi");
                    txtAdi.Text = " ";
                    txtSoyadi.Text = " ";
                    txtAdres.Text = " ";
                    txtEposta.Text = " ";
                    txtSoyadi.Text = " ";
                    txtTelefon.Text = " ";
                    
                    cmbYetki.Text = " ";

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmyoneticiGoruntule frmYonetici = new frmyoneticiGoruntule(Convert.ToInt32(label5.Text));
            this.Hide();
            frmYonetici.Show();
        }
        string photoPath = "";

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string sourcefilename = openFileDialog1.FileName;
                string extension = Path.GetExtension(sourcefilename);
                if (extension == ".jpg" || extension == ".jpeg" || extension == ".png")
                {


                    photoPath = "\\images\\" + RandomValueGenerator.GenerateFileName(extension);


                    string destinationfilename = Application.StartupPath + photoPath;


                    File.Copy(sourcefilename, destinationfilename);

                    pictureBox1.ImageLocation = destinationfilename;

                   

                }
                else
                {
                    MessageBox.Show("Lütfen Sadece resim seçiniz..");
                }






            }
        }
    }
}
