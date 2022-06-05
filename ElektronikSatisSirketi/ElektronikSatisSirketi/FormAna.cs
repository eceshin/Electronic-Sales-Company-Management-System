using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ElektronikSatisSirketi
{
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            frmGiris.Show();
            this.Hide();
        }

       
      

        private void button2_Click(object sender, EventArgs e)
        {
            FormYonGiris formYonGiris = new FormYonGiris();
            formYonGiris.Show();
            this.Hide();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visible = true;
        }
    }
}
