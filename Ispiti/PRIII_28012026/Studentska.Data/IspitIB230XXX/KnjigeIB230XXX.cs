using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Data.IspitIB230XXX
{
    public class KnjigeIB230XXX
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Autor { get; set; }
        public int BrojPrimjeraka { get; set; }
        public byte[] Slika { get; set; }
        public bool Status { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
        public string KnjigaInfo => $"{Naziv} ({Autor})";
    }
}
