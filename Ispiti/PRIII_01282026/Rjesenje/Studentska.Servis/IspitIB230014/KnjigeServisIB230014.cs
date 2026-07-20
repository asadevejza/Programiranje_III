using Studentska.Data.IspitIB230014;
using Microsoft.EntityFrameworkCore;
using Studentska.Servis.Servisi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Studentska.Servis.IspitIB230014
{
    public class KnjigeServisIB230014 : BaseServis<KnjigeIB230014>
    {
        public List<KnjigeIB230014> GetAll()
        {
            return _dbContext.KnjigeIB230014.AsNoTracking().ToList();
        }
    }
}
