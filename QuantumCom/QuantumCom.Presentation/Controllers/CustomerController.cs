using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Contracts;
using Shared.DataTransferObjects;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;

namespace QuantumCom.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class CustomerController : ControllerBase
    {
        private readonly IServiceManager _service;

        public CustomerController(IServiceManager serviceManager) => _service = serviceManager;

        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            var customers = await _service.Customer.GetAllCustomersAsync(trackChanges: false);
            return Ok(customers);
        }

        [HttpGet("{id:guid}", Name = "CustomerById")]
        public async Task<IActionResult> GetCustomerById(Guid id) 
        {
            var customer = await _service.Customer.GetCustomerAsync(id, trackChanges: false);
            return Ok(customer);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] CustomerForCreationDto customer)
        {
            if (customer == null)
               return BadRequest("CustomerForCreationDto is null");
                   
            if(!ModelState.IsValid)
               return UnprocessableEntity(ModelState);
                   
            var createdCustomer = await _service.Customer.CreateCustomerAsync(customer);
            return CreatedAtRoute("CustomerById", new { id = createdCustomer.Id }, createdCustomer);
         }

        [HttpDelete("{id:guid}", Name = "CustomerById")]
        public async Task<IActionResult> DeleteCustomer(Guid id)
        {
            await _service.Customer.DeleteCustomerAsync(id, trackChanges: false);
            return NoContent();
        }

        
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateCustomer(Guid id, [FromBody] CustomerForUpdateDto customer)
        {
            if (customer == null)
                return BadRequest("CustomerForUpdateDto is null");
                    
            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);
                   
            await _service.Customer.UpdateCustomerAsync(id, customer, trackChanges: true);
            return NoContent();
        }

        
         [HttpPatch("{id:guid}")]
         public async Task<IActionResult> AdjustCustomer(Guid id, [FromBody] JsonPatchDocument<CustomerForUpdateDto> patchDocument)
         {
            if (patchDocument == null)
               return BadRequest("patchDocument object sent from client is null");
                   
            var result = await _service.Customer.GetCustomerForPatchAsync(id, trackChanges: true);
            patchDocument.ApplyTo(result.customerForUpdate);
               
            TryValidateModel(result.customerForUpdate);
               
            if (!ModelState.IsValid)
               return UnprocessableEntity(ModelState);
               
            await _service.Customer.SaveChangesForPatchAsync(result.customerForUpdate, result.customerEntity);
               
            return NoContent();
         }
    }
}
