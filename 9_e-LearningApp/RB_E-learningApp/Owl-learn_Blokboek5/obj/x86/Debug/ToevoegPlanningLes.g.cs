﻿#pragma checksum "D:\School\Gitblub\Visual Studios\2\RB_E-learningApp\Owl-learn_Blokboek5\ToevoegPlanningLes.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ED5F56BE078BF9B396D80EA70489368C"
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
    partial class ToevoegPlanningLes : 
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
                    this.btOpslaan = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 64 "..\..\..\ToevoegPlanningLes.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btOpslaan).Click += this.btOpslaan_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.dpDatum = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 3:
                {
                    this.cbVak = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 71 "..\..\..\ToevoegPlanningLes.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cbVak).SelectionChanged += this.cbVak_SelectionChanged;
                    #line default
                }
                break;
            case 4:
                {
                    this.cbLO = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 72 "..\..\..\ToevoegPlanningLes.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cbLO).SelectionChanged += this.cbLO_SelectionChanged;
                    #line default
                }
                break;
            case 5:
                {
                    this.cbLes = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 6:
                {
                    this.btLogout = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 39 "..\..\..\ToevoegPlanningLes.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.btLogout).Tapped += this.btLogout_Tapped;
                    #line default
                }
                break;
            case 7:
                {
                    this.btTerug = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\ToevoegPlanningLes.xaml"
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

