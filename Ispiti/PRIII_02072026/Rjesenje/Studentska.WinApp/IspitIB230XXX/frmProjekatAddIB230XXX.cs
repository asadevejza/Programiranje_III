using Studentska.Data.IspitIB230XXX;
using Studentska.Servis.IspitIB230XXX;
using Studentska.WinApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentska.WinApp.IspitIB230XXX
{
    public partial class frmProjekatAddIB230XXX : Form
    {

        StatusIB230XXXServis _statusServis = new StatusIB230XXXServis();
        StudentiProjektiIB230XXXServis _studentiProjektiServis = new StudentiProjektiIB230XXXServis();
        ProjektiIB230XXXServis _projektiServis = new ProjektiIB230XXXServis();
        public frmProjekatAddIB230XXX()
        {
            InitializeComponent();
        }

        private void frmProjekatAddIB230XXX_Load(object sender, EventArgs e)
        {

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbLogo.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidnaPolja())
            {
                try
                {
                    var noviProjekat = new ProjektiIB230XXX
                    {
                        NazivProjekta = txtNaziv.Text,
                        Napomena = txtNapomena.Text,
                        RokZavrsetka = dtpRokZavrsetka.Value,
                        MaksimalanBrojStudenata = int.Parse(txtMaksimalanBrojStudenata.Text),
                        SlikaProjekta = ImageHelper.ImageToByte(pbLogo.Image),
                        Aktivan = cbAktivan.Checked
                    };

                    _projektiServis.Add(noviProjekat);
                    MessageBox.Show("Novi projekat uspješno dodat!");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom spašavanja! " + ex.Message);
                }
            }
        }

        private bool ValidnaPolja()
        {
            //1. Sva obavezna polja
            if (!Helpers.Validator.ValidanUnos(txtNaziv,err,"Obavezan unos!")||
                !Helpers.Validator.ValidanUnos(dtpRokZavrsetka, err, "Obavezan unos!") ||
                !Helpers.Validator.ValidanUnos(txtMaksimalanBrojStudenata, err, "Obavezan unos!") ||
                !Helpers.Validator.ValidanUnos(cbAktivan, err, "Obavezan unos!"))
            {
                return false;
            }
            //2. Maksimalan broj studenata mora biti broj i to broj veci od 0: 
            if (!int.TryParse(txtMaksimalanBrojStudenata.Text, out int broj) || broj < 0)
            {
                MessageBox.Show("Maksimalan broj studenata mora biti veci od 0!");
                return false;
            }
            // 3. Rok završetka projekta ne može biti manji od trenutnog datuma
            if (dtpRokZavrsetka.Value.Date<DateTime.Now.Date)
            {
                MessageBox.Show("Rok završetka projekta ne može biti manji od trenutnog datuma!");
                return false;
            }
            // 4. Onemogućiti dodavanje projekata sa istim nazivom
            var postojiProjekat = _projektiServis.GetAll().Any(x => x.NazivProjekta == txtNaziv.Text);
            if(postojiProjekat)
            {
                MessageBox.Show("Projekat koji pokusavate dodati vec postoji!");
                return false;
            }
            return true;
        }
    }
}
