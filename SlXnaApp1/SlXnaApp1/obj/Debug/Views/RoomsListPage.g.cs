﻿#pragma checksum "C:\WinRepo\App1\SlXnaApp1\SlXnaApp1\SlXnaApp1\Views\RoomsListPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E98199DC6F8CC42C5B66B6A98E87E207"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SlXnaApp1 {
    
    
    public partial class RoomsListPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.ListBox listBox1;
        
        internal System.Windows.Controls.TextBlock txt_Result;
        
        internal System.Windows.Controls.Button btn_CreateRoom;
        
        internal System.Windows.Controls.Button btn_Refresh;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SlXnaApp1;component/Views/RoomsListPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.listBox1 = ((System.Windows.Controls.ListBox)(this.FindName("listBox1")));
            this.txt_Result = ((System.Windows.Controls.TextBlock)(this.FindName("txt_Result")));
            this.btn_CreateRoom = ((System.Windows.Controls.Button)(this.FindName("btn_CreateRoom")));
            this.btn_Refresh = ((System.Windows.Controls.Button)(this.FindName("btn_Refresh")));
        }
    }
}

