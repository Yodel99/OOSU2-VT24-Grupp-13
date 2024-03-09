using EnityLayer;
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
using System.Windows.Input;

namespace PatientHanteringWPF.MVVM.MVVM.ViewModels
{
    internal class SearchPatientViewModel : ObservableObject
    {
        private GetListsController getListsController;

        private string searchTerm;
        public string SearchTerm
        {
            get { return searchTerm; }
            set
            {
                if (searchTerm != value)
                {
                    searchTerm = value;
                    FilterPatients();
                    OnPropertyChanged(nameof(SearchTerm));
                }
            }
        }
        private Patient patientSelectedItem = null!;
        public Patient PatientSelectedItem
        {
            get { return patientSelectedItem; }
            set
            {
                patientSelectedItem = value;
                OnPropertyChanged();
                UpdatePrescriptions();
                UpdateDiagnoses();
            }
        }

        private ObservableCollection<Patient> patients;
        public ObservableCollection<Patient> Patients
        {
            get { return patients; }
            set
            {
                patients = value;
                OnPropertyChanged(nameof(Patients));
                FilterPatients();
            }
        }

        private ObservableCollection<Patient> filteredPatients;
        public ObservableCollection<Patient> FilteredPatients
        {
            get { return filteredPatients; }
            set
            {
                filteredPatients = value;
                OnPropertyChanged(nameof(FilteredPatients));
            }
        }
        private ObservableCollection<DrugPrescription> prescriptions;
        public ObservableCollection<DrugPrescription> Prescriptions
        {
            get { return prescriptions; }
            set
            {
                prescriptions = value;
                OnPropertyChanged(nameof(Prescriptions));
            }
        }
        private ObservableCollection<Diagnosis> diagnoses;
        public ObservableCollection<Diagnosis> Diagnoses
        {
            get { return diagnoses; }
            set
            {
                diagnoses = value;
                OnPropertyChanged(nameof(Diagnoses));
            }
        }
        public SearchPatientViewModel()
        {
            getListsController = new GetListsController();
            Patients = new ObservableCollection<Patient>(getListsController.GetPatients());
        }
        private void FilterPatients()
        {
            if (string.IsNullOrWhiteSpace(SearchTerm))
            {
                FilteredPatients = Patients;
            }
            else
            {
                FilteredPatients = new ObservableCollection<Patient>(
                    Patients.Where(patient => patient.PatientNr.ToLower().Contains(SearchTerm.ToLower())));
            }
        }
        private void UpdatePrescriptions()
        {
            if (PatientSelectedItem != null)
            {

                Prescriptions = new ObservableCollection<DrugPrescription>(getListsController.GetPrescriptions(PatientSelectedItem));
            }
            else
            {
                Prescriptions.Clear();
            }
        }
        private void UpdateDiagnoses()
        {

            if (PatientSelectedItem != null)
            {

                Diagnoses = new ObservableCollection<Diagnosis>(getListsController.GetDiagnosis(PatientSelectedItem));
            }
            else
            {
                Diagnoses.Clear();
            }
        }
    }
}
