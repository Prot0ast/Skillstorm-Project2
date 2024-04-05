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
    public class CustomerPlanController : ControllerBase
    {
        private readonly IServiceManager _service;
        public CustomerPlanController(IServiceManager serviceManager) => _service = serviceManager;

        [HttpGet]
        public async Task<IActionResult> GetCustomerPlans() 
        {
            var customerPlans = await _service.CustomerPlan.GetCustomerPlans(trackChanges: false);
            return Ok(customerPlans);
        }

        [HttpGet("{id:guid}", Name = "CustomerPlanById")]
        public async Task<IActionResult> GetCustomerPlanById(Guid id) 
        {
            var customerPlan = await _service.CustomerPlan.GetCustomerPlanById(id, trackChanges: false);
            return Ok(customerPlan);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomerPlan([FromBody] CustomerPlanForCreationDto customerPlan)
        {
            if (customerPlan == null)
               return BadRequest("CustomerPlanForCreationDto is null");
                   
            if(!ModelState.IsValid)
               return UnprocessableEntity(ModelState);
                   
            var createdCustomerPlan = await _service.CustomerPlan.CreateCustomerPlan(customerPlan);
            return CreatedAtRoute("CustomerPlanById", new { id = createdCustomerPlan.Id }, createdCustomerPlan);
         }

        [HttpDelete("{id:guid}", Name = "CustomerPlanById")]
        public async Task<IActionResult> DeleteCustomerPlan(Guid id) 
        {
            await _service.CustomerPlan.DeleteCustomerPlan(id, trackChanges: false);
            return NoContent();
        }
    }
}
