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
    public partial class Administrator : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PrijavaKvara_v2.Properties.Settings.ConnectionString"].ConnectionString);

        public Administrator()
        {
            InitializeComponent();
        }
        
        private void btnSpremi_Click(object sender, EventArgs e)
        {

                SqlCommand cmd = new SqlCommand ("INSERT INTO[dbo].[Administrator] ([Ime], [Prezime]) VALUES(@Ime, @Prezime)", conn);
                 cmd.Parameters.AddWithValue("@Ime",txtIme.Text);
                 cmd.Parameters.AddWithValue("@Prezime",txtPrezime.Text);

                 conn.Open();
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("insert successful");
                 conn.Close();


      /*      try
            {
                this.administratorTableAdapter1.InsertTEST(txtIme.Text,txtPrezime.Text);
                MessageBox.Show("Spremljeno");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nije spremljeno");
            }*/
        }
    }
}
