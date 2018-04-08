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
    /// Interaction logic for PatientViewAppointments.xaml
    /// </summary>
    public partial class PatientViewAppointments : Page
    {
        clinicEntities context = new clinicEntities();
        CollectionViewSource display_appointements_for_PatientViewSource;

        public PatientViewAppointments()
        {
            InitializeComponent();
            display_appointements_for_PatientViewSource = ((CollectionViewSource)(this.FindResource("display_appointements_for_PatientViewSource")));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            context.display_appointements_for_Patient.Load();
            display_appointements_for_PatientViewSource.Source = context.display_appointements_for_Patient.Local;
            display_appointements_for_PatientViewSource.View.Filter = item =>
            {
                display_appointements_for_Patient m = item as display_appointements_for_Patient;
                if (m != null)
                {
                    if (m.PatientId.Equals(Globals.SessionId))
                        return true;
                }
                return false;
            };
        }

        private void btCancelAppointment_Click(object sender, RoutedEventArgs e)
        {   try
            {   using (clinicEntities context = new clinicEntities()) { 
                display_appointements_for_Patient app = (display_appointements_for_Patient)display_appointements_for_PatientListView.SelectedItem;
                int timeslot = app.TimeSlotId;
                int appointmentId = app.appointmentId;
                var app1 = context.appointments.Find(appointmentId);
                context.timeslots.Find(timeslot).IsAvailable = true;
                context.appointments.Remove(app1);
                MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure to delete this appointment?", "Delete Confirmation", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    context.SaveChanges();
                    MessageBox.Show("the appointment cancelled");
                    context.display_appointements_for_Patient.Load();
                    display_appointements_for_PatientViewSource.Source = context.display_appointements_for_Patient.Local;
                        display_appointements_for_PatientViewSource.View.Filter = item =>
                        {
                            display_appointements_for_Patient m = item as display_appointements_for_Patient;
                            if (m != null)
                            {
                                if (m.PatientId.Equals(Globals.SessionId))
                                    return true;
                            }
                            return false;
                        };

                    }
                }
            }
            catch
            {
                MessageBox.Show("there is no appointment selected");
            }
          
        }
    }
}
