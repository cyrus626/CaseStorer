﻿#pragma checksum "..\..\..\ViewModels\AppMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5D9250CB19FDC05D7F82476CA9DBA3E2C4C088B963E20B8D2A28C79645D6C75E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EFCC.ViewModels;
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


namespace EFCC.ViewModels {
    
    
    /// <summary>
    /// AppMenu
    /// </summary>
    public partial class AppMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\ViewModels\AppMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewCase;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\ViewModels\AppMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ViewCase;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\ViewModels\AppMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateCase;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\ViewModels\AppMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox CaseList;
        
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
            System.Uri resourceLocater = new System.Uri("/EFCC;component/viewmodels/appmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ViewModels\AppMenu.xaml"
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
            this.NewCase = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\ViewModels\AppMenu.xaml"
            this.NewCase.Click += new System.Windows.RoutedEventHandler(this.NewCase_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ViewCase = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\ViewModels\AppMenu.xaml"
            this.ViewCase.Click += new System.Windows.RoutedEventHandler(this.ViewCase_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UpdateCase = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\ViewModels\AppMenu.xaml"
            this.UpdateCase.Click += new System.Windows.RoutedEventHandler(this.UpdateCase_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CaseList = ((System.Windows.Controls.ListBox)(target));
            
            #line 47 "..\..\..\ViewModels\AppMenu.xaml"
            this.CaseList.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.CaseList_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

