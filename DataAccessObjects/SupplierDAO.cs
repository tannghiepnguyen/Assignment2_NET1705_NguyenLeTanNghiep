using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class SupplierDAO
    {
        #region
        private static SupplierDAO? instance = null;
        private static readonly object instanceLock = new object();
        private SupplierDAO() { }
        public static SupplierDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new SupplierDAO();
                    }
                    return instance;
                }
            }
        }
        #endregion

        public List<Supplier> GetAllSupplier()
        {
            List<Supplier> supplierList = new List<Supplier>();
            try
            {
                using (FUFlowerBouquetManagementV4Context context = new FUFlowerBouquetManagementV4Context())
                {
                    supplierList = context.Suppliers.ToList();
                    return supplierList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GetSupplierNameById(int? supplierId)
        {
			try
			{
				using (FUFlowerBouquetManagementV4Context context = new FUFlowerBouquetManagementV4Context())
				{
                    return context.Suppliers.FirstOrDefault(x => x.SupplierId == supplierId).SupplierName;
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
    }
}
