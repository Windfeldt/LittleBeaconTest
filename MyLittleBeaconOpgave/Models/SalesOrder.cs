using System;
using SQLite;

namespace MyLittleBeaconOpgave.Models
{
    public class SalesOrder
    {

        public string CustormerId { get; set; }
        public string Id { get; set; }
        public DateTime SalesDate { get; set; }
        public string Note { get; set; }

        public SalesOrder()
        {


        }
    }
}
