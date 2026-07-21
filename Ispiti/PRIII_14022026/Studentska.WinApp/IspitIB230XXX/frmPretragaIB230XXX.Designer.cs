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
            cmbStatus = new ComboBox();
            label2 = new Label();
            btnNovaKompanija = new Button();
            dgvPodaci = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            Kompanija = new DataGridViewTextBoxColumn();
            Grad = new DataGridViewTextBoxColumn();
            StatusZahtjeva = new DataGridViewTextBoxColumn();
            DatumPromjene = new DataGridViewTextBoxColumn();
            Obrisi = new DataGridViewButtonColumn();
            btnNovaPraksa = new Button();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(231, 15);
            label1.TabIndex = 0;
            label1.Text = "Ime i prezime studenta ili naziv kompanije:";
            // 
            // txtImePrezimeNaziv
            // 
            txtImePrezimeNaziv.Location = new Point(12, 27);
            txtImePrezimeNaziv.Name = "txtImePrezimeNaziv";
            txtImePrezimeNaziv.Size = new Size(262, 23);
            txtImePrezimeNaziv.TabIndex = 1;
            txtImePrezimeNaziv.TextChanged += txtImePrezimeNaziv_TextChanged;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(296, 27);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(254, 23);
            cmbStatus.TabIndex = 2;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 9);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 3;
            label2.Text = "Status zahtjeva:";
            // 
            // btnNovaKompanija
            // 
            btnNovaKompanija.Location = new Point(575, 27);
            btnNovaKompanija.Name = "btnNovaKompanija";
            btnNovaKompanija.Size = new Size(114, 23);
            btnNovaKompanija.TabIndex = 4;
            btnNovaKompanija.Text = "Nova kompanija";
            btnNovaKompanija.UseVisualStyleBackColor = true;
            btnNovaKompanija.Click += btnNovaKompanija_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { ID, Student, Kompanija, Grad, StatusZahtjeva, DatumPromjene, Obrisi });
            dgvPodaci.Location = new Point(12, 56);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.Size = new Size(797, 354);
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
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Kompanija
            // 
            Kompanija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kompanija.DataPropertyName = "Kompanija";
            Kompanija.HeaderText = "Kompanija";
            Kompanija.Name = "Kompanija";
            Kompanija.ReadOnly = true;
            // 
            // Grad
            // 
            Grad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grad.DataPropertyName = "Grad";
            Grad.HeaderText = "Grad";
            Grad.Name = "Grad";
            Grad.ReadOnly = true;
            // 
            // StatusZahtjeva
            // 
            StatusZahtjeva.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StatusZahtjeva.DataPropertyName = "StatusZahtjeva";
            StatusZahtjeva.HeaderText = "Status zahjteva";
            StatusZahtjeva.Name = "StatusZahtjeva";
            StatusZahtjeva.ReadOnly = true;
            // 
            // DatumPromjene
            // 
            DatumPromjene.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumPromjene.DataPropertyName = "DatumPromjene";
            DatumPromjene.HeaderText = "Datum promjene";
            DatumPromjene.Name = "DatumPromjene";
            DatumPromjene.ReadOnly = true;
            // 
            // Obrisi
            // 
            Obrisi.DataPropertyName = "Obrisi";
            Obrisi.HeaderText = "";
            Obrisi.Name = "Obrisi";
            Obrisi.ReadOnly = true;
            Obrisi.Text = "Obriši";
            Obrisi.UseColumnTextForButtonValue = true;
            // 
            // btnNovaPraksa
            // 
            btnNovaPraksa.Location = new Point(695, 26);
            btnNovaPraksa.Name = "btnNovaPraksa";
            btnNovaPraksa.Size = new Size(114, 23);
            btnNovaPraksa.TabIndex = 6;
            btnNovaPraksa.Text = "Nova praksa";
            btnNovaPraksa.UseVisualStyleBackColor = true;
            btnNovaPraksa.Click += btnNovaPraksa_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(695, 416);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(114, 23);
            btnPrint.TabIndex = 7;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // frmPretragaIB230XXX
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 450);
            Controls.Add(btnPrint);
            Controls.Add(btnNovaPraksa);
            Controls.Add(dgvPodaci);
            Controls.Add(btnNovaKompanija);
            Controls.Add(label2);
            Controls.Add(cmbStatus);
            Controls.Add(txtImePrezimeNaziv);
            Controls.Add(label1);
            Name = "frmPretragaIB230XXX";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga";
            Load += frmPretragaIB230XXX_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtImePrezimeNaziv;
        private ComboBox cmbStatus;
        private Label label2;
        private Button btnNovaKompanija;
        private DataGridView dgvPodaci;
        private Button btnNovaPraksa;
        private Button btnPrint;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Kompanija;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn StatusZahtjeva;
        private DataGridViewTextBoxColumn DatumPromjene;
        private DataGridViewButtonColumn Obrisi;
    }
}