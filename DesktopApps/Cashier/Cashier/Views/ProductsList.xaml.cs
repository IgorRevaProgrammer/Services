using Cashier.ViewModels;
using Data.Models;
using System.Windows.Controls;

namespace Cashier.Views
{
    /// <summary>
    /// Product list page<br/>
    /// Adding products to list
    /// </summary>
    public partial class ProductsList : Page, IPage
    {
        public ProductsList(ProductListPageViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
        Pages IPage.Name => Pages.ProductList;
    }
}
