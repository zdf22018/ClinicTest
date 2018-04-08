using DAL;
using System;
using System.Collections;
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
    /// Interaction logic for PatientTakeAppointment.xaml
    /// </summary>
    public partial class PatientTakeAppointment : Page
    {
        clinicEntities context = new clinicEntities();
        CollectionViewSource display_available_slotsViewSource;
        public PatientTakeAppointment()
        {
            InitializeComponent();
            display_available_slotsViewSource = ((CollectionViewSource)(this.FindResource("display_available_slotsViewSource")));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            context.display_available_slots.Load();
            display_available_slotsViewSource.Source = context.display_available_slots.Local;
            
        }



        private void tbName_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (tbName == null || string.IsNullOrWhiteSpace(tbName.Text))
            {
                display_available_slotsViewSource.View.Filter = null;
                return;
            }
            else
            {
                string txt = tbName.Text.ToString().ToLower();
                display_available_slotsViewSource.View.Filter = item =>
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
                display_available_slotsViewSource.View.Filter = null;
                return;
            }
            else
            {
                display_available_slotsViewSource.View.Filter = item =>
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
                display_available_slotsViewSource.View.Filter = null;
                return;
            }
            else
            {
                display_available_slotsViewSource.View.Filter = item =>
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

        private void btTakeAppointment_Click(object sender, RoutedEventArgs e)
        {
            // get the selected item from grid
            display_available_slots slot = (display_available_slots)display_available_slotsDataGrid.SelectedItem;
            int slotId =slot.TimeSoltId;
            MessageBox.Show(slotId.ToString());
            MessageBox.Show(Globals.SessionId.ToString());
           

            appointment app = new appointment(slotId,Globals.SessionId);
            MessageBox.Show(app.ToString());
            context.appointments.Add(app);
            context.SaveChanges();
            
            //load the view, need to find out how to refresh the viw of display_available_slots??
            
            MessageBox.Show("you have succefully taken an appointment, go to view appointment to see");

        }
    }
}