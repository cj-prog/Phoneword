using System.Threading.Tasks;
using Xamarin.Forms;

namespace Phoneword 
{
    public class Forms : ContentPage
    {
        public Task<bool> FormsDisplayAlert(string title, string message, string accept, string cancel)
        {
            return DisplayAlert(title, message, accept, cancel);

        }
        public IDialer getDependencyService()
        {
            return DependencyService.Get<IDialer>();
        }
        

    }
}