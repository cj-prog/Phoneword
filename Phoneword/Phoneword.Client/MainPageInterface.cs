using System;

namespace Phoneword.Client
{
    public class MainPageObjects // load objects
    {
        public class CallButton
        {
            public bool IsEnabled;
            public string Text;
        }

        public class PhoneNumberText
        {
            public string Text;
        }

        public void InitializeComponent() { }

        public CallButton callButton = new CallButton();
        public PhoneNumberText phoneNumberText = new PhoneNumberText();
        public object sender = new object();
        public EventArgs e = new EventArgs();
        public Forms forms = new Forms();
    }
        

    public class MainPageInterface : MainPage
    {
        public void OnTranslate(string phoneNumberTxt)
        {
            phoneNumberText.Text = phoneNumberTxt;
            base.OnTranslate(sender, e);
        }

        public void OnCall(string translatedNumber)
        {
            base.OnCall(translatedNumber);
            //RegisteredFunction.Invoke<bool>("messageBox", translatedNumber);

            //if (await _forms.DisplayAlert(
            //    "Dial a Number",
            //    "Would you like to call " + translatedNumber + "?",
            //    "Yes",
            //    "No"))
            //{
            //    //var dialer = _forms.GetDependencyService();
            //    //if (dialer != null)
            //    //    dialer.Dial(translatedNumber);
            //}
        }
    }
}
