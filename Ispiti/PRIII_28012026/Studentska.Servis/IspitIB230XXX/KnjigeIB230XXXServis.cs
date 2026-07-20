using Microsoft.EntityFrameworkCore;
using Studentska.Data.IspitIB230XXX;
using Studentska.Servis.Servisi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.IspitIB230XXX
{
    public class KnjigeIB230XXXServis : BaseServis<KnjigeIB230XXX>
    {
        public List<KnjigeIB230XXX> GetAllKnjige()
        {
            return _dbContext.KnjigeIB230XXX.AsNoTracking().ToList();
        } 
    }
}
