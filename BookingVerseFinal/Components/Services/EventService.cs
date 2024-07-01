using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using BookingVerseFinal.Components.Models;
using Microsoft.Extensions.Logging;

namespace BookingVerseFinal.Services
{
    public class EventService
    {
        private readonly HttpClient _httpClient;

        public EventService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Event>> GetEventsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Event>>("Event") ?? [];
        }

        public async Task<Event> GetEventByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Event>($"Event/{id}") ?? new Event();
        }

        public async Task<HttpResponseMessage> CreateEventAsync(int eventId)
        {
            return await _httpClient.PostAsJsonAsync($"Event{eventId}", new { EventId = eventId });
        }


        public async Task<HttpResponseMessage> DeleteEventAsync(int id)
        {
            return await _httpClient.DeleteAsync($"Event/{id}");
        }
    }
}
