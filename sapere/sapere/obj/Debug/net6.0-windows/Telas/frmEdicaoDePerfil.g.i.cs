﻿#pragma checksum "..\..\..\..\Telas\frmEdicaoDePerfil.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FBCE1A3ECD4D84848C0C72965A8E5E1CF0E92399"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

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
using sapere.View;


namespace sapere.View {
    
    
    /// <summary>
    /// frmEdicaoDePerfil
    /// </summary>
    public partial class frmEdicaoDePerfil : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\Telas\frmEdicaoDePerfil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgFundoEdicaoDePerfil;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Telas\frmEdicaoDePerfil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtInformacao;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Telas\frmEdicaoDePerfil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox boxNome;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Telas\frmEdicaoDePerfil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox boxEmail;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Telas\frmEdicaoDePerfil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock btnVoltar;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Telas\frmEdicaoDePerfil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock btnAtualizarPerfil;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Telas\frmEdicaoDePerfil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox boxSenha;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Telas\frmEdicaoDePerfil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox boxConfirmarSenha;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/sapere.View;V1.0.0.0;component/telas/frmedicaodeperfil.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Telas\frmEdicaoDePerfil.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.imgFundoEdicaoDePerfil = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.txtInformacao = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.boxNome = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.boxEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnVoltar = ((System.Windows.Controls.TextBlock)(target));
            
            #line 34 "..\..\..\..\Telas\frmEdicaoDePerfil.xaml"
            this.btnVoltar.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.PressionarBtnVoltar);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAtualizarPerfil = ((System.Windows.Controls.TextBlock)(target));
            
            #line 35 "..\..\..\..\Telas\frmEdicaoDePerfil.xaml"
            this.btnAtualizarPerfil.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.PressionarBtnAtualizarPerfil);
            
            #line default
            #line hidden
            return;
            case 7:
            this.boxSenha = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 8:
            this.boxConfirmarSenha = ((System.Windows.Controls.PasswordBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

