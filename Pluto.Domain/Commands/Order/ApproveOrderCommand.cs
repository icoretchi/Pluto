﻿using Pluto.Domain.Commands.Common;
using System;

namespace Pluto.Domain.Commands.Order
{
    public class ApproveOrderCommand : Command
    {
        public Guid UserId { get; set; }
        public Guid OrderId { get; set; }
    }
}
