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
        public async Task<IActionResult> GetPlans()
        {
            //var plans = await _service.Plan.GetPlans(trackChanges: false);
            //return Ok(customers);

            //TODO: uncomment the above line(s) once implemented and remove the exception from below
            throw new NotImplementedException();
        }

        [HttpGet("{id:guid}", Name = "PlanById")]
        public async Task<IActionResult> GetPlanById()
        {
            //var plan = await _service.Plan.GetPlanById(id, trackChanges: false);
            //return Ok(plan);

            //TODO: uncomment the above line(s) once implemented and remove the exception from below
            throw new NotImplementedException();
        }

        /*
         * [HttpPost]
         * public async Task<IActionResult> CreatePlan([FromBody] PlanForCreationDto plan)
         * {
         *      if (plan == null)
         *          return BadRequest("PlanForCreationDto is null");
         *          
         *      if(!ModelState.IsValid)
         *          return UnprocessableEntity(ModelState);
         *          
         *      var createdPlan = await _service.Plan.CreatePlan(plan);
         *      return CreatedAtRoute("PlanById", new { id = createdPlan.Id }, createdPlan);
         * }
         */
        //TODO: uncomment the above line(s) once implemented

        [HttpDelete("{id:guid}", Name = "PlanById")]
        public async Task<IActionResult> DeletePlan(Guid id)
        {
            //await _service.Plan.DeletePlan(id, trackChanges:false);
            return NoContent();

            //TODO: uncomment the above line(s) once implemented
        }

        /*
         * [HttpPut("{id:guid}")]
         * public async Task<IActionResult> UpdatePlan(Guid id, [FromBody] PlanForUpdateDto plan)
         * {
         *      if (plan == null)
         *          return BadRequest("PlanForUpdateDto is null");
         *          
         *      if (!ModelState.IsValid)
         *          return UnprocessableEntity(ModelState);
         *          
         *      await _service.Plan.UpdatePlan(id, plan, trackChanges: true);
         *      return NoContent();
         * }
         */
        //TODO: uncomment the above line(s) once implemented

        /*
         * [HttpPatch("{id:guid}")]
         * public async Task<IActionResult> AdjustPlan(Guid id, [FromBody] JsonPatchDocument<PlanForUpdateDto> patchDocument)
         * {
         *      if (patchDocument == null)
         *          return BadRequest("patchDocument object sent from client is null");
         *          
         *      var result = await _service.Plan.GetPlanForPatch(id, trackChanges: true);
         *      patchDocument.ApplyTo(result.planForUpdate);
         *      
         *      TryValidateModel(result.planForUpdate);
         *      
         *      if (!ModelState.IsValid)
         *          return UnprocessableEntity(ModelState);
         *      
         *      await _service.Plan.SaveChangesForPatch(result.planForUpdate, result.planEntity);
         *      
         *      return NoContent();
         * }
         */
        //TODO: uncomment the above line(s) once implemented
    }
}
