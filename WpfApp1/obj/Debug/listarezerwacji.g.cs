﻿#pragma checksum "..\..\listarezerwacji.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "44B92D715C21DCF92E5E74D4A3A6978454A047CE675657E447E731E58030BFDB"
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// listarezerwacji
    /// </summary>
    public partial class listarezerwacji : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\listarezerwacji.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LstRezerwacje;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\listarezerwacji.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPokaz;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\listarezerwacji.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnWszystkie;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\listarezerwacji.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtimie;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\listarezerwacji.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtnazwisko;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\listarezerwacji.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtod;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\listarezerwacji.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtdo;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\listarezerwacji.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbSala;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\listarezerwacji.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDodaj;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\listarezerwacji.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUsun;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\listarezerwacji.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbSala_1;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/listarezerwacji.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\listarezerwacji.xaml"
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
            this.LstRezerwacje = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.BtnPokaz = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\listarezerwacji.xaml"
            this.BtnPokaz.Click += new System.Windows.RoutedEventHandler(this.BtnPokaz_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnWszystkie = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\listarezerwacji.xaml"
            this.BtnWszystkie.Click += new System.Windows.RoutedEventHandler(this.BtnWszystkie_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtimie = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtnazwisko = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtod = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtdo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.CmbSala = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.BtnDodaj = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\listarezerwacji.xaml"
            this.BtnDodaj.Click += new System.Windows.RoutedEventHandler(this.BtnDodaj_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnUsun = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\listarezerwacji.xaml"
            this.BtnUsun.Click += new System.Windows.RoutedEventHandler(this.BtnUsun_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.CmbSala_1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

