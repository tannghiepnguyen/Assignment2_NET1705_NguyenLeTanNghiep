using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class ProductDAO
    {
        #region
        private static ProductDAO? instance = null;
        private static readonly object instanceLock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }
        #endregion

        public List<FlowerBouquet> GetAllProduct()
        {
            List<FlowerBouquet> productList = new List<FlowerBouquet>();
            try
            {
                using (FUFlowerBouquetManagementV4Context? context = new FUFlowerBouquetManagementV4Context())
                {
                    productList = context.FlowerBouquets.ToList();
                    return productList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }           
        }

        public void InsertProduct(FlowerBouquet flowerBouquet)
        {
            try
            {
                using (FUFlowerBouquetManagementV4Context? context = new FUFlowerBouquetManagementV4Context())
                {
                    context.FlowerBouquets.Add(flowerBouquet);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateProduct(FlowerBouquet flowerBouquet)
        {
            try
            {
                using (FUFlowerBouquetManagementV4Context? context = new FUFlowerBouquetManagementV4Context())
                {
                    context.Entry<FlowerBouquet>(flowerBouquet).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteProduct(FlowerBouquet flowerBouquet)
        {
            try
            {
                using (FUFlowerBouquetManagementV4Context? context = new FUFlowerBouquetManagementV4Context())
                {

                    var deleteProduct = context.FlowerBouquets.SingleOrDefault(c => c.FlowerBouquetId == flowerBouquet.FlowerBouquetId);
                    context.FlowerBouquets.Remove(deleteProduct);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
