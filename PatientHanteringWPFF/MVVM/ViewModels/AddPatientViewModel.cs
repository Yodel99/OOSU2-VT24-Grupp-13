using EnityLayer;
using PatientHanteringWPFF.Core;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PatientHanteringWPFF.MVVM.ViewModels
{
    public class AddPatientViewModel : ObservableObject
    {
        // ListBox
        private GetListsController getListsController = new GetListsController();

        private ObservableCollection<Patient> patients = null;
        RegisterPatientController RP = new RegisterPatientController();

        public ObservableCollection<Patient> Patients
        {
            get { return patients; }
            set 
            { 
                patients = value;
                OnPropertyChanged(nameof(Patients));
            }
        }



        //public AddPatientViewModel()
        //{
        //    getListsController = new GetListsController();
        //    Patients = new List<Patient>();
        //}

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        // Textboxes och labels
        private ObservableCollection<Patient> patientss = new ObservableCollection<Patient>();
       
        public ObservableCollection<Patient> Patientss
        {
            get => patientss;
            set { patientss = value; OnPropertyChanged(); }

        }
       

        private string ssn;
        public string SSN
        {
            get => ssn;
            set { ssn = value; OnPropertyChanged(); }
        }

        private string fName;
        public string Fname
        {
            get => fName;
            set { fName = value; OnPropertyChanged(); }
        }

        private string eName;
        public string Ename
        {
            get => eName;
            set { eName = value; OnPropertyChanged(); }
        }

        private string eMail;
        public string Email
        {
            get => eMail;
            set { eMail = value; OnPropertyChanged(); }
        }

        private string patientNr;
        public string PatientNr
        {
            get => patientNr;
            set { patientNr = value; OnPropertyChanged(); }
        }

        private string adress;
        public string Adress
        {
            get => adress;
            set { adress = value; OnPropertyChanged(); }
        }

        private string telNr;
        public string TelNr
        {
            get => telNr;
            set { telNr = value; OnPropertyChanged(); }
        }


        // Add kanpp

        //public ObservableCollection<Patient> Patients_
        //{
        //    get { return Patients; }
        //    set
        //    {
        //        if (Patients != value )
        //        {
        //            Patients = value;
        //            OnPropertyChanged(nameof(Patients));
        //        }
        //    }
        //}

        public void AddPatient()
        {
            if (PatientNr == null || SSN == null || Fname == null || Ename == null || Email == null || Adress == null || TelNr == null)
            {
                MessageBox.Show("Enter all the attributes");
            }
            else
            {
                RP.RegisterPatient(SSN, Fname, Ename, Email, PatientNr, Adress, TelNr);
            }
            
           
        }


      
        public ICommand AddPatientCommand { get; private set; }
        public AddPatientViewModel()
        {
            
            Patients = new ObservableCollection<Patient>(getListsController.GetPatients());
            AddPatientCommand = new RelayCommand(param => AddPatient());
        }



    }
}
