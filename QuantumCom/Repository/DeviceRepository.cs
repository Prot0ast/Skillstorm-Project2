using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Contracts;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class DeviceRepository : RepositoryBase<Device>, IDeviceRepository
    {
        public DeviceRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public void CreateDevice(Device device) => Create(device);

        public void DeleteDevice(Device device) => Delete(device);

        public async Task<IEnumerable<Device>> GetAllDevices(bool trackChanges) => await FindAll(trackChanges).OrderBy(d => d.Id).ToListAsync();

        public async Task<Device> GetDeviceById(int id, bool trackChanges) => await FindByCondition(d => d.Id.Equals(id), trackChanges).SingleOrDefaultAsync();
    }
}
