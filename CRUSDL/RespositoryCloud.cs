using System.Collections.Generic;
using Model = CRUSModels;
using Entity = CRUSDL;
using CRUSModels;
using System.Linq;

namespace CRUSDL
{
    public class RepositoryCloud : IRepository
    {
        private Entity.ClothesRUSdemoContext _context;
        public RepositoryCloud(Entity.ClothesRUSdemoContext p_context)
        {
            _context = p_context;
        }


        public Model.Customer AddCustomer(Model.Customer p_customer)
        {
            _context.Customers.Add
            (
               new Customer()
               {
                   Name = p_customer.Name,
                   Email = p_customer.Email,
                   Address = p_customer.Address
               }
            );

            //This method will save the changes made to the database
            _context.SaveChanges();
            return p_customer;
        }

        public OrderPlacement AddOrder(OrderPlacement p_orderPlacement)
        {
            throw new System.NotImplementedException();
        }

        public List<Clothing> GetAllClothing()
        {
            throw new System.NotImplementedException();
        }

        public List<Customer> GetAllCustomer()
        {
            return _context.Customers.Select(Customer =>
            new Model.Customer()
            {
                 Name= Customer.Name,
                 Address = Customer.Address,
                 Email = Customer.Email,
                 ID = Customer.CustomerId
            }
             ).ToList();

        }

        public List<LineItem> GetAllLineItems(int p_productId)
        {
            
            //  return _context.LineItems.Select(LineItems =>
            // new Model.LineItem()
            // {
            //      Description= LineItems.Description,
            //      ProductId = LineItems.ProductId, 
            //      Price= (int)LineItems.Price, 
            //      Quantity= LineItems.Quantity              
                  throw new System.NotImplementedException();
            // } 
            //  ).ToList();
        }

        public List<LineItem> GetAllLineItems()
        {
        //      return _context.LineItems.Select(LineItems =>
        //     new Model.LineItem()
        //     {
        //          Description= LineItems.Description,
        //          ProductId = LineItems.ProductId, 
        //          Price= (int)LineItems.Price, 
        //          Quantity= LineItems.Quantity              
                 throw new System.NotImplementedException();
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
                 throw new System.NotImplementedException();             
                
           // }
            //  ).ToList();
        }

        public List<Review> GetAllReview()
        {
            throw new System.NotImplementedException();
        }

        // public List<StoreFront> GetAllStoreFront(Model.StoreFront p_storefront)
        // {
           
        // // Query syntax

        // var result = (from storefront in _context.StoreFronts
        // where storefront.Location == p_storefront.Location
        // select storefront);
        //     //throw new System.NotImplementedException();

        //     List<Model.StoreFront> listofStoreFront = new List<Model.StoreFront>();

        //     foreach (Entity.StoreFront storefront in result)
        //     {
        //         listofStoreFront.Add(new Model.StoreFront()

        //         {
        //             Name = storefront.Name,
        //             Location = storefront.Location
        //         });
        //     }
        //     return listofStoreFront; ----- may need to change back

         public List<Model.StoreFront> GetAllStoreFront()
        {
            //Method Syntax
           return _context.StoreFronts.Select(StoreFront =>
            new Model.StoreFront()
            {
                 Name= StoreFront.Name,
                 Address = StoreFront.Address,
                 
                 StoreFrontId = StoreFront.StoreFrontId
            }
             ).ToList();
        
        }

          public List<Model.Product> GetAllProduct()
        {
            //Method Syntax
           return _context.Products.Select(Product =>
            new Model.Product()
            {
                 Name= Product.Name,
                 ProductId = (int) Product.ProductId,
                 
                 Price = (int) Product.Price,
            }
             ).ToList();
        
        }

        // public List<StoreFront> GetAllStoreFront()
        // {
        //     throw new System.NotImplementedException();
        // } may need to change back 10.30. 4.15

        public List<StoreFront> GetAllStoreFrontbylocation(string location)
        {
            throw new System.NotImplementedException();
        }

        /* public List<StoreFront> GetAllStoreFrontbylocation(string location)
         {
             Entity.StoreFront StorefrontToFind    - temp change
         }*/

        public Product GetProductsByItemId(int p_ItemId)
        {
            throw new System.NotImplementedException();
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

        List<Product> IRepository.GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        Product IRepository.GetProductsByItemId(int p_ItemId)
        {
            throw new System.NotImplementedException();
        }
    }
}



/*public List<Model.Customer> GetAllCustomer()
 {
     //Method Syntax
     return _context.Customers.Select(Customer => 
         new Model.Customer()
         {
             Name = Customer.Name,
             Email = Customer.EmailAddress,
             Address = Customer.Address,
             ID = Customer.PersonId
         }
     ).ToList();

 public List<Customer> GetAllCustomer()
 {
     throw new System.NotImplementedException();
 }

 public List<LineItems> GetAllLineItems(string p_locations)
 {
     throw new System.NotImplementedException();
 }

 public List<Review> GetAllReview()
 {
     throw new System.NotImplementedException();
 }

 public List<StoreFront> GetAllStoreFront()
 {
     throw new System.NotImplementedException();
 }
}

 public List<Model.Customer> GetAllCustomer()
 {
     //Method Syntax
     return _context.Customers.Select(rest => 
         new Model.Restaurant()
         {
             Name = Customer.customerName,
             Email = Customer.customerEmail,
             Address = Customer.customerAddress,
             Id = Customer.customerId
         }
     ).ToList();


     //Query Syntax
     // var result = (from rest in _context.Restaurants
     //             select rest);

     // List<Model.Restaurant> listOfRest = new List<Model.Restaurant>();
     // foreach (var rest in result)
     // {
     //     listOfRest.Add(new Model.Restaurant(){
     //         Name = rest.RestName,
     //         State = rest.RestState,
     //         City = rest.RestCity,
     //         Id = rest.RestId
     //     });
     // }

     // return listOfRest;
 }

 /*public List<Model.Review> GetAllReview()
 {
     throw new System.NotImplementedException();
 }
}
}
 public Model.Customer AddCustomer(Model.Customer p_customer)
 {
     return _context.Customers.Select(Customer=>)
 }

 public List<Model.Clothing> GetAllClothing()
 {
     throw new System.NotImplementedException();
 }

 public List<Model.Customer> GetAllCustomer()
 {
     throw new System.NotImplementedException();
 }

 public List<Model.LineItems> GetAllLineItems(string p_locations)
 {
     throw new System.NotImplementedException();
 }

 public List<Model.Review> GetAllReview()
 {
     throw new System.NotImplementedException();
 }

 public List<Model.StoreFront> GetAllStoreFront()
 {
     throw new System.NotImplementedException();
 }
}
}*/