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

namespace Clinic
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        string SessionUserRole;
         // this is the Id of Doctor or Patient or Admin 
        clinicEntities context = new clinicEntities();
      

        public Login()
        {
            InitializeComponent();

        }

        private void btLogin_Click(object sender, RoutedEventArgs e)
        {
            // take the user entry and verify with database
            try
            {
                var userList = context.users;
                foreach (user u in userList)
                {
                    if (u.UserName == tbUserName.Text && u.LoginPassWord == tbPW.Password.ToString())
                    {
                        MessageBox.Show("user authentification done");
                        SessionUserRole = u.UserRole;
                        switch (SessionUserRole)
                        {
                            case "Doctor":
                                Globals.SessionId = u.DoctorId.Value;
                                MainWindow mainView = new MainWindow();
                                mainView.Show();
                                break;
                            case "Patient":
                                Globals.SessionId = u.PatientId.Value;
                                Patient patientView = new Patient();
                                patientView.Show();
                                break;
                            case "Admin":
                                Globals.SessionId = u.Id;
                                Admin adminView = new Admin();
                                adminView.Show();
                                break;

                        }

                    }

                }



                if (SessionUserRole == null)
                {
                    MessageBox.Show("User name or password is not valid");
                }

            }
            catch
            {
                MessageBox.Show("database error or connection time out");
            }
        }

        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
