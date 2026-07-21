using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Studentska.Data.IspitIB230XXX;
using Studentska.Servis.IspitIB230XXX;

namespace Studentska.WinApp.IspitIB230XXX
{
    public partial class frmPretragaIB230XXX : Form
    {
        StatusIB230XXXServis _statusServis = new StatusIB230XXXServis();
        StudentiPraksaIB230XXXServis _studentPraksaServis = new StudentiPraksaIB230XXXServis();
        public frmPretragaIB230XXX()
        {
            InitializeComponent();
        }

        private void frmPretragaIB230XXX_Load(object sender, EventArgs e)
        {
            ucitajPodatkeCmb();
            ucitajPodatkeDgv();
        }

        private void ucitajPodatkeDgv()
        {
            var sviPodaci = _studentPraksaServis.getAllStudentiPrakse();
            setPodatkeUdgvPodaci();
        }

        private void setPodatkeUdgvPodaci(List<StudentiPraksaIB230XXX> sviPodaci = null)
        {
            if (sviPodaci != null)
            {
                dgvPodaci.DataSource = sviPodaci.Select(x => new
                {
                    ID = x.Id,
                    Student = x.Student.ToString(),
                    Kompanija = x.Kompanija.Naziv,
                    Grad = x.Kompanija.Grad.Naziv,
                    StatusZahtjeva = x.Status.Naziv,
                    DatumPromjene = x.DatumPromjeneStatusa?.ToString("dd-MM-yyyy")
                }).ToList();
            }
        }

        private void ucitajPodatkeCmb()
        {
            var statusi = _statusServis.getAllStatuse();

            var dummyStavka = new StatusIB230XXX
            {
                Id = 0,
                Naziv = "Odaberite status zahtjeva"
            };

            statusi.Insert(0, dummyStavka);

            cmbStatus.DataSource = statusi;
            cmbStatus.SelectedIndex = 0;
        }
        private void filtrirajPodatke()
        {
            var filtriraniPodaci = _studentPraksaServis.getFiltriranePodatke(txtImePrezimeNaziv.Text, cmbStatus.SelectedIndex);
            setPodatkeUdgvPodaci(filtriraniPodaci);
        }

       private void txtImePrezimeNaziv_TextChanged(object sender, EventArgs e)
        {
            filtrirajPodatke();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrirajPodatke();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dgvPodaci.Columns[e.ColumnIndex].Name == "Obrisi")
            {
                var zapisId = (int)dgvPodaci.Rows[e.RowIndex].Cells["ID"].Value;

                try
                {
                    _studentPraksaServis.ObisiZapis(zapisId);
                    MessageBox.Show("Zapis uspjesno obrisan!");
                }
                catch (Exception message)
                {
                    MessageBox.Show("Greska" + message);
                }
            }
            filtrirajPodatke();
        }

        private void dgvPodaci_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var praksaId = (int)dgvPodaci.Rows[e.RowIndex].Cells["ID"].Value;
                var praksa = _studentPraksaServis.GetById(praksaId);

                var frm = new frmPraksaAddEditIB230XXX(praksa);
                frm.ShowDialog();
            }
            filtrirajPodatke();
        }

        private void btnNovaKompanija_Click(object sender, EventArgs e)
        {
            var frm = new frmKompanijeAddIB230XXX();
            frm.ShowDialog();
        }

        private void btnNovaPraksa_Click(object sender, EventArgs e)
        {
            var frm = new frmPraksaAddEditIB230XXX();
            frm.ShowDialog();
            filtrirajPodatke();
        }
    }
}
