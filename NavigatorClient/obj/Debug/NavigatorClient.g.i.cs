﻿#pragma checksum "..\..\NavigatorClient.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76D038673E5F6177AFA39656B8AAE178E18677F7"
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
        
        
        #line 42 "..\..\NavigatorClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem Local;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\NavigatorClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label localFilesLabel;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\NavigatorClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button localTop;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\NavigatorClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox localFiles;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\NavigatorClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button localUp;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\NavigatorClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox localDirs;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\NavigatorClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoteTop;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\NavigatorClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox remoteFiles;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\NavigatorClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoteUp;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\NavigatorClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox remoteDirs;
        
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
            System.Uri resourceLocater = new System.Uri("/NavigatorClient;component/navigatorclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NavigatorClient.xaml"
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
            
            #line 8 "..\..\NavigatorClient.xaml"
            ((Navigator.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
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
            
            #line 65 "..\..\NavigatorClient.xaml"
            this.localTop.Click += new System.Windows.RoutedEventHandler(this.localTop_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.localFiles = ((System.Windows.Controls.ListBox)(target));
            
            #line 67 "..\..\NavigatorClient.xaml"
            this.localFiles.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.localFiles_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.localUp = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\NavigatorClient.xaml"
            this.localUp.Click += new System.Windows.RoutedEventHandler(this.localUp_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.localDirs = ((System.Windows.Controls.ListBox)(target));
            
            #line 83 "..\..\NavigatorClient.xaml"
            this.localDirs.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.localDirs_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RemoteTop = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\NavigatorClient.xaml"
            this.RemoteTop.Click += new System.Windows.RoutedEventHandler(this.RemoteTop_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.remoteFiles = ((System.Windows.Controls.ListBox)(target));
            
            #line 97 "..\..\NavigatorClient.xaml"
            this.remoteFiles.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.remoteFiles_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.RemoteUp = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\NavigatorClient.xaml"
            this.RemoteUp.Click += new System.Windows.RoutedEventHandler(this.RemoteUp_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.remoteDirs = ((System.Windows.Controls.ListBox)(target));
            
            #line 113 "..\..\NavigatorClient.xaml"
            this.remoteDirs.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.remoteDirs_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

