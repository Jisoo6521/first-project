﻿#pragma checksum "..\..\..\UC\UCRoomList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CA89B666F3184D867A81387099D5061E"
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


namespace DormitoryManagement.UC {
    
    
    /// <summary>
    /// UCRoomList
    /// </summary>
    public partial class UCRoomList : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\..\UC\UCRoomList.xaml"
        internal DormitoryManagement.UC.UCRoomList WindowRoomList;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\UC\UCRoomList.xaml"
        internal System.Windows.Controls.ListView lvRoomList;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\UC\UCRoomList.xaml"
        internal System.Windows.Controls.Button btAddRoom;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\UC\UCRoomList.xaml"
        internal System.Windows.Controls.Button btEditRoom;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\UC\UCRoomList.xaml"
        internal System.Windows.Controls.Button btDeleteRoom;
        
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
            System.Uri resourceLocater = new System.Uri("/DormitoryManagement;component/uc/ucroomlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UC\UCRoomList.xaml"
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
            this.WindowRoomList = ((DormitoryManagement.UC.UCRoomList)(target));
            
            #line 5 "..\..\..\UC\UCRoomList.xaml"
            this.WindowRoomList.Loaded += new System.Windows.RoutedEventHandler(this.WindowRoomList_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lvRoomList = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.btAddRoom = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\UC\UCRoomList.xaml"
            this.btAddRoom.Click += new System.Windows.RoutedEventHandler(this.btAddRoom_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btEditRoom = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\UC\UCRoomList.xaml"
            this.btEditRoom.Click += new System.Windows.RoutedEventHandler(this.btEditRoom_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btDeleteRoom = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\UC\UCRoomList.xaml"
            this.btDeleteRoom.Click += new System.Windows.RoutedEventHandler(this.btDeleteRoom_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
