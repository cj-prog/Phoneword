using System;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Phoneword.MVVM_UWP.Interfaces;
using Phoneword.MVVM_UWP.View;

namespace Phoneword.MVVM_UWP.Services
{
    public class SpeechDialogService : ISpeechDialogService
    {
        public async Task ShowAsync()
        {
            //var contentDialog = new ContentDialog();
            var contentDialog = new Speech();
            await contentDialog.ShowAsync();

        }
    }
}