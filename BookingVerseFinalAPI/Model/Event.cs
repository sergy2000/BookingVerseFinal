using ServiceStack.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace BookingVerseFinalAPI.Model
{
    public class Event
    {
        public Event(string _title, DateTime _date, string _location, string _category, decimal _price, string _description)
        {
            Title = _title;
            Date = _date;
            Location = _location;
            Category = _category;
            Price = _price;
            Description = _description;
        }

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
