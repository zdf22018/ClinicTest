﻿#pragma checksum "..\..\..\pagesAdmin\ManageDoctors.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AF278096F112F0F8A3A2605F553BC342ACC06F79"
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
    /// ManageDoctors
    /// </summary>
    public partial class ManageDoctors : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\pagesAdmin\ManageDoctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid1;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\pagesAdmin\ManageDoctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label emailLabel;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\pagesAdmin\ManageDoctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\pagesAdmin\ManageDoctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDoctorId;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\pagesAdmin\ManageDoctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label idLabel;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\pagesAdmin\ManageDoctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lastNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\pagesAdmin\ManageDoctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginPassWordTextBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\pagesAdmin\ManageDoctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phoneTextBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\pagesAdmin\ManageDoctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox specialityTextBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\pagesAdmin\ManageDoctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\pagesAdmin\ManageDoctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btPrevious;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\pagesAdmin\ManageDoctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btNext;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\pagesAdmin\ManageDoctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btUpdate;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\pagesAdmin\ManageDoctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btDelete;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\pagesAdmin\ManageDoctors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/Clinic;component/pagesadmin/managedoctors.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pagesAdmin\ManageDoctors.xaml"
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
            
            #line 10 "..\..\..\pagesAdmin\ManageDoctors.xaml"
            ((Clinic.pagesAdmin.ManageDoctors)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.emailLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.firstNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.lblDoctorId = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.idLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lastNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.loginPassWordTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.phoneTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.specialityTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.userNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.btPrevious = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\pagesAdmin\ManageDoctors.xaml"
            this.btPrevious.Click += new System.Windows.RoutedEventHandler(this.btPrevious_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btNext = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\pagesAdmin\ManageDoctors.xaml"
            this.btNext.Click += new System.Windows.RoutedEventHandler(this.btNext_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.btUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\pagesAdmin\ManageDoctors.xaml"
            this.btUpdate.Click += new System.Windows.RoutedEventHandler(this.btUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.btDelete = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\pagesAdmin\ManageDoctors.xaml"
            this.btDelete.Click += new System.Windows.RoutedEventHandler(this.btDelete_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.btAdd = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\pagesAdmin\ManageDoctors.xaml"
            this.btAdd.Click += new System.Windows.RoutedEventHandler(this.btAdd_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

