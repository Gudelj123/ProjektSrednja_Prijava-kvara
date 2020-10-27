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
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PrijavaKvara_v2.Properties.Settings.ConnectionString"].ConnectionString);


        public Form3()
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

        private void btnLokacija_Click(object sender, EventArgs e)
        {
            Lokacija lokacija = new Lokacija();
            lokacija.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator();
            admin.Show();
        }

        private void btnOpisKvara_Click(object sender, EventArgs e)
        {
            OpisKvara opiskvara = new OpisKvara();
            opiskvara.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
             SqlDataAdapter da = new SqlDataAdapter(@"SELECT  Klijent.Ime as KIme, Klijent.Prezime as KPrezime, Klijent.Email, [Kli-Lok].Datum, Lokacija_kvara.naziv_lokacije,
                                                Opis_kvara.kvar,[Kli-Opis].Opis_kvara, Administrator.Ime as AIme, Administrator.Prezime as APrezime
                                                FROM Klijent,[Kli-Lok],Lokacija_kvara,Opis_kvara,[Kli-Opis],Administrator
                                                Where Klijent.Id_klijent=[Kli-Lok].Id_klijent and Lokacija_kvara.Id_lokacija = [Kli-Lok].Id_lokacija 
                                                and Klijent.Id_klijent = [Kli-Opis].Id_klijent and Opis_kvara.Id_opis_kvara = [Kli-Opis].Id_opis 
                                                and Administrator.Id_admin = Lokacija_kvara.Id_admin", conn);
              DataTable dt = new DataTable();
              da.Fill(dt);

              for (int i = 0; i < dt.Rows.Count; i++)
              {
                  DataRow dr = dt.Rows[i];

                  ListViewItem listitem = new ListViewItem(dr["Datum"].ToString());
                listitem.SubItems.Add(dr["KIme"].ToString());
                listitem.SubItems.Add(dr["KPrezime"].ToString());
                listitem.SubItems.Add(dr["naziv_lokacije"].ToString());
                listitem.SubItems.Add(dr["kvar"].ToString());
                listitem.SubItems.Add(dr["Opis_kvara"].ToString());
                listitem.SubItems.Add(dr["AIme"].ToString() +" "+ dr["APrezime"].ToString());

                listView1.Items.Add(listitem);

              }

            /*           conn.Open();
                       SqlCommand cmd = new SqlCommand(@"SELECT  Klijent.Ime, Klijent.Prezime, Klijent.Email, [Kli-Lok].Datum, Lokacija_kvara.naziv_lokacije,
                                                           Opis_kvara.kvar,[Kli-Opis].Opis_kvara, Administrator.Ime, Administrator.Prezime
                                                           FROM Klijent,[Kli-Lok],Lokacija_kvara,Opis_kvara,[Kli-Opis],Administrator
                                                           Where Klijent.Id_klijent=[Kli-Lok].Id_klijent and Lokacija_kvara.Id_lokacija = [Kli-Lok].Id_lokacija 
                                                           and Klijent.Id_klijent = [Kli-Opis].Id_klijent and Opis_kvara.Id_opis_kvara = [Kli-Opis].Id_opis 
                                                           and Administrator.Id_admin = Lokacija_kvara.Id_admin", conn);

                       SqlDataReader reader = cmd.ExecuteReader();

                       try
                       {
                           while(reader.Read())
                           {
                               ListViewItem lv = new ListViewItem(reader.GetDateTime(3).ToString());


                               listView1.Items.Add(lv);
                           }
                           reader.Close();
                           conn.Close();
                       }
                       catch(Exception ex)
                       {
                           MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                       }*/

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();
            form1.ShowDialog();

            this.Close();
        }

        private void btnPopravljen_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                item.BackColor = Color.LimeGreen;
            }
            
        }

        private void btnNijePopravljen_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {

                item.BackColor = Color.Red;
            }
        }
    }
}
