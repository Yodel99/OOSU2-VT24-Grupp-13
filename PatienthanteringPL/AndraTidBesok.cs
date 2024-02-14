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
using PatienthanteringEL;

namespace PatienthanteringPL
{
    public partial class AndraTidBesok : Form
    {
        Patienthantering patienthantering = new Patienthantering();
        ManageVisitController manageVisitController = new ManageVisitController();
        DoctorAppointment LakarBesokObjekt { get; set; }
        public AndraTidBesok(DoctorAppointment doctorAppointment)
        {
            InitializeComponent();
            LakarBesokObjekt = doctorAppointment;
            ModifieraDatePicker();
        }
        private void ModifieraDatePicker()
        {
            dateTimePickerAndraDatum.Format = DateTimePickerFormat.Custom;
            dateTimePickerAndraDatum.CustomFormat = "yyyy-MM-dd HH:mm";


            dateTimePickerAndraDatum.ShowUpDown = true;
        }
        private void AndraBesok(DoctorAppointment doctorAppointment)
        {
            
            LakarBesokObjekt.Datum = dateTimePickerAndraDatum.Value;
            manageVisitController.ChangeDate(doctorAppointment);
            
        }

        private void buttonAndraDatum_Click(object sender, EventArgs e)
        {
            AndraBesok(LakarBesokObjekt);
            KvittensBokning kvittensBokning = new KvittensBokning(LakarBesokObjekt);
            kvittensBokning.Show();
            this.Close();

        }

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            RedigeraBesok redigeraBesok = new RedigeraBesok();
            redigeraBesok.Show();
            this.Close();
        }
    }
}
