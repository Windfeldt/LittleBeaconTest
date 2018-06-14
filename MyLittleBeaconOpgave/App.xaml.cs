using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyLittleBeaconOpgave.Data;
using MyLittleBeaconOpgave.Models;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyLittleBeaconOpgave
{
    public partial class App : Application
    {
        public static CustomerController customerController;
        public static SalesOrderController salesOrderController;
        public static ItemController itemController;
        public static SalesLineController salesLineController;


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
        public static SalesOrderController SalesOrderController
        {
            get
            {
                if (salesOrderController == null)
                {
                    salesOrderController = new SalesOrderController();
                }
                return salesOrderController;
            }
        }
        public static ItemController ItemController
        {
            get
            {
                if (itemController == null)
                {
                    itemController = new ItemController();
                }
                return itemController;
            }
        }
        public static SalesLineController SalesLineController
        {
            get
            {
                if (salesLineController == null)
                {
                    salesLineController = new SalesLineController();
                }
                return salesLineController;
            }
        }
    }
}
