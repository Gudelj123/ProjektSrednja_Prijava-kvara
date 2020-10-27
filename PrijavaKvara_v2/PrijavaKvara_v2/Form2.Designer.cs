namespace PrijavaKvara_v2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.btnSend = new System.Windows.Forms.Button();
            this.lnkNazad = new System.Windows.Forms.LinkLabel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.cmbLokacija = new System.Windows.Forms.ComboBox();
            this.lokacijakvaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new PrijavaKvara_v2.DataSet();
            this.cmbOpis = new System.Windows.Forms.ComboBox();
            this.opiskvaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbAdmin = new System.Windows.Forms.ComboBox();
            this.administratorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.klijentTableAdapter = new PrijavaKvara_v2.DataSetTableAdapters.KlijentTableAdapter();
            this.lokacija_kvaraTableAdapter = new PrijavaKvara_v2.DataSetTableAdapters.Lokacija_kvaraTableAdapter();
            this.administratorTableAdapter = new PrijavaKvara_v2.DataSetTableAdapters.AdministratorTableAdapter();
            this.opis_kvaraTableAdapter = new PrijavaKvara_v2.DataSetTableAdapters.Opis_kvaraTableAdapter();
            this.lokacijakvaraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lokacijakvaraKliLokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kli_LokTableAdapter = new PrijavaKvara_v2.DataSetTableAdapters.Kli_LokTableAdapter();
            this.lokacijakvaraLokOpisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lok_OpisTableAdapter = new PrijavaKvara_v2.DataSetTableAdapters.Kli_OpisTableAdapter();
            this.btnNazad = new System.Windows.Forms.Button();
            this.txtOpisKvara2 = new System.Windows.Forms.TextBox();
            this.btnNoviNalog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijakvaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opiskvaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administratorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijakvaraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijakvaraKliLokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijakvaraLokOpisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(346, 216);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lnkNazad
            // 
            this.lnkNazad.AutoSize = true;
            this.lnkNazad.Location = new System.Drawing.Point(526, 41);
            this.lnkNazad.Name = "lnkNazad";
            this.lnkNazad.Size = new System.Drawing.Size(38, 13);
            this.lnkNazad.TabIndex = 1;
            this.lnkNazad.TabStop = true;
            this.lnkNazad.Text = "Nazad";
            this.lnkNazad.Visible = false;
            this.lnkNazad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNazad_LinkClicked);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Location = new System.Drawing.Point(7, 34);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Vaš e-mail";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIme.Location = new System.Drawing.Point(7, 60);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 4;
            this.lblIme.Text = "Ime";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrezime.Location = new System.Drawing.Point(7, 86);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 5;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLokacija.Location = new System.Drawing.Point(7, 112);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(77, 13);
            this.lblLokacija.TabIndex = 6;
            this.lblLokacija.Text = "Lokacija kvara";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOpis.Location = new System.Drawing.Point(7, 139);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(58, 13);
            this.lblOpis.TabIndex = 7;
            this.lblOpis.Text = "Opis kvara";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdmin.Location = new System.Drawing.Point(7, 166);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(67, 13);
            this.lblAdmin.TabIndex = 8;
            this.lblAdmin.Text = "Administrator";
            // 
            // cmbLokacija
            // 
            this.cmbLokacija.DataSource = this.lokacijakvaraBindingSource;
            this.cmbLokacija.DisplayMember = "naziv_lokacije";
            this.cmbLokacija.FormattingEnabled = true;
            this.cmbLokacija.Location = new System.Drawing.Point(90, 109);
            this.cmbLokacija.Name = "cmbLokacija";
            this.cmbLokacija.Size = new System.Drawing.Size(187, 21);
            this.cmbLokacija.TabIndex = 9;
            this.cmbLokacija.ValueMember = "Id_lokacija";
            this.cmbLokacija.Click += new System.EventHandler(this.cmbLokacija_Click);
            // 
            // lokacijakvaraBindingSource
            // 
            this.lokacijakvaraBindingSource.DataMember = "Lokacija_kvara";
            this.lokacijakvaraBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbOpis
            // 
            this.cmbOpis.DataSource = this.opiskvaraBindingSource;
            this.cmbOpis.DisplayMember = "kvar";
            this.cmbOpis.FormattingEnabled = true;
            this.cmbOpis.Location = new System.Drawing.Point(90, 136);
            this.cmbOpis.Name = "cmbOpis";
            this.cmbOpis.Size = new System.Drawing.Size(187, 21);
            this.cmbOpis.TabIndex = 10;
            this.cmbOpis.ValueMember = "Id_opis_kvara";
            this.cmbOpis.SelectedIndexChanged += new System.EventHandler(this.cmbOpis_SelectedIndexChanged);
            // 
            // opiskvaraBindingSource
            // 
            this.opiskvaraBindingSource.DataMember = "Opis_kvara";
            this.opiskvaraBindingSource.DataSource = this.dataSet;
            // 
            // cmbAdmin
            // 
            this.cmbAdmin.DataSource = this.administratorBindingSource;
            this.cmbAdmin.DisplayMember = "Ime";
            this.cmbAdmin.FormattingEnabled = true;
            this.cmbAdmin.Location = new System.Drawing.Point(90, 163);
            this.cmbAdmin.Name = "cmbAdmin";
            this.cmbAdmin.Size = new System.Drawing.Size(187, 21);
            this.cmbAdmin.TabIndex = 11;
            this.cmbAdmin.ValueMember = "Id_admin";
            // 
            // administratorBindingSource
            // 
            this.administratorBindingSource.DataMember = "Administrator";
            this.administratorBindingSource.DataSource = this.dataSet;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(90, 31);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(288, 20);
            this.txtMail.TabIndex = 12;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(90, 57);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(187, 20);
            this.txtIme.TabIndex = 13;
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataMember = "Klijent";
            this.klijentBindingSource.DataSource = this.dataSet;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(90, 83);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(187, 20);
            this.txtPrezime.TabIndex = 14;
            // 
            // klijentTableAdapter
            // 
            this.klijentTableAdapter.ClearBeforeFill = true;
            // 
            // lokacija_kvaraTableAdapter
            // 
            this.lokacija_kvaraTableAdapter.ClearBeforeFill = true;
            // 
            // administratorTableAdapter
            // 
            this.administratorTableAdapter.ClearBeforeFill = true;
            // 
            // opis_kvaraTableAdapter
            // 
            this.opis_kvaraTableAdapter.ClearBeforeFill = true;
            // 
            // lokacijakvaraBindingSource1
            // 
            this.lokacijakvaraBindingSource1.DataMember = "Lokacija_kvara";
            this.lokacijakvaraBindingSource1.DataSource = this.dataSet;
            // 
            // lokacijakvaraKliLokBindingSource
            // 
            this.lokacijakvaraKliLokBindingSource.DataMember = "Lokacija_kvara_Kli-Lok";
            this.lokacijakvaraKliLokBindingSource.DataSource = this.lokacijakvaraBindingSource1;
            // 
            // kli_LokTableAdapter
            // 
            this.kli_LokTableAdapter.ClearBeforeFill = true;
            // 
            // lok_OpisTableAdapter
            // 
            this.lok_OpisTableAdapter.ClearBeforeFill = true;
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(454, 216);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 15;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // txtOpisKvara2
            // 
            this.txtOpisKvara2.Location = new System.Drawing.Point(297, 57);
            this.txtOpisKvara2.Multiline = true;
            this.txtOpisKvara2.Name = "txtOpisKvara2";
            this.txtOpisKvara2.Size = new System.Drawing.Size(267, 127);
            this.txtOpisKvara2.TabIndex = 16;
            // 
            // btnNoviNalog
            // 
            this.btnNoviNalog.Location = new System.Drawing.Point(239, 216);
            this.btnNoviNalog.Name = "btnNoviNalog";
            this.btnNoviNalog.Size = new System.Drawing.Size(75, 23);
            this.btnNoviNalog.TabIndex = 17;
            this.btnNoviNalog.Text = "Novi nalog";
            this.btnNoviNalog.UseVisualStyleBackColor = true;
            this.btnNoviNalog.Click += new System.EventHandler(this.btnNoviNalog_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(581, 256);
            this.Controls.Add(this.btnNoviNalog);
            this.Controls.Add(this.txtOpisKvara2);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.cmbAdmin);
            this.Controls.Add(this.cmbOpis);
            this.Controls.Add(this.cmbLokacija);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblLokacija);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lnkNazad);
            this.Controls.Add(this.btnSend);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klijent";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lokacijakvaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opiskvaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administratorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijakvaraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijakvaraKliLokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijakvaraLokOpisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.LinkLabel lnkNazad;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblLokacija;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.ComboBox cmbLokacija;
        private System.Windows.Forms.ComboBox cmbOpis;
        private System.Windows.Forms.ComboBox cmbAdmin;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private DataSetTableAdapters.KlijentTableAdapter klijentTableAdapter;
        private System.Windows.Forms.BindingSource lokacijakvaraBindingSource;
        private DataSetTableAdapters.Lokacija_kvaraTableAdapter lokacija_kvaraTableAdapter;
        private System.Windows.Forms.BindingSource administratorBindingSource;
        private DataSetTableAdapters.AdministratorTableAdapter administratorTableAdapter;
        private System.Windows.Forms.BindingSource opiskvaraBindingSource;
        private DataSetTableAdapters.Opis_kvaraTableAdapter opis_kvaraTableAdapter;
        private System.Windows.Forms.BindingSource lokacijakvaraBindingSource1;
        private System.Windows.Forms.BindingSource lokacijakvaraKliLokBindingSource;
        private DataSetTableAdapters.Kli_LokTableAdapter kli_LokTableAdapter;
        private System.Windows.Forms.BindingSource lokacijakvaraLokOpisBindingSource;
        private DataSetTableAdapters.Kli_OpisTableAdapter lok_OpisTableAdapter;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.TextBox txtOpisKvara2;
        private System.Windows.Forms.Button btnNoviNalog;
    }
}