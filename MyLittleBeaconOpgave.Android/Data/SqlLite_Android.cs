using System;
using System.IO;
using MyLittleBeaconOpgave.Data;
using MyLittleBeaconOpgave.Droid.Data;
using Xamarin.Forms;
using SQLite;

[assembly: Dependency(typeof(SqlLite_Android))]
namespace MyLittleBeaconOpgave.Droid.Data
{
    public class SqlLite_Android : ISQLite
    {


        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "opgave.db";
            string DbPathAndroid = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(DbPathAndroid, sqliteFileName);
            var dbAndroid = new SQLiteConnection(path);
            return dbAndroid;

        }
        public SqlLite_Android()
        {

        }
    }
}

