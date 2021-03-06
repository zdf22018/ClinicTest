﻿#pragma checksum "..\..\..\pagesPatient\PatientTakeAppointment.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06F178DDB3202BA2FF9CABF79D8B0FFF0D29237D"
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
    /// PatientTakeAppointment
    /// </summary>
    public partial class PatientTakeAppointment : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\pagesPatient\PatientTakeAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid display_available_slotsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\pagesPatient\PatientTakeAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn doctorColumn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\pagesPatient\PatientTakeAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn startColumn;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\pagesPatient\PatientTakeAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn endColumn;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\pagesPatient\PatientTakeAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn timeSoltIdColumn;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\pagesPatient\PatientTakeAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbName;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\pagesPatient\PatientTakeAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpFrom;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\pagesPatient\PatientTakeAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpTo;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\pagesPatient\PatientTakeAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btTakeAppointment;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\pagesPatient\PatientTakeAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSearch;
        
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
            System.Uri resourceLocater = new System.Uri("/Clinic;component/pagespatient/patienttakeappointment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pagesPatient\PatientTakeAppointment.xaml"
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
            
            #line 10 "..\..\..\pagesPatient\PatientTakeAppointment.xaml"
            ((Clinic.pagesPatient.PatientTakeAppointment)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.display_available_slotsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.doctorColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 4:
            this.startColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 5:
            this.endColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 6:
            this.timeSoltIdColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 7:
            this.tbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.dpFrom = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.dpTo = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 10:
            this.btTakeAppointment = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\pagesPatient\PatientTakeAppointment.xaml"
            this.btTakeAppointment.Click += new System.Windows.RoutedEventHandler(this.btTakeAppointment_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btSearch = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\pagesPatient\PatientTakeAppointment.xaml"
            this.btSearch.Click += new System.Windows.RoutedEventHandler(this.btSearch_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

