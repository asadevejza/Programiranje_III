namespace Studentska.WinApp.IspitIB230014
{
    partial class frmPretragaIB230014
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
            lblImePrezimeKorisnikaNazivKnjige = new Label();
            txtPretraga = new TextBox();
            cbVracena = new CheckBox();
            btnDodajKnjigu = new Button();
            dgvPodaci = new DataGridView();
            btnIznajmljivanja = new Button();
            ID = new DataGridViewTextBoxColumn();
            KnjigaID = new DataGridViewTextBoxColumn();
            IndeksImePrezime = new DataGridViewTextBoxColumn();
            Knjiga = new DataGridViewTextBoxColumn();
            DatumIznajmljivanja = new DataGridViewTextBoxColumn();
            DatumVracanja = new DataGridViewTextBoxColumn();
            Vracena = new DataGridViewCheckBoxColumn();
            Povrat = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // lblImePrezimeKorisnikaNazivKnjige
            // 
            lblImePrezimeKorisnikaNazivKnjige.AutoSize = true;
            lblImePrezimeKorisnikaNazivKnjige.Location = new Point(12, 9);
            lblImePrezimeKorisnikaNazivKnjige.Name = "lblImePrezimeKorisnikaNazivKnjige";
            lblImePrezimeKorisnikaNazivKnjige.Size = new Size(211, 15);
            lblImePrezimeKorisnikaNazivKnjige.TabIndex = 0;
            lblImePrezimeKorisnikaNazivKnjige.Text = "Ime i prezime korisnika ili naziv knjige: ";
            // 
            // txtPretraga
            // 
            txtPretraga.Location = new Point(12, 27);
            txtPretraga.Name = "txtPretraga";
            txtPretraga.Size = new Size(391, 23);
            txtPretraga.TabIndex = 1;
            txtPretraga.TextChanged += txtPretraga_TextChanged;
            // 
            // cbVracena
            // 
            cbVracena.AutoSize = true;
            cbVracena.Location = new Point(409, 31);
            cbVracena.Name = "cbVracena";
            cbVracena.Size = new Size(68, 19);
            cbVracena.TabIndex = 2;
            cbVracena.Text = "Vraćena";
            cbVracena.UseVisualStyleBackColor = true;
            cbVracena.CheckedChanged += cbVracena_CheckedChanged;
            // 
            // btnDodajKnjigu
            // 
            btnDodajKnjigu.Location = new Point(704, 27);
            btnDodajKnjigu.Name = "btnDodajKnjigu";
            btnDodajKnjigu.Size = new Size(179, 23);
            btnDodajKnjigu.TabIndex = 4;
            btnDodajKnjigu.Text = "Dodaj knjigu";
            btnDodajKnjigu.UseVisualStyleBackColor = true;
            btnDodajKnjigu.Click += btnDodajKnjigu_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { ID, KnjigaID, IndeksImePrezime, Knjiga, DatumIznajmljivanja, DatumVracanja, Vracena, Povrat });
            dgvPodaci.Location = new Point(12, 56);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.Size = new Size(1056, 372);
            dgvPodaci.TabIndex = 5;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            dgvPodaci.CellDoubleClick += dgvPodaci_CellDoubleClick;
            // 
            // btnIznajmljivanja
            // 
            btnIznajmljivanja.Location = new Point(889, 27);
            btnIznajmljivanja.Name = "btnIznajmljivanja";
            btnIznajmljivanja.Size = new Size(179, 23);
            btnIznajmljivanja.TabIndex = 6;
            btnIznajmljivanja.Text = "Iznajmljivanja";
            btnIznajmljivanja.UseVisualStyleBackColor = true;
            btnIznajmljivanja.Click += btnIznajmljivanja_Click;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.DataPropertyName = "ID";
            ID.HeaderText = "";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // KnjigaID
            // 
            KnjigaID.DataPropertyName = "KnjigaID";
            KnjigaID.HeaderText = "";
            KnjigaID.Name = "KnjigaID";
            KnjigaID.ReadOnly = true;
            KnjigaID.Visible = false;
            // 
            // IndeksImePrezime
            // 
            IndeksImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IndeksImePrezime.DataPropertyName = "IndeksImePrezime";
            IndeksImePrezime.HeaderText = "(Indeks) Ime i prezime";
            IndeksImePrezime.Name = "IndeksImePrezime";
            IndeksImePrezime.ReadOnly = true;
            // 
            // Knjiga
            // 
            Knjiga.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Knjiga.DataPropertyName = "Knjiga";
            Knjiga.HeaderText = "Knjiga";
            Knjiga.Name = "Knjiga";
            Knjiga.ReadOnly = true;
            // 
            // DatumIznajmljivanja
            // 
            DatumIznajmljivanja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumIznajmljivanja.DataPropertyName = "DatumIznajmljivanja";
            DatumIznajmljivanja.HeaderText = "Datum iznajmljivanja";
            DatumIznajmljivanja.Name = "DatumIznajmljivanja";
            DatumIznajmljivanja.ReadOnly = true;
            // 
            // DatumVracanja
            // 
            DatumVracanja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumVracanja.DataPropertyName = "DatumVracanja";
            DatumVracanja.HeaderText = "Datum vraćanja";
            DatumVracanja.Name = "DatumVracanja";
            DatumVracanja.ReadOnly = true;
            // 
            // Vracena
            // 
            Vracena.DataPropertyName = "Vracena";
            Vracena.HeaderText = "Vraćena";
            Vracena.Name = "Vracena";
            Vracena.ReadOnly = true;
            Vracena.Resizable = DataGridViewTriState.True;
            Vracena.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Povrat
            // 
            Povrat.DataPropertyName = "Povrat";
            Povrat.HeaderText = "";
            Povrat.Name = "Povrat";
            Povrat.ReadOnly = true;
            Povrat.Text = "Povrat";
            Povrat.UseColumnTextForButtonValue = true;
            // 
            // frmPretragaIB230014
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 440);
            Controls.Add(btnIznajmljivanja);
            Controls.Add(dgvPodaci);
            Controls.Add(btnDodajKnjigu);
            Controls.Add(cbVracena);
            Controls.Add(txtPretraga);
            Controls.Add(lblImePrezimeKorisnikaNazivKnjige);
            Name = "frmPretragaIB230014";
            Text = "Broj prikazanih podataka: ";
            Load += frmPretragaIB230014_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblImePrezimeKorisnikaNazivKnjige;
        private TextBox txtPretraga;
        private CheckBox cbVracena;
        private Button btnDodajKnjigu;
        private DataGridView dgvPodaci;
        private Button btnIznajmljivanja;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn KnjigaID;
        private DataGridViewTextBoxColumn IndeksImePrezime;
        private DataGridViewTextBoxColumn Knjiga;
        private DataGridViewTextBoxColumn DatumIznajmljivanja;
        private DataGridViewTextBoxColumn DatumVracanja;
        private DataGridViewCheckBoxColumn Vracena;
        private DataGridViewButtonColumn Povrat;
    }
}