using System;
using SQLite;

namespace MyLittleBeaconOpgave.Models
{
    public class SalesLine
    {
        public SalesLine()
        { }
        public string OrderId { get; set; }
        public string Id { get; set; }
        public string Note { get; set; }
        public string ItemId { get; set; }
        public int Qty { get; set; }
        public float Discount { get; set; }
        public float DiscountPercent { get; set; }
        public string Size { get; set; }

    }
}

