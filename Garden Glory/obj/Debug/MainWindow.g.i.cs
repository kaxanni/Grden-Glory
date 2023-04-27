﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3E8A56111DC25133995FB13194DEE1E27EC75E11E435817EEF7A8ADAB7DA0E51"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Garden_Glory;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Garden_Glory {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox DemoItemsListBox;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton MenuToggleButton;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back_btn;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button fwd_btn;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame navigation_frame;
        
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
            System.Uri resourceLocater = new System.Uri("/Garden Glory;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.DemoItemsListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 41 "..\..\MainWindow.xaml"
            this.DemoItemsListBox.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.UIElement_OnPreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 46 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.customer_selected);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 47 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.emplyee_selected);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 48 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.trainedemplyee_selected);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 49 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.equipment_selected);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 50 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.equipment_repair_selected);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 51 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.equipment_usage_selected);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 52 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.property_selected);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 53 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.service_selected);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 54 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.task_selected);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 55 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.payment_selected);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 56 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.account_selected);
            
            #line default
            #line hidden
            return;
            case 13:
            this.MenuToggleButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 14:
            this.back_btn = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\MainWindow.xaml"
            this.back_btn.Click += new System.Windows.RoutedEventHandler(this.back_btn_click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.fwd_btn = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\MainWindow.xaml"
            this.fwd_btn.Click += new System.Windows.RoutedEventHandler(this.fwd_btn_click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 103 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.home_click);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 110 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.logout_click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.navigation_frame = ((System.Windows.Controls.Frame)(target));
            
            #line 122 "..\..\MainWindow.xaml"
            this.navigation_frame.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.navigated_complete);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
