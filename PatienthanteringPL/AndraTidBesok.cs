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
    public partial class AndraTidBesok : Form
    {
        
        ManageVisitController manageVisitController = new ManageVisitController();
        DoctorAppointment LakarBesokObjekt { get; set; }
        User AktivAnvandare { get; }
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
            
            doctorAppointment.Datum = dateTimePickerAndraDatum.Value;
            manageVisitController.ChangeDate(doctorAppointment.Datum, doctorAppointment);
            

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
            RedigeraBesok redigeraBesok = new RedigeraBesok(AktivAnvandare);
            redigeraBesok.Show();
            this.Close();
        }
    }
}
