namespace BookingVerseFinalAPI.Model
{
    public class ShoppingCart
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int EventID { get; set; }
        public int Quantity { get; set; }
        public DateTime AddedAt { get; set; } = DateTime.Now;
    }
}
