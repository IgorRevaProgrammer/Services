using Cashier.BaseClassesForWPFDeveloping;
using Cashier.Views;

namespace Cashier.ViewModels
{
    /// <summary>
    /// View Model class for Main Window
    /// Contains all properties, commands and methods for Main Window
    /// </summary>
    public class MainWindowViewModel : BaseViewModel
    {
        public MainWindowViewModel()
        {
            Base.CurrentPage = new AuthPage();
        }
    }
}
