namespace BookingVerseFinal.Components.Models
{
    public class Event
    {
        public string EventID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }

        public Event(string EventID, string Title, DateTime Date, string Location, string Category, decimal Price, string Description)
        {
            this.EventID = EventID;
            this.Title = Title;
            this.Date = Date;
            this.Location = Location;
            this.Category = Category;
            this.Price = Price;
            this.Description = Description;
        }
        
        public Event() { }
    }
}