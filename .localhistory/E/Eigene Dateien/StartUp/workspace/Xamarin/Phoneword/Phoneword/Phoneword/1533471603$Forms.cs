using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Phoneword 
{
    public class Forms : ContentPage
    {
        public async Task<bool> FDisplayAlert(string title, string message, string accept, string cancel)
        {
            return await DisplayAlert(title, message, accept, cancel);

        }


    }
}