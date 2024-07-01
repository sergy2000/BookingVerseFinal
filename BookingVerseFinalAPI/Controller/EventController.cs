
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using BookingVerseFinalAPI.Database;
using BookingVerseFinalAPI.Model;
using System;

namespace BookingVerseApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EventController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            return await _context.Events.ToListAsync();
        }

        [HttpPut("{id}")]
        public async Task GetEvent(int id)
        {
            var eventItem = await _context.Events.FindAsync(id);

            //_context.Add<Order>(new Order { });
            //_context.SaveChanges();


        }

        [HttpPost]
        public async Task<ActionResult<Event>> CreateEvent([FromBody] Event eventItem)
        {
            _context.Events.Add(eventItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEvent), new { id = eventItem.ID }, eventItem);
        }

       /* [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEvent(int id, [FromBody] Event eventItem)
        {
            if (id != eventItem.ID)
            {
                return BadRequest();
            }

            _context.Entry(eventItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
       */
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            var eventItem = await _context.Events.FindAsync(id);
            if (eventItem == null)
            {
                return NotFound();
            }

            _context.Events.Remove(eventItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.ID == id);
        }
    }
}
