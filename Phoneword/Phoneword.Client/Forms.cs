using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Components;
using Phoneword;
using Phoneword.Client.Interfaces;

namespace Phoneword.Client
{
    public class Forms
    {
        [Inject]
        private IMessageBoxProvider MessageBoxProvider { get; set; }

        private MainPage Page;

        public Forms(MainPage page)
        {
            Page = page;
        }

        //public Task<bool> FormsDisplayAlert(string title, string message, string accept, string cancel)
        //{
        //    RegisteredFunction.Invoke<bool>("messageBox", title, message, accept, cancel);
        //    return null;
        //}

        public Task<bool> FormsDisplayAlert(string title, string message, string accept, string cancel)
        {

            if (string.IsNullOrEmpty(cancel))
                throw new ArgumentNullException(nameof(cancel));
            return MessageBoxProvider.ShowMessageBox(title, message);



        }

        public IDialer GetDependencyService()
        {
            return null;
        }

    }
}