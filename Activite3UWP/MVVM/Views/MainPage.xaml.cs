using Activite3UWP.MVVM.ViewsModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Activite3UWP
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private DataVM vm = new DataVM();
        public MainPage()
        {
            this.InitializeComponent();
            //Laison entre la view et le viewModel
            DataContext = vm;

            if (Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride == "en-US")
            {
                EnLangButton.IsChecked = true;
                FrLangButton.IsChecked = false;
            }
            else if (Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride == "fr-FR")
            {
                EnLangButton.IsChecked = false;
                FrLangButton.IsChecked = true;
            }
        }

        private bool speak = false;
        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

            if (Developement1.IsSelected)
            {
                ArrangeHideAndSeek();
                vm.GetTopics(1);
              //  ResultTextBlock.Text = "Developement1";
                SpeakLoud(TB1.Text);
            }
            else if (Developement2.IsSelected)
            {
                ArrangeHideAndSeek();
                vm.GetTopics(2);
                //  ResultTextBlock.Text = "Developement2";
                SpeakLoud(TB2.Text);
            }
            else if (Developement3.IsSelected)
            {
                ArrangeHideAndSeek();
                vm.GetTopics(3);
                //  ResultTextBlock.Text = "Developement3";
                SpeakLoud(TB3.Text);
            }
            else if (Developement4.IsSelected)
            {
                ArrangeHideAndSeek();
                vm.GetTopics(4);
                //   ResultTextBlock.Text = "Developement4";
                SpeakLoud(TB4.Text);
            }
            else if (Developement5.IsSelected)
            {
                ArrangeHideAndSeek();
                vm.GetTopics(5);
                //   ResultTextBlock.Text = "Developement5";
                SpeakLoud(TB5.Text);
            }
            else
            {

                // vm.GetTopics(0);
                SpeakLoud(TB0.Text);
                // ResultTextBlock.Text = "_Null";
            }
        }

        private void ArrangeHideAndSeek()
        {
            mainRow1Colum1.MaxWidth = double.MaxValue;
            mainRow1Colum0.MaxWidth = double.MaxValue;
            mainRow1Colum2.MaxWidth = 0;
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            //vm.Title = "hello".Localize();
           // ResultTextBlock.Text = "Logout";
            SpeakLoud("Logout");
        }

        private async void SpeakLoud(string text)
        {
            //foreach(var voice in SpeechSynthesizer.AllVoices) { ResultTextBlock.Text += voice.Language; }
            if (speak)
            {
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync(text);
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
            }
            
        }

        private void Speech_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)Voice.IsChecked)
            {
                this.speak = true;
            }
            else
            {
                this.speak = false;
            }
        }

       

        private async void LanguageRadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null ) //&& ResultTextBlock != null
            {
                string languageName = rb.Tag.ToString();
                switch (languageName)
                {
                    case "en-US":
                        //ResultTextBlock.Text = languageName;

                        Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "en-US";

                        break;
                    case "fr-FR":
                        //ResultTextBlock.Text = languageName;
                        Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "fr-FR";

                        break;
                }
                await Task.Delay(50); // Permet d'attendre la modification
                Frame.Navigate(typeof(MainPage)); // On recharge la page dans la bonne localization
                //await Task.Delay(1250); // Permet d'attendre la modification
                //if (languageName == "en-US")
                //{
                //    EnLangButton.IsChecked = true;
                //    FrLangButton.IsChecked = false;
                //}
                //else
                //{
                //    EnLangButton.IsChecked = false;
                //    FrLangButton.IsChecked = true;
                //}
            }
        }

        private void lstTopics_ItemClick(object sender, ItemClickEventArgs e)
        {

            if ((e != null) && (e.ClickedItem != null))
            {
                BOTopic bOTopic = e.ClickedItem as BOTopic;
                int topicId = (int)bOTopic.TopicId;
                vm.GetReplies(topicId);

                //var selected = (lsv.SelectedItem as yourClassType);
                //var yorItemID = selected.id;

            }

        }

        private void Page_Loading(FrameworkElement sender, object args)
        {
            mainRow1Colum1.MaxWidth = 0;
            mainRow1Colum0.MaxWidth = 0;
            mainRow1Colum2.MaxWidth = double.MaxValue;
            // vm.GetTopics(1);
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            IconsListBox.SelectedItem = null;
            //Page_Loading(this, new object());
            mainRow1Colum1.MaxWidth = 0;
            mainRow1Colum0.MaxWidth = 0;
            mainRow1Colum2.MaxWidth = double.MaxValue;

        }

        private void TextBlockAMIO_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SpeakLoud(AMIO.Text); 
        }

        private void TextBlockRubric_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SpeakLoud(TB0.Text);
            
        }

       









        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    PageContent1.Margin = new Thickness(43, 0, 0, 0);
        //}
    }
}
