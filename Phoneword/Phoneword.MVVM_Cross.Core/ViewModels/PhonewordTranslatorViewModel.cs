using MvvmCross.Core.ViewModels;
using Phoneword.MVVM_Cross.Core.Interfaces;
using Phoneword.MVVM_Cross.Core.Models;

namespace Phoneword.MVVM_Cross.Core.ViewModels
{
    public class PhonewordTranslatorViewModel : MvxViewModel
    {
        PhonewordTranslator phonewordTranslator;
        readonly IDialogService _dialog;

        public PhonewordTranslatorViewModel(IDialogService dialog)
        {
            phonewordTranslator = new PhonewordTranslator();
            // Call to set default phone number text.
            _phoneNumberText = phonewordTranslator.PhoneNumberText("");
            // Call to set call button state and text.
            Translate();
            _dialog = dialog;
            _callButtonText = "Call";

        }

        private bool _callButtonEnabled;
        private string _callButtonText;
        public string CallButtonText { get=>_callButtonText; set=> SetProperty(ref _callButtonText, value); }
        private string _translatedNumber;

        private string _phoneNumberText;
        public string PhoneNumberText
        {
            get => _phoneNumberText;
            set
            {
                //_phoneNumberText = value;
                //RaisePropertyChanged(() => phonewordTranslator.PhoneNumberText(value));
                SetProperty(ref _phoneNumberText, value);
            }
        }

        public void Translate()
        {
            var callButton = phonewordTranslator.Translate(_phoneNumberText);
            _callButtonEnabled = callButton.isEnabled;
            _callButtonText = callButton.buttonText;
            _translatedNumber = callButton.translatedNumber;
            SetProperty(ref _callButtonText, "test123");
            
            


        }

        public async void Call()
        {
            await _dialog.ShowAsync();
            //var dialog = phonewordTranslator.Call(_translatedNumber);
            //new MessageDialogResult(dialog.title, dialog.message, dialog.accept, dialog.cancel);
        }




    }
}