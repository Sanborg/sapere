#pragma checksum "..\..\..\..\Telas\frmInsercaoCodigo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D7212B5C43DE097BE3BE17820E08EE2F6A8F2E65"
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
    /// frmInsercaoCodigo
    /// </summary>
    public partial class frmInsercaoCodigo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Telas\frmInsercaoCodigo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgFundoInsercaoCodigo;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Telas\frmInsercaoCodigo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox boxCodigoDeRecuperacao;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Telas\frmInsercaoCodigo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock btnOk;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Telas\frmInsercaoCodigo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtCadastro;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Telas\frmInsercaoCodigo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock btnOk_Copy;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/sapere.View;component/telas/frminsercaocodigo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Telas\frmInsercaoCodigo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.imgFundoInsercaoCodigo = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.boxCodigoDeRecuperacao = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnOk = ((System.Windows.Controls.TextBlock)(target));
            
            #line 16 "..\..\..\..\Telas\frmInsercaoCodigo.xaml"
            this.btnOk.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.PressionarBtnOk);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtCadastro = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.btnOk_Copy = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

