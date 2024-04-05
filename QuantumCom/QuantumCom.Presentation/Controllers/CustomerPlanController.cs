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
            //var customerPlans = await _service.CustomerPlan.GetCustomerPlans(trackChanges: false);
            //return Ok(customerPlans);

            //TODO: uncomment the above line(s) once implemented and remove the exception from below
            throw new NotImplementedException();
        }

        [HttpGet("{id:guid}", Name = "CustomerPlanById")]
        public async Task<IActionResult> GetCustomerPlanById() 
        {
            //var customerPlan = await _service.CustomerPlan.GetCustomerPlanById(id, trackChanges: false);
            //return Ok(customerPlan);

            //TODO: uncomment the above line(s) once implemented and remove the exception from below
            throw new NotImplementedException();
        }

        /*
         * [HttpPost]
         * public async Task<IActionResult> CreateCustomerPlan([FromBody] CustomerPlanForCreationDto customerPlan)
         * {
         *      if (customerPlan == null)
         *          return BadRequest("CustomerPlanForCreationDto is null");
         *          
         *      if(!ModelState.IsValid)
         *          return UnprocessableEntity(ModelState);
         *          
         *      var createdCustomerPlan = await _service.CustomerPlan.CreateCustomerPlan(customerPlan);
         *      return CreatedAtRoute("CustomerPlanById", new { id = createdCustomerPlan.Id }. createdCustomerPlan);
         * }
         */
        //TODO: uncomment the above line(s) once implemented

        [HttpDelete("{id:guid}", Name = "CustomerPlanById")]
        public async Task<IActionResult> DeleteCustomerPlan(Guid id) 
        {
            //await _service.CustomerPlan.DeleteCustomerPlan(id, trackChanges:false);
            return NoContent();

            //TODO: uncomment the above line(s) once implemented
        }

        /*
         * [HttpPut("{id:guid}")]
         * public async Task<IActionResult> UpdateCustomerPlan(Guid id, [FromBody] CustomerPlanForUpdateDto customerPlan)
         * {
         *      if (customerPlan == null)
         *          return BadRequest("CustomerPlanForUpdateDto is null");
         *          
         *      if (!ModelState.IsValid)
         *          return UnprocessableEntity(ModelState);
         *          
         *      await _service.CustomerPlan.UpdateCustomerPlan(id, customerPlan, trackChanges: true);
         *      return NoContent();
         * }
         */
        //TODO: uncomment the above line(s) once implemented

        /*
         * [HttpPatch("{id:guid}")]
         * public async Task<IActionResult> AdjustCustomerPlan(Guid id, [FromBody] JsonPatchDocument<CustomerPlanForUpdateDto> patchDocument)
         * {
         *      if (patchDocument == null)
         *          return BadRequest("patchDocument object sent from client is null");
         *          
         *      var result = await _service.CustomerPlan.GetCustomerPlanForPatch(id, trackChanges: true);
         *      patchDocument.ApplyTo(result.customerPlanForUpdate);
         *      
         *      TryValidateModel(result.customerPlanForUpdate);
         *      
         *      if (!ModelState.IsValid)
         *          return UnprocessableEntity(ModelState);
         *      
         *      await _service.CustomerPlan.SaveChangesForPatch(result.customerPlanForUpdate, result.customerPlanEntity);
         *      
         *      return NoContent();
         * }
         */
        //TODO: uncomment the above line(s) once implemented
    }
}
