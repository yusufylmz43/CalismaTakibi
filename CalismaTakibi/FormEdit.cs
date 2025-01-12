using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalismaTakibi.Classes;


namespace CalismaTakibi
{
    public partial class FormEdit : Form
    {
        CultureInfo turkishCulture = new CultureInfo("tr-TR");

        public FormEdit()
        {
            InitializeComponent();
            RefreshGorevTable();

            MessageBox.Show(
                "Burada veritabanı üzerinde işlemler yapılıyor. Değerlerin yanlış girilmesi sonucunda veritabanında geri dönülemez hatalara yol açabilir!",
                "DİKKAT",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning );
        }

        private void FormEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.Owner is Form1 mainForm)
            {
                mainForm.Show();
                mainForm.RefreshYapilanlarTable();
                mainForm.RefreshLogKaydiTable();
            }
        }
        public void RefreshGorevTable()
        {
            SqlCommand verileriGetirCat = new SqlCommand("SELECT gorevID, gorevCat, gorevName, gorevDiff FROM gorevTable", SqlBaglanti.connection);
            SqlBaglanti.CheckConnection(SqlBaglanti.connection);

            SqlDataAdapter adapterC = new SqlDataAdapter(verileriGetirCat);
            DataTable dtC = new DataTable();
            adapterC.Fill(dtC);
            dataGridViewCat.DataSource = dtC;
            dataGridViewCat.AllowUserToResizeRows = false;
            dataGridViewCat.AllowUserToResizeColumns = false;
            
            SqlCommand verileriGetirYap = new SqlCommand("SELECT checkGorevID as ID, tarihY as Tarih, kategoriY as Kategori, gorevY as Görev, sureY as Süre, puanY as Puan FROM yapilanlarTable WHERE tarihY = @pTarih", SqlBaglanti.connection);
            SqlDataAdapter adapterY = new SqlDataAdapter(verileriGetirYap);

            DateTime selectedTime = dateTimePickerY.Value.Date;
            verileriGetirYap.Parameters.AddWithValue("@pTarih", selectedTime);

            DataTable dtY = new DataTable();
            adapterY.Fill(dtY);
            dataGridViewYap.DataSource = dtY;
            dataGridViewYap.AllowUserToResizeRows = false;
            dataGridViewYap.AllowUserToResizeColumns = false;
        }
        private void radioButtonEkle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEkle.Checked)
            {
                buttonAdd.Visible = true;
                buttonSil.Visible = false;
                buttonEdit.Visible = false;
                tBoxCat.ReadOnly = false;
                tBoxName.ReadOnly = false;
                tBoxDiff.ReadOnly = false;
            }
            else if (radioButtonSil.Checked)
            {
                buttonAdd.Visible = false;
                buttonSil.Visible = true;
                buttonEdit.Visible = false;
                tBoxCat.ReadOnly = true;
                tBoxName.ReadOnly = true;
                tBoxDiff.ReadOnly = true;
            }
            else if (radioButtonEdit.Checked)
            {
                buttonAdd.Visible = false;
                buttonSil.Visible = false;
                buttonEdit.Visible = true;
                tBoxCat.ReadOnly = false;
                tBoxName.ReadOnly = false;
                tBoxDiff.ReadOnly = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bu işlemi onaylıyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlCommand setIdOn = new SqlCommand("SET IDENTITY_INSERT gorevTable ON;", SqlBaglanti.connection);
                SqlBaglanti.CheckConnection(SqlBaglanti.connection);
                setIdOn.ExecuteNonQuery();

                SqlCommand command = new SqlCommand("INSERT INTO gorevTable (gorevID, gorevCat, gorevName, gorevDiff) VALUES(@pID, @pCat, @pName, @pDiff);", SqlBaglanti.connection);

                command.Parameters.AddWithValue("@pID", Convert.ToInt16(tBoxID.Text));
                command.Parameters.AddWithValue("@pCat", tBoxCat.Text);
                command.Parameters.AddWithValue("@pName", tBoxName.Text);
                command.Parameters.AddWithValue("@pDiff", Convert.ToDouble(tBoxDiff.Text, turkishCulture));

                command.ExecuteNonQuery();

                SqlCommand setIdOff = new SqlCommand("SET IDENTITY_INSERT gorevTable OFF;", SqlBaglanti.connection);
                setIdOff.ExecuteNonQuery();

                RefreshGorevTable();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi");
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bu işlemi onaylıyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("DELETE FROM gorevTable WHERE gorevID = @pID", SqlBaglanti.connection);
                SqlBaglanti.CheckConnection(SqlBaglanti.connection);

                command.Parameters.AddWithValue("@pID", Convert.ToInt16(tBoxID.Text));
                command.ExecuteNonQuery();

                RefreshGorevTable();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi");
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bu işlemi onaylıyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("UPDATE gorevTable SET gorevCat = @pCat, gorevName = @pGorev, gorevDiff = @pDiff WHERE gorevID = @pID", SqlBaglanti.connection);
                SqlBaglanti.CheckConnection(SqlBaglanti.connection);
                command.Parameters.AddWithValue("@pCat",tBoxCat.Text);
                command.Parameters.AddWithValue("@pGorev", tBoxName.Text);
                command.Parameters.AddWithValue("@pDiff", decimal.Parse(tBoxDiff.Text, turkishCulture));
                command.Parameters.AddWithValue("@pID", Convert.ToInt16(tBoxID.Text));
                command.ExecuteNonQuery();

                //TODO: Sadece yapılan değişikliğe göre açıklama eklenecek şekilde düzenle
                SqlCommand logCommand = new SqlCommand("INSERT INTO logKaydi (actionType, timeStamp, description) VALUES(@pAction, @pTime, @pDes)", SqlBaglanti.connection);
                SqlBaglanti.CheckConnection(SqlBaglanti.connection);
                logCommand.Parameters.AddWithValue("@pAction", "Edit");
                logCommand.Parameters.AddWithValue("@pTime", System.DateTime.Today);
                logCommand.Parameters.AddWithValue("@pDes", $"{tBoxID.Text} ID'li görevde değişiklik yapıldı. Kategori: {tBoxCat.Text} Görev: {tBoxName.Text} Puan: {tBoxDiff.Text}");
                logCommand.ExecuteNonQuery();

                RefreshGorevTable();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi");
            }
        }

        private void dataGridViewYap_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewYap.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewYap.SelectedRows[0];
                tBoxIDY.Text = selectedRow.Cells["ID"].Value.ToString();
                tBoxCatY.Text = selectedRow.Cells["Kategori"].Value.ToString();
                tBoxNameY.Text = selectedRow.Cells["Görev"].Value.ToString();
                tBoxPuanY.Text = selectedRow.Cells["Puan"].Value.ToString();

                string timeString = selectedRow.Cells["Süre"].Value.ToString();
                if(TimeSpan.TryParse(timeString, out TimeSpan timeSpanValue))
                {
                    int toplamMin = (int)timeSpanValue.TotalMinutes;
                    numericUDY.Value = toplamMin;
                }

                object dateValue = selectedRow.Cells["Tarih"].Value;
                if(dateValue != null && DateTime.TryParse(dateValue.ToString(), out DateTime date))
                {
                    dateTimePickerY.Value = date;
                }
            }
        }

        private void dateTimePickerY_ValueChanged(object sender, EventArgs e)
        {
            RefreshGorevTable();
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bu işlemi onaylıyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int sureDakika = (int)numericUDY.Value;
                TimeSpan sureDegeri = TimeSpan.FromMinutes(sureDakika);

                SqlCommand cmd = new SqlCommand("UPDATE yapilanlarTable SET kategoriY = @pKategori, gorevY = @pGorev, sureY = @pSure, puanY = @pPuan WHERE checkGorevID = @pGorevID ", SqlBaglanti.connection);
                SqlBaglanti.CheckConnection(SqlBaglanti.connection);
                cmd.Parameters.AddWithValue("@pKategori", tBoxCatY.Text);
                cmd.Parameters.AddWithValue("@pGorev", tBoxNameY.Text);
                cmd.Parameters.AddWithValue("@pSure", sureDegeri);
                cmd.Parameters.AddWithValue("@pPuan", float.Parse(tBoxPuanY.Text, turkishCulture));
                cmd.Parameters.AddWithValue("@pGorevID", Convert.ToInt16(tBoxIDY.Text));

                cmd.ExecuteNonQuery();
                RefreshGorevTable();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi");
            }
        }

        private void buttonYSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bu işlemi onaylıyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmnd = new SqlCommand("DELETE FROM yapilanlarTable WHERE checkGorevID = @pGorevID", SqlBaglanti.connection);
                SqlBaglanti.CheckConnection(SqlBaglanti.connection);
                cmnd.Parameters.AddWithValue("@pGorevID", Convert.ToInt16(tBoxIDY.Text));
                cmnd.ExecuteNonQuery();
                RefreshGorevTable();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi");
            }

        }
    }
}
