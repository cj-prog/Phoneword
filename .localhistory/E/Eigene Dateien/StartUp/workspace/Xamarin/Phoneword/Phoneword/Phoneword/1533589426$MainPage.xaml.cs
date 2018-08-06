using System;

namespace Phoneword
{
    public partial class MainPage
    {
        Forms forms = new Forms();
        string translatedNumber;

        public MainPage()
        {
            InitializeComponent();
        }

        void OnTranslate(object sender, EventArgs e)
        {
            translatedNumber = PhonewordTranslator.ToNumber(phoneNumberText.Text);
            if (!string.IsNullOrWhiteSpace(translatedNumber))
            {
                callButton.IsEnabled = true;
                callButton.Text = "Call " + translatedNumber;
            }
            else
            {
                callButton.IsEnabled = false;
                callButton.Text = "Call";
            }
        }

        async void OnCall(object sender, EventArgs e)
        {
            if (await forms.FormsDisplayAlert(
                "Dial a Number",
                "Would you like to call " + translatedNumber + "?",
                "Yes",
                "No"))
            {
                //var dialer = DependencyService.Get<IDialer>();
                var dialer = forms.getDependencyService();
                if (dialer != null)
                    dialer.Dial(translatedNumber);
            }
        }
    }
}