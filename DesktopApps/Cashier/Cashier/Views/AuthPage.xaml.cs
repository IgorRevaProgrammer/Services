using Cashier.ViewModels;
using Data.Models;
using System.Windows.Controls;

namespace Cashier.Views
{
    /// <summary>
    /// Authorization page class<br/>
    /// Is used for authorization
    /// </summary>
    public partial class AuthPage : Page, IPage
    {
        public AuthPage(AuthPageViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();     
        }
        Pages IPage.Name => Pages.Auth;
    }
}
