using System.Collections.Generic;
using BookingVerse.Components.Models;

namespace BookingVerse.Components.Services
{
    public class EventService
    {
        private List<Event> warenkorb = new List<Event>();

        public List<Event> GetWarenkorb()
        {
            return warenkorb;
        }

        public void AddToWarenkorb(Event eventItem)
        {
            if (!warenkorb.Any(x => x.EventID.Equals(eventItem.EventID)))
            {
                warenkorb.Add(eventItem);
            }
        }

        public void RemoveFromWarenkorb(Event eventItem)
        {
            warenkorb.Remove(eventItem);
        }
    }
}
