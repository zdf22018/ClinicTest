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
    /// Interaction logic for ManageTimeSlots.xaml
    /// </summary>
    public partial class ManageTimeSlots : Page
    {
        clinicEntities context = new clinicEntities();
        CollectionViewSource display_available_slotsViewSource;
        public ManageTimeSlots()
        {
            InitializeComponent();
            display_available_slotsViewSource = ((CollectionViewSource)(this.FindResource("display_available_slotsViewSource")));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            context.display_available_slots.Load();
            display_available_slotsViewSource.Source = context.display_available_slots.Local;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (clinicEntities context = new clinicEntities())
                {
                    display_available_slots s = (display_available_slots)display_available_slotsDataGrid.SelectedItem;
                    int slotId = s.TimeSoltId;
                    int AvailabilityId = 0;
                                       
                    context.timeslots.Remove(context.timeslots.Find(slotId));
                    
                    
                    MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure to delete this time slot?", "Delete Confirmation", MessageBoxButton.YesNo);
                    if (messageBoxResult == MessageBoxResult.Yes)
                    {
                        
                        context.SaveChanges();
                        MessageBox.Show("the slot is deleted");
                        context.display_available_slots.Load();
                        display_available_slotsViewSource.Source = context.display_available_slots.Local;
                    }
                    // check in timeslots table, if no more availabilityId exists, meaning that availability can be deleted
                    var list = context.timeslots;
                    foreach (timeslot t in list)
                    {   
                        if (t.Id==slotId)
                        {
                            AvailabilityId = t.AvailabilityId;                           
                        }
                    }
                    if (AvailabilityId==0)
                    {
                        context.availabilities.Remove(context.availabilities.Find(AvailabilityId));
                        context.SaveChanges();
                    }
                }
            }
            catch (System.InvalidCastException ex) { MessageBox.Show("Exception caught: {0}", ex.ToString()); }
            finally{ MessageBox.Show("nothing is selected"); }
        }
    }
}
