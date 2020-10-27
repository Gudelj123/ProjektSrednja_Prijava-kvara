using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Diagnostics;

namespace PrijavaKvara_v2
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PrijavaKvara_v2.Properties.Settings.ConnectionString"].ConnectionString);
        int id_klijentt;

        public Form2()
        {
            InitializeComponent();
        }

        private void lnkNazad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();
            form1.ShowDialog();

            this.Close();
        }

        private void cmbOpis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOpis.SelectedIndex == 5)
            {               
                txtOpisKvara2.Show();
            }
            else
            {
                txtOpisKvara2.Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet._Lok_Opis' table. You can move, or remove it, as needed.
            this.lok_OpisTableAdapter.Fill(this.dataSet._Kli_Opis);
            // TODO: This line of code loads data into the 'dataSet._Kli_Lok' table. You can move, or remove it, as needed.
            this.kli_LokTableAdapter.Fill(this.dataSet._Kli_Lok);
            // TODO: This line of code loads data into the 'dataSet.Opis_kvara' table. You can move, or remove it, as needed.
            this.opis_kvaraTableAdapter.Fill(this.dataSet.Opis_kvara);
            // TODO: This line of code loads data into the 'dataSet.Administrator' table. You can move, or remove it, as needed.
            this.administratorTableAdapter.Fill(this.dataSet.Administrator);
            // TODO: This line of code loads data into the 'dataSet.Lokacija_kvara' table. You can move, or remove it, as needed.
               this.lokacija_kvaraTableAdapter.Fill(this.dataSet.Lokacija_kvara);
            // TODO: This line of code loads data into the 'dataSet.Klijent' table. You can move, or remove it, as needed.
            this.klijentTableAdapter.Fill(this.dataSet.Klijent);

            cmbLokacija.SelectedIndex = -1;
            cmbOpis.SelectedIndex = -1;
            cmbAdmin.SelectedIndex = -1;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SqlDataReader reader;

            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Klijent (Ime, Prezime, Email) VALUES(@ime, @prezime, @email)", conn);

            cmd.Parameters.AddWithValue("@ime", txtIme.Text);
            cmd.Parameters.AddWithValue("@prezime", txtPrezime.Text);
            cmd.Parameters.AddWithValue("@email", txtMail.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Prijava je poslana!");
            
            SqlCommand cmd2 = new SqlCommand("SELECT Id_klijent, Ime, Prezime, Email FROM Klijent WHERE(Ime = '"+txtIme.Text+"') AND(Prezime = '"+txtPrezime.Text+"')", conn);

            try
            {
                
                reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    id_klijentt = reader.GetInt32(0);
                }
                reader.Close();

                SqlCommand cmd3 = new SqlCommand("INSERT INTO [Kli-Lok] (Id_klijent, Id_lokacija, Datum) VALUES (@id_klijent, @id_lokacija, @datum)", conn);
                SqlCommand cmd4 = new SqlCommand("INSERT INTO [Kli-Opis](Id_klijent, Id_opis) VALUES(@id_klijent, @id_opis)",conn);
                cmd3.Parameters.AddWithValue("@id_klijent", id_klijentt);
                cmd3.Parameters.AddWithValue("@id_lokacija", cmbLokacija.SelectedValue);
                cmd3.Parameters.AddWithValue("@datum", DateTime.Now);
                cmd4.Parameters.AddWithValue("@id_klijent", id_klijentt);
                cmd4.Parameters.AddWithValue("@id_opis",cmbOpis.SelectedValue);
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                MessageBox.Show("Spremljeno");

                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("markovic.marko2601@gmail.com");
                message.To.Add(new MailAddress("ivic_darjan@yahoo.com"));
                message.Subject = "Test Test Test";
                message.Body = "Ime i prezime: " + txtIme.Text + " " + txtPrezime.Text +
                               "Email: " + txtMail.Text +
                               "Lokacija kvara: " + cmbLokacija.Text +
                               "Opis kvara: " + cmbOpis.Text;

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("markovic.marko2601", "O123456789");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            conn.Close();

            /* MailMessage mail = new MailMessage();
             SmtpClient SmtpServer = new SmtpClient();
             mail.To.Add(new MailAddress("ivic_darjan@yahoo.com"));
             mail.From = new MailAddress("markovic.marko2601@gmail.com");
             mail.Subject = "Test Test Test";
             mail.IsBodyHtml = true;
             mail.Body = "Content bla bla bla ghcvghkfgh";
             SmtpServer.Host = "smtp.gmail.com";
             SmtpServer.Port = 25;
            SmtpServer.EnableSsl = true;
            SmtpServer.UseDefaultCredentials = true;
            SmtpServer.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
             try
             {
                 SmtpServer.Send(mail);
             }
             catch (Exception ex)
             {
                 Debug.WriteLine("Exception Message: " + ex.Message);
                 if (ex.InnerException != null)
                     Debug.WriteLine("Exception Inner:   " + ex.InnerException);
             }*/

  

        }

        private void cmbLokacija_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();
            form1.ShowDialog();

            this.Close();
        }

        private void btnNoviNalog_Click(object sender, EventArgs e)
        {
            txtMail.Text = "";
            txtIme.Text = "";
            txtPrezime.Text = "";
            cmbLokacija.Text = "";
            cmbOpis.Text = "";
            cmbAdmin.Text = "";
            txtOpisKvara2.Visible = false;
        }
    }
}
