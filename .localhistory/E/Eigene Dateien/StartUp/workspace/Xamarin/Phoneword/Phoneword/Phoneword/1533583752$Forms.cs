using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Phoneword 
{
    public class Forms : ContentPage
    {
        public async Task<bool> FDisplayAlert(string title, string message, string accept, string cancel)
        {
            return DisplayAlert(title, message, accept, cancel).Result;
        }

        public IDialer getDependencyService()
        {
            return DependencyService.Get<IDialer>();
        }
        

    }
}