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


namespace CalismaTakibi
{
    public partial class FormEdit : Form
    {
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
    }
}
