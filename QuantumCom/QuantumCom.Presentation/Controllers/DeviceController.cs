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
    public class DeviceController : ControllerBase
    {
        private readonly IServiceManager _service;
        public DeviceController(IServiceManager serviceManager) => _service = serviceManager;

        [HttpGet]
        public async Task<IActionResult> GetDevices()
        {
            //var devices = await _service.Device.GetDevices(trackChanges: false);
            //return Ok(devices);

            //TODO: uncomment the above line(s) once implemented and remove the exception from below
            throw new NotImplementedException();
        }

        [HttpGet("{id:guid}", Name = "DeviceById")]
        public async Task<IActionResult> GetDeviceById()
        {
            //var device = await _service.Device.GetDeviceById(id, trackChanges: false);
            //return Ok(device);

            //TODO: uncomment the above line(s) once implemented and remove the exception from below
            throw new NotImplementedException();
        }

        /*
         * [HttpPost]
         * public async Task<IActionResult> CreateDevice([FromBody] DeviceForCreationDto device)
         * {
         *      if (device == null)
         *          return BadRequest("DeviceForCreationDto is null");
         *          
         *      if(!ModelState.IsValid)
         *          return UnprocessableEntity(ModelState);
         *          
         *      var createdDevice = await _service.Device.CreateDevice(device);
         *      return CreatedAtRoute("DeviceById", new { id = createdDevice.Id }, createdDevice);
         * }
         */
        //TODO: uncomment the above line(s) once implemented

        [HttpDelete("{id:guid}", Name = "DeviceById")]
        public async Task<IActionResult> DeleteDevice(Guid id)
        {
            //await _service.Device.DeleteDevice(id, trackChanges:false);
            return NoContent();

            //TODO: uncomment the above line(s) once implemented
        }

        /*
         * [HttpPut("{id:guid}")]
         * public async Task<IActionResult> UpdateDevice(Guid id, [FromBody] DeviceForUpdateDto device)
         * {
         *      if (device == null)
         *          return BadRequest("DeviceForUpdateDto is null");
         *          
         *      if (!ModelState.IsValid)
         *          return UnprocessableEntity(ModelState);
         *          
         *      await _service.Device.UpdateDevice(id, device, trackChanges: true);
         *      return NoContent();
         * }
         */
        //TODO: uncomment the above line(s) once implemented

        /*
         * [HttpPatch("{id:guid}")]
         * public async Task<IActionResult> AdjustDevice(Guid id, [FromBody] JsonPatchDocument<DeviceForUpdateDto> patchDocument)
         * {
         *      if (patchDocument == null)
         *          return BadRequest("patchDocument object sent from client is null");
         *          
         *      var result = await _service.Device.GetDeviceForPatch(id, trackChanges: true);
         *      patchDocument.ApplyTo(result.deviceForUpdate);
         *      
         *      TryValidateModel(result.deviceForUpdate);
         *      
         *      if (!ModelState.IsValid)
         *          return UnprocessableEntity(ModelState);
         *      
         *      await _service.Device.SaveChangesForPatch(result.deviceForUpdate, result.deviceEntity);
         *      
         *      return NoContent();
         * }
         */
        //TODO: uncomment the above line(s) once implemented
    }
}
