using System;
using System.Collections.Generic;
using System.Linq;
using MyLittleBeaconOpgave.Models;
using SQLite;
using Xamarin.Forms;

namespace MyLittleBeaconOpgave.Data
{
    public class SalesOrderController
    {
        static object locker = new object();
        SQLiteConnection database;

        public SalesOrderController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<SalesOrder>();
        }

        public List<SalesOrder> tableListSalesOrder;

        public List<SalesOrder> GetSalesOrder()
        {
            lock (locker)
            {
                if (database.Table<SalesOrder>().Count() == 0)
                {
                    return null;
                }
                else
                {

                    var salesorderid = "test";
                    var saleslines = database.Table<SalesLine>().Where(i => i.OrderId == salesorderid).ToList();
                    var line = saleslines.FirstOrDefault();

                    var item = database.Table<Item>().Where(i => i.Id == line.ItemId).FirstOrDefault();


                    var sql = $"select {nameof(Item.Price)} from {nameof(Item)} where {nameof(Item.Id)} = '{line.ItemId}'";
                    var res = database.ExecuteScalar<double>(sql);


                    return tableListSalesOrder = database.Table<SalesOrder>().ToList<SalesOrder>();

                }

            }
        }
    }
}
