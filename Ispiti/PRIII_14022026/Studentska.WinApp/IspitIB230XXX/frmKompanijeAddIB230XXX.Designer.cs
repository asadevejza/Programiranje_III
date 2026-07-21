namespace Studentska.WinApp.IspitIB230XXX
{
    partial class frmKompanijeAddIB230XXX
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
            err = new ErrorProvider(components);
            pbSlika = new PictureBox();
            txtNaziv = new TextBox();
            label1 = new Label();
            cbAktivna = new CheckBox();
            btnSacuvaj = new Button();
            label2 = new Label();
            txtAdresa = new TextBox();
            label3 = new Label();
            txtMaksimalnoStudenata = new TextBox();
            cmbGrad = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txtUrl = new TextBox();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(12, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(198, 190);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            pbSlika.Click += pbSlika_Click;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(233, 39);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(253, 23);
            txtNaziv.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 21);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Naziv:";
            // 
            // cbAktivna
            // 
            cbAktivna.AutoSize = true;
            cbAktivna.Location = new Point(515, 158);
            cbAktivna.Name = "cbAktivna";
            cbAktivna.Size = new Size(66, 19);
            cbAktivna.TabIndex = 3;
            cbAktivna.Text = "Aktivna";
            cbAktivna.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(661, 189);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(107, 25);
            btnSacuvaj.TabIndex = 4;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 80);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 6;
            label2.Text = "Adresa:";
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(233, 98);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(253, 23);
            txtAdresa.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 140);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 8;
            label3.Text = "Maksimalno studenata:";
            // 
            // txtMaksimalnoStudenata
            // 
            txtMaksimalnoStudenata.Location = new Point(233, 158);
            txtMaksimalnoStudenata.Name = "txtMaksimalnoStudenata";
            txtMaksimalnoStudenata.Size = new Size(253, 23);
            txtMaksimalnoStudenata.TabIndex = 7;
            // 
            // cmbGrad
            // 
            cmbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrad.FormattingEnabled = true;
            cmbGrad.Location = new Point(515, 39);
            cmbGrad.Name = "cmbGrad";
            cmbGrad.Size = new Size(253, 23);
            cmbGrad.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(515, 21);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 10;
            label4.Text = "Grad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(515, 80);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 12;
            label5.Text = "URL:";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(515, 98);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(253, 23);
            txtUrl.TabIndex = 11;
            // 
            // frmKompanijeAddIB230XXX
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 255);
            Controls.Add(label5);
            Controls.Add(txtUrl);
            Controls.Add(label4);
            Controls.Add(cmbGrad);
            Controls.Add(label3);
            Controls.Add(txtMaksimalnoStudenata);
            Controls.Add(label2);
            Controls.Add(txtAdresa);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbAktivna);
            Controls.Add(label1);
            Controls.Add(txtNaziv);
            Controls.Add(pbSlika);
            Name = "frmKompanijeAddIB230XXX";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kompanija";
            Load += frmKompanijeAddIB230XXX_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider err;
        private Label label5;
        private TextBox txtUrl;
        private Label label4;
        private ComboBox cmbGrad;
        private Label label3;
        private TextBox txtMaksimalnoStudenata;
        private Label label2;
        private TextBox txtAdresa;
        private Button btnSacuvaj;
        private CheckBox cbAktivna;
        private Label label1;
        private TextBox txtNaziv;
        private PictureBox pbSlika;
    }
}