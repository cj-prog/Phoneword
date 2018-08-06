using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Phoneword 
{
    public class Forms : ContentPage
    {
        public async Task<bool> FDisplayAlert(string title, string message, string accept, string cancel)
        {
            displayawait DisplayAlert(title, message, accept, cancel);
            return @class

        }

        public IDialer getDependencyService()
        {
            return DependencyService.Get<IDialer>();
        }
        

    }
}