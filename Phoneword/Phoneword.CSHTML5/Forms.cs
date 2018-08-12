using System;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Phoneword.CSHTML5
{
    public class Forms
    {
        private MainPage Page;

        public Forms(MainPage page)
        {
            Page = page;
        }

        public async void FormsDisplayAlert(string title, string message, string accept, string cancel)
        {
            MessageBoxResult result = MessageBox.Show(message, title, MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                
            }

        }

        public IDialer GetDependencyService()
        {
            return null;
        }
        

    }
}