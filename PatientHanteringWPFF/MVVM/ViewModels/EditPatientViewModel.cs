using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using PatienthanteringELNy;
using PatienthanteringDLNy;
using PatienthanteringALNy;
using PatientHanteringWPFF.Core;
using PatientHanteringWPFF.MVVM.ViewModels;

namespace PatientHanteringWPFF.MVVM.ViewModels
{

    public class EditPatientViewModel : ObservableObject
    {
        private GetListsController getListsController;
        
        private List<Patient> patients = null;
        public List<Patient> Patients 
        {
            get => patients;
            set { patients = getListsController.GetPatients(); }

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

