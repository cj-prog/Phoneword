using System;
using Phoneword.Client;

namespace Phoneword.Client
{
    public partial class MainPage : MainPageObjects
    {
        //private readonly Forms _forms = new Forms();
        public string TranslatedNumber;

        public MainPage()
        {
            InitializeComponent();
        }

        public void OnTranslate(object sender, EventArgs e)
        {
            TranslatedNumber = PhonewordTranslator.ToNumber(phoneNumberText.Text);
            if (!string.IsNullOrWhiteSpace(TranslatedNumber))
            {
                callButton.IsEnabled = true;
                callButton.Text = "Call " + TranslatedNumber;
            }
            else
            {
                callButton.IsEnabled = false;
                callButton.Text = "Call";
            }
        }

        public async void OnCall(string translatedNumber)
        {
            if (await forms.FDisplayAlert(
                "Dial a Number",
                "Would you like to call " + translatedNumber + "?",
                "Yes",
                "No"))
            {
                var dialer = forms.GetDependencyService();
                if (dialer != null)
                    dialer.Dial(translatedNumber);
            }
        }
    }
}