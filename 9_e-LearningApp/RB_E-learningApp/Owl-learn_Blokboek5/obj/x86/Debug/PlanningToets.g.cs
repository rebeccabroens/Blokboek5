﻿#pragma checksum "D:\School\Gitblub\Visual Studios\2\RB_E-learningApp\Owl-learn_Blokboek5\PlanningToets.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "57ADE22D26035187AC6B3CF8DDDBDF9D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Owl_learn_Blokboek5
{
    partial class PlanningToets : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.lbLeerlingen = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 61 "..\..\..\PlanningToets.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.lbLeerlingen).SelectionChanged += this.lbLeerlingen_SelectionChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.btNieuw = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 62 "..\..\..\PlanningToets.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btNieuw).Click += this.btNieuw_ClickAsync;
                    #line default
                }
                break;
            case 3:
                {
                    this.btVerwijder = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 63 "..\..\..\PlanningToets.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btVerwijder).Click += this.btVerwijder_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.lbPlanning = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 5:
                {
                    this.btLogout = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 39 "..\..\..\PlanningToets.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.btLogout).Tapped += this.btLogout_Tapped;
                    #line default
                }
                break;
            case 6:
                {
                    this.btTerug = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\PlanningToets.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btTerug).Click += this.Button_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

