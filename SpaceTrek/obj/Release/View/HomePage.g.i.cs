﻿#pragma checksum "E:\Work\Pribadi\NASA\SpaceTrek\SpaceTrek\View\HomePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4A5F6A080027008B92B84937CB3F4EE7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
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


namespace SpaceTrek {
    
    
    public partial class HomePage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Image imgLogo;
        
        internal System.Windows.Controls.TextBlock txtDays;
        
        internal System.Windows.Controls.TextBlock txtHours;
        
        internal System.Windows.Controls.TextBlock txtMinutes;
        
        internal System.Windows.Controls.TextBlock txtSeconds;
        
        internal System.Windows.Controls.TextBlock txtDistance;
        
        internal System.Windows.Controls.TextBlock txtName;
        
        internal System.Windows.Controls.TextBlock txtDesc;
        
        internal System.Windows.Controls.Button btnRecord;
        
        internal System.Windows.Controls.Button btnAll;
        
        internal System.Windows.Controls.Button btnAll_Copy;
        
        internal System.Windows.Controls.Button btnAllCalendar;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SpaceTrek;component/View/HomePage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.imgLogo = ((System.Windows.Controls.Image)(this.FindName("imgLogo")));
            this.txtDays = ((System.Windows.Controls.TextBlock)(this.FindName("txtDays")));
            this.txtHours = ((System.Windows.Controls.TextBlock)(this.FindName("txtHours")));
            this.txtMinutes = ((System.Windows.Controls.TextBlock)(this.FindName("txtMinutes")));
            this.txtSeconds = ((System.Windows.Controls.TextBlock)(this.FindName("txtSeconds")));
            this.txtDistance = ((System.Windows.Controls.TextBlock)(this.FindName("txtDistance")));
            this.txtName = ((System.Windows.Controls.TextBlock)(this.FindName("txtName")));
            this.txtDesc = ((System.Windows.Controls.TextBlock)(this.FindName("txtDesc")));
            this.btnRecord = ((System.Windows.Controls.Button)(this.FindName("btnRecord")));
            this.btnAll = ((System.Windows.Controls.Button)(this.FindName("btnAll")));
            this.btnAll_Copy = ((System.Windows.Controls.Button)(this.FindName("btnAll_Copy")));
            this.btnAllCalendar = ((System.Windows.Controls.Button)(this.FindName("btnAllCalendar")));
        }
    }
}
