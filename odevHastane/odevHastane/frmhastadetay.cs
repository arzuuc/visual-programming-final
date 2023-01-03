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
    public partial class frmhastadetay : Form
    {
        public frmhastadetay()
        {
            InitializeComponent();
        }
        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void frmhastadetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;

            // ad soyad cekme

            MySqlCommand komutt = new MySqlCommand("select hastaAd,hastaSoyad from tbl_hastalar where hastaTC=@p1", bgl.baglanti());
            komutt.Parameters.AddWithValue("@p1", LblTC.Text);
            MySqlDataReader dr = komutt.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] +" "+  dr[1];
            }
            bgl.baglanti().Close();

            //randevu getirme 

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from tbl_randevular where HastaTC= " + tc,bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            //klinik kısmı
            MySqlCommand komut2 = new MySqlCommand("select bransad from tbl_branslar", bgl.baglanti());
            MySqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            MySqlCommand komut3 = new MySqlCommand("select DoktorAd,DoktorSoyad from tbl_doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            MySqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            
            { 
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);

            }
            bgl.baglanti().Close();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from tbl_randevular where randevuBrans='" + cmbBrans.Text + " ' " + " and randevudoktor='" + cmbDoktor.Text+ " '  " , bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
                
        }

        private void LnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frmbilgiduzenle fr = new Frmbilgiduzenle();
            fr.TCno = LblTC.Text;
            fr.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void Btnrandevual_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand(" update tbl_randevular set randevuDurum=1,hastaTC=@p1,hastasikayet=@p2 where randevu_id=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            komut.Parameters.AddWithValue("@p2", rchsikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("randevu alındı", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
