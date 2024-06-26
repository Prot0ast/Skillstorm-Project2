﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Contracts
{
    public interface IDeviceRepository
    {

        Task<IEnumerable<Device>> GetDevicesByCustId(Guid custId, bool trackChanges);
        Task<IEnumerable<Device>> GetAllDevices(bool trackChanges);
        Task<Device> GetDeviceById(Guid id, bool trackChanges);
        void CreateDevice(Device device);
        void DeleteDevice(Device device);
    }
}
