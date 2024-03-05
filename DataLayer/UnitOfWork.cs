using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using EnityLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UnitOfWork
    {
        private bool isDisposed = false;
        private readonly bool disposeContext = false;
        PatientMSContext PatientMSContext { get; }
       
        public UserRepository UserRepository
        {
            get; private set;
        }

        public DrugPrescriptionRepository DrugPrescriptionRepository
        {
            get; private set;
        }
        public DiagnosisRepository DiagnosisRepository
        {
            get; private set;
        }
        public DoctorAppointmentRepository DoctorAppointmentRepository
        { get; private set; }
        public PersonRepository PersonRepository
        {
            get; private set;
        }
        public NursingStaffRepository NursingStaffRepository
        {
            get; private set;
        }
        public PatientRepository PatientRepository
        {
            get; private set;
        }

        

        public UnitOfWork()
      : this(new PatientMSContext())
        {
            disposeContext = true;
        }

        public UnitOfWork(PatientMSContext context)
        {
            PatientMSContext = context;
            UserRepository = new UserRepository(context);
            DrugPrescriptionRepository = new DrugPrescriptionRepository(context);
            DiagnosisRepository = new DiagnosisRepository(context);
            DoctorAppointmentRepository = new DoctorAppointmentRepository(context);
            PersonRepository = new PersonRepository(context);
            NursingStaffRepository = new NursingStaffRepository(context);
            PatientRepository = new PatientRepository(context);
        }

        /// <summary>
        ///  Save the changes made. Does nothing in this case.
        /// </summary>
        //public void Save()
        //{ }
      
        public int SaveChanges()
        {
            try
            {
                return PatientMSContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            catch (RetryLimitExceededException ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            catch (DbUpdateException ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }


    }
}

//private static UnitOfWork instans = null;
//public static UnitOfWork GetInstance()
//{
//    if (instans == null)
//    {
//        instans = new UnitOfWork();
//    }
//    return instans;
//}

/// <summary>
///  Create a new instance.
/// </summary>
//public UnitOfWork()
//{
//    UserRepository = new Repository<User>();
//    DrugPrescriptionRepository = new Repository<DrugPrescription>();
//    DiagnosRepository = new Repository<Diagnos>();
//    DoctorAppointmentRepository = new Repository<DoctorAppointment>();
//    PersonRepository = new Repository<Person>();
//    VardPersonalRepository = new Repository<NursingStaff>();
//    PatientRepository = new Repository<Patient>();

//    // Initialize the tables if this is the first UnitOfWork.
//    if (UserRepository.IsEmpty())
//    {
//        Fill();
//    }
//}