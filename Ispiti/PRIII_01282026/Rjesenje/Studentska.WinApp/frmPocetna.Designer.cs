namespace Studentska.WinApp
{
    partial class frmPocetna
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
            lblInfo = new Label();
            btnIzvjestaj = new Button();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 20F);
            lblInfo.Location = new Point(143, 108);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 37);
            lblInfo.TabIndex = 0;
            // 
            // btnIzvjestaj
            // 
            btnIzvjestaj.Location = new Point(222, 187);
            btnIzvjestaj.Margin = new Padding(3, 2, 3, 2);
            btnIzvjestaj.Name = "btnIzvjestaj";
            btnIzvjestaj.Size = new Size(183, 22);
            btnIzvjestaj.TabIndex = 1;
            btnIzvjestaj.Text = "Prikazi izvjestaj";
            btnIzvjestaj.UseVisualStyleBackColor = true;
            btnIzvjestaj.Click += btnIzvjestaj_Click;
            // 
            // frmPocetna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 278);
            Controls.Add(btnIzvjestaj);
            Controls.Add(lblInfo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPocetna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Početna";
            Load += frmPocetna_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private Button btnIzvjestaj;
    }
}