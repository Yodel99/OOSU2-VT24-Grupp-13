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

namespace PatientHanteringWPFF.MVVM.ViewModels
{
    internal class AddPrescriptionViewModel : ObservableObject
    {
        private GetListsController getListsController;
        private PrescribePrescriptionController prescribePrescriptionController;

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
        private string drugName;
        public string DrugName
        {
            get { return drugName; }
            set { drugName = value; OnPropertyChanged(nameof(DrugName)); }
        }

        private string dosage;
        public string Dosage
        {
            get { return dosage; }
            set { dosage = value; OnPropertyChanged(nameof(Dosage)); }
        }

        private string reason;
        public string Reason
        {
            get { return reason; }
            set { reason = value; OnPropertyChanged(nameof(Reason)); }
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

        public ICommand CreatePrescriptionCommand { get; private set; }

        public AddPrescriptionViewModel()
        {
            getListsController = new GetListsController();
            prescribePrescriptionController = new PrescribePrescriptionController();
            Patients = new ObservableCollection<Patient>(getListsController.GetPatients());
            CreatePrescriptionCommand = new RelayCommand(param => CreatePrescription());
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

        private void CreatePrescription()
        {
            if (PatientSelectedItem != null && DrugName != null && Dosage != null && Reason != null)
            {
                if (Prescriptions.Count > 0)
                {
                    MessageBoxResult result = MessageBox.Show("This patient already has an active prescription. Do you want to continue?", "Warning", MessageBoxButton.OKCancel);
                    if (result == MessageBoxResult.Cancel)
                    {
                        return; // Avbryt metoden om användaren klickar på "Cancel"
                    }
                }

                prescribePrescriptionController.PrescripePrescription(PatientSelectedItem, DrugName, Dosage, Reason);
                UpdatePrescriptions();
            }
            else
            {
                MessageBox.Show("Please fill in every field");
                return; // Avbryt metoden om något av fälten inte är ifyllt
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
    }
}
