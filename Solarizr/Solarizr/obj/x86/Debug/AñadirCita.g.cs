﻿#pragma checksum "C:\Users\vmperez\Documents\GitHub\Solarizer\Solarizr\Solarizr\AñadirCita.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F51726DC2479371812712BB74579E74E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Solarizr
{
    partial class AñadirCita : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // AñadirCita.xaml line 43
                {
                    this.grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // AñadirCita.xaml line 65
                {
                    this.panelCentrado = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4: // AñadirCita.xaml line 66
                {
                    this.textNombre = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // AñadirCita.xaml line 67
                {
                    this.textDireccion = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // AñadirCita.xaml line 68
                {
                    this.textFecha = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // AñadirCita.xaml line 69
                {
                    this.txtbox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // AñadirCita.xaml line 70
                {
                    this.btnGuardar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnGuardar).Click += this.btnGuardar_Click;
                }
                break;
            case 9: // AñadirCita.xaml line 53
                {
                    this.appbtnCarpetaImagenes = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.appbtnCarpetaImagenes).Click += this.AppbtnCarpetaImagenes_Click;
                }
                break;
            case 10: // AñadirCita.xaml line 58
                {
                    this.appbtnLocalizacion = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

