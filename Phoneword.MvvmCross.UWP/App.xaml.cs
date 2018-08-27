using MvvmCross.Platforms.Uap.Core;
using MvvmCross.Platforms.Uap.Views;

namespace Phoneword.MvvmCross.UWP
{
    public sealed partial class App
    {
        public App()
        {
            InitializeComponent();
        }
    }

    public abstract class PhonewordApp : MvxApplication<MvxWindowsSetup<Phoneword.MvvmCross.Core.App>, Phoneword.MvvmCross.Core.App>
    {
    }
}
