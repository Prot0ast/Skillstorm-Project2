using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IDeviceService
    {
        Task<IEnumerable<DeviceDto>> GetDevicesByCustId(Guid custId, bool trackChanges);
        Task<DeviceDto> GetDeviceById(Guid deviceId, bool trackChanges);
        Task<IEnumerable<DeviceDto>> GetAllDevices(bool trackChanges);
        Task<DeviceDto> CreateDevice(DeviceForCreationDto device);
        Task DeleteDevice(Guid deviceId, bool trackChanges);

    }
}
