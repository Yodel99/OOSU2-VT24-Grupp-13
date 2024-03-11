using EnityLayer;
using PatientHanteringWPFF.Core;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PatientHanteringWPFF.MVVM.ViewModels
{
    internal class ManageVisitViewModel:ObservableObject
    {
        #region Initiatiion of objects
        private ObservableCollection<DoctorAppointment> visits = null;
        private ObservableCollection<DoctorAppointment> filteredVisits;
        private ObservableCollection<DoctorAppointment> selectedVisit;
        ManageVisitController manageVisitController = new ManageVisitController();
        GetListsController getListsController = new GetListsController();
        public ObservableCollection<DoctorAppointment> Visits
        {
            get { return visits; }
            set
            {
                visits = value;
                OnPropertyChanged(nameof(Visits));
            }
        }

        public ObservableCollection<DoctorAppointment> FilteredVisits
        {
            get { return filteredVisits; }
            set
            {
                filteredVisits = value;
                OnPropertyChanged(nameof(FilteredVisits));
            }
        }
        public ObservableCollection<DoctorAppointment> SelectedVisit
        {
            get { return selectedVisit; }
            set
            {
                selectedVisit = value;
                OnPropertyChanged(nameof(SelectedVisit));
            }
        }
        private DoctorAppointment visitSelectedItem;
        public DoctorAppointment VisitSelectedItem
        {
            get { return visitSelectedItem; }
            set
            {
                visitSelectedItem = value;
                ShowSelectedVisit();
                OnPropertyChanged(nameof(VisitSelectedItem));
            }
        }
        private string searchText;
        public string SearchText
        {
            get { return searchText; }
            set
            {
                if (searchText != value)
                {
                    searchText = value;
                    ApplyFilterVisits();
                    OnPropertyChanged(nameof(SearchText));

                }

            }
        }
        private string setDoneText;
        public string SetDoneText
        {
            get { return setDoneText; }
            set
            {
                if (setDoneText != value)
                {
                    setDoneText = value;
                    ApplyFilterVisits();
                    OnPropertyChanged(nameof(SetDoneText));

                }

            }
        }
        public List<int> Hours { get; } = Enumerable.Range(8, 11).SelectMany(h => new[] { h }).ToList();
        public List<int> Minutes { get; } = new List<int> { 0, 15, 30, 45 };
        private DateTime _selectedDate;
        public DateTime SelectedDate
        {
            get { return _selectedDate; }
            set
            {
                _selectedDate = value;
                OnPropertyChanged(nameof(SelectedDate));
            }
        }
        private int _selectedHour;
        public int SelectedHour
        {
            get { return _selectedHour; }
            set
            {
                _selectedHour = value;
                OnPropertyChanged(nameof(SelectedHour));
            }
        }

        private int _selectedMinute;
        public int SelectedMinute
        {
            get { return _selectedMinute; }
            set
            {
                _selectedMinute = value;
                OnPropertyChanged(nameof(SelectedMinute));
            }
        }
        public DateTime CombinedDateTime
        {
            get { return new DateTime(SelectedDate.Year, SelectedDate.Month, SelectedDate.Day, SelectedHour, SelectedMinute, 0); }
        }
        public ICommand ChangeTimeVisitCommand { get; private set; }
        public ICommand RefreshAllCommand { get; private set; }
        public ICommand SetDoneCommand { get; private set; }
        public User ActiveUser { get; private set; }
        #endregion
        #region Constructor
        public ManageVisitViewModel(User user)
        {
            Visits = new ObservableCollection<DoctorAppointment>((manageVisitController.GetUserSpecificVisits(user)));
            selectedVisit = new ObservableCollection<DoctorAppointment>();
            FilteredVisits = new ObservableCollection<DoctorAppointment>(Visits);
            SelectedDate = DateTime.Today;
            ChangeTimeVisitCommand = new RelayCommand(param => ChangeTime());
            RefreshAllCommand = new RelayCommand(param => RefreshLists());
            SetDoneCommand = new RelayCommand(param => SetAsDone());
            ActiveUser =user;
        }
        #endregion
        #region Methods
        private void ShowSelectedVisit()
        {
            SelectedVisit.Clear();
            SelectedVisit.Add(VisitSelectedItem);
        }

        private void ApplyFilterVisits()
        {
            if (SearchText == null)
            {
                FilteredVisits = new ObservableCollection<DoctorAppointment>(Visits);
                return;
            }
            else
                FilteredVisits.Clear();
            foreach (var visit in Visits)
            {
                if (visit.Patient.FName.Contains(SearchText) ||
                    visit.Patient.EName.Contains(SearchText) ||
                    visit.VisitNr.Contains(SearchText))
                {
                    FilteredVisits.Add(visit);
                }
            }
            OnPropertyChanged(nameof(FilteredVisits));
        }
        private void ChangeTime()
        {
            if (VisitSelectedItem == null)
            {
                MessageBox.Show("Please select a visit to change its time.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            DateTime newDateTime = CombinedDateTime;
            if (newDateTime < DateTime.Now)
            {
                MessageBox.Show("Please select a date and time that is not earlier than the current date and time.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            try
            {
                SetDoneText = "Revisit";
                manageVisitController.ChangeDate(newDateTime, VisitSelectedItem);
                manageVisitController.EditAppointmentStatus(VisitSelectedItem, SetDoneText);

                MessageBox.Show($"A revisit has been scheduled {newDateTime}", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                RefreshLists();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while changing the visit time: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void SetAsDone()
        {
            SetDoneText = "Complete";
            if (VisitSelectedItem == null)
            {
                MessageBox.Show("Please select a visit to change its time.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                manageVisitController.EditAppointmentStatus(VisitSelectedItem, SetDoneText);
                MessageBox.Show($"The visit has now been set to done!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                RefreshLists();
            }
        }
        private void RefreshLists()
        {
            GetListsController getListsController = new GetListsController();
            Visits.Clear();
            foreach (var visit in manageVisitController.GetUserSpecificVisits(ActiveUser))
            {
                Visits.Add(visit);
            }
            ApplyFilterVisits(); // Uppdatera filtrerade listan om det behövs
        }
        #endregion
    }

}
