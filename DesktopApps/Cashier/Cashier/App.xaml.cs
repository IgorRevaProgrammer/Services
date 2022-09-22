using Autofac;
using Cashier.ViewModels;
using Cashier.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Cashier
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ContainerBuilder();
            //builder.RegisterType<MainWindowViewModel>();
            builder.RegisterType<AuthPageViewModel>();
            builder.RegisterType<ProductListPageViewModel>();
            builder.RegisterType<MainWindow>().AsSelf();
            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var window = scope.Resolve<MainWindow>();
                window.Show();
            }
        }
    }
}
