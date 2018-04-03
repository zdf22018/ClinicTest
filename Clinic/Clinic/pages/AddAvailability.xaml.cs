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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Clinic
{
    /// <summary>
    /// Interaction logic for AddAvailability.xaml
    /// </summary>
    public partial class AddAvailability : Page
    {
        clinicEntities eContext = new clinicEntities();
        CRUD crud = new CRUD();

        public AddAvailability()
        {
            InitializeComponent();
            
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            int doctorId = 5;
            DateTime date = DateTime.Now.Date;
            DateTime startTime = DateTime.Now.Date;
            DateTime endTime= DateTime.Now.Date;
            if (dpDateAddAv.Text != null) { date = Convert.ToDateTime(dpDateAddAv.Text); }
            if (cmbStartTime.Text != null) { startTime = Convert.ToDateTime(cmbStartTime.Text); }
            if (cmbEndTime.Text != null) { endTime = Convert.ToDateTime(cmbEndTime.Text); }
            int duration = 0;
            if (rb30M.IsChecked == true) { duration = 30; }
            else { duration = 60; }

            availability av = new availability(doctorId, date, startTime, endTime, duration);
            crud.AddAvailableTime(av);
            MessageBox.Show("Added ", av.ToString());
            dpDateAddAv.Text = "";
            cmbStartTime.SelectedIndex = -1;
            cmbEndTime.SelectedIndex = -1;
         
        }
    }
}
