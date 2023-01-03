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
    public partial class Frmsekreterdetay : Form
    {
        public Frmsekreterdetay()
        {
            InitializeComponent();
        }
        public string TCnumara;
        
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void Frmsekreterdetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCnumara;
            ;
            //ad soyad gtrme

            MySqlCommand komut1 = new MySqlCommand("select  SekreterAdSoyad from tbl_sekreter where SekreterTC=@p1 ", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lblTC.Text);
            MySqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbladsoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //bransları görmek
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select bransad from tbl_branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource=dt1;

            //doktorları aktarma 
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter("select (DoktorAd +' '+ DoktorSoyad) as 'DOKTORLAR',DoktorBrans from tbl_doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //bransı comboboxa aktarma
            MySqlCommand komut2 = new MySqlCommand("select bransad from tbl_branslar", bgl.baglanti());
            MySqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            MySqlCommand komutkaydet = new MySqlCommand("insert into tbl_randevular(randevuTarih,randevuSaat,randevuBrans,randevudoktor)values(@r1,@r2,@r3,@r4)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbbrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbdoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("RANDEVU OLUŞTURULDU");
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();

            MySqlCommand komut = new MySqlCommand("select DoktorAd,DoktorSoyad from tbl_doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbbrans.Text);
            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbdoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnduyuruolustur_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("insert into tbl_duyurular(duyuru) values(@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rchduyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("duyuru oluşturuldu");

        }

        private void btndoktorpanel_Click(object sender, EventArgs e)
        {
            frmdoktorpaneli drp = new frmdoktorpaneli();
            drp.Show();
        }

        private void btnbranspanel_Click(object sender, EventArgs e)
        {
            frmbrans frb = new frmbrans();
            frb.Show();
        }

        private void btnliste_Click(object sender, EventArgs e)
        {
            frmrandevulistesi frl = new frmrandevulistesi();
            frl.Show();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmduyurular fr = new frmduyurular();
            fr.Show();
        }
    }
}
