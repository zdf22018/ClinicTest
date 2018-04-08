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
            display_available_slotsViewSource = ((CollectionViewSource)(this.FindResource("display_available_slotsViewSource")));
            patientViewSource = ((CollectionViewSource)(this.FindResource("patientViewSource")));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            
            context.display_available_slots.Load();
            display_available_slotsViewSource.Source = context.display_available_slots.Local;
            
           
            context.patients.Load();
            patientViewSource.Source = context.patients.Local;

        }

        //private void tbName_TextChanged(object sender, TextChangedEventArgs e)
        //{

        //    if (tbName == null || string.IsNullOrWhiteSpace(tbName.Text))
        //    {
        //        patientViewSource.View.Filter = null;
        //        return;
        //    }
        //    else
        //    {
        //        string txt = tbName.Text.ToString().ToLower();
        //        display_available_slotsViewSource.View.Filter = item =>
        //        {

        //            display_available_slots m = item as display_available_slots;

        //            if (m != null)
        //            {
        //                if (!string.IsNullOrWhiteSpace(m.Doctor) && m.Doctor.ToLower().Contains(txt))
        //                    return true;
        //            }
        //            return false;
        //        };
        //    }
        //}
        //private void dpFrom_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (dpFrom.SelectedDate == null)
        //    {
        //        display_available_slotsViewSource.View.Filter = null;
        //        return;
        //    }
        //    else
        //    {
        //        display_available_slotsViewSource.View.Filter = item =>
        //        {

        //            display_available_slots m = item as display_available_slots;

        //            if (m != null)
        //            {
        //                if (m.Start > dpFrom.SelectedDate)
        //                    return true;
        //            }
        //            return false;
        //        };
        //    }
        //}
        //private void dpTo_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (dpTo.SelectedDate == null)
        //    {
        //        display_available_slotsViewSource.View.Filter = null;
        //        return;
        //    }
        //    else
        //    {
        //        display_available_slotsViewSource.View.Filter = item =>
        //        {

        //            display_available_slots m = item as display_available_slots;

        //            if (m != null)
        //            {
        //                if (m.End < dpTo.SelectedDate)
        //                    return true;
        //            }
        //            return false;
        //        };
        //    }
        //}

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
                MessageBox.Show(string.Format("you have chosen slot: {0}",slotId.ToString()));
                
                //get the selected patient id from list
                patient p = (patient)patientListView.SelectedItem;
                int patientId = p.Id;
                MessageBox.Show(string.Format("you have chosen patient with Id: {0}",patientId.ToString()));
                appointment app = new appointment(slotId, patientId);
                MessageBox.Show(string.Format("this appointment will be made {0}", app.ToString()));
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
                    dpFrom.Text = "";
                    dpTo.Text = "";
                }
                if (messageBoxResult == MessageBoxResult.No)
                {
                    Close();
                }

            }
            

        }

        private void btSearch_Click(object sender, RoutedEventArgs e)
        {
            using (clinicEntities context = new clinicEntities())
            {                
                display_available_slotsViewSource.View.Filter = item =>
                {
                    string txt = tbName.Text.ToString().ToLower();
                    display_available_slots m = item as display_available_slots;

                    if (m != null)
                    {
                        if (!string.IsNullOrWhiteSpace(txt) && dpFrom.SelectedDate == null && dpTo.SelectedDate == null)// only doctor box has input
                        {
                            if (m.Doctor.ToLower().Contains(txt) && m.Start >= DateTime.Today)
                            { return true; }
                        }


                        if (!string.IsNullOrWhiteSpace(txt) && dpTo.SelectedDate == null && dpFrom.SelectedDate != null)// doctor and dpFrom has input
                        {
                            if (m.Doctor.ToLower().Contains(txt) && m.Start >= dpFrom.SelectedDate)
                            { return true; }
                        }

                        if (!string.IsNullOrWhiteSpace(txt) && dpTo.SelectedDate != null && dpFrom.SelectedDate == null) // doctor and dpTo has input
                        {
                            if (m.Doctor.ToLower().Contains(txt) && m.Start <= dpTo.SelectedDate.Value.AddDays(1) && m.Start >= DateTime.Today)
                            { return true; }
                        }


                        if (!string.IsNullOrWhiteSpace(txt) && dpFrom.SelectedDate != null && dpTo.SelectedDate != null)// doctor, dpFrom, dpTo has input
                        {   
                                if (m.Doctor.ToLower().Contains(txt) && m.Start >= dpFrom.SelectedDate && m.End <= dpTo.SelectedDate.Value.AddDays(1))
                                { return true; }
                           
                            }
                        }

                        if (string.IsNullOrWhiteSpace(txt) && dpFrom.SelectedDate != null && dpTo.SelectedDate != null)// doctor empty, dpTo, doFrom filled
                        {
                            
                                if(m.Start >= dpFrom.SelectedDate && m.End <= dpTo.SelectedDate.Value.AddDays(1))
                                {
                                    return true;
                                }
                            } 
                            
                    
                    return false;
                };


            }
        }
    }
}
