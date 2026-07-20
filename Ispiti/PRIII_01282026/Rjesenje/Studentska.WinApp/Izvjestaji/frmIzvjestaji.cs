using Microsoft.Reporting.WinForms;
using Studentska.Data.Entiteti;
using Studentska.Servis.IspitIB230014;

namespace Studentska.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private Student _student;
        private StudentiKnjigeServisIB230014 _servis = new StudentiKnjigeServisIB230014();

        public frmIzvjestaji(Student student)
        {
            InitializeComponent();
            _student = student;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            // 1. Postavljanje putanje (mora biti Embedded Resource u Properties!)
            reportViewer1.LocalReport.ReportEmbeddedResource = "Studentska.WinApp.Izvjestaji.rptStudentiUplate.rdlc";

            // 2. Dohvatanje podataka za odabranog studenta
            var podaci = _servis.GetAllWithDetails()
                                .Where(x => x.StudentId == _student.Id)
                                .ToList();

            // 3. Mapiranje u listu (podaci za tabelu)
            int rb = 1;
            var listaStavki = podaci.Select(x => new
            {
                Rb = rb++,
                NazivKnjige = $"{x.Knjiga.Naziv} ({x.Knjiga.Autor})",
                Vracena = x.DatumVracanja.HasValue ? "Da" : "Ne",
                BrojDana = ((x.DatumVracanja ?? DateTime.Now) - x.DatumIznajmljivanja).Days
            }).ToList();

            // 4. POVEZIVANJE SA 'DataSet1' (ime sa slike 631685)
            reportViewer1.LocalReport.DataSources.Clear();
            var rds = new ReportDataSource("DataSet1", listaStavki); // Koristimo tačno DataSet1
            reportViewer1.LocalReport.DataSources.Add(rds);

            // 5. SLANJE PARAMETARA (sa slike 631685)
            var parametri = new ReportParameterCollection();
            parametri.Add(new ReportParameter("Student", _student.ToString())); // @Student
            parametri.Add(new ReportParameter("Total", listaStavki.Sum(x => x.BrojDana).ToString())); // @Total
            reportViewer1.LocalReport.SetParameters(parametri);

            // 6. Refresh za prikaz
            reportViewer1.RefreshReport();
        }
    }
}
