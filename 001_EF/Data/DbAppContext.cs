using _001_EF.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace _001_EF.Data
{
    internal class DbAppContext: DbContext
    {
        public DbSet<User> Users { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = ".",
                InitialCatalog = "EF",
                IntegratedSecurity = true,
                TrustServerCertificate = true,
            };
            
            optionsBuilder.UseSqlServer(builder.ConnectionString); //("server=.;database=TestDB;Trusted_Connection=True;");



        }
    }
}
