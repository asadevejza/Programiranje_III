namespace Studentska.WinApp.IspitIB230XXX
{
    partial class frmPretragaIB230XXX
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
            label1 = new Label();
            txtImePrezimeNaziv = new TextBox();
            cbVracena = new CheckBox();
            btnDodajKnjigu = new Button();
            btnIznajmljivanja = new Button();
            dgvPodaci = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            KnjigaID = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            Knjiga = new DataGridViewTextBoxColumn();
            DatumIznajmljivanja = new DataGridViewTextBoxColumn();
            DatumVracanja = new DataGridViewTextBoxColumn();
            Vracena = new DataGridViewCheckBoxColumn();
            Povrat = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 15);
            label1.TabIndex = 0;
            label1.Text = "Ime i prezime korisnika ili naziv knjige:";
            // 
            // txtImePrezimeNaziv
            // 
            txtImePrezimeNaziv.Location = new Point(12, 27);
            txtImePrezimeNaziv.Name = "txtImePrezimeNaziv";
            txtImePrezimeNaziv.Size = new Size(448, 23);
            txtImePrezimeNaziv.TabIndex = 1;
            txtImePrezimeNaziv.TextChanged += txtImePrezimeNaziv_TextChanged;
            // 
            // cbVracena
            // 
            cbVracena.AutoSize = true;
            cbVracena.Location = new Point(466, 29);
            cbVracena.Name = "cbVracena";
            cbVracena.Size = new Size(68, 19);
            cbVracena.TabIndex = 2;
            cbVracena.Text = "Vraćena";
            cbVracena.UseVisualStyleBackColor = true;
            cbVracena.CheckedChanged += cbVracena_CheckedChanged;
            // 
            // btnDodajKnjigu
            // 
            btnDodajKnjigu.Location = new Point(611, 29);
            btnDodajKnjigu.Name = "btnDodajKnjigu";
            btnDodajKnjigu.Size = new Size(98, 25);
            btnDodajKnjigu.TabIndex = 3;
            btnDodajKnjigu.Text = "Dodaj knjigu";
            btnDodajKnjigu.UseVisualStyleBackColor = true;
            btnDodajKnjigu.Click += btnDodajKnjigu_Click;
            // 
            // btnIznajmljivanja
            // 
            btnIznajmljivanja.Location = new Point(715, 27);
            btnIznajmljivanja.Name = "btnIznajmljivanja";
            btnIznajmljivanja.Size = new Size(98, 27);
            btnIznajmljivanja.TabIndex = 4;
            btnIznajmljivanja.Text = "Iznajmljivanja";
            btnIznajmljivanja.UseVisualStyleBackColor = true;
            btnIznajmljivanja.Click += btnIznajmljivanja_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { ID, KnjigaID, Student, Knjiga, DatumIznajmljivanja, DatumVracanja, Vracena, Povrat });
            dgvPodaci.Location = new Point(12, 65);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.Size = new Size(801, 362);
            dgvPodaci.TabIndex = 5;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            dgvPodaci.CellContentDoubleClick += dgvPodaci_CellContentDoubleClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // KnjigaID
            // 
            KnjigaID.DataPropertyName = "KnjigaID";
            KnjigaID.HeaderText = "KnjigaID";
            KnjigaID.Name = "KnjigaID";
            KnjigaID.ReadOnly = true;
            KnjigaID.Visible = false;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "(Indeks) Ime i prezime";
            Student.Name = "Student";
            Student.ReadOnly = true;
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
            DatumIznajmljivanja.DataPropertyName = "DatumIznajmljivanja";
            DatumIznajmljivanja.HeaderText = "Datum iznajmljivanja";
            DatumIznajmljivanja.Name = "DatumIznajmljivanja";
            DatumIznajmljivanja.ReadOnly = true;
            // 
            // DatumVracanja
            // 
            DatumVracanja.DataPropertyName = "DatumVracanja";
            DatumVracanja.HeaderText = "Datum vracanja";
            DatumVracanja.Name = "DatumVracanja";
            DatumVracanja.ReadOnly = true;
            // 
            // Vracena
            // 
            Vracena.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vracena.DataPropertyName = "Vracena";
            Vracena.HeaderText = "Vracena";
            Vracena.Name = "Vracena";
            Vracena.ReadOnly = true;
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
            // frmPretragaIB230XXX
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 442);
            Controls.Add(dgvPodaci);
            Controls.Add(btnIznajmljivanja);
            Controls.Add(btnDodajKnjigu);
            Controls.Add(cbVracena);
            Controls.Add(txtImePrezimeNaziv);
            Controls.Add(label1);
            Name = "frmPretragaIB230XXX";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Broj prikazanih podataka:";
            Load += frmPretragaIB230XXX_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtImePrezimeNaziv;
        private CheckBox cbVracena;
        private Button btnDodajKnjigu;
        private Button btnIznajmljivanja;
        private DataGridView dgvPodaci;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn KnjigaID;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Knjiga;
        private DataGridViewTextBoxColumn DatumIznajmljivanja;
        private DataGridViewTextBoxColumn DatumVracanja;
        private DataGridViewCheckBoxColumn Vracena;
        private DataGridViewButtonColumn Povrat;
    }
}