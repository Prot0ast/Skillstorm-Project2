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
    public class DeviceController : ControllerBase
    {
        private readonly IServiceManager _service;
        public DeviceController(IServiceManager serviceManager) => _service = serviceManager;

        [HttpGet]
        public async Task<IActionResult> GetAllDevices()
        {
            var devices = await _service.Device.GetAllDevices(trackChanges: false);
            return Ok(devices);
        }

        [HttpGet("{id:guid}", Name = "DeviceById")]
        public async Task<IActionResult> GetDeviceById(Guid id)
        {
            var device = await _service.Device.GetDeviceById(id, trackChanges: false);
            return Ok(device);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateDevice([FromBody] DeviceForCreationDto device)
        {
           if (device == null)
               return BadRequest("DeviceForCreationDto is null");
                   
           if(!ModelState.IsValid)
               return UnprocessableEntity(ModelState);
                   
           var createdDevice = await _service.Device.CreateDevice(device);
           return CreatedAtRoute("DeviceById", new { id = createdDevice.Id }, createdDevice);
        }

        [HttpDelete("{id:guid}", Name = "DeviceById")]
        public async Task<IActionResult> DeleteDevice(Guid id)
        {
            await _service.Device.DeleteDevice(id, trackChanges:false);
            return NoContent();
        }
    }
}
