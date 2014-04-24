﻿using Capstone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Domain.Abstract
{
    public interface BvLocationInterface
    {
        public BvLocation GetBvLocation(string storeNum);
        public void AddBvLocation(BvLocation bvLocation);
        public void DeleteBvLocation(string storeNum);
        public BvLocation EditBvLocation(string storeNum);
    }
}
