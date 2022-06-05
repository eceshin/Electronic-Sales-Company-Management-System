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
    public partial class frmUrunEkle : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        SqlCommand cmd = new SqlCommand();

        public frmUrunEkle(int id)
        {
            InitializeComponent();
            label6.Text = Convert.ToString(id);
        }

        private void button1_Click(object sender, EventArgs e)
       
        {
            
            cmd.CommandText = "insert UrunBilgi(UrunAdi,UrunStok,UrunFiyat,EklenmeTarihi) values(@urunadi,@stok,@fiyat,@datetime)";
            cmd.Connection = con;

            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@urunadi", txtUrunAdi2.Text);
            cmd.Parameters.AddWithValue("@fiyat", txtUrunFiyat2.Text);
            cmd.Parameters.AddWithValue("@stok", txtUrunStok2.Text);
            cmd.Parameters.AddWithValue("@datetime", dateTimePicker1.Value);

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                int sonuc = cmd.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    MessageBox.Show("Ürün Başaryla Eklendi");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            frmCalisan frmCalisan = (frmCalisan)Application.OpenForms["frmCalisan"];
            frmCalisan.UrunleriGetir();


        }

        private void btndon_Click(object sender, EventArgs e)
        {

            frmCalisan frmCalisan = new frmCalisan(Convert.ToInt32(label6.Text));
            frmCalisan.Show();
            this.Hide();

        }
    }
    }

