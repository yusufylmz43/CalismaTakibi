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
        }

        private void FormEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
        public void RefreshGorevTable()
        {
            SqlCommand verileriGetir = new SqlCommand("SELECT gorevID, gorevCat, gorevName, gorevDiff FROM gorevTable", SqlBaglanti.connection);
            SqlBaglanti.CheckConnection(SqlBaglanti.connection);

            SqlDataAdapter adapter = new SqlDataAdapter(verileriGetir);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewCat.DataSource = dt;
        }
        private void radioButtonEkle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEkle.Checked)
            {
                buttonAdd.Visible = true;
                buttonSil.Visible = false;
                tBoxCat.ReadOnly = false;
                tBoxName.ReadOnly = false;
                tBoxDiff.ReadOnly = false;
            }
            else if (radioButtonSil.Checked)
            {
                buttonAdd.Visible = false;
                buttonSil.Visible = true;
                tBoxCat.ReadOnly = true;
                tBoxName.ReadOnly = true;
                tBoxDiff.ReadOnly = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
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

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM gorevTable WHERE gorevID = @pID", SqlBaglanti.connection);
            SqlBaglanti.CheckConnection(SqlBaglanti.connection);

            command.Parameters.AddWithValue("@pID", Convert.ToInt16(tBoxID.Text));
            command.ExecuteNonQuery();

            RefreshGorevTable();
        }
    }
}
