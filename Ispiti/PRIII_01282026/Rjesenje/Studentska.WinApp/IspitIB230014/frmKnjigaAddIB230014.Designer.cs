namespace Studentska.WinApp.IspitIB230014
{
    partial class frmKnjigaAddIB230014
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
            pbSlika = new PictureBox();
            lblNazivKnjige = new Label();
            txtNazivKnjige = new TextBox();
            txtAutori = new TextBox();
            lblAutori = new Label();
            txtBrojPrimjeraka = new TextBox();
            lblBrojPrimjeraka = new Label();
            btnSacuvaj = new Button();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(12, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(170, 205);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            pbSlika.Click += pbSlika_Click;
            // 
            // lblNazivKnjige
            // 
            lblNazivKnjige.AutoSize = true;
            lblNazivKnjige.Location = new Point(199, 24);
            lblNazivKnjige.Name = "lblNazivKnjige";
            lblNazivKnjige.Size = new Size(74, 15);
            lblNazivKnjige.TabIndex = 1;
            lblNazivKnjige.Text = "Naziv knjige:";
            // 
            // txtNazivKnjige
            // 
            txtNazivKnjige.Location = new Point(199, 55);
            txtNazivKnjige.Name = "txtNazivKnjige";
            txtNazivKnjige.Size = new Size(194, 23);
            txtNazivKnjige.TabIndex = 2;
            // 
            // txtAutori
            // 
            txtAutori.Location = new Point(199, 125);
            txtAutori.Name = "txtAutori";
            txtAutori.Size = new Size(194, 23);
            txtAutori.TabIndex = 4;
            // 
            // lblAutori
            // 
            lblAutori.AutoSize = true;
            lblAutori.Location = new Point(199, 94);
            lblAutori.Name = "lblAutori";
            lblAutori.Size = new Size(43, 15);
            lblAutori.TabIndex = 3;
            lblAutori.Text = "Autori:";
            // 
            // txtBrojPrimjeraka
            // 
            txtBrojPrimjeraka.Location = new Point(199, 194);
            txtBrojPrimjeraka.Name = "txtBrojPrimjeraka";
            txtBrojPrimjeraka.Size = new Size(194, 23);
            txtBrojPrimjeraka.TabIndex = 6;
            // 
            // lblBrojPrimjeraka
            // 
            lblBrojPrimjeraka.AutoSize = true;
            lblBrojPrimjeraka.Location = new Point(199, 163);
            lblBrojPrimjeraka.Name = "lblBrojPrimjeraka";
            lblBrojPrimjeraka.Size = new Size(90, 15);
            lblBrojPrimjeraka.TabIndex = 5;
            lblBrojPrimjeraka.Text = "Broj primjeraka:";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(291, 232);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(102, 23);
            btnSacuvaj.TabIndex = 7;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmKnjigaAddIB230014
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 274);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtBrojPrimjeraka);
            Controls.Add(lblBrojPrimjeraka);
            Controls.Add(txtAutori);
            Controls.Add(lblAutori);
            Controls.Add(txtNazivKnjige);
            Controls.Add(lblNazivKnjige);
            Controls.Add(pbSlika);
            Name = "frmKnjigaAddIB230014";
            Text = "Podaci o knjizi";
            Load += frmKnjigaAddIB230014_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Label lblNazivKnjige;
        private TextBox txtNazivKnjige;
        private TextBox txtAutori;
        private Label lblAutori;
        private TextBox txtBrojPrimjeraka;
        private Label lblBrojPrimjeraka;
        private Button btnSacuvaj;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}