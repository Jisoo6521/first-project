﻿#pragma checksum "..\..\..\Windows\WindowEditStatus.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A60AA5F3A035360542482F4B81847F83"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace DormitoryManagement.Windows {
    
    
    /// <summary>
    /// WindowEditStatus
    /// </summary>
    public partial class WindowEditStatus : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\Windows\WindowEditStatus.xaml"
        internal System.Windows.Controls.Label lbStatusName;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\Windows\WindowEditStatus.xaml"
        internal System.Windows.Controls.TextBox tbStatus;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\Windows\WindowEditStatus.xaml"
        internal System.Windows.Controls.Button btOk;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Windows\WindowEditStatus.xaml"
        internal System.Windows.Controls.Button btBack;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Windows\WindowEditStatus.xaml"
        internal System.Windows.Controls.Label lbStatusID;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DormitoryManagement;component/windows/windoweditstatus.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\WindowEditStatus.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 4 "..\..\..\Windows\WindowEditStatus.xaml"
            ((DormitoryManagement.Windows.WindowEditStatus)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lbStatusName = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.tbStatus = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btOk = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\Windows\WindowEditStatus.xaml"
            this.btOk.Click += new System.Windows.RoutedEventHandler(this.btOk_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btBack = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Windows\WindowEditStatus.xaml"
            this.btBack.Click += new System.Windows.RoutedEventHandler(this.btBack_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lbStatusID = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}