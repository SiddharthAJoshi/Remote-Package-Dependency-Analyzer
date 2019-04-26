﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3896B21D554024C4FB394EC54BF76E5D0EC4351A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Navigator;
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


namespace Navigator {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem Local;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label localFilesLabel;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button localTop;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox localFiles;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button localUp;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox localDirs;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox FilesSelected;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ViewResults;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Tokens;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SemiExpressions;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TypeAnalysis;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DependencyAnalysis;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StrongComponent;
        
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
            System.Uri resourceLocater = new System.Uri("/NavigatorClient;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            
            #line 8 "..\..\MainWindow.xaml"
            ((Navigator.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 9 "..\..\MainWindow.xaml"
            ((Navigator.MainWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            
            #line 10 "..\..\MainWindow.xaml"
            ((Navigator.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.LoaderWindow);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Local = ((System.Windows.Controls.TabItem)(target));
            return;
            case 3:
            this.localFilesLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.localTop = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\MainWindow.xaml"
            this.localTop.Click += new System.Windows.RoutedEventHandler(this.localTop_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.localFiles = ((System.Windows.Controls.ListBox)(target));
            
            #line 70 "..\..\MainWindow.xaml"
            this.localFiles.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.localFiles_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.localUp = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\MainWindow.xaml"
            this.localUp.Click += new System.Windows.RoutedEventHandler(this.localUp_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.localDirs = ((System.Windows.Controls.ListBox)(target));
            
            #line 86 "..\..\MainWindow.xaml"
            this.localDirs.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.localDirs_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.FilesSelected = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this.ViewResults = ((System.Windows.Controls.ListBox)(target));
            return;
            case 10:
            this.Tokens = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\MainWindow.xaml"
            this.Tokens.Click += new System.Windows.RoutedEventHandler(this.Tokens_Event);
            
            #line default
            #line hidden
            return;
            case 11:
            this.SemiExpressions = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\MainWindow.xaml"
            this.SemiExpressions.Click += new System.Windows.RoutedEventHandler(this.SemiExpressions_Event);
            
            #line default
            #line hidden
            return;
            case 12:
            this.TypeAnalysis = ((System.Windows.Controls.Button)(target));
            
            #line 118 "..\..\MainWindow.xaml"
            this.TypeAnalysis.Click += new System.Windows.RoutedEventHandler(this.TypeAnalysis_Event);
            
            #line default
            #line hidden
            return;
            case 13:
            this.DependencyAnalysis = ((System.Windows.Controls.Button)(target));
            
            #line 120 "..\..\MainWindow.xaml"
            this.DependencyAnalysis.Click += new System.Windows.RoutedEventHandler(this.DependencyAnalysis_Event);
            
            #line default
            #line hidden
            return;
            case 14:
            this.StrongComponent = ((System.Windows.Controls.Button)(target));
            
            #line 122 "..\..\MainWindow.xaml"
            this.StrongComponent.Click += new System.Windows.RoutedEventHandler(this.StrongComponent_Event);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
