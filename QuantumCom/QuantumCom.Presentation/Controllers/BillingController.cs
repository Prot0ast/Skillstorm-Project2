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
    public class BillingController : ControllerBase
    {
        private readonly IServiceManager _service;

        public BillingController(IServiceManager serviceManager) => _service = serviceManager;

        [HttpGet]
        public async Task<IActionResult> GetBilling()
        {
            var bills = await _service.Billing.GetAllBillings(trackChanges: false);
            return Ok(bills);
        }

        [HttpGet("{id:guid}", Name = "BillingById")]
        public async Task<IActionResult> GetBillingById(Guid custId, Guid id) 
        {
            var bill = await _service.Billing.GetBillingById(custId, id, trackChanges: false);
            return Ok(bill);
        }

        [HttpGet("{id:guid}", Name = "BillingByAmount")]
        public async Task<IActionResult> GetBillingByAmount(decimal amount) 
        {
            var bill = await _service.Billing.GetBillingByAmount(amount, trackChanges: false);
            return Ok(bill);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateBilling([FromBody] BillingForCreationDto billing)
        {
            if (billing == null)
               return BadRequest("BillingForCreationDto is null");
                   
            if(!ModelState.IsValid)
               return UnprocessableEntity(ModelState);
                   
            var createdBilling = await _service.Billing.CreateBilling(billing);
            return CreatedAtRoute("BillingById", new { id = createdBilling.Id }, createdBilling);
        }

        [HttpDelete("{id:guid}", Name = "BillingById")]
        public async Task<IActionResult> DeleteBilling(Guid id)
        {
            await _service.Billing.DeleteBilling(id, trackChanges: false);
            return NoContent();
        }
    }
}
