using Microsoft.EntityFrameworkCore;
using PatienthanteringELNy;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace PatienthanteringDLNy
{
    public class PatientMSContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=sqlutb2.hb.se,56077;initial catalog=oosu2413;user id=oosu2413;password=GWL374; MultipleActiveResultSets=true;");
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Patienthantering;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<DoctorAppointment> DoctorAppointments { get; set; }
        public DbSet<DrugPrescription> DrugPrescriptions { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<NursingStaff> NursingStaffs { get; set; }
        public PatientMSContext() { }       
    }
}