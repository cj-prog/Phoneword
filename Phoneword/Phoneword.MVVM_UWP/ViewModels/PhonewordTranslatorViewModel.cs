using System;
using Models;

namespace ViewModels
{
    public class PhonewordTranslatorViewModel : NotificationBase
    {
        PhonewordTranslator phonewordTranslator;

        public PhonewordTranslatorViewModel()
        {
            phonewordTranslator = new PhonewordTranslator();
            _PhoneNumberText = phonewordTranslator.PhoneNumberText("");
        }

        private String _PhoneNumberText;
        public String PhoneNumberText
        {
            get { return _PhoneNumberText; }
            set { SetProperty(_PhoneNumberText, value, () => _PhoneNumberText = phonewordTranslator.PhoneNumberText(value)); }
            
        }
    }
}