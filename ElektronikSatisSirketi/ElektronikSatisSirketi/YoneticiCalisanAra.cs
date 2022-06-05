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
    public partial class frmYoneticiCalisanAra : Form
    {
        public frmYoneticiCalisanAra(int id)
        {
            InitializeComponent();
            label5.Text = Convert.ToString(id);
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        string sorgUu;

        //bir kez arama yapıyor sadece

        private void button1_Click(object sender, EventArgs e)
        {


            cmd.Connection = con;
            sorgUu = "select * from KullaniciBilgi where 1=1 ";

            if (!string.IsNullOrEmpty(txtAdi.Text))
            {
                sorgUu += " and Adi = " + txtAdi.Text;
            }
            if (!string.IsNullOrEmpty(txtSoyadi.Text))
            {
                sorgUu += " and Soyadi = " + txtSoyadi.Text;
            }

            if (!string.IsNullOrEmpty(txtAdress.Text))
            {
                sorgUu += " and Adres = " + txtAdress.Text;
            }

            if (!string.IsNullOrEmpty(txtEposta.Text))
            {
                sorgUu += " and Eposta = " + txtEposta.Text;
            }
            if (!string.IsNullOrEmpty(txtBaslamaTarihi.Text))
            {
                sorgUu += " and IseBaslamaTarihi = " + txtBaslamaTarihi.Text;
            }
            if (!string.IsNullOrEmpty(txtDogumTarihi.Text))
            {
                sorgUu += " and IseBaslamaTarihi = " + txtDogumTarihi.Text;
            }
            if (!string.IsNullOrEmpty(txtYetki.Text))
            {
                sorgUu += " and Yetki = " + txtYetki.Text;
            }

            cmd.CommandText = sorgUu;

            //cmd.Parameters.AddWithValue("@adi", txtAda.Text);
            //cmd.Parameters.AddWithValue("@fiyat", txtfiyata.Text);
            //cmd.Parameters.AddWithValue("@stok", txtstoga.Text);
            //cmd.Parameters.AddWithValue("@tarih", txttarihe.Text);


            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlDataReader dr = cmd.ExecuteReader();
                ListViewCalisanAra.Items.Clear();

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

                    ListViewCalisanAra.Items.Add(lvi);

                }
                dr.Close();
                con.Close();

                txtAdi.Text = " ";
                txtSoyadi.Text = " ";
                txtAdress.Text = " ";
                txtEposta.Text = " ";
                txtSoyadi.Text = " ";
                txtTelefon.Text = " ";
                txtYetki.Text = " ";
                txtDogumTarihi.Text = " ";
                txtBaslamaTarihi.Text = " ";
                txtId.Text = " ";
                txtAdress.Text = " ";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            sorgUu = "";
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            
                frmyoneticiGoruntule frmYonetici = new frmyoneticiGoruntule(Convert.ToInt32(label5.Text));
                this.Hide();
                frmYonetici.Show();
            }
        }
    }

