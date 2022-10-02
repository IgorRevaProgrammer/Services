using Cashier.ViewModels;
using System.Windows;

namespace Cashier.Views
{
    /// <summary>
    /// Main window class<br/>
    /// Is used as frame for navigation between pages
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainWindowViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
