using Clinic;
using Clinic.pages;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Login
{
    /// <summary>
    /// Interaction logic for DoctorUser.xaml
    /// </summary>
    public partial class DoctorUser : UserControl
    {
        public DoctorUser()
        {
            InitializeComponent();
        }

        private void btDoctorDetail_Click(object sender, RoutedEventArgs e)
        {
            DoctorMainFrame.Content = new DoctorDetail();
            
        }

        private void btViewAppointments_Click(object sender, RoutedEventArgs e)
        {
            DoctorMainFrame.Content = new ViewSchedule();
        }

        private void btViewPatients_Click(object sender, RoutedEventArgs e)
        {
            DoctorMainFrame.Content = new ViewPatient();

        }

        private void btAddAvailability_Click(object sender, RoutedEventArgs e)
        {
            DoctorMainFrame.Content = new AddAvailability();
        }

        private void btLogout_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
