using System.Threading.Tasks;
using Xamarin.Forms;

namespace Phoneword.XAMARIN 
{
    public class Forms : ContentPage
    {
        private Page Page;

        public Forms(Page page)
        {
            Page = page;
        }

        public Task<bool> FormsDisplayAlert(string title, string message, string accept, string cancel)
        {
            return Page.DisplayAlert(title, message, accept, cancel);

        }
        public IDialer GetDependencyService()
        {
            return DependencyService.Get<IDialer>();
        }
        

    }
}