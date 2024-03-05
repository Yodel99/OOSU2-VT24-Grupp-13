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
    public class EditPatientViewModel : ObservableObject
    {
        private GetListsController getListsController;

        private List<Patient> patients = null;
        public List<Patient> Patients
        {
            get => patients;
            set { patients = (List<Patient>)getListsController.GetPatients(); }

        }

        //(ObservableCollection<Patient>) getListsController.GetPatients();
        public EditPatientViewModel()
        {
            getListsController = new GetListsController();
            Patients = new List<Patient>();
        }



        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }
}
