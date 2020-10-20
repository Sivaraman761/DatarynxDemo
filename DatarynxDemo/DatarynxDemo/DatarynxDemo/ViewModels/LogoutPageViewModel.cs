using DatarynxDemo.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DatarynxDemo.ViewModels
{
    public class LogoutPageViewModel 
    {
        public Command LoginCommand { get; }
        public LogoutPageViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }
        private async void OnLoginClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
