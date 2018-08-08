﻿using System;

namespace Phoneword
{
    public partial class MainPage
    {
        private Forms forms;
        string translatedNumber;

        public MainPage()
        {
            InitializeComponent();
            forms = new Forms(this);
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
                var dialer = forms.GetDependencyService();
                if (dialer != null)
                    dialer.Dial(translatedNumber);
            }
        }
    }
}