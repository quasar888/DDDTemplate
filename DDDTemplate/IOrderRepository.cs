﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTemplate
{
    public interface IOrderRepository
    {
        void Save(Order order);
        Order GetById(Guid orderId);
    }
}
