using MvvmCross.Platforms.Uap.Views;
using MvvmCross.ViewModels;
using Phoneword.MvvmCross.Core.ViewModels;

namespace Phoneword.MvvmCross.UWP.Views
{
    [MvxViewFor(typeof(TipViewModel))]
    public sealed partial class TipView : MvxWindowsPage
    {
        public TipView()
        {
            InitializeComponent();
        }
    }
}
