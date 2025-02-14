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
            RefreshLogKaydiTable();
            RefreshComboBoxCat_Cal();
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
            dataGridViewYapilanlar.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewYapilanlar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewYapilanlar.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        public void RefreshLogKaydiTable()
        {
            SqlCommand verileriGetir = new SqlCommand("SELECT logID as ID, actionType as İşlem, timeStamp as Tarih, description as Açıklama FROM logKaydi", SqlBaglanti.connection);
            SqlBaglanti.CheckConnection(SqlBaglanti.connection);

            SqlDataAdapter adapter = new SqlDataAdapter(verileriGetir);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewLog.DataSource = dt;
            dataGridViewLog.Columns[dataGridViewLog.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewLog.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewLog.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewLog.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        //Combo Box'a, veritabanından çekilen kategorilerle item ekler.
        public void RefreshComboBoxCat_Cal()
        {
            comboBoxCat.Items.Clear();

            SqlCommand verileriGetirYap = new SqlCommand("SELECT gorevID, gorevCat, gorevName, gorevDiff FROM gorevTable ORDER BY gorevCat", SqlBaglanti.connection);
            SqlBaglanti.CheckConnection (SqlBaglanti.connection);

            SqlDataReader reader = verileriGetirYap.ExecuteReader();
            while (reader.Read())
            {
                string gorevCat = reader.GetString(reader.GetOrdinal("gorevCat"));
                if (!comboBoxCat.Items.Contains(gorevCat))
                {
                    comboBoxCat.Items.Add(gorevCat);

                }
            }
            reader.Close();

            if(comboBoxCat.Items.Count > 0)
            {
                comboBoxCat.SelectedIndex = 0;
            }
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

                int topPuanInt = Convert.ToInt32(toplamPuan);
                if (topPuanInt > 130)
                {
                    progressBarStat.Value = 130;
                }
                else
                {
                    progressBarStat.Value = topPuanInt;
                }

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
            if(comboBoxCal.SelectedItem is Gorevler selectedGorev)
            {
                _gorevID = selectedGorev.GorevID;
                _gorevCat = selectedGorev.GorevCat;
                _gorevName = selectedGorev.GorevName;
                _gorevDiff = selectedGorev.GorevDiff;
                labelID.Text = Convert.ToString(selectedGorev.GorevID);
                 carpan = selectedGorev.GorevDiff;
            }

        }
        public void RefreshComboBoxGorevler(string selectedCat)
        {
            comboBoxCal.Items.Clear();
            SqlCommand verileriGetir = new SqlCommand("SELECT gorevID, gorevName, gorevDiff FROM gorevTable WHERE gorevCat = @pCat ORDER BY gorevName", SqlBaglanti.connection);
            verileriGetir.Parameters.AddWithValue("@pCat", selectedCat);
            SqlBaglanti.CheckConnection(SqlBaglanti.connection);

            SqlDataReader reader = verileriGetir.ExecuteReader();
            while (reader.Read())
            {
                int gorevID = reader.GetInt32(reader.GetOrdinal("gorevID"));
                string gorevName = reader.GetString(reader.GetOrdinal("gorevName"));
                float gorevDiff = float.Parse(reader["gorevDiff"].ToString(), turkishCulture);
                comboBoxCal.Items.Add(new Gorevler { GorevID = gorevID, GorevCat = selectedCat, GorevName = gorevName, GorevDiff = gorevDiff });
            }
            reader.Close();

            if(comboBoxCal.Items.Count > 0)
            {
                comboBoxCal.SelectedIndex = 0;
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

        private void button2_Click(object sender, EventArgs e)
        {
            FormEdit formEdit = new FormEdit();
            formEdit.Owner = this;
            formEdit.Show();
            this.Hide();
        }

        private void comboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCat.SelectedItem is string selectedCat)
            {
                DateTime selectedTime = dateTimePicker.Value.Date;
                SqlCommand sonucGuncelle = new SqlCommand("SELECT SUM(CAST(DATEDIFF(MINUTE, '00:00:00', sureY) AS int)) AS ToplamDakika FROM yapilanlarTable WHERE tarihY=@pTarih AND kategoriY = @pCat", SqlBaglanti.connection);
                SqlBaglanti.CheckConnection(SqlBaglanti.connection);
                sonucGuncelle.Parameters.AddWithValue("@pTarih", selectedTime);
                sonucGuncelle.Parameters.AddWithValue("@pCat", comboBoxCat.SelectedItem.ToString());

                SqlDataReader reader = sonucGuncelle.ExecuteReader();
                if (reader.Read())
                {
                    object sureSonuc = reader["ToplamDakika"];
                    int toplamSure = sureSonuc != DBNull.Value ? (int)sureSonuc : 0;
                    int saat = toplamSure / 60;
                    int dakika = toplamSure % 60;

                    lblSonucCatSure.Text = $"{saat}:{dakika}";
                    lblSonucCat.Text = comboBoxCat.SelectedItem.ToString();
                    reader.Close();

                    RefreshComboBoxGorevler(selectedCat);

                }


            }
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
            
            
            
                // Eğer reader hâlâ açık kalmışsa, burada kapatıyoruz.
                if (!reader.IsClosed)
                {
                    reader.Close();
                }
            
            RefreshYapilanlarTable();
            RefreshSonuclar();


        }
    }
}
