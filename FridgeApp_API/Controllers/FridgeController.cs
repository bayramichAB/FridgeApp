using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FridgeApp_API.Data;
using FridgeApp_API.Models;
using Microsoft.EntityFrameworkCore;
using FridgeApp_API.ServiceContracts;

namespace FridgeApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FridgeController : ControllerBase
    {
        private readonly IServiceManager _service;

        public FridgeController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult>GetFridges() 
        {
            return Ok(await _service.FridgeService.GetAllFridgesAsync(trackChanges: false));
        }

        [HttpGet("{id:guid}", Name = "FridgeById")]
        public async Task<IActionResult>GetFridge(Guid id)
        {
            var fridge = await _service.FridgeService.GetFridgeByIdAsync(id, trachChanges: false);
            if (fridge is null)
            {
                return NotFound();
            }
            return Ok(fridge);
        }

        [HttpPost(Name = "CreateFridge")]
        public async Task<ActionResult> CreateFridge([FromBody] Fridge fridge)
        {
            var createdFridge = await _service.FridgeService.CreateFridgeAsync(fridge);
            return CreatedAtRoute("FridgeById", new { id = createdFridge.Id }, createdFridge);
        }

        [HttpPut("{id:guid}")]
        public async Task <IActionResult> Update(Guid id,[FromBody] Fridge fridge)
        {
            await _service.FridgeService.UpdateFridgeAsync(id, fridge, trachChanges: true);
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.FridgeService.DeleteFridgeAsync(id, trachChanges:false);
            return NoContent();
        }
    }
}
