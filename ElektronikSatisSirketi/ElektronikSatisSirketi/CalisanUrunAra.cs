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
    public partial class frmCalisanUrunAra : Form
    {
        public frmCalisanUrunAra(int id)
        {
            InitializeComponent();
            label5.Text = Convert.ToString(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            SqlCommand cmd = new SqlCommand();

            //ürün adına göre aramada hata
         //   cmd.CommandText = "select * from UrunBilgi where UrunAdi like @adi or UrunFiyat like @fiyat or UrunStok like @stok or EklenmeTarihi  like @tarih";
            cmd.Connection = con;
            string sorgUu = "select * from UrunBilgi where 1=1 ";

            if (!string.IsNullOrEmpty(txtada.Text))
            {
                sorgUu += " and UrunAdi = " + txtada.Text;
            }
            if (!string.IsNullOrEmpty(txtfiyata.Text))
            {
                sorgUu += " and UrunFiyat = " + txtfiyata.Text;
            }

            if (!string.IsNullOrEmpty(txtstoga.Text))
            {
                sorgUu += " and UrunStok = " + txtstoga.Text;
            }

            if (!string.IsNullOrEmpty(txttarihe.Text))
            {
                sorgUu += " and EklenmeTarihi = " + txttarihe.Text;
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
                listView2.Items.Clear();

                while (dr.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = dr["Id"].ToString();
                    lvi.SubItems.Add(dr["UrunAdi"].ToString());
                    lvi.SubItems.Add(dr["UrunFiyat"].ToString());
                    lvi.SubItems.Add(dr["UrunStok"].ToString());
                    lvi.SubItems.Add(dr["EklenmeTarihi"].ToString());


                    listView2.Items.Add(lvi);
                    
                }
                dr.Close();
                con.Close();

                txtada.Text = "";
                txtfiyata.Text = "";
                txtstoga.Text = "";
                txttarihe.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmCalisan frmcalisan = new frmCalisan(Convert.ToInt32(label5.Text));
            frmcalisan.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}