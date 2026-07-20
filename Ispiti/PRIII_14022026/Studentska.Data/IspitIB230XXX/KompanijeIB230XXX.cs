using Studentska.Data.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Data.IspitIB230XXX
{
    public class KompanijeIB230XXX
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int GradId { get; set; }
        public Grad Grad { get; set; }
        public string Adresa { get; set; }
        public string Url { get; set; }
        public byte[] Slika { get; set; }
        public int MaksimalanBrojStudenata { get; set; }
        public bool Aktivna { get; set; }
    }
}
