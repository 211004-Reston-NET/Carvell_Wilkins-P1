using System;
using System.Collections.Generic;
using System.Linq;
using CRUSDL;
using CRUSModels;

namespace CRUSBL
{
    /// <summary>
    /// Handles all the business logic for the our restuarant application
    /// They are in charge of further processing/sanitizing/furthur validation of data
    /// Any Logic
    /// </summary>
    public class ProductBL :IProductBL
    {
        private IRepository _repo;
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it this way because we can easily switch out which implementation details we will be using
        /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
        /// have the implementation
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public ProductBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public Product AddProduct(Product p_product)
        {
            if (p_product.Name == null )
            {
                throw new Exception("You must have a value in all of the properties of the customeraurant class");
            }

            return _repo.AddProduct(p_product);
        }

         public OrderPlacement AddOrder(OrderPlacement p_orderPlacement)
        {
            //if (p_orderPlacement.OrderId == null || p_orderPlacement.CustomerId == null)
            {
                throw new Exception("You must have a value in all of the properties of the customeraurant class");
            }

           // return _repo.AddOrder(p_orderPlacement);
        }

        public List<Product> GetAllProduct()
        {
            //Maybe my business operation needs to capitalize every name of a restaurant
            List<Product> listOfProduct = _repo.GetAllProduct();
            for (int i = 0; i < listOfProduct.Count; i++)
            {
                listOfProduct[i].Name = listOfProduct[i].Name.ToLower(); 
            }

            return listOfProduct;
        }

        

        public Customer GetSingleCustomer(string p_name, string p_email)
        {
            List<Customer> listOfCustomers = _repo.GetAllCustomer();
            return listOfCustomers.FirstOrDefault(cust => cust.Name == p_name && cust.Email == p_email);
        }

        public OrderPlacement OrderPlacement(Customer p_customer, OrderPlacement p_order)
        {
            //  if (p_productID == null || p_customer.Email == null || p_customer.Address == null)
            // {
            //     throw new Exception("You must have a value in all of the properties of the customeraurant class");
            // }

            return _repo.PlaceOrder(p_customer, p_order);
        }

        public List<Product> getAllProduct()
        {
            throw new NotImplementedException();
        }

        public List<Product> getProduct(string p_product)
        {
            throw new NotImplementedException();
        }
    }
}



// using System.Collections.Generic;
// using System.Linq;
// using CRUSDL;
// using CRUSModels;

// namespace CRUSBL
// {
//     public class ProductBL : IProductBL
//     {
//         private IRepository _repo;
//         public ProductBL(IRepository p_repo)
//         {
//             _repo = p_repo;
//         }

//         public List<Product> getAllProduct()
//         {
//             throw new System.NotImplementedException();
//         }

//         public List<Product> getProduct()
//         {
//             throw new System.NotImplementedException();
//         }

//         public List<Product> getProduct(string p_product)
//         {
//             throw new System.NotImplementedException();
//         }

//         // public List<Product> GetProducts()
//         // {
//         //     List<Product> products = _repo.GetAllProducts();
//         //     return products.Where(products =>
//         //     {
//         //         return products.Name
//         //     }).ToList();
//         // }
//     }
// }