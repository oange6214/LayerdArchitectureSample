using LayerArchitectureSample.MVVM.ViewModels;
using LayerArchitectureSample.Repository.Implements;
using LayerArchitectureSample.Repository.Interfaces;
using LayerArchitectureSample.Service.Implements;
using LayerArchitectureSample.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows;

namespace LayerArchitectureSample.GUI
{
    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    string connectionString = hostContext.Configuration.GetConnectionString("Default") ?? string.Empty;

                    services.AddScoped<IFooRepository, FooRepository>();
                    services.AddScoped<IFooService, FooService>();
                    services.AddScoped<FooViewModel>();
                    services.AddScoped(s => new MainWindow()
                    {
                        DataContext = s.GetRequiredService<FooViewModel>()
                    });

                    services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
                })
                .Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await _host.StartAsync();

            MainWindow = _host.Services.GetRequiredService<MainWindow>();
            MainWindow.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await _host.StopAsync();
            base.OnExit(e);
        }
    }
}
