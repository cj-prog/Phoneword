using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace BlazorDemo.Client
{
    public class Forms
    {
        public Task<bool> FDisplayAlert(string title, string message, string accept, string cancel)
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