using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ElektronikSatisSirketi
{
    public partial class frmYoneticiSil : Form
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        public frmYoneticiSil(int id)
        {
            InitializeComponent();
            CalisanGetir();
            label1.Text = Convert.ToString(id);
        }
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




        private void btnCalisanSil_Click(object sender, EventArgs e)
        {

            if (ListViewCalisan.FocusedItem == null)
                return;

            cmd.CommandText = "delete from KullaniciBilgi where ID=@id";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", ListViewCalisan.FocusedItem.Text);


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
            CalisanGetir();

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            frmyoneticiGoruntule frmyoneticiGoruntule = new frmyoneticiGoruntule(Convert.ToInt32(label1.Text));
            frmyoneticiGoruntule.Show();
            this.Hide();
        }
    }
}
