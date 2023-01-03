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
    public partial class Frmsekretergiris : Form
    {
        public Frmsekretergiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("select * from tbl_sekreter where SekreterTC=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            MySqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Frmsekreterdetay frs = new Frmsekreterdetay();
                frs.TCnumara = mskTC.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI TC VEYA ŞİFRE");
            }
            bgl.baglanti().Close();
        }

        private void lnkuyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
