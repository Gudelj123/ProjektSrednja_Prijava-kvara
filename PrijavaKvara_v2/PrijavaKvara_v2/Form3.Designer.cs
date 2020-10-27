namespace PrijavaKvara_v2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lnkNazad = new System.Windows.Forms.LinkLabel();
            this.btnLokacija = new System.Windows.Forms.Button();
            this.btnOpisKvara = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lokacija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kvar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.opisKvara = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Administrator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnPopravljen = new System.Windows.Forms.Button();
            this.btnNijePopravljen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lnkNazad
            // 
            this.lnkNazad.AutoSize = true;
            this.lnkNazad.Location = new System.Drawing.Point(805, 358);
            this.lnkNazad.Name = "lnkNazad";
            this.lnkNazad.Size = new System.Drawing.Size(38, 13);
            this.lnkNazad.TabIndex = 1;
            this.lnkNazad.TabStop = true;
            this.lnkNazad.Text = "Nazad";
            this.lnkNazad.Visible = false;
            this.lnkNazad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNazad_LinkClicked);
            // 
            // btnLokacija
            // 
            this.btnLokacija.Location = new System.Drawing.Point(12, 12);
            this.btnLokacija.Name = "btnLokacija";
            this.btnLokacija.Size = new System.Drawing.Size(75, 23);
            this.btnLokacija.TabIndex = 2;
            this.btnLokacija.Text = "Lokacija";
            this.btnLokacija.UseVisualStyleBackColor = true;
            this.btnLokacija.Click += new System.EventHandler(this.btnLokacija_Click);
            // 
            // btnOpisKvara
            // 
            this.btnOpisKvara.Location = new System.Drawing.Point(109, 12);
            this.btnOpisKvara.Name = "btnOpisKvara";
            this.btnOpisKvara.Size = new System.Drawing.Size(75, 23);
            this.btnOpisKvara.TabIndex = 3;
            this.btnOpisKvara.Text = "Opis kvara";
            this.btnOpisKvara.UseVisualStyleBackColor = true;
            this.btnOpisKvara.Click += new System.EventHandler(this.btnOpisKvara_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(207, 12);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Datum,
            this.Ime,
            this.Prezime,
            this.Lokacija,
            this.Kvar,
            this.opisKvara,
            this.Administrator});
            this.listView1.Location = new System.Drawing.Point(12, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(901, 292);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Datum
            // 
            this.Datum.Text = "Datum";
            this.Datum.Width = 116;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 107;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 95;
            // 
            // Lokacija
            // 
            this.Lokacija.Text = "Lokacija";
            this.Lokacija.Width = 98;
            // 
            // Kvar
            // 
            this.Kvar.Text = "Kvar";
            this.Kvar.Width = 168;
            // 
            // opisKvara
            // 
            this.opisKvara.Text = "Opis kvara";
            this.opisKvara.Width = 168;
            // 
            // Administrator
            // 
            this.Administrator.Text = "Administrator";
            this.Administrator.Width = 130;
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(838, 373);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 7;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnPopravljen
            // 
            this.btnPopravljen.Location = new System.Drawing.Point(12, 373);
            this.btnPopravljen.Name = "btnPopravljen";
            this.btnPopravljen.Size = new System.Drawing.Size(75, 23);
            this.btnPopravljen.TabIndex = 8;
            this.btnPopravljen.Text = "Popravljen";
            this.btnPopravljen.UseVisualStyleBackColor = true;
            this.btnPopravljen.Click += new System.EventHandler(this.btnPopravljen_Click);
            // 
            // btnNijePopravljen
            // 
            this.btnNijePopravljen.Location = new System.Drawing.Point(93, 373);
            this.btnNijePopravljen.Name = "btnNijePopravljen";
            this.btnNijePopravljen.Size = new System.Drawing.Size(91, 23);
            this.btnNijePopravljen.TabIndex = 9;
            this.btnNijePopravljen.Text = "Nije popravljen";
            this.btnNijePopravljen.UseVisualStyleBackColor = true;
            this.btnNijePopravljen.Click += new System.EventHandler(this.btnNijePopravljen_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(929, 405);
            this.Controls.Add(this.btnNijePopravljen);
            this.Controls.Add(this.btnPopravljen);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnOpisKvara);
            this.Controls.Add(this.btnLokacija);
            this.Controls.Add(this.lnkNazad);
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkNazad;
        private System.Windows.Forms.Button btnLokacija;
        private System.Windows.Forms.Button btnOpisKvara;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader Lokacija;
        private System.Windows.Forms.ColumnHeader Kvar;
        private System.Windows.Forms.ColumnHeader opisKvara;
        private System.Windows.Forms.ColumnHeader Administrator;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnPopravljen;
        private System.Windows.Forms.Button btnNijePopravljen;
    }
}