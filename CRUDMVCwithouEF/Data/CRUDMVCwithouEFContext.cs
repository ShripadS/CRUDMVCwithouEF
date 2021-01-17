using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDMVCwithouEF.Models;

namespace CRUDMVCwithouEF.Data
{
    public class CRUDMVCwithouEFContext : DbContext
    {
        public CRUDMVCwithouEFContext (DbContextOptions<CRUDMVCwithouEFContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDMVCwithouEF.Models.BookViewModel> BookViewModel { get; set; }
    }
}
