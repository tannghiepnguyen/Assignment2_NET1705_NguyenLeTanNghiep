using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void AddProduct(FlowerBouquet product) => ProductDAO.Instance.InsertProduct(product);

        public void DeleteProduct(FlowerBouquet product) => ProductDAO.Instance.DeleteProduct(product);

        public List<FlowerBouquet> GetAllProduct() => ProductDAO.Instance.GetAllProduct();

        public void UpdateProduct(FlowerBouquet product) => ProductDAO.Instance.UpdateProduct(product);
    }
}
