using MvvmCross.Core.ViewModels;
using Phoneword.MvvmCross.Core.Services;
using Phoneword.MvvmCross.Core.ViewModels;
using IMvxAppStart = MvvmCross.ViewModels.IMvxAppStart;

namespace Phoneword.MvvmCross.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        /// <summary>
        /// The login service.
        /// </summary>
        //private readonly ILoginService _loginService;

        private readonly ISpeechDialogService _speechDialogService;

        public AppStart(ISpeechDialogService speechDialogService)
        {
            _speechDialogService = speechDialogService;
        }

        /// <summary>
        /// Start is called on startup of the app
        /// Hint contains information in case the app is started with extra parameters
        /// </summary>
        public void Start(object hint = null)
        {
            // If your application uses a secure API this first call attempts to log the user into the application
            // using any credentials stored from a previous session.  If there are
            // none stored we should present the login screen, else go straight into the app

            ShowViewModel<PhonewordTranslatorViewModel>();

        }

        public void ResetStart()
        {
            throw new System.NotImplementedException();
        }

        public bool IsStarted { get; }
    }
}