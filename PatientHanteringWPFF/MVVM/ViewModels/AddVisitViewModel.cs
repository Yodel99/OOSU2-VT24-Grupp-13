using EnityLayer;
using PatientHanteringWPFF.Core;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientHanteringWPFF.MVVM.ViewModels
{
    internal class AddVisitViewModel:ObservableObject
    {
        GetListsController getListsController;

        private List<Patient> patients = null;
        private List<NursingStaff> nurses = null;
        public List<Patient> Patients
        {
            get => patients;
            set { patients = (List<Patient>)getListsController.GetPatients(); }

        }
        public List<NursingStaff> Nurses
        {
            get => nurses;
            set { nurses = (List<NursingStaff>)getListsController.GetNursingStaffs(); }
        }
        public AddVisitViewModel()
        {
            getListsController = new GetListsController();
            Patients = new List<Patient>();
            Nurses = new List<NursingStaff>();
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
