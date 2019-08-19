using insurance_policy.Api.Infrastructure.Tables;
using Microsoft.EntityFrameworkCore;
using System;

namespace insurance_policy.Api.Infrastructure.Data
{
    public class InsuranceContext: DbContext
    {
        public DbSet<Assigment> Assigment { get; set; }
        


        public string Connection { get; set; }
        public InsuranceContext(string sqlConnectionString)
        {
            Connection = sqlConnectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connection,
               sqlServerOptionsAction: sqlOptions =>
               {
                   sqlOptions.EnableRetryOnFailure(
                   maxRetryCount: 5,
                   maxRetryDelay: TimeSpan.FromSeconds(20),
                   errorNumbersToAdd: null);
               });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assigment>()
            .HasKey(x => x.Id);
        }
    }
}
