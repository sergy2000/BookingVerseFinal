namespace BookingVerseFinalAPI.Model
{
    public class Order
    {
        public Order(int id, int userId, Account account, int eventId, Event @event, DateTime orderDate)
        {
            Id = id;
            UserId = userId;
            this.account = account;
            EventId = eventId;
            Event = @event;
            OrderDate = orderDate;
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public Account account { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
