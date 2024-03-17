using EnityLayer;
using PatientHanteringWPFF.Core;
using ServiceLayer;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace PatientHanteringWPFF.MVVM.ViewModels
{
    public class AddPatientViewModel : INotifyPropertyChanged
    {
        private GetListsController getListsController = new GetListsController();
        private RegisterPatientController registerPatientController = new RegisterPatientController();

        private ObservableCollection<Patient> patients;
        public ObservableCollection<Patient> Patients
        {
            get { return patients; }
            set
            {
                patients = value;
                OnPropertyChanged(nameof(Patients));
            }
        }

        private string ssn;
        public string SSN
        {
            get => ssn;
            set { ssn = value; OnPropertyChanged(nameof(SSN)); }
        }

        private string fname;
        public string FName
        {
            get => fname;
            set { fname = value; OnPropertyChanged(nameof(FName)); }
        }

        private string ename;
        public string EName
        {
            get => ename;
            set { ename = value; OnPropertyChanged(nameof(EName)); }
        }

        private string email;
        public string Email
        {
            get => email;
            set { email = value; OnPropertyChanged(nameof(Email)); }
        }

        private string patientNr;
        public string PatientNr
        {
            get => patientNr;
            set { patientNr = value; OnPropertyChanged(nameof(PatientNr)); }
        }

        private string adress;
        public string Address
        {
            get => adress;
            set { adress = value; OnPropertyChanged(nameof(Address)); }
        }

        private string telNr;
        public string TelNr
        {
            get => telNr;
            set { telNr = value; OnPropertyChanged(nameof(TelNr)); }
        }

        public ICommand AddPatientCommand { get; private set; }

        public AddPatientViewModel()
        {
            Patients = new ObservableCollection<Patient>(getListsController.GetPatients());
            AddPatientCommand = new RelayCommand(param => AddPatient());
        }

        private void AddPatient()
        {
            if (string.IsNullOrEmpty(SSN) || string.IsNullOrEmpty(FName) || string.IsNullOrEmpty(EName) ||
                string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(PatientNr) || string.IsNullOrEmpty(Address) ||
            string.IsNullOrEmpty(TelNr))
            {
                MessageBox.Show("Enter all the attributes");
            }
            else
            {
                var existingPatient = registerPatientController.GetPatient(PatientNr);
                if (existingPatient != null)
                {
                    MessageBox.Show("Patient number already taken");
                }
                else
                {
                    try
                    {
                        registerPatientController.RegisterPatient(SSN, FName, EName, Email, PatientNr, Address, TelNr);
                        MessageBox.Show("Patient Created");
                        RefreshList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while registering the patient: {ex.Message}");
                    }
                }
            }

        }
        private void RefreshList()
        {
            Patients.Clear();
            Patients = new ObservableCollection<Patient>(getListsController.GetPatients());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
