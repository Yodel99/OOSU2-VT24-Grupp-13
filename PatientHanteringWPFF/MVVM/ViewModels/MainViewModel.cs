using PatientHanteringWPFF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientHanteringWPFF.MVVM.ViewModels
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; } 
        public RelayCommand AddVisitViewCommand { get; set; }
        public RelayCommand EditVisitViewCommand { get; set; }
        public RelayCommand ManageVisitViewCommand { get; set; }
        public RelayCommand AddPatientViewCommand { get; set; }
        public RelayCommand EditPatientViewCommand { get; set; }
        public RelayCommand AddPrescriptionViewCommand { get; set; }
        public RelayCommand PrescribeMedicineViewCommand { get; set; }
        public RelayCommand AddDiagnosisViewCommand { get; set; }



        public HomeViewModel HomeVm { get; set; }
        public AddVisitViewModel AddVisitVm { get; set; }
        public EditVisitViewModel EditVisitVm { get; set; }
        public ManageVisitViewModel ManageVisitVm { get; set; }
        public AddPatientViewModel AddPatientVm { get; set; }
        public EditPatientViewModel EditPatientVm { get; set; }
        public AddPrescriptionViewModel AddPrescriptionVm { get;set; }
        public PrescribeMedicineViewModel PrecribeMedicineVm { get; set; }
        public AddDiagnosisViewModel AddDiagnosisVm { get; set; }

        private object _currentView;

        public object CurrentVeiw
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }

        }

        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            AddVisitVm = new AddVisitViewModel();
            EditVisitVm = new EditVisitViewModel();
            ManageVisitVm = new ManageVisitViewModel();
            AddPatientVm = new AddPatientViewModel();
            EditPatientVm = new EditPatientViewModel();
            AddPrescriptionVm = new AddPrescriptionViewModel();
            PrecribeMedicineVm = new PrescribeMedicineViewModel();
            AddDiagnosisVm= new AddDiagnosisViewModel();
            
            CurrentVeiw = HomeVm;

            HomeViewCommand = new RelayCommand(o => 
            {
                CurrentVeiw = HomeVm;
            });
            AddVisitViewCommand = new RelayCommand(o =>
            {
                CurrentVeiw = AddVisitVm;
            });
            EditVisitViewCommand = new RelayCommand(o =>
            {
                CurrentVeiw = EditVisitVm;
            });
            ManageVisitViewCommand = new RelayCommand(o =>
            {
                CurrentVeiw = ManageVisitVm;
            });
            AddPatientViewCommand = new RelayCommand(o =>
            {
                CurrentVeiw = AddPatientVm;
            });
            EditPatientViewCommand = new RelayCommand(o =>
            {
                CurrentVeiw = EditPatientVm;
            });
            AddPrescriptionViewCommand = new RelayCommand(o =>
            {
                CurrentVeiw = AddPrescriptionVm;
            });
            PrescribeMedicineViewCommand = new RelayCommand(o =>
            {
                CurrentVeiw = PrecribeMedicineVm;
            });
            AddDiagnosisViewCommand = new RelayCommand(o =>
            {
                CurrentVeiw = AddDiagnosisVm;
            });
        }
    }
}
