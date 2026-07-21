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
    public partial class frmPraksaAddEditIB230XXX : Form
    {
        private StudentiPraksaIB230XXX _praksa;
        StudentServis _studentServis = new StudentServis();
        KompanijeIB230XXXServis _kompanijeServis = new KompanijeIB230XXXServis();
        StudentiPraksaIB230XXXServis _studentPraksaServis = new StudentiPraksaIB230XXXServis();
        StatusIB230XXXServis _statusServis = new StatusIB230XXXServis();
        public frmPraksaAddEditIB230XXX(StudentiPraksaIB230XXX praksa = null)
        {
            InitializeComponent();
            _praksa = praksa;
        }

        private void frmPraksaAddEditIB230XXX_Load(object sender, EventArgs e)
        {
            ucitajPodatke();
            if (_praksa == null)
            {
                cmbStatusZahtjeva.Enabled = false;
                cmbStatusZahtjeva.SelectedIndex = 0;
            }
            else
            {
                cmbStatusZahtjeva.Enabled = true;

                cmbStudent.SelectedValue = _praksa.StudentId;
                cmbKompanija.SelectedValue = _praksa.KompanijaId;
                cmbStatusZahtjeva.SelectedValue = _praksa.StatusId;
                dtpDatumPrijave.Value = _praksa.DatumPrijave;
            }
        }

        private void ucitajPodatke()
        {
            cmbStudent.DataSource = _studentServis.GetAll();
            cmbStudent.ValueMember = "Id";
            cmbStudent.DisplayMember = "StudentInfo";

            cmbKompanija.DataSource = _kompanijeServis.getAktivne();
            cmbKompanija.ValueMember = "Id";
            cmbKompanija.DisplayMember = "Naziv";

            cmbStatusZahtjeva.DataSource = _statusServis.GetAll();
            cmbStatusZahtjeva.ValueMember = "Id";
            cmbStatusZahtjeva.DisplayMember = "Naziv";
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidnaPolja())
            {
                if (_praksa == null)
                {
                    var novaPraksa = new StudentiPraksaIB230XXX
                    {
                        StudentId = (int)cmbStudent.SelectedValue,
                        KompanijaId = (int)cmbKompanija.SelectedValue,
                        DatumPrijave = DateTime.Now,
                        StatusId = (int)cmbStatusZahtjeva.SelectedValue,
                        DatumPromjeneStatusa = null
                    };
                    _studentPraksaServis.Add(novaPraksa);
                    MessageBox.Show("Uspješno dodata nova praksa");
                }
                else
                {
                    _praksa.StudentId = (int)cmbStudent.SelectedValue;
                    _praksa.KompanijaId = (int)cmbKompanija.SelectedValue;
                    var status = (int)cmbStatusZahtjeva.SelectedValue;
                    if (status != _praksa.StatusId)
                    {
                        _praksa.DatumPromjeneStatusa = DateTime.Now;
                    }
                    _praksa.StatusId = status;

                    _studentPraksaServis.Update(_praksa);
                    MessageBox.Show("Uspješno ažurirana praksa!");
                }
            }
        }
        private bool ValidnaPolja()
        {
            var studentId = (int)cmbStudent.SelectedValue;
            var kompanija = (KompanijeIB230XXX)cmbKompanija.SelectedItem;
            var noviStatus = (StatusIB230XXX)cmbStatusZahtjeva.SelectedItem;

            var svePrakse = _studentPraksaServis.getAllStudentiPrakse();


            if (!Helpers.Validator.ValidanUnos(cmbStudent, err, "Obavezan unos") ||
                !Helpers.Validator.ValidanUnos(cmbKompanija, err, "Obavezan unos") ||
                !Helpers.Validator.ValidanUnos(cmbStatusZahtjeva, err, "Obavezan unos"))
            {
                return false;
            }

            var brojPrihvacenih = svePrakse.Count(x =>
                x.KompanijaId == kompanija.Id &&
                x.Status.Naziv.ToUpper() == "PRIHVACENA" &&
                (_praksa == null || x.Id != _praksa.Id));

            if (noviStatus.Naziv.ToUpper() == "PRIHVACENA" && brojPrihvacenih >= kompanija.MaksimalanBrojStudenata)
            {
                MessageBox.Show("Novi zahtjevi se mogu prihvatiti tek nakon što se za nekog od studenata koji su trenutno prihvaćeni promijeni status u REALIZOVANA.");
                return false;
            }

            var duplikat = svePrakse.Any(x =>
                x.StudentId == studentId &&
                x.KompanijaId == kompanija.Id &&
                (_praksa == null || x.Id != _praksa.Id));

            if (duplikat)
            {
                MessageBox.Show("Ovaj student već ima zahtjev prema odabranoj kompaniji!");
                return false;
            }

            var vecPrihvacena = svePrakse.Any(x =>
                x.StudentId == studentId &&
                x.Status.Naziv.ToUpper() == "PRIHVACENA" &&
                (_praksa == null || x.Id != _praksa.Id));

            if (noviStatus.Naziv.ToUpper() == "PRIHVACENA" && vecPrihvacena)
            {
                MessageBox.Show("Student već ima jednu prihvaćenu praksu!");
                return false;
            }

            var imaAktivnuPraksuUToku = svePrakse.Any(x =>
                x.StudentId == studentId &&
                (x.Status.Naziv.ToUpper() == "PODNESENA" || x.Status.Naziv.ToUpper() == "PRIHVACENA"));

            if (_praksa == null && imaAktivnuPraksuUToku)
            {
                MessageBox.Show("Student ne može kreirati novi zahtjev sve dok trenutna praksa ne bude odobrena i realizovana (ili odbijena)!");
                return false;
            }
            return true;
        }

        private void btnGenerisiZahtjeve_Click(object sender, EventArgs e)
        {
            if (cmbStudent.SelectedValue == null)
            {
                MessageBox.Show("Molimo odaberite studenta!");
                return;
            }

            var odabraniStudent = (Student)cmbStudent.SelectedItem;
            Task.Run(() =>
            {
                var svePrakse = _studentPraksaServis.getAllStudentiPrakse();
                var sveKompanije = _kompanijeServis.GetAll();

                var kompanijeGdeJeAplicirao = svePrakse
                    .Where(x => x.StudentId == odabraniStudent.Id)
                    .Select(x => x.KompanijaId)
                    .ToList();

                var kompanijeZaAplicirati = sveKompanije
                    .Where(k => !kompanijeGdeJeAplicirao.Contains(k.Id))
                    .ToList();

                var statusi = _statusServis.GetAll();
                var podnesenaStatusId = statusi.FirstOrDefault(x => x.Naziv.ToUpper() == "PODNESENA")?.Id ?? 1;

                int brojac = 1;

                foreach (var kompanija in kompanijeZaAplicirati)
                {

                    var noviZahtjev = new StudentiPraksaIB230XXX
                    {
                        StudentId = odabraniStudent.Id,
                        KompanijaId = kompanija.Id,
                        DatumPrijave = DateTime.Now,
                        StatusId = podnesenaStatusId,
                        DatumPromjeneStatusa = null
                    };

                    _studentPraksaServis.Add(noviZahtjev);

                    string infoPoruka = $"{brojac} -> {DateTime.Now:dd.MM.yyyy} kreiran zahtjev za praksu - {odabraniStudent.StudentInfo} u kompaniji {kompanija.Naziv}{Environment.NewLine}";

                    txtGeneratorInfo.BeginInvoke(new Action(() =>
                    {
                        txtGeneratorInfo.AppendText(infoPoruka);
                    }));

                    brojac++;
                    Thread.Sleep(300);
                }

                this.BeginInvoke(new Action(() =>
                {
                    MessageBox.Show("Dodavanje podataka završeno!");
                    DialogResult = DialogResult.OK;
                }));
            });
        }
    }
}
