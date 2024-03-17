using ServiceLayer;
using EnityLayer;
﻿using PatientHanteringWPF.MVVM.MVVM.ViewModels;
using PatientHanteringWPFF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using PatientHanteringWPF.MVVM;

namespace PatientHanteringWPFF.MVVM.ViewModels
{
    internal class MainViewModel : ObservableObject, ICloseWindow
    {     
        ValidationController validationController=new ValidationController();
        private User _currentUser;
        public User CurrentUser
        {
            get { return _currentUser; }
            set
            {
                _currentUser = value;
                OnPropertyChanged(nameof(CurrentUser));
            }
        }

        public RelayCommand HomeViewCommand { get; set; } 
        public RelayCommand AddVisitViewCommand { get; set; }
        public RelayCommand EditVisitViewCommand { get; set; }
        public RelayCommand ManageVisitViewCommand { get; set; }
        public RelayCommand AddPatientViewCommand { get; set; }
        public RelayCommand EditPatientViewCommand { get; set; }
        public RelayCommand AddPrescriptionViewCommand { get; set; }
        public RelayCommand PrescribeMedicineViewCommand { get; set; }
        public RelayCommand AddDiagnosisViewCommand { get; set; }
        public RelayCommand SearchPatientViewCommand { get; set; }
        public RelayCommand NurseScheduleViewCommand { get; set; }



        public HomeViewModel HomeVm { get; set; }
        public AddVisitViewModel AddVisitVm { get; set; }
        public EditVisitViewModel EditVisitVm { get; set; }
        public ManageVisitViewModel ManageVisitVm { get; set; }
        public AddPatientViewModel AddPatientVm { get; set; }
        public EditPatientViewModel EditPatientVm { get; set; }
        public AddPrescriptionViewModel AddPrescriptionVm { get;set; }
        public AddDiagnosisViewModel AddDiagnosisVm { get; set; }
        public SearchPatientViewModel SearchPatientVm { get; set; }
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
        private void CloseProgram()
        {
            Environment.Exit(0);
        }
        public ICommand LogOutCommand { get; private set; }
        
        
        private void LogOut()
        {
            // Skapa en instans av LoginWindow och Visa den
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();


            Close?.Invoke();

        } 
        public Action Close { get; set; }
        


        public MainViewModel(User user)
        {
           
            CurrentUser = user;
           

            HomeVm = new HomeViewModel();
            AddVisitVm = new AddVisitViewModel();
            EditVisitVm = new EditVisitViewModel();
            ManageVisitVm = new ManageVisitViewModel(CurrentUser);
            AddPatientVm = new AddPatientViewModel();
            EditPatientVm = new EditPatientViewModel();
            AddPrescriptionVm = new AddPrescriptionViewModel();
            AddDiagnosisVm= new AddDiagnosisViewModel();
            SearchPatientVm = new SearchPatientViewModel();
            NurseScheduleVm= new NurseScheduleViewModel(CurrentUser);

            LogOutCommand = new RelayCommand(param => LogOut());
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
            { if(validationController.AccessCheckNurse(CurrentUser)==true)
                {
                    CurrentVeiw = ManageVisitVm;
                }
                else
                {
                    MessageBox.Show("Not Authorized", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            });
            AddPatientViewCommand = new RelayCommand(o =>
            {
                CurrentVeiw = AddPatientVm;
            });
            EditPatientViewCommand = new RelayCommand(o =>
            {
                if(validationController.AccessCheckNurse(CurrentUser)==true)
                {
                    CurrentVeiw = EditPatientVm;
                }
                else
                {
                    MessageBox.Show("Not Authorized", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            });
            AddPrescriptionViewCommand = new RelayCommand(o =>
            { if(validationController.AccessCheckDoctor(CurrentUser)==true)
                {
                    CurrentVeiw = AddPrescriptionVm;
                }
                else
                {
                    MessageBox.Show("Not Authorized", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            });
            AddDiagnosisViewCommand = new RelayCommand(o =>
            {
                if(validationController.AccessCheckDoctor(CurrentUser)==true)
                {
                    CurrentVeiw = AddDiagnosisVm;
                }
                else
                {
                    MessageBox.Show("Not Authorized", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }


            });
            SearchPatientViewCommand = new RelayCommand(o =>
            {
                if(validationController.AccessCheckNurse(CurrentUser)==true)
                {
                    CurrentVeiw = SearchPatientVm;
                }
                else
                {
                    MessageBox.Show("Not Authorized", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            });
            NurseScheduleViewCommand = new RelayCommand(o =>
            { if(validationController.AccessCheckNurse(CurrentUser)==true)
                {
                    CurrentVeiw = NurseScheduleVm;

                }
                else
                {
                    MessageBox.Show("Not Authorized", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            });
        }
        
    }

    public interface ICloseWindow
    {
        Action Close { get; set; }
    }
}
