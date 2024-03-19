using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PatientHanteringWPFF.MVVM.ViewModels;
using System.Windows.Input;
using GalaSoft.MvvmLight.Messaging;
using PatientHanteringWPFF;
using System.Windows;
using System.Security;
using PatientHanteringWPF.MVVM.CloseWindows;

namespace PatientHanteringWPF.MVVM.MVVM.ViewModels
{
    public class LoginViewModel : ObservableObject,ICloseWindow
    {       
        private readonly LogInController loginController;
        public Action Close { get; set; }

        public LoginViewModel()
        {          
            loginController = new LogInController();
        }       

        private string logInID;
        public string LogInID
        {
            get { return logInID; }
            set { Set(ref logInID, value); }
        }       

        private string password;
        public string Password
        {
            get { return password; }
            set { Set(ref password, value); }
        }

        private RelayCommand loginCommand;
        public ICommand LoginCommand
        {
            get
            {
                return loginCommand ?? (loginCommand = new RelayCommand(Login));
            }
        }

        private void Login()
        {
            var user = loginController.GetUser(logInID, password);
            if (user != null)
            {
                MainViewModel mainViewModel = new MainViewModel(user);
                mainViewModel.CurrentUser = user;

                MainWindow mainWindow = new MainWindow();
                mainWindow.DataContext = mainViewModel;

                mainWindow.Show();

                Close?.Invoke();
            }
            else
            {
                MessageBox.Show("Wrong username or password, Try again!", "Felmeddelande", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private RelayCommand exitCommand;
        public ICommand ExitCommand
        {
            get
            {
                return exitCommand ?? (exitCommand = new RelayCommand(Exit));
            }
        }

        private void Exit()
        {
            Application.Current.Shutdown();
        }
    }
}
