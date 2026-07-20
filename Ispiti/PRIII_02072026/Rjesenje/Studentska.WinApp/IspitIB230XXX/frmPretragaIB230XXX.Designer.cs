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
            cmbStatusPrijave = new ComboBox();
            btnNoviProjekat = new Button();
            dgvPodaci = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            Projekat = new DataGridViewTextBoxColumn();
            RokZavrsetka = new DataGridViewTextBoxColumn();
            StatusPrijave = new DataGridViewTextBoxColumn();
            DatumPrijave = new DataGridViewTextBoxColumn();
            DatumPromjeneStatusa = new DataGridViewTextBoxColumn();
            StanjePrijave = new DataGridViewTextBoxColumn();
            Arhiviraj = new DataGridViewButtonColumn();
            cmbStanjePrijave = new ComboBox();
            btnNovaPrijava = new Button();
            btnPrint = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 15);
            label1.TabIndex = 0;
            label1.Text = "Ime i prezime studenta ili naziv projekta:";
            // 
            // txtImePrezimeNaziv
            // 
            txtImePrezimeNaziv.Location = new Point(8, 27);
            txtImePrezimeNaziv.Name = "txtImePrezimeNaziv";
            txtImePrezimeNaziv.Size = new Size(278, 23);
            txtImePrezimeNaziv.TabIndex = 1;
            txtImePrezimeNaziv.TextChanged += txtImePrezimeNaziv_TextChanged;
            // 
            // cmbStatusPrijave
            // 
            cmbStatusPrijave.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusPrijave.FormattingEnabled = true;
            cmbStatusPrijave.Location = new Point(303, 27);
            cmbStatusPrijave.Name = "cmbStatusPrijave";
            cmbStatusPrijave.Size = new Size(149, 23);
            cmbStatusPrijave.TabIndex = 2;
            cmbStatusPrijave.SelectedIndexChanged += cmbStatusPrijave_SelectedIndexChanged;
            // 
            // btnNoviProjekat
            // 
            btnNoviProjekat.Location = new Point(627, 27);
            btnNoviProjekat.Name = "btnNoviProjekat";
            btnNoviProjekat.Size = new Size(119, 23);
            btnNoviProjekat.TabIndex = 3;
            btnNoviProjekat.Text = "Novi projekat";
            btnNoviProjekat.UseVisualStyleBackColor = true;
            btnNoviProjekat.Click += btnNoviProjekat_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { ID, Student, Projekat, RokZavrsetka, StatusPrijave, DatumPrijave, DatumPromjeneStatusa, StanjePrijave, Arhiviraj });
            dgvPodaci.Location = new Point(8, 56);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.Size = new Size(861, 331);
            dgvPodaci.TabIndex = 4;
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
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Projekat
            // 
            Projekat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Projekat.DataPropertyName = "Projekat";
            Projekat.HeaderText = "Projekat";
            Projekat.Name = "Projekat";
            Projekat.ReadOnly = true;
            // 
            // RokZavrsetka
            // 
            RokZavrsetka.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RokZavrsetka.DataPropertyName = "RokZavrsetka";
            RokZavrsetka.HeaderText = "Rok završetka";
            RokZavrsetka.Name = "RokZavrsetka";
            RokZavrsetka.ReadOnly = true;
            // 
            // StatusPrijave
            // 
            StatusPrijave.DataPropertyName = "StatusPrijave";
            StatusPrijave.HeaderText = "Status prijave";
            StatusPrijave.Name = "StatusPrijave";
            StatusPrijave.ReadOnly = true;
            // 
            // DatumPrijave
            // 
            DatumPrijave.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumPrijave.DataPropertyName = "DatumPrijave";
            DatumPrijave.HeaderText = "Prijavljen";
            DatumPrijave.Name = "DatumPrijave";
            DatumPrijave.ReadOnly = true;
            // 
            // DatumPromjeneStatusa
            // 
            DatumPromjeneStatusa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumPromjeneStatusa.DataPropertyName = "DatumPromjeneStatusa";
            DatumPromjeneStatusa.HeaderText = "Promjena";
            DatumPromjeneStatusa.Name = "DatumPromjeneStatusa";
            DatumPromjeneStatusa.ReadOnly = true;
            // 
            // StanjePrijave
            // 
            StanjePrijave.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StanjePrijave.DataPropertyName = "StanjePrijave";
            StanjePrijave.HeaderText = "Stanje prijave";
            StanjePrijave.Name = "StanjePrijave";
            StanjePrijave.ReadOnly = true;
            // 
            // Arhiviraj
            // 
            Arhiviraj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Arhiviraj.DataPropertyName = "Arhiviraj";
            Arhiviraj.HeaderText = "";
            Arhiviraj.Name = "Arhiviraj";
            Arhiviraj.ReadOnly = true;
            Arhiviraj.Text = "Arhiviraj";
            Arhiviraj.UseColumnTextForButtonValue = true;
            // 
            // cmbStanjePrijave
            // 
            cmbStanjePrijave.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStanjePrijave.FormattingEnabled = true;
            cmbStanjePrijave.Location = new Point(458, 27);
            cmbStanjePrijave.Name = "cmbStanjePrijave";
            cmbStanjePrijave.Size = new Size(149, 23);
            cmbStanjePrijave.TabIndex = 5;
            cmbStanjePrijave.SelectedIndexChanged += cmbStanjePrijave_SelectedIndexChanged;
            // 
            // btnNovaPrijava
            // 
            btnNovaPrijava.Location = new Point(752, 27);
            btnNovaPrijava.Name = "btnNovaPrijava";
            btnNovaPrijava.Size = new Size(119, 23);
            btnNovaPrijava.TabIndex = 6;
            btnNovaPrijava.Text = "Nova prijava";
            btnNovaPrijava.UseVisualStyleBackColor = true;
            btnNovaPrijava.Click += btnNovaPrijava_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(752, 393);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(119, 23);
            btnPrint.TabIndex = 7;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 9);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 8;
            label2.Text = "Status prijave:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(458, 9);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 9;
            label3.Text = "Stanje prijave:";
            // 
            // frmPretragaIB230XXX
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 428);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnPrint);
            Controls.Add(btnNovaPrijava);
            Controls.Add(cmbStanjePrijave);
            Controls.Add(dgvPodaci);
            Controls.Add(btnNoviProjekat);
            Controls.Add(cmbStatusPrijave);
            Controls.Add(txtImePrezimeNaziv);
            Controls.Add(label1);
            Name = "frmPretragaIB230XXX";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga prijava na projekte";
            Load += frmPretragaIB230XXX_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtImePrezimeNaziv;
        private ComboBox cmbStatusPrijave;
        private Button btnNoviProjekat;
        private DataGridView dgvPodaci;
        private ComboBox cmbStanjePrijave;
        private Button btnNovaPrijava;
        private Button btnPrint;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Projekat;
        private DataGridViewTextBoxColumn RokZavrsetka;
        private DataGridViewTextBoxColumn StatusPrijave;
        private DataGridViewTextBoxColumn DatumPrijave;
        private DataGridViewTextBoxColumn DatumPromjeneStatusa;
        private DataGridViewTextBoxColumn StanjePrijave;
        private DataGridViewButtonColumn Arhiviraj;
    }
}