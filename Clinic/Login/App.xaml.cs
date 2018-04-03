using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Login
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {


        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    base.OnStartup(e);

        //    LoginDlg dlg = new LoginDlg();
        //    if (dlg.ShowDialog() != true)
        //        return;
        //    if (dlg.tbUserRole.Text=="Doctor")
        //    {
        //        DoctorUser dUser = new DoctorUser();
        //    }



        //    //switch (dlg.tbUserRole.Text)
        //    //{
        //    //    case "Doctor":
                    
        //    //        StartupUri = new Uri(@"DoctorUser.xaml",
        //    //            UriKind.Relative);
        //    //        break;

        //        //case ChoiceApp.VendorEntry:
        //        //    StartupUri = new Uri("/MyApp;component/Forms/VendorEntry.xaml",
        //        //        UriKind.Relative);
        //        //    break;
        //    //}
        //}



        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    this.StartupUri = new System.Uri(@"C:\Users\Jay\Documents\ClinicTest\Clinic\Clinic\MainWindow.xaml", UriKind.Absolute);
        //}

        //private void Application_Startup(object sender, StartupEventArgs e)
        //{


        //    if (Global.UserRole == "Doctor") { 
        //        StartupUri = new Uri(@"C:\Users\Jay\Documents\ClinicTest\Clinic\Clinic\MainWindow.xaml", UriKind.Absolute);}
        //    //else
        //    //    StartupUri = new Uri("/SOTestWPF;component/Window2.xaml", UriKind.Relative);

        //}
    }
}
