namespace Studentska.WinApp.IspitIB230014
{
    partial class frmIznajmljivanjaIB230014
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
            cmbStudent = new ComboBox();
            cmbKnjiga = new ComboBox();
            btnIznajmi = new Button();
            lblStudent = new Label();
            lblKnjiga = new Label();
            dgvIznajmljivanja = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            IndeksImePrezime = new DataGridViewTextBoxColumn();
            Knjiga = new DataGridViewTextBoxColumn();
            DatumIznajmljivanja = new DataGridViewTextBoxColumn();
            Vracena = new DataGridViewCheckBoxColumn();
            btnGenerisi = new Button();
            btnPotvrda = new Button();
            txtGenerator = new TextBox();
            gbGenerator = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvIznajmljivanja).BeginInit();
            gbGenerator.SuspendLayout();
            SuspendLayout();
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(12, 38);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(270, 23);
            cmbStudent.TabIndex = 0;
            // 
            // cmbKnjiga
            // 
            cmbKnjiga.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKnjiga.FormattingEnabled = true;
            cmbKnjiga.Location = new Point(288, 38);
            cmbKnjiga.Name = "cmbKnjiga";
            cmbKnjiga.Size = new Size(330, 23);
            cmbKnjiga.TabIndex = 1;
            // 
            // btnIznajmi
            // 
            btnIznajmi.Location = new Point(631, 38);
            btnIznajmi.Name = "btnIznajmi";
            btnIznajmi.Size = new Size(157, 23);
            btnIznajmi.TabIndex = 2;
            btnIznajmi.Text = "Iznajmi";
            btnIznajmi.UseVisualStyleBackColor = true;
            btnIznajmi.Click += btnIznajmi_Click;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(12, 20);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(51, 15);
            lblStudent.TabIndex = 3;
            lblStudent.Text = "Student:";
            // 
            // lblKnjiga
            // 
            lblKnjiga.AutoSize = true;
            lblKnjiga.Location = new Point(288, 20);
            lblKnjiga.Name = "lblKnjiga";
            lblKnjiga.Size = new Size(40, 15);
            lblKnjiga.TabIndex = 4;
            lblKnjiga.Text = "Knjiga";
            // 
            // dgvIznajmljivanja
            // 
            dgvIznajmljivanja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIznajmljivanja.Columns.AddRange(new DataGridViewColumn[] { Id, IndeksImePrezime, Knjiga, DatumIznajmljivanja, Vracena });
            dgvIznajmljivanja.Location = new Point(12, 67);
            dgvIznajmljivanja.Name = "dgvIznajmljivanja";
            dgvIznajmljivanja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIznajmljivanja.Size = new Size(776, 257);
            dgvIznajmljivanja.TabIndex = 5;
            // 
            // Id
            // 
            Id.HeaderText = "";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // IndeksImePrezime
            // 
            IndeksImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IndeksImePrezime.DataPropertyName = "IndeksImePrezime";
            IndeksImePrezime.HeaderText = "(Indeks) Ime i prezime";
            IndeksImePrezime.Name = "IndeksImePrezime";
            // 
            // Knjiga
            // 
            Knjiga.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Knjiga.DataPropertyName = "Knjiga";
            Knjiga.HeaderText = "Knjiga";
            Knjiga.Name = "Knjiga";
            // 
            // DatumIznajmljivanja
            // 
            DatumIznajmljivanja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumIznajmljivanja.DataPropertyName = "DatumIznajmljivanja";
            DatumIznajmljivanja.HeaderText = "Datum iznajmljivanja";
            DatumIznajmljivanja.Name = "DatumIznajmljivanja";
            // 
            // Vracena
            // 
            Vracena.DataPropertyName = "Vracena";
            Vracena.HeaderText = "Vracena";
            Vracena.Name = "Vracena";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(12, 330);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(157, 23);
            btnGenerisi.TabIndex = 6;
            btnGenerisi.Text = "Generiši iznajmljivanja";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // btnPotvrda
            // 
            btnPotvrda.Location = new Point(676, 330);
            btnPotvrda.Name = "btnPotvrda";
            btnPotvrda.Size = new Size(112, 23);
            btnPotvrda.TabIndex = 7;
            btnPotvrda.Text = "Potvrda";
            btnPotvrda.UseVisualStyleBackColor = true;
            btnPotvrda.Click += btnPotvrda_Click;
            // 
            // txtGenerator
            // 
            txtGenerator.Location = new Point(6, 14);
            txtGenerator.Multiline = true;
            txtGenerator.Name = "txtGenerator";
            txtGenerator.Size = new Size(770, 230);
            txtGenerator.TabIndex = 8;
            // 
            // gbGenerator
            // 
            gbGenerator.Controls.Add(txtGenerator);
            gbGenerator.Location = new Point(12, 370);
            gbGenerator.Name = "gbGenerator";
            gbGenerator.Size = new Size(784, 250);
            gbGenerator.TabIndex = 9;
            gbGenerator.TabStop = false;
            gbGenerator.Text = "Generator info";
            // 
            // frmIznajmljivanjaIB230014
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 642);
            Controls.Add(gbGenerator);
            Controls.Add(btnPotvrda);
            Controls.Add(btnGenerisi);
            Controls.Add(dgvIznajmljivanja);
            Controls.Add(lblKnjiga);
            Controls.Add(lblStudent);
            Controls.Add(btnIznajmi);
            Controls.Add(cmbKnjiga);
            Controls.Add(cmbStudent);
            Name = "frmIznajmljivanjaIB230014";
            Text = "Iznajmljivanje knjiga";
            Load += frmIznajmljivanjaIB230014_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIznajmljivanja).EndInit();
            gbGenerator.ResumeLayout(false);
            gbGenerator.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbStudent;
        private ComboBox cmbKnjiga;
        private Button btnIznajmi;
        private Label lblStudent;
        private Label lblKnjiga;
        private DataGridView dgvIznajmljivanja;
        private Button btnGenerisi;
        private Button btnPotvrda;
        private TextBox txtGenerator;
        private GroupBox gbGenerator;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IndeksImePrezime;
        private DataGridViewTextBoxColumn Knjiga;
        private DataGridViewTextBoxColumn DatumIznajmljivanja;
        private DataGridViewCheckBoxColumn Vracena;
    }
}