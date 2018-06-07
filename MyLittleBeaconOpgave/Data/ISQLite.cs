using System;
using SQLite;
namespace MyLittleBeaconOpgave.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection(); 
    }
}
