using System;
using SQLite;
using Xamarin.Forms;
using MyLittleBeaconOpgave.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyLittleBeaconOpgave.Data
{
    public class ItemController
    {
        static object locker = new object();
        SQLiteConnection database;

        public ItemController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Item>();
        }

        public List<Item> tableListItem;

        public List<Item> GetItems()
        {
            lock (locker)
            {
                if (database.Table<Item>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return tableListItem = database.Table<Item>().ToList();
                }
            }
        }
    }
}
