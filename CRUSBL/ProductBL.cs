using System.Collections.Generic;
using System.Linq;
using CRUSDL;
using CRUSModels;

namespace CRUSBL
{
    public class ProductBL : IProductBL
    {
        private IRepository _repo;
        public ProductBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public List<Product> getAllProduct()
        {
            throw new System.NotImplementedException();
        }

        public List<Product> getProduct()
        {
            throw new System.NotImplementedException();
        }

        public List<Product> getProduct(string p_product)
        {
            throw new System.NotImplementedException();
        }

        // public List<Product> GetProducts()
        // {
        //     List<Product> products = _repo.GetAllProducts();
        //     return products.Where(products =>
        //     {
        //         return products.Name
        //     }).ToList();
        // }
    }
}