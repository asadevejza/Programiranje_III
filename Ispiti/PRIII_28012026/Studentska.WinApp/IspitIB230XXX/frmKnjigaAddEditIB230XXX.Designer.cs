namespace Studentska.WinApp.IspitIB230XXX
{
    partial class frmKnjigaAddEditIB230XXX
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
            label1 = new Label();
            txtNazivKnjige = new TextBox();
            btnSacuvaj = new Button();
            txtAutori = new TextBox();
            label2 = new Label();
            txtBrojPrimjeraka = new TextBox();
            label3 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(12, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(158, 185);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            pbSlika.Click += pbSlika_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 21);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "Naziv knjige";
            // 
            // txtNazivKnjige
            // 
            txtNazivKnjige.Location = new Point(189, 39);
            txtNazivKnjige.Name = "txtNazivKnjige";
            txtNazivKnjige.Size = new Size(210, 23);
            txtNazivKnjige.TabIndex = 2;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(291, 167);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(108, 30);
            btnSacuvaj.TabIndex = 3;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // txtAutori
            // 
            txtAutori.Location = new Point(189, 83);
            txtAutori.Name = "txtAutori";
            txtAutori.Size = new Size(210, 23);
            txtAutori.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 65);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Autori:";
            // 
            // txtBrojPrimjeraka
            // 
            txtBrojPrimjeraka.Location = new Point(189, 127);
            txtBrojPrimjeraka.Name = "txtBrojPrimjeraka";
            txtBrojPrimjeraka.Size = new Size(210, 23);
            txtBrojPrimjeraka.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 109);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 6;
            label3.Text = "Broj primjeraka:";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmKnjigaAddEditIB230XXX
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 277);
            Controls.Add(txtBrojPrimjeraka);
            Controls.Add(label3);
            Controls.Add(txtAutori);
            Controls.Add(label2);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtNazivKnjige);
            Controls.Add(label1);
            Controls.Add(pbSlika);
            Name = "frmKnjigaAddEditIB230XXX";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o knjizi";
            Load += frmKnjigaAddEditIB230XXX_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Label label1;
        private TextBox txtNazivKnjige;
        private Button btnSacuvaj;
        private TextBox txtAutori;
        private Label label2;
        private TextBox txtBrojPrimjeraka;
        private Label label3;
        private ErrorProvider err;
    }
}