using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace Clinic.pagesAdmin
{
    /// <summary>
    /// Interaction logic for DlgAddPatient.xaml
    /// </summary>
    public partial class DlgAddPatient : Window
    {
        clinicEntities context = new clinicEntities();
        public DlgAddPatient()
        {
            InitializeComponent();
        }

        private void tbSavePatient_Click(object sender, RoutedEventArgs e)
        {
            var p = context.patients;
            bool CanAdd = true;
            string firstName = tbFirstName.Text.ToString();
            string lastName = tbLastName.Text.ToString();
            string phone = tbPhone.Text.ToString();
            string email = tbEmail.Text.ToString();
            DateTime? dob = DateTime.Parse(dpDOB.Text);
            string medicalCardNo = tbMedicalCardNo.Text.ToString();
            string userName = tbUserName.Text.ToString();
            string loginPassword = tbLoginPassword.Text.ToString();

            // check if username is unique in with patients table
            foreach (patient pat in p)
            {
                if (pat.UserName == userName)
                {
                    CanAdd = false;
                    break;
                }
            }
            if (!CanAdd) { MessageBox.Show(string.Format("The UserName {0} exist already, please enter another userName", userName)); }
            if (CanAdd)
            {
                patient newPatient = new patient(firstName, lastName,  phone, email, dob, medicalCardNo, userName, loginPassword);
                context.patients.Add(newPatient);
                try
                {
                    context.SaveChanges();
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}",
                                                    validationError.PropertyName,
                                                    validationError.ErrorMessage);
                            MessageBox.Show(validationError.ErrorMessage);
                        }
                    }
                }
                MessageBox.Show("new patient added");

                //after add, ask user if need to add more, if yes, set the ui field to empty if now close dialog window

                MessageBoxResult messageBoxResult = MessageBox.Show("Do you need to add another new patient?", "Add more?", System.Windows.MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    tbFirstName.Text = "";
                    tbLastName.Text = "";
                    tbPhone.Text = "";
                    tbEmail.Text = "";
                    dpDOB.Text = "";
                    tbMedicalCardNo.Text = "";
                    tbUserName.Text = "";
                    tbLoginPassword.Text = "";
                }
                if (messageBoxResult == MessageBoxResult.No)
                {
                    Close();
                }
            }

        }
    }
}
