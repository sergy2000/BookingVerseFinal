using BookingVerseFinal.Components.Models;

namespace BookingVerseFinal.Components.Services
{
    public class EventService
    {
        private List<Event> warenkorb = new List<Event>();
        private List<Event> orders = new List<Event>();

        public void AddToWarenkorb(Event eventItem)
        {
            if (!warenkorb.Any(x => x.EventID.Equals(eventItem.EventID)))
            {
                warenkorb.Add(eventItem);
            }
        }

        public void AddToOrders(Event eventItem)
        {
            if (!orders.Where(x=> x.Equals(eventItem)).Any())
            {
                orders.Add(eventItem);
            }
        }

        public void RemoveFromWarenkorb(Event eventItem) => warenkorb.Remove(eventItem);

        public List<Event> GetWarenkorb() => warenkorb;

        public List<Event> GetOrders() => orders;
    }
}

