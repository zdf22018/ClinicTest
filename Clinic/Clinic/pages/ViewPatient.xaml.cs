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
    /// Interaction logic for ViewPatient.xaml
    /// </summary>
    public partial class ViewPatient : Page
    {
        clinicEntities context = new clinicEntities();
        CollectionViewSource patientViewSource;
        CollectionViewSource display_appointements_for_PatientViewSource;


        public ViewPatient()
        {
            InitializeComponent();
            patientViewSource = ((CollectionViewSource)(this.FindResource("patientViewSource")));
            display_appointements_for_PatientViewSource= ((CollectionViewSource)(this.FindResource("display_appointements_for_PatientViewSource")));
           
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            context.patients.Load();
            patientViewSource.Source = context.patients.Local;
            context.display_appointements_for_Patient.Load();
            display_appointements_for_PatientViewSource.Source = context.display_appointements_for_Patient.Local;
            display_appointements_for_PatientViewSource.View.Filter = item =>
            {
                display_appointements_for_Patient m = item as display_appointements_for_Patient;
                if (m != null)
                {
                    if (m.PatientId.Equals(int.Parse(idLabel.Content.ToString())))
                        return true;
                }
                return false;
            };
        }

        private void btPrevious_Click(object sender, RoutedEventArgs e)
        {

            if (patientViewSource.View.CurrentPosition > 0)
                patientViewSource.View.MoveCurrentToPrevious();
            display_appointements_for_PatientViewSource.View.Filter = item =>
            {
                display_appointements_for_Patient m = item as display_appointements_for_Patient;
                if (m != null)
                {
                    if (m.PatientId.Equals(int.Parse(idLabel.Content.ToString())))
                        return true;
                }
                return false;
            };
        }

        private void btNext_Click(object sender, RoutedEventArgs e)
        {
            if (patientViewSource.View.CurrentPosition < ((CollectionView)patientViewSource.View).Count - 1)
                patientViewSource.View.MoveCurrentToNext();
            display_appointements_for_PatientViewSource.View.Filter = item =>
            {
                display_appointements_for_Patient m = item as display_appointements_for_Patient;
                if (m != null)
                {
                    if (m.PatientId.Equals(int.Parse(idLabel.Content.ToString())))
                        return true;
                }
                return false;
            };
        }
    }
}
