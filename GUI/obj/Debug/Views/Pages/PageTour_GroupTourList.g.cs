﻿#pragma checksum "..\..\..\..\Views\Pages\PageTour_GroupTourList.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0A1BFE6704D977258DA2DCC56C6135C4AC086E9F5C0BA1B5F7A48BDD2A945CCE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GUI.Views.Pages;
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


namespace GUI.Views.Pages {
    
    
    /// <summary>
    /// PageTour_GroupTourList
    /// </summary>
    public partial class PageTour_GroupTourList : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\Views\Pages\PageTour_GroupTourList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GUI.Views.Pages.PageTour_GroupTourList PgTourGroup;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Views\Pages\PageTour_GroupTourList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LbAll;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Views\Pages\PageTour_GroupTourList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LbOntrip;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Views\Pages\PageTour_GroupTourList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LbPlanning;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\Views\Pages\PageTour_GroupTourList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LbOver;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\..\Views\Pages\PageTour_GroupTourList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel WpTourGroupList;
        
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
            System.Uri resourceLocater = new System.Uri("/GUI;component/views/pages/pagetour_grouptourlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Pages\PageTour_GroupTourList.xaml"
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
            this.PgTourGroup = ((GUI.Views.Pages.PageTour_GroupTourList)(target));
            return;
            case 2:
            this.LbAll = ((System.Windows.Controls.Label)(target));
            
            #line 38 "..\..\..\..\Views\Pages\PageTour_GroupTourList.xaml"
            this.LbAll.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.LbAll_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LbOntrip = ((System.Windows.Controls.Label)(target));
            
            #line 54 "..\..\..\..\Views\Pages\PageTour_GroupTourList.xaml"
            this.LbOntrip.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.LbOntrip_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LbPlanning = ((System.Windows.Controls.Label)(target));
            
            #line 70 "..\..\..\..\Views\Pages\PageTour_GroupTourList.xaml"
            this.LbPlanning.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.LbPlanning_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LbOver = ((System.Windows.Controls.Label)(target));
            
            #line 86 "..\..\..\..\Views\Pages\PageTour_GroupTourList.xaml"
            this.LbOver.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.LbOver_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.WpTourGroupList = ((System.Windows.Controls.WrapPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
