using Studentska.Data.Entiteti;
using Studentska.Data.IspitIB230XXX;
using Studentska.Servis.IspitIB230XXX;
using Studentska.Servis.Servisi;
using Studentska.WinApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentska.WinApp.IspitIB230XXX
{
    public partial class frmKompanijeAddIB230XXX : Form
    {
        GradServis _gradServis = new GradServis();
        KompanijeIB230XXXServis _kompanijaServis = new KompanijeIB230XXXServis();
        public frmKompanijeAddIB230XXX()
        {
            InitializeComponent();
        }

        private void frmKompanijeAddIB230XXX_Load(object sender, EventArgs e)
        {
            UcitajCmb();
        }

        private void UcitajCmb()
        {
            var gradovi = _gradServis.GetAll();
            cmbGrad.DataSource = gradovi;
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidnaPolja())
            {
                try
                {
                    var novaKompanija = new KompanijeIB230XXX
                    {
                        Naziv = txtNaziv.Text,
                        Adresa = txtAdresa.Text,
                        MaksimalanBrojStudenata = int.Parse(txtMaksimalnoStudenata.Text),
                        GradId = (cmbGrad.SelectedItem as Grad).Id,
                        Url = txtUrl.Text,
                        Aktivna = cbAktivna.Checked,
                        Slika = ImageHelper.ImageToByte(pbSlika.Image)
                    };

                    _kompanijaServis.Add(novaKompanija);
                    MessageBox.Show("Kompanija uspješno dodata!");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception message)
                {
                    MessageBox.Show("Greska! " + message);
                }
            }
        }
             private bool ValidnaPolja()
        {
            if (!Helpers.Validator.ValidanUnos(txtNaziv, err, "Obavezan unos") ||
                !Helpers.Validator.ValidanUnos(txtAdresa, err, "Obavezan unos") ||
                !Helpers.Validator.ValidanUnos(txtMaksimalnoStudenata, err, "Obavezan unos") ||
                !Helpers.Validator.ValidanUnos(cmbGrad, err, "Obavezan unos") ||
                !Helpers.Validator.ValidanUnos(txtUrl, err, "Obavezan unos") ||
                !Helpers.Validator.ValidanUnos(pbSlika, err, "Obavezan unos")
                )
            {
                return false;
            }

            if (!int.TryParse(txtMaksimalnoStudenata.Text, out int broj) || broj < 0)
            {
                MessageBox.Show("Maksimalan broj studenata ne smije biti negativan!");
                return false;
            }

            if (!ValidanUrl(txtUrl.Text))
            {
                MessageBox.Show("Url mora imati validan format: www.xx.xx");
                return false;
            }

            var postojiKompanija = _kompanijaServis.GetAll().Any(x =>
                x.Naziv == txtNaziv.Text && x.Grad.Id == ((Grad)cmbGrad.SelectedItem).Id);
            if (postojiKompanija)
            {
                MessageBox.Show("Kompanija koju pokušavate dodati vec postoji!");
                return false;
            }
            return true;
        }

        private bool ValidanUrl(string text)
        {
            return Regex.IsMatch(text, @"^www\.[A-Za-z]{2,}\.[A-Za-z]{2,}$");
        }
    }
}
