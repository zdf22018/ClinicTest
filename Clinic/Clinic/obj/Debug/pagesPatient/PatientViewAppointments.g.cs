﻿#pragma checksum "..\..\..\pagesPatient\PatientViewAppointments.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25367A8BC0DDC828C6846008F35CAD0D7726CA8B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Clinic.pagesPatient;
using DAL;
using DevExpress.Xpf.DXBinding;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Clinic.pagesPatient {
    
    
    /// <summary>
    /// PatientViewAppointments
    /// </summary>
    public partial class PatientViewAppointments : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\pagesPatient\PatientViewAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView display_appointements_for_PatientListView;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\pagesPatient\PatientViewAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn doctorColumn;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\pagesPatient\PatientViewAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn startColumn;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\pagesPatient\PatientViewAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn endColumn;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\pagesPatient\PatientViewAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btCancelAppointment;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Clinic;component/pagespatient/patientviewappointments.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pagesPatient\PatientViewAppointments.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\pagesPatient\PatientViewAppointments.xaml"
            ((Clinic.pagesPatient.PatientViewAppointments)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.display_appointements_for_PatientListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.doctorColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 4:
            this.startColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 5:
            this.endColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 6:
            this.btCancelAppointment = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\pagesPatient\PatientViewAppointments.xaml"
            this.btCancelAppointment.Click += new System.Windows.RoutedEventHandler(this.btCancelAppointment_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

