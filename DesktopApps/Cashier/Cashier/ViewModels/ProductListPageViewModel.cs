using Cashier.BaseClassesForWPFDeveloping;
using Services.Interfaces;

namespace Cashier.ViewModels
{
    /// <summary>
    /// View Model class for Product list page<br/>
    /// Contains all properties, commands and methods for product list page
    /// </summary>
    public class ProductListPageViewModel : BaseViewModel
    {
        private readonly IPageNavigator navigator;
        public ProductListPageViewModel(IPageNavigator navigator)
        {
            this.navigator = navigator;
        }
        protected override void OnPageLoaded()
        {
        }
    }
}
