﻿#pragma checksum "..\..\..\..\MVVM\View\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DF7E7CB4FCB112F837A69467DC49695483B43DC4F6FA7C55E939E322E3FDCD2F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using System.Windows.Shell;
using login_screen;


namespace login_screen {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\MVVM\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinisize;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\MVVM\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\MVVM\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_email;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\MVVM\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_passwordun;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\MVVM\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txt_pass;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\..\MVVM\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image eye;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\..\MVVM\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image eyeopen;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\..\MVVM\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock fgtxt;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\..\MVVM\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border bolderlogin;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\..\..\MVVM\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock signup;
        
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
            System.Uri resourceLocater = new System.Uri("/login screen;component/mvvm/view/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM\View\MainWindow.xaml"
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
            
            #line 10 "..\..\..\..\MVVM\View\MainWindow.xaml"
            ((login_screen.MainWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnMinisize = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\MVVM\View\MainWindow.xaml"
            this.btnMinisize.Click += new System.Windows.RoutedEventHandler(this.btnMinisize_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\..\MVVM\View\MainWindow.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txt_email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_passwordun = ((System.Windows.Controls.TextBox)(target));
            
            #line 120 "..\..\..\..\MVVM\View\MainWindow.xaml"
            this.txt_passwordun.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_passwordun_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txt_pass = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 123 "..\..\..\..\MVVM\View\MainWindow.xaml"
            this.txt_pass.PasswordChanged += new System.Windows.RoutedEventHandler(this.txt_pass_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.eye = ((System.Windows.Controls.Image)(target));
            
            #line 125 "..\..\..\..\MVVM\View\MainWindow.xaml"
            this.eye.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.eye_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.eyeopen = ((System.Windows.Controls.Image)(target));
            
            #line 130 "..\..\..\..\MVVM\View\MainWindow.xaml"
            this.eyeopen.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.eyeopen_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 148 "..\..\..\..\MVVM\View\MainWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.fgtxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.bolderlogin = ((System.Windows.Controls.Border)(target));
            
            #line 170 "..\..\..\..\MVVM\View\MainWindow.xaml"
            this.bolderlogin.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Border_MouseEnter);
            
            #line default
            #line hidden
            
            #line 170 "..\..\..\..\MVVM\View\MainWindow.xaml"
            this.bolderlogin.MouseLeave += new System.Windows.Input.MouseEventHandler(this.bolderlogin_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 12:
            this.signup = ((System.Windows.Controls.TextBlock)(target));
            
            #line 185 "..\..\..\..\MVVM\View\MainWindow.xaml"
            this.signup.MouseEnter += new System.Windows.Input.MouseEventHandler(this.TextBlock_MouseEnter_1);
            
            #line default
            #line hidden
            
            #line 185 "..\..\..\..\MVVM\View\MainWindow.xaml"
            this.signup.MouseLeave += new System.Windows.Input.MouseEventHandler(this.signup_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

