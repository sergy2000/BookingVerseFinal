using ServiceStack.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace BookingVerseFinalAPI.Model
{
    public class Event
    {
        [Key, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
