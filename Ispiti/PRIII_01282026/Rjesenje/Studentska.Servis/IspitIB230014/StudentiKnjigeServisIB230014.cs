using Microsoft.EntityFrameworkCore;
using Studentska.Data.Entiteti;
using Studentska.Data.IspitIB230014;
using Studentska.Servis.Servisi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Studentska.Servis.IspitIB230014
{
    public class StudentiKnjigeServisIB230014 : BaseServis<StudentiKnjigeIB230014>
    {
        public List<StudentiKnjigeIB230014> GetAllStudents()
        {
            return _dbContext.StudentiKnjigeIB230014
                .AsNoTracking()
                .Include(x => x.Student)
                .Include(x => x.Knjiga)
                .ToList();
        }

        public List<StudentiKnjigeIB230014> PretraziStudente(string trazeni, bool samoVracene)
        {
            var studenti = GetAllStudents();

            if (!string.IsNullOrWhiteSpace(trazeni))
            {
                trazeni = trazeni.ToLower();
                studenti = studenti
                    .Where(s => (s.Student.Ime + " " + s.Student.Prezime).ToLower().Contains(trazeni)
                             || s.Knjiga.Naziv.ToLower().Contains(trazeni))
                    .ToList();
            }

            if (samoVracene)
            {
                studenti = studenti.Where(s => s.DatumVracanja.HasValue).ToList();
            }
            else
            {
                studenti = studenti.Where(s => s.DatumVracanja==null).ToList();
            }

                return studenti;
        }

        public void OznaciKnjiguVracenom(int studentKnjigaId)
        {
            var zapis = _dbContext.StudentiKnjigeIB230014.FirstOrDefault(s => s.Id == studentKnjigaId);

            if (zapis == null)
                throw new Exception("Zapis nije pronađen.");

            if (zapis.DatumVracanja.HasValue)
                throw new Exception("Ova knjiga je već vraćena.");

            zapis.DatumVracanja = DateTime.Now;
            _dbContext.SaveChanges();
        }
        public List<StudentiKnjigeIB230014> GetAllWithDetails()
        {
            return _dbContext.StudentiKnjigeIB230014
                .Include(x => x.Student)
                .Include(x => x.Knjiga)
                .ToList();
        }
        public void IznajmiKnjigu(StudentiKnjigeIB230014 novoIznajmljivanje)
        {
            var vecIznajmio = _dbContext.StudentiKnjigeIB230014
                .Any(x => x.StudentId == novoIznajmljivanje.StudentId &&
                          x.KnjigaId == novoIznajmljivanje.KnjigaId &&
                          x.DatumVracanja == null);

            if (vecIznajmio)
                throw new Exception("Student već posjeduje ovu knjigu i nije je vratio!");

            var knjiga = _dbContext.KnjigeIB230014.Find(novoIznajmljivanje.KnjigaId);
            var brojIznajmljenih = _dbContext.StudentiKnjigeIB230014
                .Count(x => x.KnjigaId == novoIznajmljivanje.KnjigaId && x.DatumVracanja == null);

            if (brojIznajmljenih >= knjiga.BrojPrimjeraka)
                throw new Exception("Nema dostupnih primjeraka ove knjige na stanju!");

            _dbContext.StudentiKnjigeIB230014.Add(novoIznajmljivanje);
            _dbContext.SaveChanges();
        }
        public List<KnjigeIB230014> GetKnjigeKojeStudentNijeIznajmljivao(int studentId)
        {
            var iznajmljeneId = _dbContext.StudentiKnjigeIB230014
                .Where(x => x.StudentId == studentId)
                .Select(x => x.KnjigaId)
                .ToList();

            return _dbContext.KnjigeIB230014
                .Where(x => !iznajmljeneId.Contains(x.Id))
                .ToList();
        }
        
    }
}

