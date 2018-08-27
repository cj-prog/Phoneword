using MvvmCross.ViewModels;
using Phoneword.MvvmCross.Core.Models;
using Phoneword.MvvmCross.Core.Services;

namespace Phoneword.MvvmCross.Core.ViewModels
{
    public class PhonewordTranslatorViewModel : MvxViewModel
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
                SetProperty(ref _phoneNumberText, value);
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