using Studentska.Data.Entiteti;
using Studentska.Servis.Servisi;
using Studentska.WinApp.Izvjestaji;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentska.WinApp
{
    public partial class frmPocetna : Form
    {

        StudentServis studentServis = new StudentServis();
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {
            lblInfo.Text = $"Broj studenata u bazi: {studentServis.GetBrojStudenata()}";
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            var student = studentServis.GetAll().FirstOrDefault(); // Uzima prvog studenta iz baze
            if (student != null)
            {
                var frm = new frmIzvjestaji(student);
                frm.ShowDialog();
            }
            ;
        }
    }
}
