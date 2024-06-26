﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class DeviceNotFoundException : NotFoundException
    {
        public DeviceNotFoundException(Guid id) : base( $"Device with id {id} is not found in the database")
        {
        }
    }
}
