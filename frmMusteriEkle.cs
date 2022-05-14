using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracSatısOtomasyonuOracle
{
    public partial class frmMusteriEkle : Form
    {
        AracSatis arac_satis = new AracSatis();
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
        

           
            String commandText = "INSERT INTO MUSTERI (TC,ADSOYAD,TELEFON,ADRES,EMAIL) VALUES (:TC,:ADSOYAD,:TELEFON,:ADRES,:EMAIL)";
            OracleCommand komut2 = new OracleCommand();

 
            komut2.Parameters.Add("TC",txtTC.Text);
            komut2.Parameters.Add("ADSOYAD", txtAdSoyad.Text);
            komut2.Parameters.Add("TELEFON", txtTelNo.Text);
            komut2.Parameters.Add("ADRES", txtAdres.Text);
            komut2.Parameters.Add("EMAIL", txtEmail.Text);

            arac_satis.ekle_sil_guncelle(komut2, commandText);



            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
