using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class DeviceNotFoundException : NotFoundException
    {
        public DeviceNotFoundException(Guid id, Guid CustId) : base( $"Device with id {id} and customer id {CustId}" )
        {
        }
    }
}
