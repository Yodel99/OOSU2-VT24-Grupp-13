using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using PatienthanteringEL;


namespace PatienthanteringDLef
{
    public class PatienthanteringContext : DbContext
    {
        public PatienthanteringContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<Patient> Patienter { get; set; }
        public DbSet<VardPersonal> Vårdpersonal { get; set; }
        public DbSet<Anvandare> Användare { get; set; }
        public DbSet<LakarBesok> Läkarbesök { get; set; }
        public DbSet<Lakemedelsrecept> Läkemedelsrecept { get; set; }
        public DbSet<Diagnos> Diagnoser { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=sqlutb2.hb.se,56077;Database=Patient;User ID=oosu2413;Password=GWL374;");
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Patienthantering;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }



    }
}
