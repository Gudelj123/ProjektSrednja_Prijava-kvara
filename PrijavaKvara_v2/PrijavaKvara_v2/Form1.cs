using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrijavaKvara_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
//Kada korisnik klikne na dugme "Klijent" Zatvoriti će se prva forma te otvoriti druga.
        private void btnKlijent_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 form2 = new Form2();
            form2.ShowDialog();

            this.Close();
        }
//Pri učitavanju programa će se sakriti TextBox Passworda.
        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 forma1 = new Form1();
            btnPrijava.Hide();
            txtPW.Hide();
            txtPW.ForeColor = Color.Gray;
            

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            txtPW.Show();
            txtPW.Focus();
            btnPrijava.Show();
        }
/*Pritiskom na tipku > korisnik se pokušava prijaviti te program provjerva da li je lozinka koju je korisnik unio točna.
Ukoliko jest otvoriti će se treća forma, a u koliko nije točna ponuditi će mu se mogućnost ponovnog unosa lozinke.*/
        private void btnPrijava_Click(object sender, EventArgs e)
        {

            if (txtPW.Text == "0")
            {
                
                Form3 form3 = new Form3();
                
                form3.Show();
                
            }
            else
            {
                MessageBox.Show("Unijeli ste pogrešnu lozinku." + Environment.NewLine + "Pokušajte ponovno", "Kriva Lozinka!");
                txtPW.Clear();
            }
        }

        private void txtPW_Click(object sender, EventArgs e)
        {
            txtPW.Clear();
            txtPW.ForeColor = Color.Black;
            txtPW.PasswordChar = '*';
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
          if (e.KeyCode == Keys.Enter)
            {
                btnPrijava.PerformClick();
            }
        }
    }
}
