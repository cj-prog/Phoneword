using System;

namespace Phoneword
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

        public void InitializeComponent()
        {
        }

        public CallButton callButton = new CallButton();
        public PhoneNumberText phoneNumberText = new PhoneNumberText();
        public object sender = new object();
        public EventArgs e = new EventArgs();
    }
}