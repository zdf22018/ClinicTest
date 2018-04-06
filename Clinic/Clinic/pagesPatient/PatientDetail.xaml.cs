using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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

namespace Clinic.pagesPatient
{
    /// <summary>
    /// Interaction logic for PatientDetail.xaml
    /// </summary>
    public partial class PatientDetail : Page
    {
        clinicEntities context = new clinicEntities();
        CollectionViewSource patientViewSource;

        public PatientDetail()
        {
            InitializeComponent();
            patientViewSource = ((CollectionViewSource)(this.FindResource("patientViewSource")));

        }

        private void btUPdate_Click(object sender, RoutedEventArgs e)
        {
            var p = context.patients.Find(int.Parse(idLabel.Content.ToString()));

            p.FirstName = firstNameTextBox.Text;
            p.LastName = lastNameTextBox.Text;
            p.DateOfBirth = Convert.ToDateTime(dateOfBirthTextBox.Text);
            p.MedicalCardNo = medicalCardNoTextBox.Text;
            p.Phone = phoneTextBox.Text;
            p.Email = emailTextBox.Text;
            p.UserName = userNameTextBox.Text;
            p.LoginPassWord = loginPassWordTextBox.Text;
            context.SaveChanges();
            MessageBox.Show("update successful");
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            context.patients.Load();
            patientViewSource.Source = context.patients.Local;
            //add a filter to load only logged patient details
            // patient id obtained from log in SessionId
            patientViewSource.View.Filter = item =>
            {
                patient m = item as patient;
                if (m != null)
                {
                    if (m.Id.Equals(Globals.SessionId))
                        return true;
                }
                return false;
            };
        }
    }
}
