using Studentska.Data.IspitIB230XXX;
using Studentska.Servis.Servisi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.IspitIB230XXX
{
    public class ProjektiIB230XXXServis : BaseServis<ProjektiIB230XXX>
    {
        public List<ProjektiIB230XXX> GetAktivniProjekti()
        {
            return _dbContext.ProjektiIB230XXX.Where(x => x.Aktivan).ToList();
        }
    }
}
