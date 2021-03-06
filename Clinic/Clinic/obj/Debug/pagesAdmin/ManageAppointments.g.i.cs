﻿#pragma checksum "..\..\..\pagesAdmin\ManageAppointments.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ED937F67BE1217C39FA92A5F8A9072A301D9C52"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Clinic.pagesAdmin;
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


namespace Clinic.pagesAdmin {
    
    
    /// <summary>
    /// ManageAppointments
    /// </summary>
    public partial class ManageAppointments : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\pagesAdmin\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpFrom;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\pagesAdmin\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpTo;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\pagesAdmin\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBName;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\pagesAdmin\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btDelete;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\pagesAdmin\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAdd;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\pagesAdmin\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBPatientName;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\pagesAdmin\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid doctor_scheduleDataGrid;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\pagesAdmin\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn appointmentIdColumn;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\pagesAdmin\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn doctorColumn;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\pagesAdmin\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn doctorIdColumn;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\pagesAdmin\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn patientColumn;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\pagesAdmin\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn patientIdColumn;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\pagesAdmin\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn startColumn;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\pagesAdmin\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn endColumn;
        
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
            System.Uri resourceLocater = new System.Uri("/Clinic;component/pagesadmin/manageappointments.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pagesAdmin\ManageAppointments.xaml"
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
            
            #line 10 "..\..\..\pagesAdmin\ManageAppointments.xaml"
            ((Clinic.pagesAdmin.ManageAppointments)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dpFrom = ((System.Windows.Controls.DatePicker)(target));
            
            #line 18 "..\..\..\pagesAdmin\ManageAppointments.xaml"
            this.dpFrom.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.dpFrom_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dpTo = ((System.Windows.Controls.DatePicker)(target));
            
            #line 20 "..\..\..\pagesAdmin\ManageAppointments.xaml"
            this.dpTo.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.dpTo_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TBName = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\pagesAdmin\ManageAppointments.xaml"
            this.TBName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btDelete = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\pagesAdmin\ManageAppointments.xaml"
            this.btDelete.Click += new System.Windows.RoutedEventHandler(this.btDelete_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btAdd = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\pagesAdmin\ManageAppointments.xaml"
            this.btAdd.Click += new System.Windows.RoutedEventHandler(this.btAdd_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TBPatientName = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\pagesAdmin\ManageAppointments.xaml"
            this.TBPatientName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBPatientName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.doctor_scheduleDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.appointmentIdColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 10:
            this.doctorColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 11:
            this.doctorIdColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 12:
            this.patientColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 13:
            this.patientIdColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 14:
            this.startColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 15:
            this.endColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

