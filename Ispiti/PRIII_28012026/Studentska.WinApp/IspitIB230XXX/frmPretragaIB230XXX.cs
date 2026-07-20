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
        StudentiKnjigeIB230XXXServis _studentiKnjigeServis = new StudentiKnjigeIB230XXXServis();
        KnjigeIB230XXXServis _knjigeServis = new KnjigeIB230XXXServis();
        public frmPretragaIB230XXX()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmPretragaIB230XXX_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var podaci = _studentiKnjigeServis.getAllStudentiKnjige();
            setPodatke(podaci);
        }

        private void setPodatke(List<StudentiKnjigeIB230XXX> podaci = null)
        {
            if (podaci != null)
            {
                dgvPodaci.DataSource = podaci.Select(x => new
                {
                    ID = x.Id,
                    KnjigaID = x.KnjigaId,
                    Student = x.Student.StudentInfo,
                    Knjiga = x.Knjiga.KnjigaInfo,
                    DatumIznajmljivanja = x.DatumIznajmljivanja.ToShortDateString(),
                    DatumVracanja = x.DatumVracanja?.ToShortDateString(),
                    Vracena = x.DatumVracanja.HasValue
                }).ToList();
                this.Text = $"Broj prikazanih podataka: {podaci.Count}";
            }
        }
        private void filtrirajPodatke()
        {
            var filtriraniPodaci = _studentiKnjigeServis.getFiltriranePodatke(txtImePrezimeNaziv.Text, cbVracena.Checked);
            setPodatke(filtriraniPodaci);
        }

        private void txtImePrezimeNaziv_TextChanged(object sender, EventArgs e)
        {
            filtrirajPodatke();
        }

        private void cbVracena_CheckedChanged(object sender, EventArgs e)
        {
            filtrirajPodatke();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Provjeri da li je kliknuta kolona btnPovrat
            if (dgvPodaci.Columns[e.ColumnIndex].Name == "Povrat" && e.RowIndex >= 0)
            {
                int id = (int)dgvPodaci.Rows[e.RowIndex].Cells["Id"].Value;

                try
                {
                    _studentiKnjigeServis.OznaciKnjiguVracenom(id);
                    MessageBox.Show("Knjiga je označena kao vraćena.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    filtrirajPodatke();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom vraćanja knjige: " + ex.Message);
                }
            }
        }
        private void dgvPodaci_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = (int)dgvPodaci.Rows[e.RowIndex].Cells["KnjigaID"].Value;
            var knjiga = _knjigeServis.GetById(id);

            var forma = new frmKnjigaAddEditIB230XXX(knjiga);
            if (forma.ShowDialog() == DialogResult.OK)
                filtrirajPodatke();
        }

        private void btnDodajKnjigu_Click(object sender, EventArgs e)
        {
            var forma = new frmKnjigaAddEditIB230XXX();
            forma.ShowDialog();
            filtrirajPodatke();
        }

        private void btnIznajmljivanja_Click(object sender, EventArgs e)
        {
            var forma = new frmIznajmljivanjeIB230XXX();
          forma.ShowDialog();
            filtrirajPodatke();
        }
    }
}
