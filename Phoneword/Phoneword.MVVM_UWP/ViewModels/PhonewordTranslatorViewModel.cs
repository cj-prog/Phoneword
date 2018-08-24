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
            // Call to set call button state and text.
            Translate();
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

        public bool PopUpOpened { get; set; }


        public void Translate()
        {
            //var callButton = phonewordTranslator.Translate(_phoneNumberText);
            //_callButtonEnabled = callButton.IsEnabled;
            //_callButtonText = callButton.Text;
            //_translatedNumber = callButton.TranslatedNumber;

        }

        public async void Call()
        {
            await _dialog.ShowAsync();
            //var dialog = phonewordTranslator.Call(_translatedNumber);
            //new MessageDialogResult(dialog.title, dialog.message, dialog.accept, dialog.cancel);
        }




    }
}