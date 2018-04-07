﻿#pragma checksum "..\..\Admin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4A1B6855D4842DEF6577C1710385EA2057509CFB"
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
    /// Admin
    /// </summary>
    public partial class Admin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btManageDoctors;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btManagePatients;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btManageAppointments;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btManageTimeSlots;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btLogout;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrameAdmin;
        
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
            System.Uri resourceLocater = new System.Uri("/Clinic;component/admin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Admin.xaml"
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
            this.btManageDoctors = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Admin.xaml"
            this.btManageDoctors.Click += new System.Windows.RoutedEventHandler(this.btManageDoctors_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btManagePatients = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Admin.xaml"
            this.btManagePatients.Click += new System.Windows.RoutedEventHandler(this.btManagePatients_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btManageAppointments = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Admin.xaml"
            this.btManageAppointments.Click += new System.Windows.RoutedEventHandler(this.btManageAppointments_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btManageTimeSlots = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Admin.xaml"
            this.btManageTimeSlots.Click += new System.Windows.RoutedEventHandler(this.btManageTimeSlots_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btLogout = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Admin.xaml"
            this.btLogout.Click += new System.Windows.RoutedEventHandler(this.btLogout_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.FrameAdmin = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

