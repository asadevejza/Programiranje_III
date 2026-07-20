using Studentska.Data.IspitIB230XXX;
using Studentska.Servis.IspitIB230XXX;
using Studentska.WinApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentska.WinApp.IspitIB230XXX
{
    public partial class frmKnjigaAddEditIB230XXX : Form
    {
        StudentiKnjigeIB230XXXServis _studentiKnjigeServis = new StudentiKnjigeIB230XXXServis();
        KnjigeIB230XXXServis _knjigeServis = new KnjigeIB230XXXServis();
        private KnjigeIB230XXX _knjiga;
        public frmKnjigaAddEditIB230XXX(KnjigeIB230XXX knjiga = null)
        {
            InitializeComponent();
            _knjiga = knjiga;
        }

        private void frmKnjigaAddEditIB230XXX_Load(object sender, EventArgs e)
        {
            if (_knjiga != null) // Editovanje
            {
                UcitajEditovanje();
            }
        }

        private void UcitajEditovanje()
        {
            txtNazivKnjige.Text = _knjiga.Naziv;
            txtAutori.Text = _knjiga.Autor;
            txtBrojPrimjeraka.Text = _knjiga.BrojPrimjeraka.ToString();
            pbSlika.Image = ImageHelper.ByteToImage(_knjiga.Slika);
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                pbSlika.Image = Image.FromFile(ofd.FileName);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                try
                {
                    if (_knjiga == null)
                    {
                        var novaKnjiga = new KnjigeIB230XXX
                        {
                            Naziv = txtNazivKnjige.Text,
                            Autor = txtAutori.Text,
                            BrojPrimjeraka = int.Parse(txtBrojPrimjeraka.Text),
                            Slika = ImageHelper.ImageToByte(pbSlika.Image)
                        };
                        _knjigeServis.Add(novaKnjiga);
                        MessageBox.Show("Uspješno dodata nova knjiga!");
                    }
                    else 
                    {
                        _knjiga.Naziv = txtNazivKnjige.Text.Trim();
                        _knjiga.Autor = txtAutori.Text.Trim();
                        _knjiga.BrojPrimjeraka = int.Parse(txtBrojPrimjeraka.Text);
                        _knjiga.Slika = ImageHelper.ImageToByte(pbSlika.Image);

                        _knjigeServis.Update(_knjiga);
                        MessageBox.Show("Uspješno izmijenjeni podaci o knjizi!");
                    }

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom spašavanja: " + (ex.InnerException?.Message ?? ex.Message));
                }
            }
        }

        private bool ValidirajUnos()
        {
            if (!Helpers.Validator.ValidanUnos(txtNazivKnjige, err, "Obavezan unos") ||
                !Helpers.Validator.ValidanUnos(txtAutori, err, "Obavezan unos") ||
                !Helpers.Validator.ValidanUnos(txtBrojPrimjeraka, err, "Obavezan unos") ||
                !Helpers.Validator.ValidanUnos(pbSlika, err, "Obavezan unos"))
            {
                return false;
            }

            if (!int.TryParse(txtBrojPrimjeraka.Text, out int brojPrimjeraka) || brojPrimjeraka <= 0)
            {
                MessageBox.Show("Broj primjeraka mora biti veći od 0!");
                return false;
            }

            var sve = _knjigeServis.GetAllKnjige();
            if (sve.Any(x => x.Naziv.ToLower() == txtNazivKnjige.Text.ToLower() &&
                             x.Autor.ToLower() == txtAutori.Text.ToLower() &&
                             (_knjiga == null || x.Id != _knjiga.Id)))
            {
                MessageBox.Show("Knjiga sa istim nazivom i autorom već postoji u bazi!");
                return false;
            }
            return true;
        }
    }
}
