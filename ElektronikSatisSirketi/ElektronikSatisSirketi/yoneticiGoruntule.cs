using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ElektronikSatisSirketi
{
    public partial class frmyoneticiGoruntule : Form
    {
        public frmyoneticiGoruntule()
        {
            InitializeComponent();
        }
        public frmyoneticiGoruntule(int id)
        {
            InitializeComponent();
            cmd.CommandText = "select * from KullaniciBilgi where GirisId=@id";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@id", id);
            label4.Text =Convert.ToString(id);


            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                 string isim = (string)dr["Adi"];
                 string soyadi = (string)dr["Soyadi"];
                 string photo = (string)dr["FotoPath"];


                    label6.Text = isim;
                    label9.Text = soyadi;

                    string destinationfilename = Application.StartupPath + photo;

                    pictureBox2.ImageLocation = destinationfilename;

                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            SqlCommand cmd = new SqlCommand();

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {

            frmYoneticiKullaniciEkle frmKullaniciEkle = new frmYoneticiKullaniciEkle(Convert.ToInt16(label4.Text));
            frmKullaniciEkle.Show();
            this.Hide();
        }

        private void btnCalisanAra_Click(object sender, EventArgs e)
        {
            frmYoneticiCalisanAra frmCalisanAra = new frmYoneticiCalisanAra(Convert.ToInt16(label4.Text));
            this.Hide();
            frmCalisanAra.Show();
        }

        private void btnCalisanGuncelle_Click(object sender, EventArgs e)
        {
            frmYoneticiGuncelle yoneticiGuncelle = new frmYoneticiGuncelle(Convert.ToInt16(label4.Text));
            this.Hide();
            yoneticiGuncelle.Show();
        }

        private void btnCalisanSil_Click(object sender, EventArgs e)
        {
            frmYoneticiSil frmYoneticiSil = new frmYoneticiSil(Convert.ToInt16(label4.Text));
            frmYoneticiSil.Show();
            this.Hide();
        }

       
        private void button2_Click_1(object sender, EventArgs e)
        {
            FormYonGiris frmGiris = new FormYonGiris();
            this.Hide();
            frmGiris.Show();
        }

        private void btnCalisanSatisGoruntule_Click(object sender, EventArgs e)
        {
            frmCalisanlar frmCalisanlar = new frmCalisanlar(Convert.ToInt16(label4.Text));
            this.Hide();
            frmCalisanlar.Show();
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox3.Hide();
            pictureBox4.Hide();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox3.Show();
            pictureBox4.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox3.Hide();
            pictureBox4.Show();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox7.Show();
            pictureBox6.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox7.Hide();
            pictureBox6.Show();
        }

       
    }
}
