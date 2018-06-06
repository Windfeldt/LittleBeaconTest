using System;
using SQLite;
namespace MyLittleBeaconOpgave.Models
{
    public class Item
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public bool Price { get; set; }
        public byte Image { get; set; }
        public Item()
        {
        }
    }
}
