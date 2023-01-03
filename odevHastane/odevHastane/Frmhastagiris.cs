using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace odevHastane
{
    public partial class Frmhastagiris : Form
    {
        public Frmhastagiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            MySqlCommand komut = new MySqlCommand("select * from tbl_Hastalar where hastaTC=@p1 and hastasifre=@p2 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            MySqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmhastadetay fr = new frmhastadetay();
                fr.tc = mskTC.Text;
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("hatalı tc veya şifre ");

            }
            bgl.baglanti().Close();
        }

        private void lnkuyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmhastakayitcs fr = new frmhastakayitcs();
            fr.Show();
        }
    }
}
