using System;
using System.Collections.Generic;
using System.Linq;
using MyLittleBeaconOpgave.Models;
using MyLittleBeaconOpgave.ViewModel;
using SQLite;
using Xamarin.Forms;

namespace MyLittleBeaconOpgave.Data
{
    public class CustomerController
    {
        static object locker = new object();
        SQLiteConnection database;



        public CustomerController()
        {
            database = DependencyService.Get<ISqlLite>().GetConnection();
            database.CreateTable<Customer>();

        }

        public List<Customer> tablelist;

        public List<Customer> GetCustomer()

        {

            lock (locker)
            {
                if (database.Table<Customer>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return tablelist = database.Table<Customer>().ToList<Customer>();

                }


            }





        }
    }
}
