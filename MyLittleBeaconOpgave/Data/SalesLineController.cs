using System;
using SQLite;
using Xamarin.Forms;
using MyLittleBeaconOpgave.Models;
using System.Collections.Generic;
using System.Linq;
namespace MyLittleBeaconOpgave.Data
{
    public class SalesLineController
    {
        static object locker = new object();
        SQLiteConnection database;
        public SalesLineController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<SalesLine>();
        }

        public List<SalesLine> tablesalesLine;

        public List<SalesLine> GetSalesLines()
        {
            lock (locker)
            {
                if (database.Table<SalesLine>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return tablesalesLine = database.Table<SalesLine>().ToList<SalesLine>();
                }
            }
        }
    }
}
