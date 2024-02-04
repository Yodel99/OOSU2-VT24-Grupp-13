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
        LakarBesok LakarBesokObjekt { get; set; }
        public AndraTidBesok(LakarBesok lakarBesok)
        {
            InitializeComponent();
            LakarBesokObjekt = lakarBesok;
            ModifieraDatePicker();
        }
        private void ModifieraDatePicker()
        {
            dateTimePickerAndraDatum.Format = DateTimePickerFormat.Custom;
            dateTimePickerAndraDatum.CustomFormat = "yyyy-MM-dd HH:mm";


            dateTimePickerAndraDatum.ShowUpDown = true;
        }
        private void AndraBesok()
        {
            
            LakarBesokObjekt.Datum = dateTimePickerAndraDatum.Value;
            patienthantering.AndraDatum(LakarBesokObjekt);
            
        }

        private void buttonAndraDatum_Click(object sender, EventArgs e)
        {
            AndraBesok();
            HanteraBesok hanteraBesok = new HanteraBesok();
            hanteraBesok.Show();
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
