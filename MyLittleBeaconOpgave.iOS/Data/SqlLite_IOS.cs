using System;
using System.IO;
using MyLittleBeaconOpgave.iOS.Data;
using Xamarin.Forms;
using SQLite;
using MyLittleBeaconOpgave.Data;

[assembly: Dependency(typeof(SqlLite_IOS))]
namespace MyLittleBeaconOpgave.iOS.Data
{

    public class SqlLite_IOS : ISqlLite
    {
        public SqlLite_IOS()
        {
        }
        public SQLite.SQLiteConnection GetConnection()
        {
            var fileName = "opgave.db";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var path = Path.Combine(documentsPath, fileName);
            var dbIOS = new SQLite.SQLiteConnection(path);
            return dbIOS;
        }
    }
}