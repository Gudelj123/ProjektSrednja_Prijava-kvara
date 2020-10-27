using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PrijavaKvara_v2
{
    public partial class Lokacija : Form
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PrijavaKvara_v2.Properties.Settings.ConnectionString"].ConnectionString);

        public Lokacija()
        {
            InitializeComponent();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
          /*  SqlDataAdapter da = new SqlDataAdapter("SELECT Id_admin, Ime, Prezime FROM Administrator ORDER BY Id_admin ASC", conn);

            DataSet ds = new DataSet();

            da.Fill(ds);

            this.comboBox1.DataSource = ds.Tables[0];

            this.comboBox1.DisplayMember = "Ime";

            this.comboBox1.ValueMember = "Id_admin";*/

        }

        private void Lokacija_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Administrator' table. You can move, or remove it, as needed.
            this.administratorTableAdapter.Fill(this.dataSet.Administrator);

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO[dbo].[Lokacija_kvara] ([naziv_lokacije], [Id_admin]) VALUES(@lokacija, @admin)", conn);
            cmd.Parameters.AddWithValue("@lokacija", txtLokacija.Text);
            cmd.Parameters.AddWithValue("@admin", comboBox1.SelectedValue);

            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("insert successful");
            conn.Close();
        }
    }
}
