﻿using Clinic.pagesPatient;
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
using System.Windows.Shapes;

namespace Clinic
{
    /// <summary>
    /// Interaction logic for Patient.xaml
    /// </summary>
    public partial class Patient : Window
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void btMyDetail_Click(object sender, RoutedEventArgs e)
        {
            FramePatient.Content = new PatientDetail();
        }

        private void btTakeAppointment_Click(object sender, RoutedEventArgs e)
        {
            FramePatient.Content = new PatientTakeAppointment();
        }

        private void btViewMyAppointments_Click(object sender, RoutedEventArgs e)
        {
            FramePatient.Content = new PatientViewAppointments();
        }

        private void btLogout_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
