using Microsoft.EntityFrameworkCore;
using PatienthanteringEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatienthanteringDLef
{
    public class PatienthanteringContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Patienthantering;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet <Anvandare> Anvandares { get; set; }
        public DbSet <Diagnos> Diagnoser { get; set; }
        public DbSet <LakarBesok> LakarBesoks { get; set; }
        public DbSet <Lakemedelsrecept> Lakemedelsrecepts { get; set; }
        public DbSet <Patient> Patienter { get; set; }
        
        public DbSet <VardPersonal> VardPersonals { get; set; }

        public PatienthanteringContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
