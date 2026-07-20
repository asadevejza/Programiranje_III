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
    public partial class frmPrijavaAddEditIB230XXX : Form
    {
        StatusIB230XXXServis _statusServis = new StatusIB230XXXServis();
        StudentiProjektiIB230XXXServis _studentiProjektiServis = new StudentiProjektiIB230XXXServis();
        ProjektiIB230XXXServis _projektiServis = new ProjektiIB230XXXServis();
        StudentServis _studentServis = new StudentServis();
        StudentiProjektiIB230XXX _prijava;
        public frmPrijavaAddEditIB230XXX(StudentiProjektiIB230XXX prijava = null)
        {
            InitializeComponent();
            _prijava = prijava;
        }

        private void frmPrijavaAddEditIB230XXX_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            if (_prijava == null)
            {
                cmbStatus.Enabled = false;
                cmbStatus.SelectedIndex = 0;
                dtpDatumPrijave.Value = DateTime.Now;
            }
            else
            {
                cmbStudent.SelectedValue = _prijava.StudentId;
                cmbProjekat.SelectedValue = _prijava.ProjektiId;
                cmbStatus.SelectedValue = _prijava.StatusId;
                dtpDatumPrijave.Value = _prijava.DatumPrijave;

                cmbStudent.Enabled = false;

                var trenutniStatus = (StatusIB230XXX)cmbStatus.SelectedItem;
                if (trenutniStatus != null && trenutniStatus.Naziv.ToUpper() != "PODNESENA")
                {
                    cmbProjekat.Enabled = false;
                }
                cmbStatus.Enabled = true;
            }
        }

        private void UcitajPodatke()
        {
            cmbStudent.DataSource = _studentServis.GetAll();
            cmbStudent.ValueMember = "Id";
            cmbStudent.DisplayMember = "StudentInfo";

            cmbProjekat.DataSource = _projektiServis.GetAktivniProjekti();
            cmbProjekat.ValueMember = "Id";
            cmbProjekat.DisplayMember = "NazivProjekta";

            cmbStatus.DataSource = _statusServis.GetAll();
            cmbStatus.ValueMember = "Id";
            cmbStatus.DisplayMember = "Naziv";
        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidnaPolja())
            {
                try
                {
                    if (_prijava == null)
                    {
                        var novaPrijava = new StudentiProjektiIB230XXX
                        {
                            StudentId = (int)cmbStudent.SelectedValue,
                            ProjektiId = (int)cmbProjekat.SelectedValue,
                            DatumPrijave = dtpDatumPrijave.Value,
                            StatusId = (int)cmbStatus.SelectedValue,
                            DatumPromjeneStatusa = null,
                            Arhivirana = false
                        };

                        _studentiProjektiServis.Add(novaPrijava);
                        MessageBox.Show("Uspješno dodata nova prijava!");
                    }
                    else
                    {
                        _prijava.ProjektiId = (int)cmbProjekat.SelectedValue;

                        var noviStatusId = (int)cmbStatus.SelectedValue;
                        var noviStatusObj = (StatusIB230XXX)cmbStatus.SelectedItem;

                        if (noviStatusId != _prijava.StatusId)
                        {
                            _prijava.DatumPromjeneStatusa = DateTime.Now;
                        }

                        _prijava.StatusId = noviStatusId;

                        if (noviStatusObj != null && noviStatusObj.Naziv.ToUpper() == "ZAVRSENA")
                        {
                            _prijava.Arhivirana = true;
                        }

                        _studentiProjektiServis.Update(_prijava);
                        MessageBox.Show("Uspješno ažurirana prijava!");
                    }
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom spašavanja: " + ex.Message);
                }
            }
        }

        private bool ValidnaPolja()
        {
            var studentId = (int)cmbStudent.SelectedValue;
            var projekat = (ProjektiIB230XXX)cmbProjekat.SelectedItem;
            var noviStatus = (StatusIB230XXX)cmbStatus.SelectedItem;

            var svePrijave = _studentiProjektiServis.getAllStudentiProjekti();

            if (!Helpers.Validator.ValidanUnos(cmbStudent, err, "Obavezan unos") ||
                !Helpers.Validator.ValidanUnos(cmbProjekat, err, "Obavezan unos") ||
                !Helpers.Validator.ValidanUnos(cmbStatus, err, "Obavezan unos"))
            {
                return false;
            }

            if (projekat == null || !projekat.Aktivan)
            {
                MessageBox.Show("Nije moguće prijaviti se na projekat koji nije aktivan!");
                return false;
            }

            if (dtpDatumPrijave.Value.Date > projekat.RokZavrsetka.Date)
            {
                MessageBox.Show($"Datum prijave ne može biti veći od roka završetka projekta ({projekat.RokZavrsetka:dd.MM.yyyy})!");
                return false;
            }

            var imaAktivnuNaIstiProjekat = svePrijave.Any(x =>
                x.StudentId == studentId &&
                x.ProjektiId == projekat.Id &&
                !x.Arhivirana &&
                (_prijava == null || x.Id != _prijava.Id));

            if (imaAktivnuNaIstiProjekat)
            {
                MessageBox.Show("Student već ima aktivnu prijavu na ovaj projekat!");
                return false;
            }

            var vecPrihvacena = svePrijave.Any(x =>
                x.StudentId == studentId &&
                x.Status.Naziv.ToUpper() == "PRIHVACENA" &&
                !x.Arhivirana &&
                (_prijava == null || x.Id != _prijava.Id));

            if (noviStatus.Naziv.ToUpper() == "PRIHVACENA" && vecPrihvacena)
            {
                MessageBox.Show("Student već ima jednu prihvaćenu prijavu koja još nije završena!");
                return false;
            }

            var brojPrihvacenih = svePrijave.Count(x =>
                x.ProjektiId == projekat.Id &&
                x.Status.Naziv.ToUpper() == "PRIHVACENA" &&
                !x.Arhivirana &&
                (_prijava == null || x.Id != _prijava.Id));

            if (noviStatus.Naziv.ToUpper() == "PRIHVACENA" && brojPrihvacenih >= projekat.MaksimalanBrojStudenata)
            {
                MessageBox.Show("Nove prijave se mogu prihvatiti tek nakon što se za nekog od trenutno prihvaćenih studenata status promijeni u ZAVRSENA.");
                return false;
            }
            return true;
        }

        private void btnGenerisiPrijave_Click(object sender, EventArgs e)
        {
            if (cmbStudent.SelectedValue == null)
            {
                MessageBox.Show("Molimo odaberite studenta!");
                return;
            }

            var odabraniStudent = (Student)cmbStudent.SelectedItem;

            Task.Run(() =>
            {
                var sviProjekti = _projektiServis.GetAll();
                var svePrijave = _studentiProjektiServis.GetAll();

                var statusi = _statusServis.GetAll();
                var podnesenaStatusId = statusi.FirstOrDefault(x => x.Naziv.ToUpper() == "PODNESENA")?.Id ?? 1;

                var projektiGdeJeAplicirao = svePrijave
                    .Where(x => x.StudentId == odabraniStudent.Id && !x.Arhivirana)
                    .Select(x => x.ProjektiId)
                    .ToList();

                var projektiZaAplicirati = sviProjekti
                    .Where(p => p.Aktivan &&
                                p.RokZavrsetka.Date >= DateTime.Now.Date &&
                                !projektiGdeJeAplicirao.Contains(p.Id)).ToList();

                if (projektiZaAplicirati.Count == 0)
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        MessageBox.Show("Ne postoji nijedan projekat za koji se može generisati prijava!");
                    }));
                    return;
                }

                int brojac = 1;

                foreach (var projekat in projektiZaAplicirati)
                {
                    var trenutniDatum = DateTime.Now;

                    var novaPrijava = new StudentiProjektiIB230XXX
                    {
                        StudentId = odabraniStudent.Id,
                        ProjektiId = projekat.Id,
                        DatumPrijave = trenutniDatum,
                        StatusId = podnesenaStatusId,
                        DatumPromjeneStatusa = trenutniDatum,
                        Arhivirana = false
                    };

                    _studentiProjektiServis.Add(novaPrijava);
                    string infoPoruka = $"Dodata prijava na projekat \"{projekat.NazivProjekta}\" - studentu {odabraniStudent.StudentInfo}.{Environment.NewLine}.";

                    txtGeneratorInfo.BeginInvoke(new Action(() =>
                    {
                        txtGeneratorInfo.AppendText(infoPoruka);
                    }));

                    brojac++;
                    Thread.Sleep(300);
                }
                this.BeginInvoke(new Action(() =>
                {
                    MessageBox.Show("Generisanje prijava je uspješno završeno!");
                    DialogResult = DialogResult.OK;
                }));
            });
        }
    }
}
