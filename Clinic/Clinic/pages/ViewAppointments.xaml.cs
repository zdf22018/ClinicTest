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

namespace Clinic.pages
{
    /// <summary>
    /// Interaction logic for ViewAppointments.xaml
    /// </summary>
    public partial class ViewAppointments : Page
    {
        clinicEntities context = new clinicEntities();
        CollectionViewSource doctor_scheduleViewSource;
        public ViewAppointments()
        {
            InitializeComponent();
            doctor_scheduleViewSource = ((CollectionViewSource)(FindResource("doctor_scheduleViewSource")));
            DataContext = this;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            context.doctor_schedule.Load();
            doctor_scheduleViewSource.Source = context.doctor_schedule.Local;
            doctor_scheduleViewSource.View.Filter = item =>
            {
                doctor_schedule m = item as doctor_schedule;
                if (m != null)
                {
                    if (m.DoctorId.Equals(Globals.SessionId))
                        return true;
                }
                return false;
            };
        }


    }
}
