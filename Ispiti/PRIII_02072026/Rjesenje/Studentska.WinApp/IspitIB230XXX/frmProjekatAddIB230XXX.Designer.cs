namespace Studentska.WinApp.IspitIB230XXX
{
    partial class frmProjekatAddIB230XXX
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
            pbLogo = new PictureBox();
            label2 = new Label();
            txtNaziv = new TextBox();
            dtpRokZavrsetka = new DateTimePicker();
            cbAktivan = new CheckBox();
            label3 = new Label();
            txtNapomena = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtMaksimalanBrojStudenata = new TextBox();
            btnSacuvaj = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Logo:";
            // 
            // pbLogo
            // 
            pbLogo.BorderStyle = BorderStyle.FixedSingle;
            pbLogo.Location = new Point(12, 36);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(219, 221);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 18);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(257, 36);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(495, 23);
            txtNaziv.TabIndex = 3;
            // 
            // dtpRokZavrsetka
            // 
            dtpRokZavrsetka.Location = new Point(257, 196);
            dtpRokZavrsetka.Name = "dtpRokZavrsetka";
            dtpRokZavrsetka.Size = new Size(200, 23);
            dtpRokZavrsetka.TabIndex = 4;
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Location = new Point(670, 201);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(66, 19);
            cbAktivan.TabIndex = 5;
            cbAktivan.Text = "Aktivan";
            cbAktivan.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 74);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 6;
            label3.Text = "Napomena:";
            // 
            // txtNapomena
            // 
            txtNapomena.Location = new Point(257, 92);
            txtNapomena.Multiline = true;
            txtNapomena.Name = "txtNapomena";
            txtNapomena.Size = new Size(495, 71);
            txtNapomena.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 178);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 8;
            label4.Text = "Rok završetka:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(464, 178);
            label5.Name = "label5";
            label5.Size = new Size(130, 15);
            label5.TabIndex = 9;
            label5.Text = "Maksimalno studenata:";
            // 
            // txtMaksimalanBrojStudenata
            // 
            txtMaksimalanBrojStudenata.Location = new Point(463, 199);
            txtMaksimalanBrojStudenata.Name = "txtMaksimalanBrojStudenata";
            txtMaksimalanBrojStudenata.Size = new Size(201, 23);
            txtMaksimalanBrojStudenata.TabIndex = 10;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(633, 228);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(119, 29);
            btnSacuvaj.TabIndex = 11;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmProjekatAddIB230XXX
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 281);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtMaksimalanBrojStudenata);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtNapomena);
            Controls.Add(label3);
            Controls.Add(cbAktivan);
            Controls.Add(dtpRokZavrsetka);
            Controls.Add(txtNaziv);
            Controls.Add(label2);
            Controls.Add(pbLogo);
            Controls.Add(label1);
            Name = "frmProjekatAddIB230XXX";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projekat";
            Load += frmProjekatAddIB230XXX_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbLogo;
        private Label label2;
        private TextBox txtNaziv;
        private DateTimePicker dtpRokZavrsetka;
        private CheckBox cbAktivan;
        private Label label3;
        private TextBox txtNapomena;
        private Label label4;
        private Label label5;
        private TextBox txtMaksimalanBrojStudenata;
        private Button btnSacuvaj;
        private ErrorProvider err;
    }
}