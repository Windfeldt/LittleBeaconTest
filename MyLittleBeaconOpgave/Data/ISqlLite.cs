using System;
using SQLite;
namespace MyLittleBeaconOpgave.Data
{
    public interface ISqlLite
    {
        SQLiteConnection GetConnection(); 
    }
}
