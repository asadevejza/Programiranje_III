using Studentska.Data.Entiteti;
using Studentska.Servis.IspitIB230014;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Studentska.WinApp.IspitIB230014
{
    public partial class frmPretragaIB230014 : Form
    {
        StudentiKnjigeServisIB230014 _studentiKnjigeServis = new StudentiKnjigeServisIB230014();
        KnjigeServisIB230014 _knjigeServis = new KnjigeServisIB230014();

        public frmPretragaIB230014()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }
       private void frmPretragaIB230014_Load(object sender, EventArgs e)
        {
            UcitajDgv();
        }
        private void UcitajDgv()
        {
            var studenti = _studentiKnjigeServis.PretraziStudente(txtPretraga.Text, cbVracena.Checked);

            dgvPodaci.DataSource = studenti.Select(s => new
            {
                Id = s.Id,
                KnjigaID=s.KnjigaId,
                IndeksImePrezime = $"({s.Student.Indeks}) {s.Student.Ime} {s.Student.Prezime}",
                Knjiga = $"{s.Knjiga.Naziv} ({s.Knjiga.Autor})",
                DatumIznajmljivanja = s.DatumIznajmljivanja.ToShortDateString(),
                DatumVracanja = s.DatumVracanja?.ToShortDateString(),
                Vracena = s.DatumVracanja.HasValue
            }).ToList();
        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            UcitajDgv();
        }
        private void cbVracena_CheckedChanged(object sender, EventArgs e)
        {
            UcitajDgv();
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
                    UcitajDgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom vraćanja knjige: " + ex.Message);
                }
            }
        } 
        private void btnIznajmljivanja_Click(object sender, EventArgs e)
        {
            var novaForma = new frmIznajmljivanjaIB230014();
            novaForma.ShowDialog();
        }
        private void btnDodajKnjigu_Click(object sender, EventArgs e)
        {
            var forma = new frmKnjigaAddIB230014();
            if (forma.ShowDialog() == DialogResult.OK)
                UcitajDgv();
        }
        private void dgvPodaci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = (int)dgvPodaci.Rows[e.RowIndex].Cells["KnjigaID"].Value;
            var knjiga = _knjigeServis.GetById(id);

            var forma = new frmKnjigaAddIB230014(knjiga);
            if (forma.ShowDialog() == DialogResult.OK)
                UcitajDgv();
        }
    }
}
