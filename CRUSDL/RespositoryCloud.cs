using System.Collections.Generic;
using Model = CRUSModels;
using CRUSDL;
using CRUSModels;
using System.Linq;

namespace CRUSDL
{
    public class RepositoryCloud : IRepository
    {
        private ClothesRUSdemoContext _context;
        public RepositoryCloud(ClothesRUSdemoContext p_context)
        {
            _context = p_context;
        }


        public Customer AddCustomer(Customer p_customer)
        {
            _context.Customers.Add(p_customer);
            
         

            //This method will save the changes made to the database
            _context.SaveChanges();
            return p_customer;
        }

        public OrderPlacement AddOrder(OrderPlacement p_orderPlacement)
        {
            _context.OrderPlacements.Add(p_orderPlacement);
            _context.SaveChanges();
            return p_orderPlacement;
        }

        public List<Clothing> GetAllClothing()
        {
            throw new System.NotImplementedException();
        }

        public List<Customer> GetAllCustomer()
        {
            return _context.Customers.ToList();
            
            // Select(Customer =>
            // new Model.Customer()
            // {
            //      Name= Customer.Name,
            //      Address = Customer.Address,
            //      Email = Customer.Email,
            //      ID = Customer.CustomerId
            // }
            //  ).ToList();

        }
        List<OrderPlacement> GetAllOrders()
          {
            return _context.OrderPlacements.ToList();
            
          
        }

        public List<LineItem> GetAllLineItems() //(int p_productId)
        {
            
            //  return _context.LineItems.Select(LineItems =>
            // new Model.LineItem()
            // {
            //      Description= LineItems.Description,
            //      ProductId = LineItems.ProductId, 
            //      Price= (int)LineItems.Price, 
            //      Quantity= LineItems.Quantity    
                return null;          
               //  return _context.LineItems.ToList();
            // } 
            //  ).ToList();
        }

      

        public List<Product> GetAllProducts()
        {
            //  return _context.Products.Select(Products =>
            // new Model.Product()
            // {
            //      Brand= Products.Brand,
            //      Clothing_Type = Products.ClothingType,    
               return _context.Products.ToList();             
                
           // }
            //  ).ToList();
        }

        public Product AddProduct ( Product p_product)
        
        {
            _context.Products.Add (p_product);
            //  return _context.Products.Select(Products =>
            // new Model.Product()
            // {
            //      Brand= Products.Brand,
            //      Clothing_Type = Products.ClothingType,    
               _context.SaveChanges();
            return p_product;         
                
           // }
            //  ).ToList();
        }

        public List<Review> GetAllReview()
        {
            throw new System.NotImplementedException();
        }

      

         public List<StoreFront> GetAllStoreFront()
        {
            //Method Syntax
           return _context.StoreFronts.ToList();
           
        //    Select(StoreFront =>
        //     new Model.StoreFront()
        //     {
        //          Name= StoreFront.Name,
        //          Address = StoreFront.Address,
                 
        //          StoreFrontId = StoreFront.StoreFrontId
        //     }
        //      ).ToList();
        
        }

          public List<Product> GetAllProduct()
        {
            //Method Syntax
           return _context.Products.ToList();
        }

        public List<StoreFront> GetAllStoreFrontbylocation(string location)
        {
            throw new System.NotImplementedException();
        }

        /* public List<StoreFront> GetAllStoreFrontbylocation(string location)
         {
             Entity.StoreFront StorefrontToFind    - temp change
         }*/

        public Product GetProductsById(int p_Id)
        {
            return _context.Products.Find(p_Id);
        }

        public OrderPlacement PlaceOrder(Customer p_customer, OrderPlacement p_order)
        {
            throw new System.NotImplementedException();
        }

        

        List<LineItem> IRepository.GetAllLineItems(int p_productId)
        {
            throw new System.NotImplementedException();
        }

        List<LineItem> IRepository.GetAllLineItems()
        {
            throw new System.NotImplementedException();
        }

        List<Product> IRepository.GetAllProduct()
        {
            return _context.Products.ToList();    
        }

        Product IRepository.GetProductsByItemId(int p_ItemId)
        {
            throw new System.NotImplementedException();
        }

        public List<OrderPlacement> GetOrders(string p_order)
        {
            throw new System.NotImplementedException();
        }

        public OrderPlacement DeleteOrderPlacement(OrderPlacement p_orderPlacement)
        {
           _context.OrderPlacements.Remove(p_orderPlacement);
           _context.SaveChanges();
           return p_orderPlacement;
        }
        public Customer DeleteCustomer(Customer p_customer)
        {
           _context.Customers.Remove(p_customer);
           _context.SaveChanges();
           return p_customer;
        }
        public List<OrderPlacement> GetOrder()
        {
            throw new System.NotImplementedException();
        }
         public Customer GetCustomerById(int p_customerId)
        {
            return _context.Customers.Find(p_customerId);
        }

         public OrderPlacement GetOrderById(int p_orderId)
        {
            return _context.OrderPlacements.Find(p_orderId);
        }

        public List<Product> GetAllProductByProductID(int p_prodcutId)
        {
            return _context.Products.ToList();    
        }

        public Customer GetSingleCustomer()
        {
           return _context.Customers.Find();
        }

        List<OrderPlacement> IRepository.GetAllOrders()
        {
            
          
            return _context.OrderPlacements.ToList();
            
          
        
        }
    }
}


