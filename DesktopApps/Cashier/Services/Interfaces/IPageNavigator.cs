using Data.Models;

namespace Services.Interfaces
{
    /// <summary>
    /// Interface for navigator page
    /// </summary>
    public interface IPageNavigator
    {
        /// <summary>
        /// Event if page changed
        /// </summary>
        event EventHandler<IPage>? PageChangedEvent;
        /// <summary>
        /// Navigate to page
        /// </summary>
        /// <param name="PageName"></param>
        /// <returns></returns>
        bool Navigate(Pages page);
        /// <summary>
        /// Add available page
        /// </summary>
        /// <param name="page"></param>
        void RegisterPage(IPage page);
        /// <summary>
        /// Close application event
        /// </summary>
        event EventHandler? CloseAppEvent;
        /// <summary>
        /// Close application method
        /// </summary>
        void CloseApp();
    }
}
