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

namespace Clinic
{
    /// <summary>
    /// Interaction logic for AddAvailability.xaml
    /// </summary>
    public partial class AddAvailability : Page
    {
        clinicEntities context = new clinicEntities();
        CollectionViewSource doctoravailabilitiesViewSource;

        public AddAvailability()
        {
            InitializeComponent();
            doctoravailabilitiesViewSource = ((CollectionViewSource)(this.FindResource("doctoravailabilitiesViewSource")));
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {

            DateTime? date = null;
            TimeSpan? startTime = null;
            TimeSpan? endTime = null;
            int duration;

            if (!string.IsNullOrWhiteSpace(dpDateAddAv.Text)) { date = Convert.ToDateTime(dpDateAddAv.Text); }
            if (!string.IsNullOrWhiteSpace(cmbStartTime.Text)) { startTime = TimeSpan.Parse(cmbStartTime.Text); }
            if (!string.IsNullOrWhiteSpace(cmbEndTime.Text)) { endTime = TimeSpan.Parse(cmbEndTime.Text); }

            if (rb30M.IsChecked == true) { duration = 30; }
            else { duration = 60; }

            //convert nullable DateTime to DateTime

            DateTime DateToPass = (DateTime)(date);
            DateTime sTime = (DateTime)(date + startTime);
            DateTime eTime = (DateTime)(date + endTime);
            //check the sTime if is overlapping with existing availabilities
            bool CanAddAvailability = true;
            var list = context.availabilities.Where(a => a.DoctorId == Globals.SessionId);
            foreach (availability a in list)
            {
                if (sTime >= a.AvailableFrom && sTime <= a.AvailableTo) { CanAddAvailability = false; }

            }
            if (CanAddAvailability)
            {
                availability av = new availability(Globals.SessionId, DateToPass, sTime, eTime, duration);
                context.availabilities.Add(av);
                context.SaveChanges();
                MessageBox.Show("Added ", av.ToString());
                dpDateAddAv.Text = "";
                cmbStartTime.SelectedIndex = -1;
                cmbEndTime.SelectedIndex = -1;

            }
            if (!CanAddAvailability)
            {
                MessageBox.Show("Please check the entry, it is overlapping with existing availability");
            }

        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            context.availabilities.Load();

            doctoravailabilitiesViewSource.Source = context.availabilities.Local;
            //add a filter to load only logged doctor availabilities
            // doctor id obtained from log in SessionId
            doctoravailabilitiesViewSource.View.Filter = item =>
            {
                availability m = item as availability;
                if (m != null)
                {
                    if (m.DoctorId.Equals(Globals.SessionId) && m.AvailableFrom >=DateTime.Today)
                        return true;
                }
                return false;
            };
        }

        
    }
}
