﻿#pragma checksum "..\..\Settings.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EA207CF533F2119E0F86669E77427733AA42BE1CAFE503FFD2563D32D5130A2A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NewTicketWPF;
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


namespace NewTicketWPF {
    
    
    /// <summary>
    /// Settings
    /// </summary>
    public partial class Settings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ProfileBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PRenameBtn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RenameField;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProfileInput;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TTypeCB;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TMaximumAmount;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewProfileBtn;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button okBtn;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelBtn;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button applyBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/NewTicketWPF;component/settings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Settings.xaml"
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
            this.ProfileBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.PRenameBtn = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Settings.xaml"
            this.PRenameBtn.Click += new System.Windows.RoutedEventHandler(this.ProfileRename);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RenameField = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\Settings.xaml"
            this.RenameField.KeyDown += new System.Windows.Input.KeyEventHandler(this.RenameField_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ProfileInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TTypeCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.TMaximumAmount = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.NewProfileBtn = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\Settings.xaml"
            this.NewProfileBtn.Click += new System.Windows.RoutedEventHandler(this.CreateNewProfile);
            
            #line default
            #line hidden
            return;
            case 8:
            this.okBtn = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\Settings.xaml"
            this.okBtn.Click += new System.Windows.RoutedEventHandler(this.OK_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cancelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\Settings.xaml"
            this.cancelBtn.Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.applyBtn = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\Settings.xaml"
            this.applyBtn.Click += new System.Windows.RoutedEventHandler(this.Apply_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

