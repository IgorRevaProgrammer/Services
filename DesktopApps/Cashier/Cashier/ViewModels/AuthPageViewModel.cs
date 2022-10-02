using Cashier.BaseClassesForWPFDeveloping;
using Services.Interfaces;
using System.Windows.Input;

namespace Cashier.ViewModels
{
    /// <summary>
    /// View Model class for Authorization page<br/>
    /// Contains all properties, commands and methods for Authorization page
    /// </summary>
    public class AuthPageViewModel : BaseViewModel
    {
        private readonly IPageNavigator navigator;

        private ICommand closeAppCommand;

        public ICommand CloseAppCommand => closeAppCommand ?? (closeAppCommand = new BaseCommand(o => navigator.CloseApp()));

        public AuthPageViewModel(IPageNavigator navigator)
        {
            this.navigator = navigator;
        }
        protected override void OnPageLoaded()
        {
        }
    }
}
