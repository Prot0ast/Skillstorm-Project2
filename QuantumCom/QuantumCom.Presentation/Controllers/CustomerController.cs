using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Contracts;
using Shared.DataTransferObjects;
using Microsoft.AspNetCore.JsonPatch;

namespace QuantumCom.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IServiceManager _service;

        public CustomerController(IServiceManager serviceManager) => _service = serviceManager;

        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            //var customers = await _service.Customer.GetCustomers(trackChanges: false);
            //return Ok(customers);
            
            //TODO: uncomment the above line(s) once implemented and remove the exception from below
            throw new NotImplementedException();
        }

        [HttpGet("{id:guid}", Name = "CustomerById")]
        public async Task<IActionResult> GetCustomerById() 
        {
            //var customer = await _service.Customer.GetCustomerById(id, trackChanges: false);
            //return Ok(customer);

            //TODO: uncomment the above line(s) once implemented and remove the exception from below
            throw new NotImplementedException();
        }

        /*
         * [HttpPost]
         * public async Task<IActionResult> CreateCustomer([FromBody] CustomerForCreationDto customer)
         * {
         *      if (customer == null)
         *          return BadRequest("CustomerForCreationDto is null");
         *          
         *      if(!ModelState.IsValid)
         *          return UnprocessableEntity(ModelState);
         *          
         *      var createdCustomer = await _service.Customer.CreateCustomer(customer);
         *      return CreatedAtRoute("CustomerById", new { id = createdCustomer.Id }, createdCustomer);
         *      
         *      
         * }
         */
        //TODO: uncomment the above line(s) once implemented

        [HttpDelete("{id:guid}", Name = "CustomerById")]
        public async Task<IActionResult> DeleteCustomer(Guid id)
        {
            //await _service.Customer.DeleteCustomer(id, trackChanges:false);
            return NoContent();

            //TODO: uncomment the above line(s) once implemented
        }

        /*
         * [HttpPut("{id:guid}")]
         * public async Task<IActionResult> UpdateCustomer(Guid id, [FromBody] CustomerForUpdateDto customer)
         * {
         *      if (customer == null)
         *          return BadRequest("CustomerForUpdateDto is null");
         *          
         *      if (!ModelState.IsValid)
         *          return UnprocessableEntity(ModelState);
         *          
         *      await _service.Customer.UpdateCustomer(id, customer, trackChanges: true);
         *      return NoContent();
         * }
         */
        //TODO: uncomment the above line(s) once implemented

        /*
         * [HttpPatch("{id:guid}")]
         * public async Task<IActionResult> AdjustCustomer(Guid id, [FromBody] JsonPatchDocument<CustomerForUpdateDto> patchDocument)
         * {
         *      if (patchDocument == null)
         *          return BadRequest("patchDocument object sent from client is null");
         *          
         *      var result = await _service.Customer.GetCustomerForPatch(id, trackChanges: true);
         *      patchDocument.ApplyTo(result.customerForUpdate);
         *      
         *      TryValidateModel(result.customerForUpdate);
         *      
         *      if (!ModelState.IsValid)
         *          return UnprocessableEntity(ModelState);
         *      
         *      await _service.Customer.SaveChangesForPatch(result.customerForUpdate, result.customerEntity);
         *      
         *      return NoContent();
         * }
         */
        //TODO: uncomment the above line(s) once implemented
    }
}
