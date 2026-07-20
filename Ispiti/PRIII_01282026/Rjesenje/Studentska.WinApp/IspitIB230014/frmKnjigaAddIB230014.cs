using Studentska.Data.IspitIB230014;
using Studentska.Servis.IspitIB230014;
using Studentska.WinApp.Helpers;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Studentska.WinApp.IspitIB230014
{
    public partial class frmKnjigaAddIB230014 : Form
    {
        KnjigeServisIB230014 _knjigeServis = new KnjigeServisIB230014();
        private KnjigeIB230014 _knjiga;

        public frmKnjigaAddIB230014(KnjigeIB230014 knjiga = null)
        {
            InitializeComponent();
            _knjiga = knjiga;
        }

        private void frmKnjigaAddIB230014_Load(object sender, EventArgs e)
        {
            if (_knjiga != null) // Editovanje
            {
                txtNazivKnjige.Text = _knjiga.Naziv;
                txtAutori.Text = _knjiga.Autor;
                txtBrojPrimjeraka.Text = _knjiga.BrojPrimjeraka.ToString();
                if (_knjiga.Slika != null)
                    pbSlika.Image = ImageHelper.ByteToImage(_knjiga.Slika);
            }
        }
        private void pbSlika_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                pbSlika.Image = Image.FromFile(ofd.FileName);
        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validiraj())
            {
                try
                {
                    if (_knjiga == null)
                        _knjiga = new KnjigeIB230014();

                    _knjiga.Naziv = txtNazivKnjige.Text;
                    _knjiga.Autor = txtAutori.Text;
                    _knjiga.BrojPrimjeraka = int.Parse(txtBrojPrimjeraka.Text);
                    _knjiga.Slika = ImageHelper.ImageToByte(pbSlika.Image); // Rješava NOT NULL

                    if (_knjiga.Id == 0)
                        _knjigeServis.Add(_knjiga);
                    else
                        _knjigeServis.Update(_knjiga);

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
                }
            }
        }
        bool validiraj()
        {
            if (string.IsNullOrEmpty(txtNazivKnjige.Text) || string.IsNullOrEmpty(txtAutori.Text) ||
                pbSlika.Image == null)
            {
                MessageBox.Show("Sva polja i slika su obavezni!");
                return false;
            }

            if (!int.TryParse(txtBrojPrimjeraka.Text, out int br) || br <= 0)
            {
                MessageBox.Show("Broj primjeraka mora biti veći od 0!");
                return false;
            }

            // Provjera duplikata
            var sve = _knjigeServis.GetAll();
            if (sve.Any(x => x.Naziv.ToLower() == txtNazivKnjige.Text.ToLower() &&
                             x.Autor.ToLower() == txtAutori.Text.ToLower() &&
                             (_knjiga == null || x.Id != _knjiga.Id)))
            {
                MessageBox.Show("Knjiga već postoji!");
                return false;
            }
            return true;
        }
    }
}