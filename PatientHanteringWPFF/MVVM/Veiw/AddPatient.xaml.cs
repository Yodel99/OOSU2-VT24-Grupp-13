using PatientHanteringWPFF.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PatientHanteringWPFF.MVVM.Veiw
{
    /// <summary>
    /// Interaction logic for Add_Patient.xaml
    /// </summary>
    public partial class Add_Patient : UserControl
    {
      

        public Add_Patient()
        {
            InitializeComponent();

            //viewmodel = new AddPatientViewModel();

            //DataContext = viewmodel;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string ssn = txtSSN.Text;
            //string fName = txtFName.Text;
            //string eName = txtEName.Text;
            //string email = txtEmail.Text;
            //string patientNr = txtPatientNr.Text;
            //string address  = txtAddress.Text;
            //string telNr = txtTelNr.Text;
            //viewmodel.AddPatient(ssn, fName, eName, email, patientNr, address, telNr);

        }
    }
}
