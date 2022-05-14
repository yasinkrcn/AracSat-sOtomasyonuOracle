using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracSatısOtomasyonuOracle
{
    internal class AracSatis
    {
        OracleConnection baglanti = new OracleConnection("Data Source=(DESCRIPTION =" +
        "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-H3UF2DM)(PORT = 1521))" +
        "(CONNECT_DATA =" +
         "(SERVER = DEDICATED)" +
         "(SERVICE_NAME = XEPDB1)" +
           ")" +
         ");User Id = YASIN;password=12345");

        DataTable tablo;
        public void ekle_sil_guncelle(OracleCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        public DataTable listele(OracleDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new OracleDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
    }
}
