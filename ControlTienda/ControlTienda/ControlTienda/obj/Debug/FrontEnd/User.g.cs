﻿#pragma checksum "..\..\..\FrontEnd\User.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A3E1FEA6403B732FA2812DEBF408003158027F1C82A703290BC84343AB8EA104"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ControlTienda.FrontEnd;
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


namespace ControlTienda.FrontEnd {
    
    
    /// <summary>
    /// User
    /// </summary>
    public partial class User : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 22 "..\..\..\FrontEnd\User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbName;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\FrontEnd\User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbAddress;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\FrontEnd\User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbPhone;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\FrontEnd\User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbNickName;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\FrontEnd\User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox TbPassword;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\FrontEnd\User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbRol;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\FrontEnd\User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOk;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\FrontEnd\User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddRol;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\FrontEnd\User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgUsers;
        
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
            System.Uri resourceLocater = new System.Uri("/ControlTienda;component/frontend/user.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FrontEnd\User.xaml"
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
            this.TbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TbAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TbPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TbNickName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TbPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.CbRol = ((System.Windows.Controls.ComboBox)(target));
            
            #line 33 "..\..\..\FrontEnd\User.xaml"
            this.CbRol.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbRol_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnOk = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\FrontEnd\User.xaml"
            this.BtnOk.Click += new System.Windows.RoutedEventHandler(this.BtnOk_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnAddRol = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\FrontEnd\User.xaml"
            this.BtnAddRol.Click += new System.Windows.RoutedEventHandler(this.BtnAddRol_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DgUsers = ((System.Windows.Controls.DataGrid)(target));
            
            #line 48 "..\..\..\FrontEnd\User.xaml"
            this.DgUsers.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DgUsers_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 10:
            
            #line 60 "..\..\..\FrontEnd\User.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEliminar_Click);
            
            #line default
            #line hidden
            break;
            case 11:
            
            #line 61 "..\..\..\FrontEnd\User.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnUpdate_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

