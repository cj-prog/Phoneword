using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace Phoneword.Client
{
    public class Forms
    {
        private MainPage Page;

        public Forms(MainPage page)
        {
            Page = page;
        }

        public Task<bool> FormsDisplayAlert(string title, string message, string accept, string cancel)
        {
            RegisteredFunction.Invoke<bool>("messageBox", title, message, accept, cancel);
            return null;
        }

        public IDialer GetDependencyService()
        {
            return null;
        }

    }
}