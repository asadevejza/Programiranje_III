namespace Studentska.WinApp.IspitIB230XXX
{
    partial class frmPrijavaAddEditIB230XXX
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
            dtpDatumPrijave = new DateTimePicker();
            btnSacuvaj = new Button();
            gbGenerator = new GroupBox();
            txtGeneratorInfo = new TextBox();
            cmbProjekat = new ComboBox();
            label2 = new Label();
            cmbStatus = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            btnGenerisiPrijave = new Button();
            err = new ErrorProvider(components);
            gbGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Student:";
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(12, 38);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(331, 23);
            cmbStudent.TabIndex = 1;
            // 
            // dtpDatumPrijave
            // 
            dtpDatumPrijave.Location = new Point(12, 92);
            dtpDatumPrijave.Name = "dtpDatumPrijave";
            dtpDatumPrijave.Size = new Size(331, 23);
            dtpDatumPrijave.TabIndex = 2;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(607, 149);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(89, 28);
            btnSacuvaj.TabIndex = 3;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // gbGenerator
            // 
            gbGenerator.Controls.Add(txtGeneratorInfo);
            gbGenerator.Location = new Point(12, 183);
            gbGenerator.Name = "gbGenerator";
            gbGenerator.Size = new Size(684, 255);
            gbGenerator.TabIndex = 4;
            gbGenerator.TabStop = false;
            gbGenerator.Text = "Generator info";
            // 
            // txtGeneratorInfo
            // 
            txtGeneratorInfo.Location = new Point(6, 22);
            txtGeneratorInfo.Multiline = true;
            txtGeneratorInfo.Name = "txtGeneratorInfo";
            txtGeneratorInfo.Size = new Size(672, 227);
            txtGeneratorInfo.TabIndex = 0;
            // 
            // cmbProjekat
            // 
            cmbProjekat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProjekat.FormattingEnabled = true;
            cmbProjekat.Location = new Point(365, 38);
            cmbProjekat.Name = "cmbProjekat";
            cmbProjekat.Size = new Size(331, 23);
            cmbProjekat.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(365, 20);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 5;
            label2.Text = "Projekat:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(365, 95);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(331, 23);
            cmbStatus.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(365, 77);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 7;
            label3.Text = "Status prijave:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 77);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 9;
            label4.Text = "Datum prijave:";
            // 
            // btnGenerisiPrijave
            // 
            btnGenerisiPrijave.Location = new Point(12, 149);
            btnGenerisiPrijave.Name = "btnGenerisiPrijave";
            btnGenerisiPrijave.Size = new Size(106, 28);
            btnGenerisiPrijave.TabIndex = 10;
            btnGenerisiPrijave.Text = "Generiši prijave";
            btnGenerisiPrijave.UseVisualStyleBackColor = true;
            btnGenerisiPrijave.Click += btnGenerisiPrijave_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmPrijavaAddEditIB230XXX
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 441);
            Controls.Add(btnGenerisiPrijave);
            Controls.Add(label4);
            Controls.Add(cmbStatus);
            Controls.Add(label3);
            Controls.Add(cmbProjekat);
            Controls.Add(label2);
            Controls.Add(gbGenerator);
            Controls.Add(btnSacuvaj);
            Controls.Add(dtpDatumPrijave);
            Controls.Add(cmbStudent);
            Controls.Add(label1);
            Name = "frmPrijavaAddEditIB230XXX";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nova prijava na projekat";
            Load += frmPrijavaAddEditIB230XXX_Load;
            gbGenerator.ResumeLayout(false);
            gbGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbStudent;
        private DateTimePicker dtpDatumPrijave;
        private Button btnSacuvaj;
        private GroupBox gbGenerator;
        private TextBox txtGeneratorInfo;
        private ComboBox cmbProjekat;
        private Label label2;
        private ComboBox cmbStatus;
        private Label label3;
        private Label label4;
        private Button btnGenerisiPrijave;
        private ErrorProvider err;
    }
}