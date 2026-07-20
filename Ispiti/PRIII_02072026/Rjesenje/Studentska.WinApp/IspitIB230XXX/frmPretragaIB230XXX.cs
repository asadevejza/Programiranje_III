using Studentska.Data.IspitIB230XXX;
using Studentska.Servis.IspitIB230XXX;
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
    public partial class frmPretragaIB230XXX : Form
    {
        StatusIB230XXXServis _statusServis = new StatusIB230XXXServis();
        StudentiProjektiIB230XXXServis _studentiProjektiServis = new StudentiProjektiIB230XXXServis();
        ProjektiIB230XXXServis _projektiServis = new ProjektiIB230XXXServis();
        public frmPretragaIB230XXX()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmPretragaIB230XXX_Load(object sender, EventArgs e)
        {
            UcitajStatus();
            UcitajStanje();
            UcitajPodatke();
        }

        private void UcitajStanje()
        {
            cmbStanjePrijave.Items.Clear();
            cmbStanjePrijave.Items.Add("Sve");
            cmbStanjePrijave.Items.Add("Aktivna");
            cmbStanjePrijave.Items.Add("Arhivirane");
            cmbStanjePrijave.SelectedIndex = 0;
        }

        private void UcitajPodatke()
        {
            var sviPodaci = _studentiProjektiServis.getAllStudentiProjekti();
            setPodatke();
        }

        private void setPodatke(List<StudentiProjektiIB230XXX> podaci = null)
        {
            if (podaci != null)
            {
                dgvPodaci.DataSource = podaci.Select(x => new
                {
                    ID = x.Id,
                    Student = x.Student.StudentInfo,
                    Projekat = x.Projekti.NazivProjekta,
                    RokZavrsetka = x.Projekti.RokZavrsetka.ToString("dd-MM-yyyy"),
                    StatusPrijave = x.Status.Naziv,
                    DatumPrijave = x.DatumPrijave.ToString("dd-MM-yyyy"),
                    DatumPromjeneStatusa = x.DatumPromjeneStatusa?.ToString("dd-MM-yyyy"),
                    StanjePrijave = x.Arhivirana ? "Arhivirana" : "Aktivna" // <-- TERNARNI OPERATOR
                }).ToList();
            }
        }

        private void UcitajStatus()
        {
            var statusi = _statusServis.GetAll();

            var dummyStavka = new StatusIB230XXX
            {
                Id = 0,
                Naziv = "Sve"
            };

            statusi.Insert(0, dummyStavka);

            cmbStatusPrijave.DataSource = statusi;
            cmbStatusPrijave.SelectedIndex = 0;
        }
        private void filtrirajPodatke()
        {
            var filtriraniPodaci = _studentiProjektiServis.getFiltriranePodatke(txtImePrezimeNaziv.Text, cmbStatusPrijave.SelectedIndex, cmbStanjePrijave.SelectedIndex);
            setPodatke(filtriraniPodaci);
        }

        private void txtImePrezimeNaziv_TextChanged(object sender, EventArgs e)
        {
            filtrirajPodatke();
        }

        private void cmbStatusPrijave_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrirajPodatke();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPodaci.Columns[e.ColumnIndex].Name == "Arhiviraj")
            {
                var prijavaId = (int)dgvPodaci.Rows[e.RowIndex].Cells["ID"].Value;
                try
                {
                    _studentiProjektiServis.ArhivirajZapis(prijavaId);
                    MessageBox.Show("Prijava uspjesno arhivirana");
                    filtrirajPodatke();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            filtrirajPodatke();
        }

        private void cmbStanjePrijave_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrirajPodatke();
        }

        private void dgvPodaci_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var prijavaId = (int)dgvPodaci.Rows[e.RowIndex].Cells["ID"].Value;
                var prijava = _studentiProjektiServis.GetById(prijavaId);
                var novaPrijava = new frmPrijavaAddEditIB230XXX(prijava);
                novaPrijava.ShowDialog();
            }
            filtrirajPodatke();
        }

        private void btnNoviProjekat_Click(object sender, EventArgs e)
        {
            var noviProjekat = new frmProjekatAddIB230XXX();
            noviProjekat.ShowDialog();
        }

        private void btnNovaPrijava_Click(object sender, EventArgs e)
        {
            var novaPrijava = new frmPrijavaAddEditIB230XXX();
            novaPrijava.ShowDialog();
            filtrirajPodatke();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
