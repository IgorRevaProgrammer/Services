using Cashier.BaseClassesForWPFDeveloping;
using Data.Models;
using Services.Interfaces;
using System;
using System.Windows;

namespace Cashier.ViewModels
{
    /// <summary>
    /// View Model class for Main Window<br/>
    /// Contains all properties, commands and methods for Main Window
    /// </summary>
    public class MainWindowViewModel : BaseViewModel
    {
        private readonly IPageNavigator navigator;
        private IPage currentPage;
        public IPage CurrentPage
        {
            get => currentPage;
            set 
            {
                currentPage = value;
                OnPropertyChanged();
            }
        }
        public MainWindowViewModel(IPageNavigator navigator)
        {
            this.navigator = navigator;
        }

        protected override void OnPageLoaded()
        {
            navigator.PageChangedEvent += PageChangedHandler;
            navigator.Navigate(Pages.Auth);
            navigator.CloseAppEvent += CloseAppHandler;
        }

        private void CloseAppHandler(object? sender, EventArgs e) => Application.Current.MainWindow.Close();
        private void PageChangedHandler(object? sender, IPage e) => CurrentPage = e;       
    }
}
