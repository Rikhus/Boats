﻿#pragma checksum "..\..\registerPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C8565279954CF8F4D88576854CE5CEBEC8680393"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MyProg;
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


namespace MyProg {
    
    
    /// <summary>
    /// registerPage
    /// </summary>
    public partial class registerPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 215 "..\..\registerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblHeader;
        
        #line default
        #line hidden
        
        
        #line 223 "..\..\registerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLogin;
        
        #line default
        #line hidden
        
        
        #line 226 "..\..\registerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLastName;
        
        #line default
        #line hidden
        
        
        #line 229 "..\..\registerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFirstName;
        
        #line default
        #line hidden
        
        
        #line 233 "..\..\registerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPass;
        
        #line default
        #line hidden
        
        
        #line 236 "..\..\registerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassRepeat;
        
        #line default
        #line hidden
        
        
        #line 238 "..\..\registerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePicker;
        
        #line default
        #line hidden
        
        
        #line 240 "..\..\registerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbPrivileges;
        
        #line default
        #line hidden
        
        
        #line 247 "..\..\registerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbSex;
        
        #line default
        #line hidden
        
        
        #line 253 "..\..\registerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegister;
        
        #line default
        #line hidden
        
        
        #line 254 "..\..\registerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblIsValid;
        
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
            System.Uri resourceLocater = new System.Uri("/MyProg;component/registerpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\registerPage.xaml"
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
            this.lblHeader = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.txtLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtPass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.txtPassRepeat = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.datePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.cmbPrivileges = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.cmbSex = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.btnRegister = ((System.Windows.Controls.Button)(target));
            
            #line 253 "..\..\registerPage.xaml"
            this.btnRegister.Click += new System.Windows.RoutedEventHandler(this.BtnRegister_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.lblIsValid = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

