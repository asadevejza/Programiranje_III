using Studentska.Data.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Data.IspitIB230014
{
    public class StudentiKnjigeIB230014
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int KnjigaId { get; set; }
        public DateTime DatumIznajmljivanja { get; set; }
        public DateTime? DatumVracanja { get; set; }
        public Student Student { get; set; }
        public KnjigeIB230014 Knjiga { get; set; }
     
    }
}
