namespace Studentska.WinApp.IspitIB230XXX
{
    partial class frmPraksaAddEditIB230XXX
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            cmbStudent = new ComboBox();
            cmbKompanija = new ComboBox();
            label2 = new Label();
            cmbStatusZahtjeva = new ComboBox();
            label3 = new Label();
            dtpDatumPrijave = new DateTimePicker();
            label4 = new Label();
            btnSacuvaj = new Button();
            gbGeneratorInfo = new GroupBox();
            btnGenerisiZahtjeve = new Button();
            txtGeneratorInfo = new TextBox();
            err = new ErrorProvider(components);
            gbGeneratorInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 28);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Student:";
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(33, 46);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(295, 23);
            cmbStudent.TabIndex = 1;
            // 
            // cmbKompanija
            // 
            cmbKompanija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKompanija.FormattingEnabled = true;
            cmbKompanija.Location = new Point(356, 46);
            cmbKompanija.Name = "cmbKompanija";
            cmbKompanija.Size = new Size(295, 23);
            cmbKompanija.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 28);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Kompanija:";
            // 
            // cmbStatusZahtjeva
            // 
            cmbStatusZahtjeva.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusZahtjeva.FormattingEnabled = true;
            cmbStatusZahtjeva.Location = new Point(356, 105);
            cmbStatusZahtjeva.Name = "cmbStatusZahtjeva";
            cmbStatusZahtjeva.Size = new Size(295, 23);
            cmbStatusZahtjeva.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 87);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Status:";
            // 
            // dtpDatumPrijave
            // 
            dtpDatumPrijave.Location = new Point(33, 105);
            dtpDatumPrijave.Name = "dtpDatumPrijave";
            dtpDatumPrijave.Size = new Size(295, 23);
            dtpDatumPrijave.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 87);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 7;
            label4.Text = "Datum prijave:";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(560, 162);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(91, 27);
            btnSacuvaj.TabIndex = 8;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // gbGeneratorInfo
            // 
            gbGeneratorInfo.Controls.Add(btnGenerisiZahtjeve);
            gbGeneratorInfo.Controls.Add(txtGeneratorInfo);
            gbGeneratorInfo.Location = new Point(33, 201);
            gbGeneratorInfo.Name = "gbGeneratorInfo";
            gbGeneratorInfo.Size = new Size(618, 237);
            gbGeneratorInfo.TabIndex = 9;
            gbGeneratorInfo.TabStop = false;
            gbGeneratorInfo.Text = "Generator info";
            // 
            // btnGenerisiZahtjeve
            // 
            btnGenerisiZahtjeve.Location = new Point(6, 22);
            btnGenerisiZahtjeve.Name = "btnGenerisiZahtjeve";
            btnGenerisiZahtjeve.Size = new Size(606, 32);
            btnGenerisiZahtjeve.TabIndex = 10;
            btnGenerisiZahtjeve.Text = "Generiši zahtjeve";
            btnGenerisiZahtjeve.UseVisualStyleBackColor = true;
            btnGenerisiZahtjeve.Click += btnGenerisiZahtjeve_Click;
            // 
            // txtGeneratorInfo
            // 
            txtGeneratorInfo.Location = new Point(6, 60);
            txtGeneratorInfo.Multiline = true;
            txtGeneratorInfo.Name = "txtGeneratorInfo";
            txtGeneratorInfo.Size = new Size(606, 171);
            txtGeneratorInfo.TabIndex = 0;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmPraksaAddEditIB230XXX
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 449);
            Controls.Add(gbGeneratorInfo);
            Controls.Add(btnSacuvaj);
            Controls.Add(label4);
            Controls.Add(dtpDatumPrijave);
            Controls.Add(cmbStatusZahtjeva);
            Controls.Add(label3);
            Controls.Add(cmbKompanija);
            Controls.Add(label2);
            Controls.Add(cmbStudent);
            Controls.Add(label1);
            Name = "frmPraksaAddEditIB230XXX";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Praksa";
            Load += frmPraksaAddEditIB230XXX_Load;
            gbGeneratorInfo.ResumeLayout(false);
            gbGeneratorInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbStudent;
        private ComboBox cmbKompanija;
        private Label label2;
        private ComboBox cmbStatusZahtjeva;
        private Label label3;
        private DateTimePicker dtpDatumPrijave;
        private Label label4;
        private Button btnSacuvaj;
        private GroupBox gbGeneratorInfo;
        private Button btnGenerisiZahtjeve;
        private TextBox txtGeneratorInfo;
        private ErrorProvider err;
    }
}