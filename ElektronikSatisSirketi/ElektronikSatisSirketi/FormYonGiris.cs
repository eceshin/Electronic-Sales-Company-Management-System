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
    public partial class FormYonGiris : Form
    {
        public FormYonGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);

            SqlCommand cmd = new SqlCommand("sp_Giris", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //            create proc sp_Giris
            //(
            //   @kadi varchar(50),
            //           @sifre varchar(50)
            //       )
            //       as
            //           SELECT[Id]
            //              ,[KullaniciAdi]
            //              ,[Sifre]
            //              ,[Yetki]
            //            FROM[dbo].[GirisBilgi] where KullaniciAdi = @kadi and Sifre = @sifre



            cmd.Parameters.AddWithValue("@kadi", txtKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);

            con.Open();


            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                dr.Read();

                int yetki = (int)dr["Yetki"];
                int id = (int)dr["Id"];


                if (yetki == 1)
                {
                    frmyoneticiGoruntule frmyonetici = new frmyoneticiGoruntule(id);
                    frmyonetici.Show();
                    this.Hide();
                }


                else
                {
                    MessageBox.Show("Giriş Hatalı");


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAna formAna = new FormAna();
            formAna.Show();
            this.Hide();
        }
    }
}
