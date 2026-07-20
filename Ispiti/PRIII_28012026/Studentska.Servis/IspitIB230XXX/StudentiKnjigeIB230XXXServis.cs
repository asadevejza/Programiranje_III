using Microsoft.EntityFrameworkCore;
using Studentska.Data.Entiteti;
using Studentska.Data.IspitIB230XXX;
using Studentska.Servis.Servisi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.IspitIB230XXX
{
    public class StudentiKnjigeIB230XXXServis : BaseServis<StudentiKnjigeIB230XXX>
    {
        public List<StudentiKnjigeIB230XXX> getAllStudentiKnjige()
        {
            return _dbContext.StudentiKnjigeIB230XXX.AsNoTracking().Include(x => x.Student).Include(x => x.Knjiga).ToList();
        }

        public List<StudentiKnjigeIB230XXX> getFiltriranePodatke(string text, bool @checked)
        {
            var podaci = getAllStudentiKnjige();
            if (!string.IsNullOrWhiteSpace(text))
            {
                text = text.ToLower();
                podaci = podaci
                    .Where(s => (s.Student.Ime + " " + s.Student.Prezime).ToLower().Contains(text)
                             || s.Knjiga.Naziv.ToLower().Contains(text))
                    .ToList();
            }
            if (@checked)
            {
                podaci = podaci.Where(s => s.DatumVracanja.HasValue).ToList();
            }
            else
            {
                podaci = podaci.Where(s => s.DatumVracanja == null).ToList();
            }

            return podaci;
        }

        public List<StudentiKnjigeIB230XXX> getFiltriranePodatke(int? studentId, int? knjigaId)
        {
            var podaci = getAllStudentiKnjige();

            if (studentId.HasValue)
                podaci = podaci.Where(s => s.StudentId == studentId.Value).ToList();

            if (knjigaId.HasValue)
                podaci = podaci.Where(s => s.KnjigaId == knjigaId.Value).ToList();

            return podaci;
        }

        public List<KnjigeIB230XXX> GetKnjigeKojeStudentNijeIznajmljivao(int studentId)
        {
            var iznajmljeneId = _dbContext.StudentiKnjigeIB230XXX
                .Where(x => x.StudentId == studentId)
                .Select(x => x.KnjigaId)
                .ToList();

            return _dbContext.KnjigeIB230XXX
                .Where(x => !iznajmljeneId.Contains(x.Id))
                .ToList();
        }

        public void OznaciKnjiguVracenom(int studentKnjigaId)
        {
            var zapis = _dbContext.StudentiKnjigeIB230XXX.FirstOrDefault(s=>s.Id== studentKnjigaId);

            if (zapis == null)
                throw new Exception("Zapis nije pronađen.");

            if (zapis.DatumVracanja.HasValue)
                throw new Exception("Ova knjiga je već vraćena.");

            zapis.DatumVracanja = DateTime.Now;
            _dbContext.SaveChanges();
        }
    }
}
