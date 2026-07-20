using Microsoft.EntityFrameworkCore;
using Studentska.Data.IspitIB230XXX;
using Studentska.Servis.Servisi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.IspitIB230XXX
{
    public class StudentiProjektiIB230XXXServis : BaseServis<StudentiProjektiIB230XXX>
    {

        public List<StudentiProjektiIB230XXX> getAllStudentiProjekti()
        {
            return _dbContext.StudentiProjektiIB230XXX.AsNoTracking().Include(x => x.Student).Include(x => x.Status).Include(x => x.Projekti).ToList();
        }

        public List<StudentiProjektiIB230XXX> getFiltriranePodatke(string text, int selectedIndexStatus,int selectedIndexStanje)
        {
            var podaci = getAllStudentiProjekti();

            if (!string.IsNullOrWhiteSpace(text))
            {
                text = text.ToLower();
                podaci = podaci.Where(x =>
                    (x.Student.Ime + ' ' + x.Student.Prezime).ToLower().Contains(text) ||
                    (x.Projekti.NazivProjekta).ToLower().Contains(text)).ToList();
            }

            if (selectedIndexStatus != 0)
            {
                podaci = podaci.Where(x => x.StatusId == selectedIndexStatus).ToList();
            }
            if(selectedIndexStanje==1)
            {
                podaci = podaci.Where(x => !x.Arhivirana).ToList();
            }
            else if(selectedIndexStanje==2)
            {
                podaci = podaci.Where(x => x.Arhivirana).ToList();
            }
            return podaci;
        }
        public void ArhivirajZapis(int prijavaId)
        {
            var prijava = _dbContext.StudentiProjektiIB230XXX.Find(prijavaId);

            if (prijava != null)
            {
                if (prijava.Arhivirana)
                {
                    throw new Exception("Prijava je već arhivirana!");
                }
                prijava.Arhivirana = true;
                Update(prijava); // ili Update(prijava) zavisno od tvoje BaseServis metode
            }
            else
            {
                throw new Exception("Prijava nije pronađena!");
            }
        }
    }
}
