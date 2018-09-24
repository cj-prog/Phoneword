using Windows.UI.Xaml.Controls;
using MvvmCross;
using MvvmCross.Logging;
//using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Presenters;
using MvvmCross.Platforms.Uap.Views;
using MvvmCross.ViewModels;
using MvvmCross.Platform.Platform;
using Windows.UI.Xaml.Controls;
using MvvmCross.Platforms.Uap.Core;
using Phoneword.MvvmCross.Core.Services;
using Phoneword.MvvmCross.UWP;

namespace Phoneword.MvvmCross.Core
{
    public class Setup : MvxWindowsSetup
    {
        //public Setup(Frame rootFrame) : base(rootFrame)
        //{
        //}

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            Mvx.RegisterSingleton<ISpeechDialogService>(() => new SpeechDialogService());
            //Mvx.RegisterSingleton<MvxPresentationHint>(() => new MvxPanelPopToRootPresentationHint());
        }

        //protected override IMvxTrace CreateDebugTrace()
        //{
        //    return new DebugTrace();
        //}
    }
}