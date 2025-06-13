using Microsoft.AspNetCore.Mvc;
using CafeManagement.Data; // Namespace where your DbContext is
using CafeManagement.Models; // Namespace where your MenuItem model is
using Microsoft.EntityFrameworkCore;

namespace CafeManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuItemsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MenuItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MenuItems
        [HttpGet]
        public async Task<IActionResult> GetAllMenuItems()
        {
            var items = await _context.MenuItems.ToListAsync();
            return Ok(items);
        }

        // POST: api/MenuItems
        [HttpPost]
        public async Task<IActionResult> CreateMenuItem(MenuItem item)
        {
            _context.MenuItems.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAllMenuItems), new { id = item.Id }, item);
        }

        // PUT: api/MenuItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMenuItem(int id, MenuItem updatedItem)
        {
            var item = await _context.MenuItems.FindAsync(id);
            if (item == null) return NotFound();

            item.Name = updatedItem.Name;
            item.Price = updatedItem.Price;
            // Update other fields as needed

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/MenuItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenuItem(int id)
        {
            var item = await _context.MenuItems.FindAsync(id);
            if (item == null) return NotFound();

            _context.MenuItems.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
