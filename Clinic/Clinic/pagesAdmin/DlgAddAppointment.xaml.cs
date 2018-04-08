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
using System.Windows.Shapes;

namespace Clinic.pagesAdmin
{
    /// <summary>
    /// Interaction logic for DlgAddAppointment.xaml
    /// </summary>
    public partial class DlgAddAppointment : Window
    {
        clinicEntities context = new clinicEntities();
        CollectionViewSource display_available_slotsViewSource;
        CollectionViewSource patientViewSource;
        public DlgAddAppointment()
        {
            InitializeComponent();
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            display_available_slotsViewSource = ((CollectionViewSource)(this.FindResource("display_available_slotsViewSource")));
            context.display_available_slots.Load();
            display_available_slotsViewSource.Source = context.display_available_slots.Local;
            
            patientViewSource = ((CollectionViewSource)(this.FindResource("patientViewSource")));
            context.patients.Load();
            patientViewSource.Source = context.patients.Local;

        }

        private void tbName_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (tbName == null || string.IsNullOrWhiteSpace(tbName.Text))
            {
                patientViewSource.View.Filter = null;
                return;
            }
            else
            {
                string txt = tbName.Text.ToString().ToLower();
                patientViewSource.View.Filter = item =>
                {

                    display_available_slots m = item as display_available_slots;

                    if (m != null)
                    {
                        if (!string.IsNullOrWhiteSpace(m.Doctor) && m.Doctor.ToLower().Contains(txt))
                            return true;
                    }
                    return false;
                };
            }
        }
        private void dpFrom_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dpFrom.SelectedDate == null)
            {
                patientViewSource.View.Filter = null;
                return;
            }
            else
            {
                patientViewSource.View.Filter = item =>
                {

                    display_available_slots m = item as display_available_slots;

                    if (m != null)
                    {
                        if (m.Start > dpFrom.SelectedDate)
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
                patientViewSource.View.Filter = null;
                return;
            }
            else
            {
                patientViewSource.View.Filter = item =>
                {

                    display_available_slots m = item as display_available_slots;

                    if (m != null)
                    {
                        if (m.End < dpTo.SelectedDate)
                            return true;
                    }
                    return false;
                };
            }
        }
        private void tbPatientName_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (tbPatientName == null || string.IsNullOrWhiteSpace(tbPatientName.Text))
            {
                patientViewSource.View.Filter = null;
                return;
            }
            else
            {
                string txt = tbPatientName.Text.ToString().ToLower();
                patientViewSource.View.Filter = item =>
                {

                    patient m = item as patient;

                    if (m != null)
                    {
                        if (!string.IsNullOrWhiteSpace(m.FullName) && m.FullName.ToLower().Contains(txt))
                            return true;
                    }
                    return false;
                };
            }
        }

        private void btTakeAppointment_Click(object sender, RoutedEventArgs e)
        {
            using (clinicEntities context = new clinicEntities())
            {
                // get the selected spot from grid
                display_available_slots slot = (display_available_slots)display_available_slotsDataGrid.SelectedItem;
                int slotId = slot.TimeSoltId;
                MessageBox.Show(slotId.ToString());
                MessageBox.Show(Globals.SessionId.ToString());
                //get the selected patient id from list
                patient p = (patient)patientListView.SelectedItem;
                int patientId = p.Id;
                appointment app = new appointment(slotId, p.Id);
                MessageBox.Show(app.ToString());
                context.appointments.Add(app);
                context.SaveChanges();

                //load the view, need to find out how to refresh the viw of display_available_slots??
                context.display_available_slots.Load();
                display_available_slotsViewSource.Source = context.display_available_slots.Local;
                MessageBoxResult messageBoxResult = MessageBox.Show("you have sucessfully made an appointment, do you need to make another appointment?", "Make more?", System.Windows.MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    tbPatientName.Text = "";
                    tbName.Text = "";
                }
                if (messageBoxResult == MessageBoxResult.No)
                {
                    Close();
                }

            }
            

        }


    }
}
