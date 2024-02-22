using PatienthanteringEL;
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
    public partial class MainMenu : Form
    {
        public User ActiveUser { get; }
        public MainMenu(User user)
        {           
            InitializeComponent();
            ActiveUser = user;
        }

        private void buttonManagePatients_Click(object sender, EventArgs e)
        {
            ManagePatients managePatients = new ManagePatients(ActiveUser);
            this.Hide();
            managePatients.Show();
        }

        private void buttonManageVisits_Click(object sender, EventArgs e)
        {
            ManageVisits manageVIsits = new ManageVisits(ActiveUser);
            this.Hide();
            manageVIsits.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
