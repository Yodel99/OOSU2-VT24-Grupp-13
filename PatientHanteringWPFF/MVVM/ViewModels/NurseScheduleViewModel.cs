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
        private GetListsController getListsController;
        public NurseScheduleViewModel()
        {
            getListsController = new GetListsController();
            ShedueleItem = new ObservableCollection<object>();
            DoctorAppointments = new ObservableCollection<DoctorAppointment>();
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

        public void LoadData()
        {                    
            DoctorAppointments = new (getListsController.GetVisits());         
        }
        #endregion
    }
}
