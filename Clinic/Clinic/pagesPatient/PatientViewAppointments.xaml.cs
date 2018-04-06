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

namespace Clinic.pagesPatient
{
    /// <summary>
    /// Interaction logic for PatientViewAppointments.xaml
    /// </summary>
    public partial class PatientViewAppointments : Page
    {
        clinicEntities context = new clinicEntities();
        CollectionViewSource display_appointements_for_PatientViewSource;

        public PatientViewAppointments()
        {
            InitializeComponent();
            display_appointements_for_PatientViewSource = ((CollectionViewSource)(this.FindResource("display_appointements_for_PatientViewSource")));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            context.display_appointements_for_Patient.Load();
            display_appointements_for_PatientViewSource.Source = context.display_appointements_for_Patient.Local;
        }
    }
}
