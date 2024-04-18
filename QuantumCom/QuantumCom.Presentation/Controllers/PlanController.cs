using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Authorization;

namespace QuantumCom.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanController : ControllerBase
    {
        private readonly IServiceManager _service;
        public PlanController(IServiceManager serviceManager) => _service = serviceManager;

        [HttpGet]
        public async Task<IActionResult> GetAllPlans()
        {
            var plans = await _service.Plan.GetAllPlans(trackChanges: false);
            return Ok(plans);
        }

        [HttpGet("{id:guid}", Name = "PlanById")]
        public async Task<IActionResult> GetPlanById(Guid id)
        {
            var plan = await _service.Plan.GetPlan(id, trackChanges: false);
            return Ok(plan);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreatePlan([FromBody] PlanForCreationDto plan)
        {
             if (plan == null)
                 return BadRequest("PlanForCreationDto is null");
                   
             if(!ModelState.IsValid)
                 return UnprocessableEntity(ModelState);

             if(plan.Name == "Basic" && plan.DeviceLimit > 2 || plan.Name == "Family" && plan.DeviceLimit > 5 || plan.Name == "Unlimited" && plan.DeviceLimit > 15)
            {
                return BadRequest("Maximum Devices Reached");
            }
                 
             var createdPlan = await _service.Plan.CreatePlan(plan);
             return CreatedAtRoute("PlanById", new { id = createdPlan.Id }, createdPlan);
        }

        [HttpDelete("{id:guid}", Name = "PlanById")]
        public async Task<IActionResult> DeletePlan(Guid id)
        {
            await _service.Plan.DeletePlan(id, trackChanges: false);
            return NoContent();
        }
    }
}
