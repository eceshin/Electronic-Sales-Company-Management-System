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
    public partial class frmCalisan : Form
    {


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        SqlCommand cmd = new SqlCommand();


        public void UrunleriGetir()
        {

            cmd.CommandText = "select * from UrunBilgi";
            cmd.Connection = con;

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlDataReader dr = cmd.ExecuteReader();
                listView1.Items.Clear();

                while (dr.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = dr["Id"].ToString();
                    lvi.SubItems.Add(dr["UrunAdi"].ToString());
                    lvi.SubItems.Add(dr["UrunFiyat"].ToString());
                    lvi.SubItems.Add(dr["UrunStok"].ToString());
                    lvi.SubItems.Add(dr["EklenmeTarihi"].ToString());


                    listView1.Items.Add(lvi);

                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

            public frmCalisan(int id)
        {
            InitializeComponent();
            cmd.CommandText = "select * from KullaniciBilgi where GirisId=@id";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@id", id);
            label15.Text = Convert.ToString(id);


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


                    label12.Text = isim;
                    label11.Text = soyadi;

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
            UrunleriGetir();
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            frmUrunEkle frm = new frmUrunEkle(Convert.ToInt32(label15.Text));
            frm.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUrunID.Text = listView1.FocusedItem.Text;
            txtUrunAdi.Text = listView1.FocusedItem.SubItems[1].Text;
            txtUrunFiyat.Text = listView1.FocusedItem.SubItems[2].Text;
            txtUrunStok.Text = listView1.FocusedItem.SubItems[3].Text;
            txtEklenmeTarihi.Text = listView1.FocusedItem.SubItems[4].Text;

        }
        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (listView1.FocusedItem == null)
                return;

            cmd.CommandText = "update UrunBilgi set UrunAdi=@urunadi,UrunFiyat=@fiyat,UrunStok=@stok where ID=@id";
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@urunadi", txtUrunAdi.Text);
            cmd.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(txtUrunFiyat.Text));
            cmd.Parameters.AddWithValue("@stok", txtUrunStok.Text);
            cmd.Parameters.AddWithValue("@id", txtUrunID.Text);

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                int sonuc = cmd.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    MessageBox.Show("Güncelleme Başarılı");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


            UrunleriGetir();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (listView1.FocusedItem == null)
                return;

            cmd.CommandText = "delete from UrunBilgi where ID=@id";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", txtUrunID.Text);

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                int sonuc = cmd.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt Silindi");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            UrunleriGetir();

        }

        private void btnUrunAra_Click(object sender, EventArgs e)
        {

            frmCalisanUrunAra frmUrunAra = new frmCalisanUrunAra(Convert.ToInt32(label15.Text));
            frmUrunAra.Show();
            this.Hide();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            this.Hide();
            frmGiris.Show();
        }

        private void frmCalisan_Load(object sender, EventArgs e)
        {

        }
    }
}
