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
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Customer>();

        }

        public List<Customer> tableList;

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
                    return tableList = database.Table<Customer>().ToList<Customer>();

                }
            }
        }
    }
}
