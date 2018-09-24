using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using Phoneword.MvvmCross.Core.Models;
using Phoneword.MvvmCross.Core.Services;

namespace Phoneword.MvvmCross.Core.ViewModels
{
    public class PhonewordTranslatorViewModel : MvxViewModel
    {
        PhonewordTranslator phonewordTranslator;
        readonly ISpeechDialogService _dialog;

        public PhonewordTranslatorViewModel()//ISpeechDialogService dialog)
        {

            //_dialog = dialog;

        }

        public override async Task Initialize()
        {
            await base.Initialize();

            phonewordTranslator = new PhonewordTranslator();
            // Call to set default phone number text.
            _phoneNumberText = phonewordTranslator.PhoneNumberText("");
            // Call to set call button state and text.
            //DoTranslate();
            _callButtonText = "Call";
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
                _phoneNumberText = value;
                RaisePropertyChanged(() => PhoneNumberText);
            }
        }

        public string CallContent
        {
            get => _callButtonText;
        }

        private ICommand _translate;
        public ICommand Translate => _translate ?? (_translate = new  MvxCommand(DoTranslate));

        private ICommand _call;
        public ICommand Call => _translate ?? (_translate = new  MvxCommand(DoCall));




        public void DoTranslate()
        {
            var callButton = phonewordTranslator.Translate(_phoneNumberText);
            _callButtonEnabled = callButton.IsEnabled;
            _callButtonText = callButton.Text;
            _translatedNumber = callButton.TranslatedNumber;
            RaisePropertyChanged(() => CallContent);

        }

        public async void DoCall()
        {
            //await _dialog.ShowAsync();
            //var dialog = phonewordTranslator.Call(_translatedNumber);
            //new MessageDialogResult(dialog.title, dialog.message, dialog.accept, dialog.cancel);
        }




    }
}