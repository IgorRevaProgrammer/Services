namespace Cashier.BaseClassesForWPFDeveloping
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.CompilerServices;
    using System.Windows.Controls;
    /// <summary>
    /// Base class for ever ViewModel.
    /// Contains Current page property and Property Changed event
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        private static BaseViewModel globalResources;
        /// <summary>
        /// Single instance of ItSelf
        /// </summary>>
        public static BaseViewModel Base => globalResources ?? (globalResources = new BaseViewModel());
      
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
