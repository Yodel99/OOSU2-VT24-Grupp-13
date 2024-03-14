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
        public Patient ChosenPatientNr
        {
            get { return chosenPatientNr; }
            set
            {
                chosenPatientNr = value;
                OnPropertyChanged(nameof(ChosenPatientNr));
            }
        }
        
        public EditPatientViewModel()
        {
            getListsController = new GetListsController();
            updatePatientController = new UpdatePatientController();   
            Patients = new ObservableCollection<Patient>(getListsController.GetPatients());
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

        public RelayCommand RefreshCommand => new RelayCommand(_execute => RefreshData());

        private void RefreshData()
        {
            //Patients.Clear();
            //foreach (Patient patient in getListsController.GetPatients())
            //{
            //    Patients.Add(patient);
            //}
            Patients.Clear();
            Patients = new ObservableCollection<Patient>(getListsController.GetPatients());
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
        public RelayCommand SaveCommand => new RelayCommand(_execute => SaveInput(ChosenPatientNr.PatientNr, SelectedAttribute, ChosenInput));
        private void SaveInput(string chosenPatientNr, string chosenAttribute, string chosenInput)
        {
            Patient patient = new Patient();
            patient.PatientNr = chosenPatientNr;
            updatePatientController.UpdatePatientInfo(chosenPatientNr, chosenAttribute, chosenInput);
            
            RefreshData();
            
            MessageBox.Show($"Patient: {patient.PatientNr} {chosenAttribute} has been succesfully updated with your chosen input: {ChosenInput}");
        }
        #endregion
    }
}
