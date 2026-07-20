using Studentska.Data.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Data.IspitIB230XXX
{
    public class StudentiProjektiIB230XXX
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int ProjektiId { get; set; }
        public ProjektiIB230XXX Projekti { get; set; }
        public DateTime DatumPrijave { get; set; }
        public int StatusId { get; set; }
        public StatusIB230XXX Status { get; set; }
        public DateTime? DatumPromjeneStatusa { get; set; }
        public bool Arhivirana { get; set; }
    }
}
