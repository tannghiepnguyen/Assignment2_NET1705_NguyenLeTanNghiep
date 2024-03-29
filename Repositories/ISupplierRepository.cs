﻿using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ISupplierRepository
    {
        List<Supplier> GetAllSupplier();
        string GetNameById(int? id);
        int GetIdByName(string name);
    }
}
