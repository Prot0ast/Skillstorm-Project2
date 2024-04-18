using AutoMapper;
using Contracts;
using Entities;
using Entities.Exceptions;
using Microsoft.Data.SqlClient;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class DeviceService : IDeviceService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public DeviceService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<DeviceDto> CreateDevice(DeviceForCreationDto device)
        {
            var deviceEntity = _mapper.Map<Device>(device);
            var customer = await _repositoryManager.Customer.GetCustomerById(deviceEntity.CustId, false);
            if(customer == null)
            {
                throw new CustomerNotFoundException(deviceEntity.CustId);
            }
            deviceEntity.CustId = customer.Id;
            _repositoryManager.Device.CreateDevice(deviceEntity);
            var deviceToReturn = _mapper.Map<DeviceDto>(deviceEntity);
            return deviceToReturn;
        }

        public async Task DeleteDevice(Guid deviceId, bool trackChanges)
        {
            var device = await _repositoryManager.Device.GetDeviceById(deviceId, trackChanges);
            if(device == null)
            {
                throw new DeviceNotFoundException(deviceId);
            }

            _repositoryManager.Device.DeleteDevice(device);
            await _repositoryManager.SaveAsync();


        }

        public async Task<IEnumerable<DeviceDto>> GetAllDevices(bool trackChanges)
        {
            var device = await _repositoryManager.Device.GetAllDevices(trackChanges);
            var deviceDto = _mapper.Map<IEnumerable<DeviceDto>>(device);
            return deviceDto;
        }

        public async Task<DeviceDto> GetDeviceById(Guid deviceId, bool trackChanges)
        {
            var device = await _repositoryManager.Device.GetDeviceById(deviceId, trackChanges);
            if(device == null)
            {
                throw new DeviceNotFoundException(deviceId);
            }

            var deviceDto = _mapper.Map<DeviceDto>(device);
            return deviceDto;
        }

        public async Task<IEnumerable<DeviceDto>> GetDevicesByCustId(Guid custId, bool trackChanges)
        {
            var devices = await _repositoryManager.Device.GetDevicesByCustId(custId, trackChanges);
            var devicesDto = _mapper.Map<IEnumerable<DeviceDto>>(devices);
            return devicesDto;
        }
    }
}
