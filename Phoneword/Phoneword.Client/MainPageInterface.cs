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
            TranslatedNumber = translatedNumber;
            base.OnCall(sender, e);
        }
    }
}
