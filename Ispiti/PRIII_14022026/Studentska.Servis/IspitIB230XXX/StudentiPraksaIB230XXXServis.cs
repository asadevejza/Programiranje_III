using Microsoft.EntityFrameworkCore;
using Studentska.Data.IspitIB230XXX;
using Studentska.Servis.Servisi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.IspitIB230XXX
{
    public class StudentiPraksaIB230XXXServis : BaseServis<StudentiPraksaIB230XXX>
    {
        public List<StudentiPraksaIB230XXX> getAllStudentiPrakse()
        {
            return _dbContext.StudentiPraksaIB230XXX.AsNoTracking().Include(x => x.Status).Include(x => x.Student).Include(x => x.Kompanija).ThenInclude(x => x.Grad).ToList();
        }

        public List<StudentiPraksaIB230XXX> getFiltriranePodatke(string text, int selectedIndex)
        {
            var podaci = getAllStudentiPrakse();

            if (!string.IsNullOrWhiteSpace(text))
            {
                text = text.ToLower();
                podaci = podaci.Where(x =>
                    (x.Student.Ime + ' ' + x.Student.Prezime).ToLower().Contains(text) ||
                    (x.Kompanija.Naziv).ToLower().Contains(text)).ToList();
            }

            if (selectedIndex != 0)
            {
                podaci = podaci.Where(x => x.StatusId == selectedIndex).ToList();
            }

            return podaci;
        }

        public void ObisiZapis(int zapisId)
        {
            var zapis = _dbContext.StudentiPraksaIB230XXX.Find(zapisId);

            if (zapis != null)
            {
                Obrisi(zapis);
            }
            else
            {
                throw new Exception("Zapis nije pronadjen!");
            }
        }
    }
}
