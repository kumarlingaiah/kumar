using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFIOCDIAFAMMVC.Model;

namespace EFIOCDIAFAMMVC.Data.Dbcontexts
{
    public class EFIOCDIAFAMMVCDbcontext : DbContext
    {
        static EFIOCDIAFAMMVCDbcontext()
        {
            Database.SetInitializer<EFIOCDIAFAMMVCDbcontext>(null);
        }

        public DbSet<Employee> employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
