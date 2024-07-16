using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalismaTakibi.Classes;
using System.Globalization;

namespace CalismaTakibi
{
    public partial class Form1 : Form
    {
        CultureInfo turkishCulture = new CultureInfo("tr-TR");
        
        public float carpan = 0;
        public int _gorevID;
        public string _gorevCat, _gorevName;
        public float _gorevDiff;

        public Form1()
        {
            InitializeComponent();
            RefreshYapilanlarTable();
            RefreshComboBoxKategoriler();
            RefreshSonuclar();
        }

        //Tabloyu seçili tarihe göre günceller.
        public void RefreshYapilanlarTable()
        {
            SqlCommand verileriGetir = new SqlCommand("SELECT checkGorevID as ID, tarihY as Tarih, kategoriY as Kategori, gorevY as Görev, sureY as Süre, puanY as Puan FROM yapilanlarTable  WHERE tarihY = @pTarih", SqlBaglanti.connection);
            SqlBaglanti.CheckConnection(SqlBaglanti.connection);

            DateTime selectedTime = dateTimePicker.Value.Date;
            verileriGetir.Parameters.AddWithValue("@pTarih", selectedTime);

            SqlDataAdapter adapter = new SqlDataAdapter(verileriGetir);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewYapilanlar.DataSource = dt;
        }

        //Combo Box'a, veritabanından çekilen kategorilerle item ekler.
        public void RefreshComboBoxKategoriler()
        {
            SqlCommand verileriGetir = new SqlCommand("SELECT gorevID, gorevCat, gorevName, gorevDiff FROM gorevTable", SqlBaglanti.connection);
            SqlBaglanti.CheckConnection (SqlBaglanti.connection);

            SqlDataReader reader = verileriGetir.ExecuteReader();
            while (reader.Read())
            {
                _gorevID = reader.GetInt32(reader.GetOrdinal("gorevID"));
                _gorevCat = reader.GetString(reader.GetOrdinal("gorevCat"));
                _gorevName = reader.GetString(reader.GetOrdinal("gorevName"));
                _gorevDiff = float.Parse(reader["gorevDiff"].ToString(), turkishCulture);
                comboBoxKategoriler.Items.Add(new Gorevler { GorevID = _gorevID, GorevCat = _gorevCat, GorevName = _gorevName, GorevDiff = _gorevDiff });
            }
            reader.Close();
            comboBoxKategoriler.SelectedIndex = 0; //İlk kategori otomatik olarak seçilir.
        }

        //İstatistikleri günceller.
        public void RefreshSonuclar()
        {
            DateTime selectedTime = dateTimePicker.Value.Date;

            SqlCommand verileriGetir = new SqlCommand("SELECT SUM(CAST(DATEDIFF(MINUTE, '00:00:00', sureY) AS int)) AS ToplamDakika, SUM(puanY) AS ToplamPuan FROM yapilanlarTable WHERE tarihY=@pTarih", SqlBaglanti.connection);
            SqlBaglanti.CheckConnection(SqlBaglanti.connection);
            verileriGetir.Parameters.AddWithValue("@pTarih", selectedTime);

            SqlDataReader reader = verileriGetir.ExecuteReader();
            if (reader.Read())
            {
                object sureSonuc = reader["ToplamDakika"];
                int toplamSure = sureSonuc != DBNull.Value ? (int)sureSonuc : 0;

                object puanSonuc = reader["ToplamPuan"];
                float toplamPuan = puanSonuc != DBNull.Value ? Convert.ToSingle(puanSonuc) : 0;

                int saat = toplamSure / 60;
                int dakika = toplamSure % 60;

                lblSonucSure.Text = $"{saat}:{dakika}";
                lblSonucPuan.Text = toplamPuan.ToString("F2", turkishCulture);
                progressBarStat.Value = Convert.ToInt32(toplamPuan);

                if (toplamPuan < 50)
                {
                    lblSonucAcklm.Text = "Bugün neredeyse hiç çalışmadın.";
                    lblSonucAcklm.ForeColor = Color.Red;
                }
                else if (50 <= toplamPuan && toplamPuan < 100)
                {
                    lblSonucAcklm.Text = "Bugün yeteri kadar çalışmadın.";
                    lblSonucAcklm.ForeColor = Color.Orange;
                }
                else if (80 <= toplamPuan && toplamPuan < 130)
                {
                    lblSonucAcklm.Text = "Günü verimli geçirdin.";
                    lblSonucAcklm.ForeColor = Color.Green;
                }
                else
                {
                    lblSonucAcklm.Text = "Bugün çok sıkı çalıştın!";
                    lblSonucAcklm.ForeColor = Color.Green;
                }
            }
            reader.Close();
        }

        // Combo box'tan item seçildikten sonra görevle alakalı değerler atanır.
        private void comboBoxKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxKategoriler.SelectedItem is Gorevler selectedGorev)
            {
                _gorevID = selectedGorev.GorevID;
                _gorevCat = selectedGorev.GorevCat;
                _gorevName = selectedGorev.GorevName;
                _gorevDiff = selectedGorev.GorevDiff;
                labelID.Text = Convert.ToString(selectedGorev.GorevID);
                labelCat.Text =selectedGorev.GorevCat.ToString();
                 carpan = selectedGorev.GorevDiff;
            }
        }
        
        // Süre değeri değiştirildikçe puanı hesaplar.
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            float deger = (float)numericUpDown.Value;
            textBoxPuan.Text = Convert.ToString(deger*carpan);
        }
        
        // Tarih değiştirildikten sonra tabloyu ve istatistikleri ilgili tarihe göre günceller.
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshYapilanlarTable();
            RefreshSonuclar();
        }

        // İstatistikleri günceller.
        private void buttonStatUpd_Click(object sender, EventArgs e)
        {
            RefreshSonuclar();
        }

        // Tabloya yeni veriler ekler veya günceller.
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DateTime selectedTime = dateTimePicker.Value.Date;
            int sureDakika = (int)numericUpDown.Value;
            TimeSpan sureDegeri = TimeSpan.FromMinutes(sureDakika);
            

            SqlCommand kontrolEt = new SqlCommand("SELECT sureY, puanY FROM yapilanlarTable WHERE checkGorevID = @pGorevID AND tarihY = @pTarih", SqlBaglanti.connection);
            SqlBaglanti.CheckConnection(SqlBaglanti.connection);

            kontrolEt.Parameters.AddWithValue("@pGorevID", Convert.ToInt32(labelID.Text));
            kontrolEt.Parameters.AddWithValue("@pTarih", selectedTime);

            SqlDataReader reader = kontrolEt.ExecuteReader();

            // Eğer id ve tarih değerleri eklenecek veriyle eşleşirse sadece güncelleme yapar.
            if (reader.Read())
            {
                TimeSpan mevcutSure = reader.GetTimeSpan(reader.GetOrdinal("sureY"));
                string puanString = reader["puanY"].ToString();
                float mevcutPuan = float.Parse(puanString, turkishCulture);
                reader.Close();

                TimeSpan toplamSure = mevcutSure + sureDegeri;
                float toplamPuan = mevcutPuan + float.Parse(textBoxPuan.Text, turkishCulture);

                SqlCommand guncelleKomutu = new SqlCommand("UPDATE yapilanlarTable SET sureY=@pSure, puanY=@pPuan WHERE checkGorevID = @pGorevID AND tarihY = @pTarih", SqlBaglanti.connection);
                SqlBaglanti.CheckConnection(SqlBaglanti.connection);

                guncelleKomutu.Parameters.AddWithValue("@pSure", toplamSure);
                guncelleKomutu.Parameters.AddWithValue("@pGorevID", _gorevID);
                guncelleKomutu.Parameters.AddWithValue("@pTarih", selectedTime);
                guncelleKomutu.Parameters.AddWithValue("@pPuan", toplamPuan);

                guncelleKomutu.ExecuteNonQuery();
            }
            else
            {
                reader.Close();

                SqlCommand veriEkle = new SqlCommand("INSERT INTO yapilanlarTable (checkGorevID, tarihY, kategoriY, gorevY, sureY, puanY) values(@pGorevID, @pTarih, @pKat, @pGorev, @pSure, @pPuan)", SqlBaglanti.connection);
                SqlBaglanti.CheckConnection(SqlBaglanti.connection);

                veriEkle.Parameters.AddWithValue("@pGorevID", _gorevID);
                veriEkle.Parameters.AddWithValue("@pTarih", selectedTime);
                veriEkle.Parameters.AddWithValue("@pKat", _gorevCat);
                veriEkle.Parameters.AddWithValue("@pGorev", _gorevName);
                veriEkle.Parameters.AddWithValue("@pSure", sureDegeri);
                veriEkle.Parameters.AddWithValue("@pPuan", float.Parse(textBoxPuan.Text, turkishCulture));

                veriEkle.ExecuteNonQuery();
            }
            RefreshYapilanlarTable();
            RefreshSonuclar();


        }
    }
}
