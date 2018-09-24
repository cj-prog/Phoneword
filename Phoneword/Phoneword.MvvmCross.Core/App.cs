using MvvmCross;
using MvvmCross.IoC;
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

            // Registers any classes ending with "Service" into the internal
            // Mvx IoC container for use when constructing objects through
            // the container
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            // Construct custom application start object
            Mvx.ConstructAndRegisterSingleton<IMvxAppStart, AppStart>();

            // request a reference to the constructed appstart object 
            var appStart = Mvx.Resolve<IMvxAppStart>();

            // register the appstart object
            RegisterAppStart(appStart);
        }
    }
}
