using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApp1
{
    class TianwenContext:DbContext
    {
        public DbSet<Competitor> Competitors { get; set; }
        
        public TianwenContext() : base(nameOrConnectionString: "PGConnectionString") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }


    }
}
