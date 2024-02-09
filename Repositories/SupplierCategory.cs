using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class SupplierCategory : ISupplierRepository
    {
        public List<Supplier> GetAllSupplier() => SupplierDAO.Instance.GetAllSupplier();
    }
}
