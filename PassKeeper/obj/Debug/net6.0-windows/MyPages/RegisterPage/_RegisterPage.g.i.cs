﻿#pragma checksum "..\..\..\..\..\MyPages\RegisterPage\_RegisterPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "720DA202CA4BCD8B663C2DD19DF462483BBC9186"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PassKeeper.MyPages.RegisterPage;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace PassKeeper.MyPages.RegisterPage {
    
    
    /// <summary>
    /// _RegisterPage
    /// </summary>
    public partial class _RegisterPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\..\MyPages\RegisterPage\_RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstname_txtbox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\MyPages\RegisterPage\_RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lastname_txtbox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\MyPages\RegisterPage\_RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox email_txtbox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\MyPages\RegisterPage\_RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button signin_btn;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\MyPages\RegisterPage\_RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back_btn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PassKeeper;component/mypages/registerpage/_registerpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\MyPages\RegisterPage\_RegisterPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.firstname_txtbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\..\..\MyPages\RegisterPage\_RegisterPage.xaml"
            this.firstname_txtbox.MouseEnter += new System.Windows.Input.MouseEventHandler(this.firstname_txtbox_MouseEnter);
            
            #line default
            #line hidden
            
            #line 18 "..\..\..\..\..\MyPages\RegisterPage\_RegisterPage.xaml"
            this.firstname_txtbox.MouseLeave += new System.Windows.Input.MouseEventHandler(this.firstname_txtbox_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lastname_txtbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\..\..\MyPages\RegisterPage\_RegisterPage.xaml"
            this.lastname_txtbox.MouseEnter += new System.Windows.Input.MouseEventHandler(this.lastname_txtbox_MouseEnter);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\..\..\MyPages\RegisterPage\_RegisterPage.xaml"
            this.lastname_txtbox.MouseLeave += new System.Windows.Input.MouseEventHandler(this.lastname_txtbox_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.email_txtbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\..\..\MyPages\RegisterPage\_RegisterPage.xaml"
            this.email_txtbox.MouseEnter += new System.Windows.Input.MouseEventHandler(this.email_txtbox_MouseEnter);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\..\..\MyPages\RegisterPage\_RegisterPage.xaml"
            this.email_txtbox.MouseLeave += new System.Windows.Input.MouseEventHandler(this.email_txtbox_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.signin_btn = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\..\MyPages\RegisterPage\_RegisterPage.xaml"
            this.signin_btn.Click += new System.Windows.RoutedEventHandler(this.signin_btn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.back_btn = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\..\MyPages\RegisterPage\_RegisterPage.xaml"
            this.back_btn.Click += new System.Windows.RoutedEventHandler(this.back_btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
