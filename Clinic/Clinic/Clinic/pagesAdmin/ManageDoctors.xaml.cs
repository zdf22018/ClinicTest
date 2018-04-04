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
    /// Interaction logic for ManageDoctors.xaml
    /// </summary>
    public partial class ManageDoctors : Page
    {
        clinicEntities context = new clinicEntities();
        CollectionViewSource doctorViewSource;
      

        public ManageDoctors()
        {
            InitializeComponent();
            doctorViewSource = ((CollectionViewSource)(FindResource("doctorViewSource")));
         
            DataContext = this;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            context.doctors.Load();
            doctorViewSource.Source = context.doctors.Local;
       

        }

        private void btPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (doctorViewSource.View.CurrentPosition > 0)
                doctorViewSource.View.MoveCurrentToPrevious();

        }

        private void btNext_Click(object sender, RoutedEventArgs e)
        {
            if (doctorViewSource.View.CurrentPosition < ((CollectionView)doctorViewSource.View).Count - 1)
                doctorViewSource.View.MoveCurrentToNext();

        }

        private void btUpdate_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            // need to check the data persistancy before delete, no availablity, no available time slots with this doctorId
            var a = context.availabilities;
            var slot = context.timeslots;
            bool canDelete = true;
            foreach(availability av in a)
            {
                if (av.DoctorId == int.Parse(idLabel.Content.ToString()))
                {
                    canDelete =false;
                }
            }
            foreach (timeslot s in slot)
            {
                if(s.SlotDoctorId == int.Parse(idLabel.Content.ToString()))
                {
                    canDelete = false;
                }
            }

            if (canDelete)
            {
                MessageBoxResult messageBoxResult = MessageBox.Show(string.Format("Are you sure to delete Doctor Id:{0}?", idLabel.Content.ToString()), "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    var userList = context.users;
                    int idDeleted = 0;
                    foreach (user u in userList)
                    {
                        if (u.DoctorId== int.Parse(idLabel.Content.ToString()))
                        {
                            context.users.Remove(context.users.Find(u.Id));
                            idDeleted = u.Id;
                        }
                    }
                    
                    context.doctors.Remove(context.doctors.Find(int.Parse(idLabel.Content.ToString())));
                    context.SaveChanges();
                    MessageBox.Show(string.Format("you have deletd Doctor id: {0}",idDeleted.ToString()));
                }
            }
            if (!canDelete)
            {
                MessageBox.Show("you need to first delete the related record in availability and/or timeslots"); }
            }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            DlgAddDoctor dlgAddDoctor = new DlgAddDoctor();
            dlgAddDoctor.Show();
           
        }

        private void btRefresh_Click(object sender, RoutedEventArgs e)
        {
            context.doctors.Load();
            doctorViewSource.Source = context.doctors.Local;
        }
    }
}
