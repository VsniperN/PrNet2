using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Configuration;
using System.Data;
using System.Windows;
using HeroRandomaizer.Contexts;
namespace HeroRandomaizer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            DatabaseFacade HeroesFacade = new(new HeroBuilderContext());
            HeroesFacade.EnsureCreated();
        }

    }

}
