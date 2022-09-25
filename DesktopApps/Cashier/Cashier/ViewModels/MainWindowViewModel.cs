using Cashier.BaseClassesForWPFDeveloping;
using Cashier.Views;
using System.Windows.Controls;

namespace Cashier.ViewModels
{
    /// <summary>
    /// View Model class for Main Window
    /// Contains all properties, commands and methods for Main Window
    /// </summary>
    public class MainWindowViewModel : BaseViewModel
    {
        private Page currentPage;
        /// <summary>
        /// Current page property
        /// </summary>
        public Page CurrentPage
        {
            get
            {
                return currentPage;
            }
            set
            {
                currentPage = value;
                OnPropertyChanged("CurrentPage");
            }
        }
        public MainWindowViewModel()
        {
            
            CurrentPage = new AuthPage();
        }
    }
}
