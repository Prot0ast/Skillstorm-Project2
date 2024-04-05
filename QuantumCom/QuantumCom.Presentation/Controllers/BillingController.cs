using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;
using Microsoft.AspNetCore.JsonPatch;

namespace QuantumCom.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillingController : ControllerBase
    {
        private readonly IServiceManager _service;

        public BillingController(IServiceManager serviceManager) => _service = serviceManager;

        [HttpGet]
        public async Task<IActionResult> GetBilling()
        {
            //var bills = await _service.Billing.GetBilling(trackChanges: false);
            //return Ok(bills);

            //TODO: uncomment the above line(s) once implemented and remove the exception from below
            throw new NotImplementedException();
        }

        [HttpGet("{id:guid", Name = "BillingById")]
        public async Task<IActionResult> GetBillingById() 
        {
            //var bill = await_service.Billing.GetBillingById(id, trackChanges: false);
            //return Ok(bill);

            //TODO: uncomment the above line(s) once implemented and remove the exception from below
            throw new NotImplementedException(); 
        }

        /*
         * [HttpPost]
         * public async Task<IActionResult> CreateBilling([FromBody] BillingForCreationDto billing)
         * {
         *      if (billing == null)
         *          return BadRequest("BillingForCreationDto is null");
         *          
         *      if(!ModelState.IsValid)
         *          return UnprocessableEntity(ModelState);
         *          
         *      var createdCustomer = await _service.Billing.CreateBilling(billing);
         *      return CreatedAtRoute("BillingById", new { id = createdBilling.Id }, createdBilling);
         * }
         */
        //TODO: uncomment the above line(s) once implemented

        [HttpDelete("{id:guid}", Name = "CustomerById")]
        public async Task<IActionResult> DeleteBilling(Guid id) 
        {
            //await _service.Customer.DeleteCustomer(id, trackChanges:false);
            return NoContent();

            //TODO: uncomment the above line(s) once implemented
        }

        /*
         * [HttpPut("{id:guid}")]
         * public async Task<IActionResult> UpdateBilling(Guid id, [FromBody] BillingForUpdateDto billing)
         * {
         *      if (billing == null)
         *          return BadRequest("BillingForUpdateDto is null");
         *          
         *      if (!ModelState.IsValid)
         *          return UnprocessableEntity(ModelState);
         *          
         *      await _service.Billing.UpdateBilling(id, billing, trackChanges: true);
         *      return NoContent();
         * }
         */
        //TODO: uncomment the above line(s) once implemented

        /*
         * [HttpPatch("{id:guid}")]
         * public async Task<IActionResult> AdjustBilling(Guid id, [FromBody] JsonPatchDocument<CustomerForUpdateDto> patchDocument)
         * {
         *      if (patchDocument == null)
         *          return BadRequest("patchDocument object sent from client is null");
         *          
         *      var result = await _service.Billing.GetBillingForPatch(id, trackChanges: true);
         *      patchDocument.ApplyTo(result.billingForUpdate);
         *      
         *      TryValidateModel(result.billingForUpdate);
         *      
         *      if (!ModelState.ISValid)
         *          return UnprocessableEntity(ModelState);
         *          
         *      await _service.Billing.SaveChangesForPatch(result.billingForUpdate, result.billingEntity);
         *      
         *      return NoContent();
         * }
         */
        //TODO: uncomment the above line(s) once implemented
    }
}
