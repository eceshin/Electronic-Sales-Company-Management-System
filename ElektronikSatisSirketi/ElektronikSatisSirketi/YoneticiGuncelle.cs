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
    public partial class frmYoneticiGuncelle : Form
    {
        public frmYoneticiGuncelle(int id)
        {
            InitializeComponent();
            label11.Text = Convert.ToString(id);
            CalisanGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmyoneticiGoruntule frmyoneticiGoruntule = new frmyoneticiGoruntule(Convert.ToInt32(label11.Text));
            this.Hide();
            frmyoneticiGoruntule.Show();

        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
       
        public void CalisanGetir()
        {

            cmd.CommandText = "select * from KullaniciBilgi";
            cmd.Connection = con;

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlDataReader dr = cmd.ExecuteReader();
                ListViewCalisan.Items.Clear();

                while (dr.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = dr["Id"].ToString();
                    lvi.SubItems.Add(dr["Adi"].ToString());
                    lvi.SubItems.Add(dr["Soyadi"].ToString());
                    lvi.SubItems.Add(dr["Adres"].ToString());
                    lvi.SubItems.Add(dr["Telefon"].ToString());
                    lvi.SubItems.Add(dr["Eposta"].ToString());
                    lvi.SubItems.Add(dr["IseBaslamaTarihi"].ToString());
                    lvi.SubItems.Add(dr["DogumTarihi"].ToString());
                    lvi.SubItems.Add(dr["Yetki"].ToString());
                    lvi.SubItems.Add(dr["GirisId"].ToString());

                    ListViewCalisan.Items.Add(lvi);

                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ListViewCalisan.FocusedItem == null)
                return;

            cmd.CommandText = "update KullaniciBilgi set Adi=@adi,Soyadi=@soyadi,Adres=@adres,Telefon=@telefon,Eposta=@eposta,IseBaslamaTarihi=@baslamatarihi,DogumTarihi=@dogumtarihi,Yetki=@yetki,GirisId=@girisid where Id=@id";
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@adi", txtAdi.Text);
            cmd.Parameters.AddWithValue("@soyadi", txtSoyadi.Text);
            cmd.Parameters.AddWithValue("@adres", txtAdress.Text);
            cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@eposta", txtEposta.Text);
            cmd.Parameters.AddWithValue("@baslamatarihi", txtBaslamaTarihi.Text);
            cmd.Parameters.AddWithValue("@dogumtarihi", txtDogumTarihi.Text);
            cmd.Parameters.AddWithValue("@yetki", txtYetki.Text);
            cmd.Parameters.AddWithValue("@girisid", txtGirisId.Text);
            cmd.Parameters.AddWithValue("@id", txtId.Text);

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


            CalisanGetir();
        }

        private void ListViewCalisan_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtId.Text = ListViewCalisan.FocusedItem.Text;
                txtAdi.Text = ListViewCalisan.FocusedItem.SubItems[1].Text;
                txtSoyadi.Text = ListViewCalisan.FocusedItem.SubItems[2].Text;
                txtAdress.Text = ListViewCalisan.FocusedItem.SubItems[3].Text;
                txtTelefon.Text = ListViewCalisan.FocusedItem.SubItems[4].Text;
                txtEposta.Text = ListViewCalisan.FocusedItem.SubItems[5].Text;
                txtBaslamaTarihi.Text = ListViewCalisan.FocusedItem.SubItems[6].Text;
                txtDogumTarihi.Text = ListViewCalisan.FocusedItem.SubItems[7].Text;
                txtYetki.Text = ListViewCalisan.FocusedItem.SubItems[8].Text;
            txtGirisId.Text = ListViewCalisan.FocusedItem.SubItems[9].Text;
            
        }
    }

    }

