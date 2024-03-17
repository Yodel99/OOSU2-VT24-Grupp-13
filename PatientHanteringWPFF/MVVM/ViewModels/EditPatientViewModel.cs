using DataLayer;
using EnityLayer;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using PatientHanteringWPFF.Core;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PatientHanteringWPFF.MVVM.ViewModels
{
    public class EditPatientViewModel : ObservableObject
    {
        private GetListsController getListsController;
        private UpdatePatientController updatePatientController;
        private Patient chosenPatientNr;
        public Patient ChosenPatient
        {
            get { return chosenPatientNr; }
            set
            {
                chosenPatientNr = value;
                OnPropertyChanged(nameof(ChosenPatient));
            }
        }
        
        public EditPatientViewModel()
        {
            getListsController = new GetListsController();
            updatePatientController = new UpdatePatientController();   
            Patients = new ObservableCollection<Patient>(getListsController.GetPatients());
            SaveCommand = new RelayCommand(param => SaveInput());
        }

        private string selectedAttribute;
        public string SelectedAttribute
        {
            get { return selectedAttribute; }
            set
            {
                selectedAttribute = value;
                OnPropertyChanged(nameof(SelectedAttribute));
            }
        }



        private string chosenInput;
        public string ChosenInput
        {
            get { return chosenInput; }
            set
            {
                chosenInput = value;
                OnPropertyChanged(nameof(ChosenInput));
            }
        }
        
        
        



        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

 

   

        private ObservableCollection<Patient> patients = null;
        public ObservableCollection<Patient> Patients
        {
            get { return patients; }
            set
            {
                patients = value;
                OnPropertyChanged(nameof(Patients));
            }

        }

        #region SaveCommand
        public ICommand SaveCommand { get; private set; }
  
        private void SaveInput()
        {
            Patient patient = ChosenPatient;
            updatePatientController.UpdatePatientInfo(patient.PatientNr, SelectedAttribute, ChosenInput);
            
            
            MessageBox.Show($"Patient: {patient.PatientNr} {SelectedAttribute} has been succesfully updated with your chosen input: {ChosenInput}");
        }
        #endregion
    }
}
