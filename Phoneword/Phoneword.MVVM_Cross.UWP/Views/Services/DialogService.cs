using System;
using System.Threading.Tasks;
using Phoneword.MVVM_Cross.Core.Interfaces;

namespace Phoneword.MVVM_Cross.UWP.Views.Services
{
    public class DialogService : IDialogService
    {
        public async Task ShowAsync()
        {
            var contentDialog = new CallDialog();
            await contentDialog.ShowAsync();
        }
    }
}