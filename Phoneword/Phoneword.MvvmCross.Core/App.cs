using MvvmCross;
using MvvmCross.ViewModels;
using Phoneword.MvvmCross.Core.Services;
using Phoneword.MvvmCross.Core.ViewModels;

namespace Phoneword.MvvmCross.Core
{


    // TODO from TipCalcModel to PhonewordTranslatorViewModel convert
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.RegisterType<ICalculationService, CalculationService>();
            ISpeechDialogService dialog = new SpeechDialogService();

            //RegisterAppStart<TipViewModel>();
            RegisterAppStart<PhonewordTranslatorViewModel>();
        }
    }
}
