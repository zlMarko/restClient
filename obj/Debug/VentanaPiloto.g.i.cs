﻿#pragma checksum "..\..\VentanaPiloto.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "998D5E22829AF43469789EB116D9859E1211AE30D6031192973B8103C7CFEDAE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
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


namespace AeronauticaCliente {
    
    
    /// <summary>
    /// VentanaPiloto
    /// </summary>
    public partial class VentanaPiloto : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\VentanaPiloto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile NombrePiloto;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\VentanaPiloto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile ApellidoPiloto;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\VentanaPiloto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile HoraVueloA;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\VentanaPiloto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile HoraVueloE;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\VentanaPiloto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridAeronaves;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\VentanaPiloto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Registra_vuelo_boton;
        
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
            System.Uri resourceLocater = new System.Uri("/AeronauticaCliente;component/ventanapiloto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VentanaPiloto.xaml"
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
            
            #line 16 "..\..\VentanaPiloto.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Consulta_Horas_Vuelo);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NombrePiloto = ((MahApps.Metro.Controls.Tile)(target));
            return;
            case 3:
            this.ApellidoPiloto = ((MahApps.Metro.Controls.Tile)(target));
            return;
            case 4:
            this.HoraVueloA = ((MahApps.Metro.Controls.Tile)(target));
            return;
            case 5:
            this.HoraVueloE = ((MahApps.Metro.Controls.Tile)(target));
            return;
            case 6:
            
            #line 28 "..\..\VentanaPiloto.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Consulta_Aeronaves_Disponibles);
            
            #line default
            #line hidden
            return;
            case 7:
            this.GridAeronaves = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.Registra_vuelo_boton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\VentanaPiloto.xaml"
            this.Registra_vuelo_boton.Click += new System.Windows.RoutedEventHandler(this.Registra_vuelo);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 31 "..\..\VentanaPiloto.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
