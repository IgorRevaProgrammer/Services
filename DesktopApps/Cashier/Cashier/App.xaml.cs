using Autofac;
using Autofac.Features.ResolveAnything;
using Cashier.ViewModels;
using Cashier.Views;
using Data.Models;
using Services;
using Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Cashier
{
    /// <summary>
    /// Start class for application
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Start method for application
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            try
            {
                var container = RegisterServices();
                var navigator = container.Resolve<IPageNavigator>();
                var pages = container.Resolve<IEnumerable<IPage>>();
                pages.ToList().ForEach(p => navigator.RegisterPage(p));

                using (var scope = container.BeginLifetimeScope())
                {
                    var window = scope.Resolve<MainWindow>();
                    window.Show();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// Register services method
        /// </summary>
        /// <returns></returns>
        private IContainer RegisterServices()
        {
            ContainerBuilder builder = new();

            builder.RegisterType<MainWindowViewModel>();
            builder.RegisterType<AuthPageViewModel>();
            builder.RegisterType<ProductListPageViewModel>();

            builder.RegisterType<AuthPage>().As<IPage>();
            builder.RegisterType<ProductsList>().As<IPage>();
            builder.RegisterType<PageNavigator>().As<IPageNavigator>().SingleInstance();
            builder.RegisterType<MainWindow>().AsSelf();

            builder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());
            return builder.Build();
        }
    }
}
