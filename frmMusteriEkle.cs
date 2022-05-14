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
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            String connectionString = "Data Source=(DESCRIPTION =" +
        "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-H3UF2DM)(PORT = 1521))" +
        "(CONNECT_DATA =" +
         "(SERVER = DEDICATED)" +
         "(SERVICE_NAME = XEPDB1)" +
           ")" +
         ");User Id = YASIN;password=12345";

            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;


            con.Open();

            

            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO MUSTERI (TC,ADSOYAD,TELEFON,ADRES,EMAIL) VALUES ('"+ txtTC + "','"+ txtAdSoyad + "','"+ txtTelNo + "','"+ txtAdres + "','"+ txtEmail + "')";
            
           /* cmd.Parameters.Add("TC",txtTC);
            cmd.Parameters.Add("ADSOYAD", txtAdSoyad);
            cmd.Parameters.Add("TELEFON", txtTelNo);
            cmd.Parameters.Add("ADRES", txtAdres);
            cmd.Parameters.Add("EMAIL", txtEmail);
           */
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
