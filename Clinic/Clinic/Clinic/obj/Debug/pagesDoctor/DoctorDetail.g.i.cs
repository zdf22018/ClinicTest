﻿#pragma checksum "..\..\..\pagesDoctor\DoctorDetail.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9CF4D4DAB657A1B068A4AD58C064D7AA9489624B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Clinic;
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


namespace Clinic {
    
    
    /// <summary>
    /// DoctorDetail
    /// </summary>
    public partial class DoctorDetail : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\pagesDoctor\DoctorDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btUpdate;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\pagesDoctor\DoctorDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridDoctorDetail;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\pagesDoctor\DoctorDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox emailTextBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\pagesDoctor\DoctorDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\pagesDoctor\DoctorDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fullNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\pagesDoctor\DoctorDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label idLabel;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\pagesDoctor\DoctorDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lastNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\pagesDoctor\DoctorDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginPassWordTextBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\pagesDoctor\DoctorDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phoneTextBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\pagesDoctor\DoctorDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox specialityTextBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\pagesDoctor\DoctorDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userNameTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Clinic;component/pagesdoctor/doctordetail.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pagesDoctor\DoctorDetail.xaml"
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
            
            #line 10 "..\..\..\pagesDoctor\DoctorDetail.xaml"
            ((Clinic.DoctorDetail)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\pagesDoctor\DoctorDetail.xaml"
            this.btUpdate.Click += new System.Windows.RoutedEventHandler(this.btUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.gridDoctorDetail = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.emailTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.firstNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.fullNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.idLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lastNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.loginPassWordTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.phoneTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.specialityTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.userNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

