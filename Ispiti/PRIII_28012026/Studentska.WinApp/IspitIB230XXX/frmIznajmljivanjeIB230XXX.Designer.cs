namespace Studentska.WinApp.IspitIB230XXX
{
    partial class frmIznajmljivanjeIB230XXX
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
            cmbStudent = new ComboBox();
            btnIznajmi = new Button();
            dgvPodaci = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            Knjiga = new DataGridViewTextBoxColumn();
            DatumIznajmljivanja = new DataGridViewTextBoxColumn();
            Vracena = new DataGridViewCheckBoxColumn();
            gbGeneratorInfo = new GroupBox();
            txtGenerator = new TextBox();
            cmbKnjiga = new ComboBox();
            label2 = new Label();
            btnGenerisi = new Button();
            btnPotvrda = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            gbGeneratorInfo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 17);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Student:";
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(11, 35);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(239, 23);
            cmbStudent.TabIndex = 1;
            cmbStudent.SelectedIndexChanged += cmbStudent_SelectedIndexChanged;
            // 
            // btnIznajmi
            // 
            btnIznajmi.Location = new Point(622, 35);
            btnIznajmi.Name = "btnIznajmi";
            btnIznajmi.Size = new Size(114, 23);
            btnIznajmi.TabIndex = 2;
            btnIznajmi.Text = "Iznajmi";
            btnIznajmi.UseVisualStyleBackColor = true;
            btnIznajmi.Click += btnIznajmi_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { ID, Student, Knjiga, DatumIznajmljivanja, Vracena });
            dgvPodaci.Location = new Point(12, 64);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.Size = new Size(724, 182);
            dgvPodaci.TabIndex = 3;
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
            DatumIznajmljivanja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumIznajmljivanja.DataPropertyName = "DatumIznajmljivanja";
            DatumIznajmljivanja.HeaderText = "Datum iznajmljivanja";
            DatumIznajmljivanja.Name = "DatumIznajmljivanja";
            DatumIznajmljivanja.ReadOnly = true;
            // 
            // Vracena
            // 
            Vracena.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vracena.DataPropertyName = "Vracena";
            Vracena.HeaderText = "Vracena";
            Vracena.Name = "Vracena";
            Vracena.ReadOnly = true;
            // 
            // gbGeneratorInfo
            // 
            gbGeneratorInfo.Controls.Add(txtGenerator);
            gbGeneratorInfo.Location = new Point(11, 290);
            gbGeneratorInfo.Name = "gbGeneratorInfo";
            gbGeneratorInfo.Size = new Size(725, 214);
            gbGeneratorInfo.TabIndex = 4;
            gbGeneratorInfo.TabStop = false;
            gbGeneratorInfo.Text = "Generator info";
            // 
            // txtGenerator
            // 
            txtGenerator.Location = new Point(6, 22);
            txtGenerator.Multiline = true;
            txtGenerator.Name = "txtGenerator";
            txtGenerator.Size = new Size(713, 186);
            txtGenerator.TabIndex = 0;
            // 
            // cmbKnjiga
            // 
            cmbKnjiga.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKnjiga.FormattingEnabled = true;
            cmbKnjiga.Location = new Point(263, 35);
            cmbKnjiga.Name = "cmbKnjiga";
            cmbKnjiga.Size = new Size(340, 23);
            cmbKnjiga.TabIndex = 6;
            cmbKnjiga.SelectedIndexChanged += cmbKnjiga_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 17);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Knjiga:";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(11, 261);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(158, 23);
            btnGenerisi.TabIndex = 7;
            btnGenerisi.Text = "Generiši iznajmljivanje";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // btnPotvrda
            // 
            btnPotvrda.Location = new Point(622, 261);
            btnPotvrda.Name = "btnPotvrda";
            btnPotvrda.Size = new Size(114, 23);
            btnPotvrda.TabIndex = 8;
            btnPotvrda.Text = "Potvrda";
            btnPotvrda.UseVisualStyleBackColor = true;
            // 
            // frmIznajmljivanjeIB230XXX
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 504);
            Controls.Add(btnPotvrda);
            Controls.Add(btnGenerisi);
            Controls.Add(cmbKnjiga);
            Controls.Add(label2);
            Controls.Add(gbGeneratorInfo);
            Controls.Add(dgvPodaci);
            Controls.Add(btnIznajmi);
            Controls.Add(cmbStudent);
            Controls.Add(label1);
            Name = "frmIznajmljivanjeIB230XXX";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iznajmljivanje knjiga";
            Load += frmIznajmljivanjeIB230XXX_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            gbGeneratorInfo.ResumeLayout(false);
            gbGeneratorInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbStudent;
        private Button btnIznajmi;
        private DataGridView dgvPodaci;
        private GroupBox gbGeneratorInfo;
        private TextBox txtGenerator;
        private ComboBox cmbKnjiga;
        private Label label2;
        private Button btnGenerisi;
        private Button btnPotvrda;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Knjiga;
        private DataGridViewTextBoxColumn DatumIznajmljivanja;
        private DataGridViewCheckBoxColumn Vracena;
    }
}