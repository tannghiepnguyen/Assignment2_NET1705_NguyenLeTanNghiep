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

		public int GetIdByName(string name) => ProductDAO.Instance.GetIdByName(name);

		public string GetNameById(int id) => ProductDAO.Instance.GetNameById(id);

		public void UpdateProduct(FlowerBouquet product) => ProductDAO.Instance.UpdateProduct(product);
    }
}
