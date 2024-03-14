using EnityLayer;
using PatientHanteringWPFF.Core;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientHanteringWPF.MVVM.MVVM.ViewModels
{
    public class NurseScheduleViewModel : ObservableObject
    {
        
        ManageVisitController manageVisitController= new ManageVisitController();
        ValidationController validationController = new ValidationController();
        public User ActiveUser { get; private set; }
        public NurseScheduleViewModel(User user)
        {
            ShedueleItem = new ObservableCollection<object>();
            DoctorAppointments = new ObservableCollection<DoctorAppointment>();
            ActiveUser = user;
            LoadData();
        }

        #region GetDoctorAppointment
        private ObservableCollection<DoctorAppointment> doctorAppointments= null;
        public ObservableCollection<DoctorAppointment> DoctorAppointments
        {
            get { return doctorAppointments; }
            set
            {
                doctorAppointments = value;
                OnPropertyChanged(nameof(DoctorAppointments));
            }
        }
        #endregion



        #region ShedueleItem
        private ObservableCollection<object> schedueleItem = null;
        public ObservableCollection<object> ShedueleItem
        {
            get { return schedueleItem; }
            set
            {
                schedueleItem = value;
                OnPropertyChanged(nameof(ShedueleItem));
            }
        }
        private NursingStaff loggedInStaff;
        public NursingStaff LoggedInStaff
        {
            get { return loggedInStaff; }
            set
            {
                loggedInStaff = value;
                
                OnPropertyChanged(nameof(LoggedInStaff));
            }
        }
        public string FnameAndEname { get; private set; }

        public void LoadData()
        {
            DoctorAppointments.Clear();
            DoctorAppointments = new (manageVisitController.GetUserSpecificVisits(ActiveUser));

            LoggedInStaff = validationController.GetNursingstaff(ActiveUser);
            FnameAndEname = ($"{LoggedInStaff.FName} {LoggedInStaff.EName}");

        }

        #endregion
    }
}
