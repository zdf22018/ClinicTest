using DAL;
using System;
using System.Collections.Generic;
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
using System.Data.Entity;

namespace Clinic
{
    /// <summary>
    /// Interaction logic for DoctorDetail.xaml
    /// </summary>
    public partial class DoctorDetail : Page
    {
        clinicEntities context = new clinicEntities();
        CollectionViewSource doctorViewSource;

        public DoctorDetail()
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

        private void btUpdate_Click(object sender, RoutedEventArgs e)
        {
            var d = context.doctors.Find(int.Parse(idLabel.Content.ToString()));
            
            d.FirstName = firstNameTextBox.Text;
            d.LastName = lastNameTextBox.Text;
            d.Speciality = specialityTextBox.Text;
            d.Phone = phoneTextBox.Text;
            d.Email = emailTextBox.Text;
            d.UserName = userNameTextBox.Text;
            d.LoginPassWord= loginPassWordTextBox.Text;
            context.SaveChanges();
            MessageBox.Show("update successful");
            
        }


        //private void CollectionViewSource_Filter(object sender, FilterEventArgs e)
        //{
        //    doctor d = e.Item as doctor;
        //    // filter out doctors with id matches

        //        if (d.Id == 5)
        //        {
        //            e.Accepted = true;
        //        }
        //        else
        //        {
        //            e.Accepted = false;
        //        }

        //}
    }
}
