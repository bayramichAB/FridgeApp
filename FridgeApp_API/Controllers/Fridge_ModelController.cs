/*using FridgeApp_API.Data;
using FridgeApp_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FridgeApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Fridge_ModelController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public Fridge_ModelController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Fridge_Model>>> GetModels()
        {
            return Ok(await _context.Fridge_Models.ToListAsync());
        }

        [HttpGet("{id}")]
        public ActionResult<Fridge_Model> GetModel(Guid id)
        {
            var model = _context.Fridge_Models.Find(id);
            if (model == null)
            {
                return NotFound();
            }
            return model;
        }

       

        [HttpPost]
        public async Task<ActionResult<Fridge_Model>> Create(Fridge_Model fridge_Model)
        {
            _context.Add(fridge_Model);
            await _context.SaveChangesAsync();
            return Ok(fridge_Model);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id ,Fridge_Model fridge_Model)
        {
            if (id != fridge_Model.Id)
            {
                return BadRequest();
            }
            _context.Entry(fridge_Model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var model = _context.Fridge_Models.Find(id);
            if(model == null)
            {
                return NotFound();
            }
            _context.Remove(model);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
*/