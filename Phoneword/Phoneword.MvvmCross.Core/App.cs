using MvvmCross;
using MvvmCross.ViewModels;
using Phoneword.MvvmCross.Core.Services;
using Phoneword.MvvmCross.Core.ViewModels;

namespace Phoneword.MvvmCross.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.RegisterType<ICalculationService, CalculationService>();

            RegisterAppStart<TipViewModel>();
        }
    }
}
