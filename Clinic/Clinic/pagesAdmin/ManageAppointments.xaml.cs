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
                        if (!string.IsNullOrWhiteSpace(m.DoctorName) && m.DoctorName.ToLower().Contains(txt))
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
                        if (!string.IsNullOrWhiteSpace(m.PatientName) && m.PatientName.ToLower().Contains(txt))
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
#pragma warning disable IDE0019 // Use pattern matching
                    doctor_schedule m = item as doctor_schedule;
#pragma warning restore IDE0019 // Use pattern matching
                    if (m != null)
                    {
                        if ( m.SlotStart >dpFrom.SelectedDate)
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
#pragma warning disable IDE0019 // Use pattern matching
                    doctor_schedule m = item as doctor_schedule;
#pragma warning restore IDE0019 // Use pattern matching
                    if (m != null)
                    {
                        if (m.SlotEnd < dpTo.SelectedDate)
                            return true;
                    }
                    return false;
                };
            }
        }

        private void btUpdate_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            object obj = doctor_scheduleDataGrid.SelectedItem;
            MessageBox.Show(obj.ToString());
            MessageBoxResult messageBoxResult = MessageBox.Show(string.Format("Are you sure to delete selected Appointment?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo));
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                //context.appointments.Remove();
            }
        }


        //private void btSearch_Click(object sender, RoutedEventArgs e)
        //{
        //    string docName = null; DateTime? dateFrom = null; DateTime? dateTo = null;
        //    var schedule = context.doctor_schedule;

        //    if (tbName.Text.ToString() != null) { docName = tbName.Text.ToString(); }
        //    if (dpFrom.SelectedDate != null) { dateFrom = dpFrom.SelectedDate.Value; }
        //    if (dpTo.SelectedDate != null) { dateTo = dpTo.SelectedDate.Value; }

        //    var filteredResult = from s in schedule
        //                         where s.DoctorName == docName
        //                         && s.SlotStart > dateFrom && s.SlotEnd < dateTo
        //                         select s;




        //}

    }
}
