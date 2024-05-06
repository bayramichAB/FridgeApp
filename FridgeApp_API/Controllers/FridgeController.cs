using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FridgeApp_API.Data;
using FridgeApp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FridgeApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FridgeController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public FridgeController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Fridge>>>GetFridges() 
        {
            return Ok(await _context.Fridges.ToListAsync());
        }

        [HttpGet("{id}")]
        public ActionResult<Fridge> GetFridge(Guid id)
        {
            var fridge = _context.Fridges.Find(id);
            if (fridge == null)
            {
                return NotFound();
            }
            return fridge ;
        }

        [HttpPost]
        public async Task<ActionResult<Fridge>> Create(Fridge fridge)
        {
            _context.Fridges.Add(fridge);
            await _context.SaveChangesAsync();
            return Ok(fridge);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, Fridge fridge)
        {
            if (id !=fridge.Id)
            {
                return BadRequest();
            }
            _context.Entry(fridge).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var fridge = _context.Fridges.Find(id);
            if (fridge == null)
            {
                return NotFound();
            }
            _context.Fridges.Remove(fridge);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
