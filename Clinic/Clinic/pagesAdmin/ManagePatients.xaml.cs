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
    /// Interaction logic for ManagePatients.xaml
    /// </summary>
    public partial class ManagePatients : Page
    {
        clinicEntities context = new clinicEntities();
        CollectionViewSource patientViewSource;

        public ManagePatients()
        {
            
            InitializeComponent();
            patientViewSource = ((CollectionViewSource)(FindResource("patientViewSource")));
            DataContext = this;
           
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            context.patients.Load();
            patientViewSource.Source = context.patients.Local;
        }


        private void btPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (patientViewSource.View.CurrentPosition > 0)
                patientViewSource.View.MoveCurrentToPrevious();

        }

        private void btNext_Click(object sender, RoutedEventArgs e)
        {
            if (patientViewSource.View.CurrentPosition < ((CollectionView)patientViewSource.View).Count - 1)
                patientViewSource.View.MoveCurrentToNext();


        }

        private void btUpdate_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            bool CanDelete = true;
            var list = context.display_appointements_for_Patient;
            foreach (display_appointements_for_Patient a in list) {
                if (a.PatientId == int.Parse(idLabel.Content.ToString())) {
                    CanDelete = false;
                }
            }
            if(CanDelete) {
                context.patients.Remove (context.patients.Find(int.Parse(idLabel.Content.ToString())));
                MessageBox.Show("Patient record deleted");
                            }
            if (!CanDelete)
            {
                MessageBox.Show("you cannot delete a patient who currently has appointment");
            }
       
        }

        private void btAddPatient_Click(object sender, RoutedEventArgs e)
        {
            DlgAddPatient dlgAddPatient = new DlgAddPatient();
            dlgAddPatient.Show();
        }

        private void btRefresh_Click(object sender, RoutedEventArgs e)
        {
            context.patients.Load();
            patientViewSource.Source = context.patients.Local;
        }

        
    }
}
