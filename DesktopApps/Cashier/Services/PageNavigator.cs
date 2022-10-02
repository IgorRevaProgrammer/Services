using Data.Models;
using Services.Interfaces;

namespace Services
{
    /// <summary>
    /// Service to change page in view model
    /// </summary>
    public class PageNavigator : IPageNavigator
    {
        /// <summary>
        /// All registered pages, can be used in app
        /// </summary>
        private IList<IPage> pages = new List<IPage>();
        /// <summary>
        /// Event if page changed
        /// </summary>
        public event EventHandler<IPage>? PageChangedEvent;
        /// <summary>
        /// Close application event
        /// </summary>
        public event EventHandler? CloseAppEvent;
        /// <summary>
        /// Close application method
        /// </summary>
        public void CloseApp() => CloseAppEvent?.Invoke(this, null);
        /// <summary>
        /// Navigate to page
        /// </summary>
        /// <param name="PageName"></param>
        /// <returns></returns>
        public bool Navigate(Pages PageName)
        {
            var page = pages.FirstOrDefault(p => p.Name == PageName);
            if (page == null) return false;

            PageChangedEvent?.Invoke(this, page);
            return true;
        }
        /// <summary>
        /// Add available page
        /// </summary>
        /// <param name="page"></param>
        public void RegisterPage(IPage page) => pages.Add(page);
    }
}
