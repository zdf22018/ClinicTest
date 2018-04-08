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

namespace Clinic.pagesAdmin
{
    /// <summary>
    /// Interaction logic for ManageAppointments.xaml
    /// </summary>
    public partial class ManageAppointments : Page
    {
        clinicEntities context = new clinicEntities();
        CollectionViewSource doctor_scheduleViewSource;

        public ManageAppointments()
        {
            InitializeComponent();
            doctor_scheduleViewSource = ((CollectionViewSource)(FindResource("doctor_scheduleViewSource")));
            DataContext = this;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            context.doctor_schedule.Load();
            doctor_scheduleViewSource.Source = context.doctor_schedule.Local;
        }



        private void TBName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (TBName == null || string.IsNullOrWhiteSpace(TBName.Text))
            {
                doctor_scheduleViewSource.View.Filter = null;
                return;
            }
            else
            {
                string txt = TBName.Text.ToString().ToLower();
                doctor_scheduleViewSource.View.Filter = item =>
                {
#pragma warning disable IDE0019 // Use pattern matching
                    doctor_schedule m = item as doctor_schedule;
#pragma warning restore IDE0019 // Use pattern matching
                    if (m != null)
                    {
                        if (!string.IsNullOrWhiteSpace(m.Doctor) && m.Doctor.ToLower().Contains(txt))
                            return true;
                    }
                    return false;
                };
            }
        }

        private void TBPatientName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TBPatientName == null || string.IsNullOrWhiteSpace(TBPatientName.Text))
            {
                doctor_scheduleViewSource.View.Filter = null;
                return;
            }
            else
            {
                string txt = TBPatientName.Text.ToString().ToLower();
                doctor_scheduleViewSource.View.Filter = item =>
                {
#pragma warning disable IDE0019 // Use pattern matching
                    doctor_schedule m = item as doctor_schedule;
#pragma warning restore IDE0019 // Use pattern matching
                    if (m != null)
                    {
                        if (!string.IsNullOrWhiteSpace(m.Patient) && m.Patient.ToLower().Contains(txt))
                            return true;
                    }
                    return false;
                };
            }
        }

        private void dpFrom_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dpFrom.SelectedDate==null)
            {
                doctor_scheduleViewSource.View.Filter = null;
                return;
            }
            else
            {
                doctor_scheduleViewSource.View.Filter = item =>
                {

                    doctor_schedule m = item as doctor_schedule;

                    if (m != null)
                    {
                        if ( m.Start >=dpFrom.SelectedDate)
                            return true;
                    }
                    return false;
                };
            }
        }

        private void dpTo_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dpTo.SelectedDate == null)
            {
                doctor_scheduleViewSource.View.Filter = null;
                return;
            }
            else
            {
                doctor_scheduleViewSource.View.Filter = item =>
                {

                    doctor_schedule m = item as doctor_schedule;

                    if (m != null)
                    {
                        if (m.End <= dpTo.SelectedDate.Value.AddDays(1))
                            return true;
                    }
                    return false;
                };
            }
        }

       

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (clinicEntities context = new clinicEntities())
                {
                    doctor_schedule app = (doctor_schedule)doctor_scheduleDataGrid.SelectedItem;
                    int timeslot = app.slotId;
                    int appointmentId = app.appointmentId;
                    var app1 = context.appointments.Find(appointmentId);
                    context.timeslots.Find(timeslot).IsAvailable = true;
                    context.appointments.Remove(app1);
                    MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure to delete this appointment?", "Delete Confirmation", MessageBoxButton.YesNo);
                    if (messageBoxResult == MessageBoxResult.Yes)
                    {
                        context.SaveChanges();
                        MessageBox.Show("the appointment is deleted");
                        context.doctor_schedule.Load();
                        doctor_scheduleViewSource.Source = context.doctor_schedule.Local;
                    }
                }
            }
            catch
            {
                MessageBox.Show("there is no appointment selected");
            }
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            DlgAddAppointment dlgAddAppointment = new DlgAddAppointment();
            dlgAddAppointment.Show();
        }
    }
}
