using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Phoneword 
{
    public class Forms : ContentPage
    {
        public void FDisplayAlert(string title, string message, string accept, string cancel)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                if (DisplayAlert(
                    "Dial a Number",
                    "Would you like to call " + message + "?",
                    "Yes",
                    "No").Result)
                {
    
                }
            });



        }

        public IDialer getDependencyService()
        {
            return DependencyService.Get<IDialer>();
        }
        

    }
}