using Clinic.pagesAdmin;
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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btManageDoctors_Click(object sender, RoutedEventArgs e)
        {
            FrameAdmin.Content = new ManageDoctors();
        }

        private void btManagePatients_Click(object sender, RoutedEventArgs e)
        {
            FrameAdmin.Content = new ManagePatients();
        }

        private void btManageAppointments_Click(object sender, RoutedEventArgs e)
        {
            FrameAdmin.Content = new ManageAppointments();
        }

        private void btManageTimeSlots_Click(object sender, RoutedEventArgs e)
        {
            FrameAdmin.Content = new ManageTimeSlots();

        }

        private void btLogout_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }
    }
}
