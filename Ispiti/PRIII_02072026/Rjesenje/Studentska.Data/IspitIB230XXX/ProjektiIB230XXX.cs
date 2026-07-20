using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Data.IspitIB230XXX
{
    public class ProjektiIB230XXX
    {
        public int Id { get; set; }
        public string NazivProjekta { get; set; }
        public byte[] SlikaProjekta { get; set; }
        public DateTime RokZavrsetka { get; set; }
        public int MaksimalanBrojStudenata { get; set; }
        public bool Aktivan { get; set; }
        public string Napomena { get; set; }
        public override string ToString()
        {
            return NazivProjekta;
        }
    }
}
