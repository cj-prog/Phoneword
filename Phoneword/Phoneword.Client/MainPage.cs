using System;

namespace Phoneword.Client
{
    public class MainPage : MainPageObjects
    {
        private Forms forms;
        public string TranslatedNumber;

        public MainPage()
        {
            
            InitializeComponent();
            forms = new Forms(this);
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

        public async void OnCall(object sender, EventArgs e)
        {
            if (await forms.FormsDisplayAlert(
                "Dial a Number",
                "Would you like to call " + TranslatedNumber + "?",
                "Yes",
                "No"))
            {
                var dialer = forms.GetDependencyService();
                if (dialer != null)
                    dialer.Dial(TranslatedNumber);
            }
        }
    }
}