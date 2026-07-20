using Studentska.Data.Entiteti;
using Studentska.Data.IspitIB230014;
using Studentska.Servis.IspitIB230014;
using Studentska.Servis.Servisi;
using Studentska.WinApp.Izvjestaji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentska.WinApp.IspitIB230014
{
    public partial class frmIznajmljivanjaIB230014 : Form
    {
        StudentiKnjigeServisIB230014 _studentKnjigeServis = new StudentiKnjigeServisIB230014();
        KnjigeServisIB230014 _knjigeServis = new KnjigeServisIB230014();
        StudentServis _studentServis = new StudentServis();
        public frmIznajmljivanjaIB230014()
        {
            InitializeComponent();
            dgvIznajmljivanja.AutoGenerateColumns = false;
        }
        private void frmIznajmljivanjaIB230014_Load(object sender, EventArgs e)
        {
            UcitajStudente();
            UcitajKnjige();
            UcitajPodatke();
        }
        private void UcitajPodatke()
        {
            var podaci = _studentKnjigeServis.GetAllWithDetails();

            dgvIznajmljivanja.DataSource = null;
            dgvIznajmljivanja.DataSource = podaci.Select(x => new
            {
                x.Id,
                IndeksImePrezime = x.Student.ToString(),
                Knjiga = x.Knjiga.Naziv,
                DatumIznajmljivanja = x.DatumIznajmljivanja.ToString("dd.MM.yyyy HH:mm"),
                Vracena = x.DatumVracanja.HasValue
            }).ToList();
        }

        private void UcitajKnjige()
        {
            cmbKnjiga.DataSource = _knjigeServis.GetAll();
        }

        private void UcitajStudente()
        {
            cmbStudent.DataSource = _studentServis.GetAll();
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            // UMJESTO: int studentId = (int)cmbStudent.SelectedValue;
            // KORISTI OVO:
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
            var knjigeZaIznajmiti = _studentKnjigeServis.GetKnjigeKojeStudentNijeIznajmljivao(student.Id);

            foreach (var knjiga in knjigeZaIznajmiti)
            {
                Thread.Sleep(300);

                var novo = new StudentiKnjigeIB230014
                {
                    StudentId = student.Id,
                    KnjigaId = knjiga.Id,
                    DatumIznajmljivanja = DateTime.Now
                };

                _studentKnjigeServis.Add(novo);
                string poruka = $"{DateTime.Now:HH:mm:ss} -> Student {student} iznajmio {knjiga}{Environment.NewLine}";

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
        private void btnIznajmi_Click(object sender, EventArgs e)
        {
            var student = cmbStudent.SelectedItem as Student;
            var knjiga = cmbKnjiga.SelectedItem as KnjigeIB230014;

            if (student == null || knjiga == null)
                return;
            try
            {
                var novo = new StudentiKnjigeIB230014
                {
                    StudentId = student.Id,
                    KnjigaId = knjiga.Id,
                    DatumIznajmljivanja = DateTime.Now,
                    DatumVracanja = null
                };

                _studentKnjigeServis.IznajmiKnjigu(novo);
                UcitajPodatke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            // 1. Prvo dohvatimo studenta koji je odabran u ComboBox-u
            // Koristimo 'as Student' da izbjegnemo onaj InvalidCastException
            var student = cmbStudent.SelectedItem as Student;

            if (student != null)
            {
                // 2. OVDJE DODAJES TU LINIJU:
                var frm = new frmIzvjestaji(student);

                // 3. Prikazujemo formu kao dijalog
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Molimo odaberite studenta!");
            }
        }
    }
}
