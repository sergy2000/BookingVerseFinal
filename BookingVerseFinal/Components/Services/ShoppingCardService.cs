using BookingVerseFinal.Components.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BookingVerseFinal.Components.Services
{

 
        public class ShoppingCartService
        {
            private readonly HttpClient _httpClient;

            public ShoppingCartService(HttpClient httpClient)
            {
                _httpClient = httpClient;
            }
        /*
            public async Task<List<ShoppingCart>> GetShoppingCartAsync(int userId)
            {
                return await _httpClient.GetFromJsonAsync<List<ShoppingCart>>($"ShoppingCart/{userId}") ?? new List<ShoppingCart>();
            }

            public async Task<HttpResponseMessage> AddToShoppingCartAsync(ShoppingCart shoppingCart)
            {
                return await _httpClient.PostAsJsonAsync("ShoppingCart", shoppingCart);
            }
        */

            public async Task<HttpResponseMessage> RemoveFromShoppingCartAsync(int id)
            {
                return await _httpClient.DeleteAsync($"ShoppingCart/{id}");
            }
        }
    }


