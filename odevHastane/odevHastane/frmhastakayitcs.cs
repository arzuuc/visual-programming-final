﻿using System;
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
    public partial class frmhastakayitcs : Form
    {
        public frmhastakayitcs()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Btnkayitol_Click(object sender, EventArgs e)
        {

            MySqlCommand komut = new MySqlCommand("insert into tbl_hastalar(hastaAd,hastaSoyad,hastaTC,hastaTelefon,hastasifre,hastacinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTC.Text);
            komut.Parameters.AddWithValue("@p4", msktelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtsifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbcinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("kaydınız oluşturuldu şifreniz: " + txtsifre.Text, "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
