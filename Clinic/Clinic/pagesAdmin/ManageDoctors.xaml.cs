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
            // need to check if the doctor has any future appointments, if not, doctor can be deleted 
            // neet to delete also the future availability and timeslots pertaining to this doctor
            var a = context.availabilities;
            var slot = context.timeslots;
            var list = context.display_appointements_for_Patient;
            bool canDelete = true;
            foreach(display_appointements_for_Patient app in list)
            {
                if (app.DoctorId == int.Parse(idLabel.Content.ToString()))
                {
                    canDelete =false;
                }
            }
            

            if (canDelete)
            {
                MessageBoxResult messageBoxResult = MessageBox.Show(string.Format("Are you sure to delete Doctor Id:{0}?", idLabel.Content.ToString()), "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    var userList = context.users;
                    int idDeleted = 0;
                    foreach (user u in userList.ToList())
                    {
                        if (u.DoctorId== int.Parse(idLabel.Content.ToString()))
                        {
                            context.users.Remove(context.users.Find(u.Id));
                            idDeleted = u.Id;
                        }
                        context.SaveChanges();
                    }
                    foreach (timeslot s in slot.ToList())
                    {   if (s.SlotDoctorId == int.Parse(idLabel.Content.ToString()) && s.SlotStart> DateTime.Today)
                            context.timeslots.Remove(s);
                        context.SaveChanges();
                    }
                    foreach (availability av in a.ToList())
                    {
                        if(av.DoctorId== int.Parse(idLabel.Content.ToString()) && av.AvailableFrom>DateTime.Today)
                        {
                            context.availabilities.Remove(av);
                            context.SaveChanges();
                        }
                    }
                    
                    context.doctors.Remove(context.doctors.Find(int.Parse(idLabel.Content.ToString())));
                    context.SaveChanges();
                    MessageBox.Show(string.Format("you have deleted Doctor id: {0}", idLabel.Content.ToString()));
                }
            }
            if (!canDelete)
            {
                MessageBox.Show("this doctor has future appointment, you need to first take care of appointment"); }
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
