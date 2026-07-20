using Studentska.Data.Entiteti;
using Studentska.Data.IspitIB230XXX;
using Studentska.Servis.IspitIB230XXX;
using Studentska.Servis.Servisi;
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
    public partial class frmIznajmljivanjeIB230XXX : Form
    {
        StudentiKnjigeIB230XXXServis _studentiKnjigeServis = new StudentiKnjigeIB230XXXServis();
        KnjigeIB230XXXServis _knjigeServis = new KnjigeIB230XXXServis();
        StudentServis _studentServis = new StudentServis();
        public frmIznajmljivanjeIB230XXX()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmIznajmljivanjeIB230XXX_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            UcitajDgv();
        }

        private void UcitajDgv()
        {
            var podaci = _studentiKnjigeServis.getAllStudentiKnjige();
            setPodatke(podaci);
        }

        private void setPodatke(List<StudentiKnjigeIB230XXX> podaci)
        {
            dgvPodaci.DataSource = podaci.Select(x => new
            {
                ID = x.Id,
                Student = x.Student.StudentInfo,
                Knjiga = x.Knjiga.KnjigaInfo,
                DatumIznajmljivanja = x.DatumIznajmljivanja.ToShortDateString(),
                Vracena = x.DatumVracanja.HasValue
            }).ToList();
        }

        private void UcitajPodatke()
        {
            cmbStudent.DataSource = _studentServis.GetAll();
            cmbStudent.ValueMember = "Id";
            cmbStudent.DisplayMember = "StudentInfo";

            cmbKnjiga.DataSource = _knjigeServis.GetAll();
            cmbKnjiga.ValueMember = "Id";
            cmbKnjiga.DisplayMember = "Naziv";
        }

        private void btnIznajmi_Click(object sender, EventArgs e)
        {
            if (ValidnaPolja())
            {
                try
                {
                    var student = (Student)cmbStudent.SelectedItem;
                    var knjiga = (KnjigeIB230XXX)cmbKnjiga.SelectedItem;

                    var novo = new StudentiKnjigeIB230XXX
                    {
                        StudentId = student.Id,
                        KnjigaId = knjiga.Id,
                        DatumIznajmljivanja = DateTime.Now,
                        DatumVracanja = null
                    };

                    _studentiKnjigeServis.Add(novo);
                    MessageBox.Show("Knjiga je uspješno iznajmljena!");
                    UcitajDgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom iznajmljivanja: " + (ex.InnerException?.Message ?? ex.Message));
                }
            }
        }

        private bool ValidnaPolja()
        {
            int studentId = (int)cmbStudent.SelectedValue;
            int knjigaId = (int)cmbKnjiga.SelectedValue;
            var knjiga = (KnjigeIB230XXX)cmbKnjiga.SelectedItem;

            var sveIznajmljivanja = _studentiKnjigeServis.GetAll();

            bool vecIznajmljena = sveIznajmljivanja.Any(x =>
                x.StudentId == studentId &&
                x.KnjigaId == knjigaId &&
                x.DatumVracanja == null);

            if (vecIznajmljena)
            {
                MessageBox.Show("Student već ima iznajmljenu ovu knjigu i još je nije vratio!");
                return false;
            }

            int brojNevracenih = sveIznajmljivanja.Count(x =>
                x.KnjigaId == knjigaId &&
                x.DatumVracanja == null);

            if (brojNevracenih >= knjiga.BrojPrimjeraka)
            {
                MessageBox.Show("Nema dostupnih primjeraka ove knjige za iznajmljivanje!");
                return false;
            }

            return true;
        }

        private void filtrirajPodatke()
        {
            int? studentId = cmbStudent.SelectedValue as int?;
            int? knjigaId = cmbKnjiga.SelectedValue as int?;

            var filtriraniPodaci = _studentiKnjigeServis.getFiltriranePodatke(studentId, knjigaId);
            setPodatke(filtriraniPodaci);
        }
        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrirajPodatke();
        }

        private void cmbKnjiga_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrirajPodatke();
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            var student = cmbStudent.SelectedItem as Student;

            if (student != null)
            {
                // Sada direktno šaljemo cijeli objekt studenta u metodu
                Thread thread = new Thread(() => GenerisiIznajmljivanja(student));
                thread.Start();
            }
        }
        private void GenerisiIznajmljivanja(Student student)
        {
            var knjigeZaIznajmiti = _studentiKnjigeServis.GetKnjigeKojeStudentNijeIznajmljivao(student.Id);
            int brojac = 1;

            foreach (var knjiga in knjigeZaIznajmiti)
            {
                Thread.Sleep(300);

                var novo = new StudentiKnjigeIB230XXX
                {
                    StudentId = student.Id,
                    KnjigaId = knjiga.Id,
                    DatumIznajmljivanja = DateTime.Now
                };

                _studentiKnjigeServis.Add(novo);
                string poruka = $"{brojac}. {student.StudentInfo} dodato zaduzenje {knjiga.KnjigaInfo}{Environment.NewLine}";

                BeginInvoke(new Action(() =>
                {
                    txtGenerator.AppendText(poruka);
                }));
            }

            BeginInvoke(new Action(() =>
            {
                UcitajPodatke();
                MessageBox.Show("Dodavanje podataka završeno!");
            }));
        }
    }
}
