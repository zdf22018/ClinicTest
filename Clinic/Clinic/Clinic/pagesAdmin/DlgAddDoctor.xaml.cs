using DAL;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for DlgAddDoctor.xaml
    /// </summary>
    public partial class DlgAddDoctor : Window
    {
        clinicEntities context = new clinicEntities();
        public DlgAddDoctor()
        {

            InitializeComponent();
        }

        private void btAddDoctor_Click(object sender, RoutedEventArgs e)
        {
            var d = context.doctors;
            bool CanAdd = true;
            string firstName = tbFirstName.Text.ToString();
            string lastName = tbLastName.Text.ToString();
            string speciality = tbSpeciality.Text.ToString();
            string phone = tbPhone.Text.ToString();
            string email = tbEmail.Text.ToString();
            string userName = tbUserName.Text.ToString();
            string loginPassword = tbPassword.Text.ToString();

            // check if username is unique in with doctors table
            foreach (doctor doc in d)
            {
                if (doc.UserName == userName)
                {
                    CanAdd = false;
                    break;
                }
            }
            if (!CanAdd) { MessageBox.Show(string.Format("The UserName {0} exist already, please enter another userName", userName)); }
            if (CanAdd)
            {
                doctor newDoctor = new doctor(firstName, lastName, speciality, phone, email, userName, loginPassword);
                context.doctors.Add(newDoctor);
                context.SaveChanges();
                MessageBox.Show("new doctor added");

                //after add, ask user if need to add more, if yes, set the ui field to empty if now close dialog window

                MessageBoxResult messageBoxResult = MessageBox.Show("Do you need to add another new doctor?", "Add more?", System.Windows.MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    tbFirstName.Text = "";
                    tbLastName.Text = "";
                    tbSpeciality.Text = "";
                    tbPhone.Text = "";
                    tbEmail.Text = "";
                    tbUserName.Text = "";
                    tbPassword.Text = "";
                }
                if (messageBoxResult == MessageBoxResult.No)
                {
                    Close();
                }
            }
        }
    }
}
