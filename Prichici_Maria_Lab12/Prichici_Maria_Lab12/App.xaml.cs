using Prichici_Maria_Lab12.Services;
using Prichici_Maria_Lab12.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prichici_Maria_Lab12.Data;

namespace Prichici_Maria_Lab12
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }

        public App()
        {
            //InitializeComponent();
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());


            //DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
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
