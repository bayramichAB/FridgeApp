using AutoMapper;
using FridgeApp_API.Contracts;
using FridgeApp_API.Data;
using FridgeApp_API.Models;
using FridgeApp_API.ServiceContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FridgeApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Fridge_ModelController : ControllerBase
    {
        private readonly IServiceManager _service;

        public Fridge_ModelController( IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetModels()
        {
            return Ok(await _service.Fridge_ModelService.GetAllModelsAsync(trackChanges: false));
        }


        [HttpGet("{id:guid}", Name = "FridgeModelById")]
        public async Task<IActionResult> GetFridgeModel(Guid id)
        {
            var fridgeModel = await _service.Fridge_ModelService.GetModelByIdAsync(id, trachChanges: false);
            if (fridgeModel is null)
            {
                return NotFound();
            }
            return Ok(fridgeModel);
        }


        [HttpPost(Name = "CreateFridgeModel")]
        public async Task<ActionResult> CreateFridgeModel([FromBody] Fridge_Model fridgeModel)
        {
            var createdFridgeModel = await _service.Fridge_ModelService.CreateFridgeModelAsync(fridgeModel);
            return CreatedAtRoute("FridgeModelById", new { id = createdFridgeModel.Id }, createdFridgeModel);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateModel(Guid id, [FromBody] Fridge_Model fridgeModel)
        {
            await _service.Fridge_ModelService.UpdateFridgeModelAsync(id, fridgeModel, trachChanges: true);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.Fridge_ModelService.DeleteFridgeModelAsync(id, trachChanges: false);
            return NoContent();
        }
    }
}
