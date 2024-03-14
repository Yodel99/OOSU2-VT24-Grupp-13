
﻿using DataLayer;
using EnityLayer;
using ServiceLayer;

﻿using PatientHanteringWPF.MVVM.MVVM.ViewModels;
using PatientHanteringWPFF.Core;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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
        public RelayCommand NurseScheduleViewCommand { get; set; }



        public HomeViewModel HomeVm { get; set; }
        public AddVisitViewModel AddVisitVm { get; set; }
        public EditVisitViewModel EditVisitVm { get; set; }
        public ManageVisitViewModel ManageVisitVm { get; set; }
        public AddPatientViewModel AddPatientVm { get; set; }
        public EditPatientViewModel EditPatientVm { get; set; }
        public AddPrescriptionViewModel AddPrescriptionVm { get;set; }
        public PrescribeMedicineViewModel PrecribeMedicineVm { get; set; }
        public AddDiagnosisViewModel AddDiagnosisVm { get; set; }
        public NurseScheduleViewModel NurseScheduleVm { get; set; }

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
        public ICommand CloseCommand { get; private set; }
        public void CloseProgram()
        {
            Environment.Exit(0);
        }

        public MainViewModel()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            User user = unitOfWork.UserRepository.GetUser("lakare1");
            HomeVm = new HomeViewModel();
            AddVisitVm = new AddVisitViewModel();
            EditVisitVm = new EditVisitViewModel();
            ManageVisitVm = new ManageVisitViewModel(user);
            AddPatientVm = new AddPatientViewModel();
            EditPatientVm = new EditPatientViewModel();
            AddPrescriptionVm = new AddPrescriptionViewModel();
            PrecribeMedicineVm = new PrescribeMedicineViewModel();
            AddDiagnosisVm= new AddDiagnosisViewModel();
            NurseScheduleVm= new NurseScheduleViewModel(user);
            
            CloseCommand = new RelayCommand(param => CloseProgram());


            CurrentVeiw = HomeVm;

            HomeViewCommand = new RelayCommand(execute => 
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

            NurseScheduleViewCommand = new RelayCommand(o =>
            {
                CurrentVeiw = NurseScheduleVm;
            });

        }
    }
}
