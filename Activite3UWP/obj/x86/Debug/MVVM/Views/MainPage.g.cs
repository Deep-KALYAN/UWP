﻿#pragma checksum "C:\Users\cda5kaly\source\repos\Activite3UWP\Activite3UWP\MVVM\Views\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "895003B9BE74B9A50742154B480427C987ABF58CD19E988EC03D3EBE6F4348D4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Activite3UWP
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // MVVM\Views\MainPage.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loading += this.Page_Loading;
                }
                break;
            case 2: // MVVM\Views\MainPage.xaml line 59
                {
                    this.TB0 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.TB0).Tapped += this.TextBlockRubric_Tapped;
                }
                break;
            case 3: // MVVM\Views\MainPage.xaml line 62
                {
                    this.MySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 4: // MVVM\Views\MainPage.xaml line 144
                {
                    this.PageContent1 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5: // MVVM\Views\MainPage.xaml line 147
                {
                    this.mainRow1Colum0 = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 6: // MVVM\Views\MainPage.xaml line 148
                {
                    this.mainRow1Colum1 = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 7: // MVVM\Views\MainPage.xaml line 149
                {
                    this.mainRow1Colum2 = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 8: // MVVM\Views\MainPage.xaml line 158
                {
                    this.FrameTopics = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 9: // MVVM\Views\MainPage.xaml line 213
                {
                    this.FrameReplies = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 10: // MVVM\Views\MainPage.xaml line 254
                {
                    this.FrameHome = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 11: // MVVM\Views\MainPage.xaml line 217
                {
                    this.lstReplies = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 20: // MVVM\Views\MainPage.xaml line 164
                {
                    this.lstTopics = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.lstTopics).ItemClick += this.lstTopics_ItemClick;
                }
                break;
            case 23: // MVVM\Views\MainPage.xaml line 71
                {
                    this.IconsListBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.IconsListBox).SelectionChanged += this.IconsListBox_SelectionChanged;
                }
                break;
            case 24: // MVVM\Views\MainPage.xaml line 80
                {
                    this.Developement1 = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 25: // MVVM\Views\MainPage.xaml line 93
                {
                    this.Developement2 = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 26: // MVVM\Views\MainPage.xaml line 103
                {
                    this.Developement3 = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 27: // MVVM\Views\MainPage.xaml line 113
                {
                    this.Developement4 = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 28: // MVVM\Views\MainPage.xaml line 123
                {
                    this.Developement5 = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 29: // MVVM\Views\MainPage.xaml line 131
                {
                    this.TB5 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 30: // MVVM\Views\MainPage.xaml line 120
                {
                    this.TB4 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 31: // MVVM\Views\MainPage.xaml line 110
                {
                    this.TB3 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 32: // MVVM\Views\MainPage.xaml line 100
                {
                    this.TB2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 33: // MVVM\Views\MainPage.xaml line 88
                {
                    this.TB1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 34: // MVVM\Views\MainPage.xaml line 30
                {
                    this.ImaIcon = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 35: // MVVM\Views\MainPage.xaml line 32
                {
                    this.HomeButton = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.HomeButton).Click += this.HomeButton_Click;
                }
                break;
            case 36: // MVVM\Views\MainPage.xaml line 48
                {
                    this.AMIO = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.AMIO).Tapped += this.TextBlockAMIO_Tapped;
                }
                break;
            case 37: // MVVM\Views\MainPage.xaml line 50
                {
                    this.Voice = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.Voice).Click += this.Speech_Click;
                }
                break;
            case 38: // MVVM\Views\MainPage.xaml line 52
                {
                    this.EnLangButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.EnLangButton).Click += this.LanguageRadioButton_Click;
                }
                break;
            case 39: // MVVM\Views\MainPage.xaml line 53
                {
                    this.FrLangButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.FrLangButton).Click += this.LanguageRadioButton_Click;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

