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
    public partial class LoggaIn : Form
    {
        //hehehehehehehohohohoho
        public LoggaIn()
        {
            InitializeComponent();
            LosenordtextBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoggInController loggainkontroller = new LoggInController();            
            

            string inloggID = InloggsIDtextBox1.Text;
            string losenord = LosenordtextBox2.Text;
            

            User inloggadAnvandare = loggainkontroller.GetUser(inloggID, losenord);           

            if (inloggadAnvandare != null)
            {
                Huvudmeny huvudmeny = new Huvudmeny();
                this.Hide();
                huvudmeny.Show();
            }
            else
            {
                MessageBox.Show("Felaktigt användarnamn eller lösenord. Försök igen.");
            }



        }

        
    }
}
