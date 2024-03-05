using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatienthanteringALNy;
using PatienthanteringDLef;
using PatienthanteringDLef.DataSeed;
using PatienthanteringELNy;


namespace PatienthanteringPL
{
    public partial class LogIn : Form
    {
        
        public LogIn()
        {
            InitializeComponent();
            LosenordtextBox2.UseSystemPasswordChar = true;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            LogInController logInController = new LogInController();            
            

            string username = InloggsIDtextBox1.Text;
            string password = LosenordtextBox2.Text;
            

            User loggedInUser = logInController.GetUser(username, password);           

            if (loggedInUser != null)
            {
                MainMenu mainMenu = new MainMenu(loggedInUser);
                this.Hide();
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("Felaktigt användarnamn eller lösenord. Försök igen.");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void PasswordtextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogInController logInController = new LogInController();


                string username = InloggsIDtextBox1.Text;
                string password = LosenordtextBox2.Text;


                User loggedInUser = logInController.GetUser(username, password);

                if (loggedInUser != null)
                {
                    MainMenu mainMenu = new MainMenu(loggedInUser);

                    this.Hide();
                    mainMenu.Show();
                }
                else
                {
                    MessageBox.Show("Felaktigt användarnamn eller lösenord. Försök igen.");
                }
            }
        }
    }
}
