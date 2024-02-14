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
using PatienthanteringDL;
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
            LoggaInKontroller loggainkontroller = new LoggaInKontroller();            
            

            string inloggID = InloggsIDtextBox1.Text;
            string losenord = LosenordtextBox2.Text;
            

            Anvandare inloggadAnvandare = loggainkontroller.GetAnvandare(inloggID, losenord);           

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
