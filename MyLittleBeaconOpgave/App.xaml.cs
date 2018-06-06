using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyLittleBeaconOpgave.Data;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyLittleBeaconOpgave
{
    public partial class App : Application
    {
        public static CustomerController customerController;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static CustomerController CustomerController
        {
            get
            {
                if (customerController == null)
                {
                    customerController = new CustomerController();
                }
                return customerController;
            }
        }
    }
}
