using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatienthanteringAL;
using PatienthanteringDLef;
using PatienthanteringEL;

namespace PatienthanteringPL
{
    public partial class EditTimeVisit : Form
    {
        
        ManageVisitController manageVisitController = new ManageVisitController();
        DoctorAppointment DoctorAppointmentObject { get; set; }
        User ActiveUser { get; }
        public EditTimeVisit(DoctorAppointment doctorAppointment)
        {
            InitializeComponent();
            DoctorAppointmentObject = doctorAppointment;
            ModifyDatePicker();
        }
        private void ModifyDatePicker()
        {
            dateTimePickerAndraDatum.Format = DateTimePickerFormat.Custom;
            dateTimePickerAndraDatum.CustomFormat = "yyyy-MM-dd HH:mm";


            dateTimePickerAndraDatum.ShowUpDown = true;
        }
        private void EditVisit(DoctorAppointment doctorAppointment)
        {
            
            doctorAppointment.Date = dateTimePickerAndraDatum.Value;
            manageVisitController.ChangeDate(doctorAppointment.Date, doctorAppointment);
            

        }

        private void buttonChangeDate_Click(object sender, EventArgs e)
        {
            EditVisit(DoctorAppointmentObject);
            ReceiptVisit receiptVisit = new ReceiptVisit(DoctorAppointmentObject);
            receiptVisit.Show();
            this.Close();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            EditVisit editVisit = new EditVisit(ActiveUser);
            editVisit.Show();
            this.Close();
        }
    }
}
