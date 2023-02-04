using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Common;
using Npgsql;

namespace WindowsFormsApp1
{
    class TianwenContext:DbContext
    {
        public DbSet<Competitor> Competitors { get; set; }
        
        public TianwenContext(string serverIp) : base(TWContextConnection.GetConnectionString(serverIp), true) {

            System.Data.Entity.Database.SetInitializer<TianwenContext>(null);
        }

        //public TianwenContext() : base(nameOrConnectionString: "PGConnectionString") { }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }


    }

    public static class TWContextConnection
    {
        public static DbConnection GetConnectionString(string serverIp) //Accessable form everywhere
        {
            NpgsqlConnectionStringBuilder npgsqlConnectionStringBuilder = new NpgsqlConnectionStringBuilder();
            npgsqlConnectionStringBuilder.Host = serverIp;
            npgsqlConnectionStringBuilder.Port = 5432;
            npgsqlConnectionStringBuilder.Database = "tianwen";
            npgsqlConnectionStringBuilder.Username = "postgres";
            npgsqlConnectionStringBuilder.Password = "alvin";
            var conn = new NpgsqlConnectionFactory().CreateConnection(npgsqlConnectionStringBuilder.ConnectionString.ToString());
            return conn;
        }
    }


}
