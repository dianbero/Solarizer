﻿#pragma checksum "C:\Users\dianb\Desktop\Solarizr_Diana\Última modificación Diana\Solarizer\Solarizr\Solarizr\Login.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A98A7630A214F808D97EAC144B59E9D8"
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
    partial class Login : 
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
            case 2: // Login.xaml line 11
                {
                    this.panelLogin = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3: // Login.xaml line 13
                {
                    this.lblLogin = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Login.xaml line 15
                {
                    this.txtUsuario = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Login.xaml line 16
                {
                    this.txtContraseña = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 6: // Login.xaml line 17
                {
                    this.btnEntrar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnEntrar).Click += this.BtnEntrar_Click;
                }
                break;
            case 7: // Login.xaml line 18
                {
                    this.lblOvidasteContraseña = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

