using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Data.IspitIB230014
{
    public class KnjigeIB230014
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
    }
}
