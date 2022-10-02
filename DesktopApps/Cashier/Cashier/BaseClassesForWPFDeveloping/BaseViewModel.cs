namespace Cashier.BaseClassesForWPFDeveloping
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;

    /// <summary>
    /// Base class for ever ViewModel.
    /// Implements INotifyPropertyChanged
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected virtual void OnPageLoaded() 
        { 
        }
        private ICommand loaded;
        public ICommand Loaded => loaded ?? (loaded = new BaseCommand(o => OnPageLoaded()));

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
