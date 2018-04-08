﻿#pragma checksum "..\..\Patient.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4CC9A44C8904B15801AF99A2D311B47F0C91C906"
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
    /// Patient
    /// </summary>
    public partial class Patient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Patient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btMyDetail;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Patient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btTakeAppointment;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Patient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btViewMyAppointments;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Patient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btLogout;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Patient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FramePatient;
        
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
            System.Uri resourceLocater = new System.Uri("/Clinic;component/patient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Patient.xaml"
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
            this.btMyDetail = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Patient.xaml"
            this.btMyDetail.Click += new System.Windows.RoutedEventHandler(this.btMyDetail_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btTakeAppointment = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Patient.xaml"
            this.btTakeAppointment.Click += new System.Windows.RoutedEventHandler(this.btTakeAppointment_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btViewMyAppointments = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Patient.xaml"
            this.btViewMyAppointments.Click += new System.Windows.RoutedEventHandler(this.btViewMyAppointments_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btLogout = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Patient.xaml"
            this.btLogout.Click += new System.Windows.RoutedEventHandler(this.btLogout_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FramePatient = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

