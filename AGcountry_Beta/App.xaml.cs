using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AGcountry_Beta.Services;
using AGcountry_Beta.Views;

namespace AGcountry_Beta
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
