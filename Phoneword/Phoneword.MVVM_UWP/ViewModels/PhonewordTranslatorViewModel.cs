using System;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Models;
using Phoneword.MVVM_UWP;
using Windows.UI.Xaml.Controls;
using Phoneword.MVVM_UWP.Interfaces;

namespace ViewModels
{
    public class PhonewordTranslatorViewModel : NotificationBase
    {
        PhonewordTranslator phonewordTranslator;
        readonly ISpeechDialogService _dialog;

        public PhonewordTranslatorViewModel(ISpeechDialogService dialog)
        {
            phonewordTranslator = new PhonewordTranslator();
            // Call to set default phone number text.
            _phoneNumberText = phonewordTranslator.PhoneNumberText("");
            //Translate();
            _dialog = dialog;

        }

        private bool _callButtonEnabled;
        private string _callButtonText;
        private string _translatedNumber;

        private string _phoneNumberText;
        public string PhoneNumberText
        {
            get => _phoneNumberText;
            set
            {
                SetProperty(_phoneNumberText, value,
                    () => _phoneNumberText = phonewordTranslator.PhoneNumberText(value));
            } 
        }

        private string _callContent;
        public string CallContent
        {
            get { return _callContent; }
        }


        public void Translate()
        {
            _callContent = phonewordTranslator.Translate(_phoneNumberText);
            RaisePropertyChanged(CallContent);

        }

        public async void Call()
        {
            await _dialog.ShowAsync();
        }




    }
}