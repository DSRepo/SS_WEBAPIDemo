﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSTest.Core.DataAccess;


namespace SSTest.Core.Interface
{
    public interface IProductRepository: IRepository<Product>
    {
        //any custome method can be added here
    }
}
