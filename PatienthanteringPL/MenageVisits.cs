using PatienthanteringELNy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatienthanteringPL
{
    public partial class ManageVisits : Form
    {

        public User ActiveUser { get; }
        public ManageVisits(User user)
        {
            InitializeComponent();
            ActiveUser = user;
        }

        private void buttonNewVisit_Click(object sender, EventArgs e)
        {
            NewVisit newVisit = new NewVisit(ActiveUser);
            this.Close();
            newVisit.Show();
        }

        private void buttonEditVisit_Click(object sender, EventArgs e)
        {
            EditVisit editVisit= new EditVisit(ActiveUser);
            this.Close();
            editVisit.Show();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(ActiveUser);
            mainMenu.Show();
            this.Close();
        }
    }
}
