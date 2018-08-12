using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Phoneword.CSHTML5
{
    public partial class MainPage
    {
        private Forms forms;
        public string TranslatedNumber;

        public MainPage()
        {
            this.InitializeComponent();
            forms = new Forms(this);

            // Enter construction logic here...
        }

        public void OnTranslate(object sender, RoutedEventArgs e)
        {
            TranslatedNumber = PhonewordTranslator.ToNumber(phoneNumberText.Text);
            if (!string.IsNullOrWhiteSpace(TranslatedNumber))
            {
                callButton.IsEnabled = true;
                callButton.Content = "Call " + TranslatedNumber;
            }
            else
            {
                callButton.IsEnabled = false;
                callButton.Content = "Call";
            }
        }
        public void NotifyUser(string strMessage)
        {
        }

        public void OnCall(object sender, RoutedEventArgs e)
        {
            forms.FormsDisplayAlert(
                "Dial a Number",
                "Would you like to call " + TranslatedNumber + "?",
                "Yes",
                "No");
        }
    }
}
