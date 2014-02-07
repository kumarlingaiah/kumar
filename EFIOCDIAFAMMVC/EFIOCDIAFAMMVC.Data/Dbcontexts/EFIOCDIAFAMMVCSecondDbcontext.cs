using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFIOCDIAFAMMVC.Model;

namespace EFIOCDIAFAMMVC.Data.Dbcontexts
{
    public class EFIOCDIAFAMMVCSecondDbcontext : DbContext
    {
        public EFIOCDIAFAMMVCSecondDbcontext()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<EFIOCDIAFAMMVCSecondDbcontext>());
        }

        public DbSet<Employee> employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
