using System;
using Windows.UI.Popups;

namespace Phoneword.MVVM_UWP.UiViews
{
    public class MessageDialogResult
    {

        public MessageDialogResult(string title, string message, string accept, string cancel)
        {
            FormsDisplayAlert(title, message, accept, cancel);
        }

        public async void FormsDisplayAlert(string title, string message, string accept, string cancel)
        {
            var messageDialog = new MessageDialog(message, title);
            messageDialog.Commands.Add(new UICommand(
                accept,
                new UICommandInvokedHandler(this.CommandInvokedHandler)));
            messageDialog.Commands.Add(new UICommand(
                "Close",
                new UICommandInvokedHandler(this.CommandInvokedHandler)));


            // Set the command that will be invoked by default
            messageDialog.DefaultCommandIndex = 0;

            // Set the command to be invoked when escape is pressed
            messageDialog.CancelCommandIndex = 1;

            // Show the message dialog
            await messageDialog.ShowAsync();

        }
        private void CommandInvokedHandler(IUICommand command)
        {
            // Display message showing the label of the command that was invoked
            //Page.NotifyUser("The '" + command.Label + "' command has been selected.");

        }

    }
}