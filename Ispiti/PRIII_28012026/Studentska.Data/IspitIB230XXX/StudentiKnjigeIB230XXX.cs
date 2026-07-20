using Studentska.Data.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Data.IspitIB230XXX
{
    public class StudentiKnjigeIB230XXX
    {
        public int Id { get; set; }
        public int StudentId { get; set; } 
        public Student Student { get; set; }
        public int KnjigaId { get; set; }  
        public KnjigeIB230XXX Knjiga { get; set; }
        public DateTime DatumIznajmljivanja { get; set; }
        public DateTime? DatumVracanja { get; set; }
       
      
    }
}
