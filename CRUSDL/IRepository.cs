using System.Collections.Generic;
using CRUSModels;

namespace CRUSDL
{
    public interface IRepository
    {
        

        //this will return a list of storefronts
        //List<CRUSStoreFront> GetCRUSStoreFronts();

        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
        List<Clothing> GetAllClothing();

        List<Review> GetAllReview();

        /// <summary>
        /// This is going to get all the customers from the database
        /// </summary>
        /// <returns> Will return a list of customers</returns>
        List<Customer> GetAllCustomer();
        List<OrderPlacement> GetAllOrders();

        /// <summary>
        /// this is going to add a customer to our customer database. 
        /// </summary>
        /// <param name="p_customer">The Paramater is the customre that will be added</param>
        /// <returns>Will return the customer that gets added</returns>
        Customer AddCustomer(Customer p_customer);

        Customer GetSingleCustomer();
        Product AddProduct(Product p_product);

        OrderPlacement AddOrder(OrderPlacement p_orderPlacement);
        List<StoreFront> GetAllStoreFront();

        /// <summary>
        /// This is going to get all the line items for a specific store location
        /// </summary>
        /// <param name="p_locations"> This is the store location that will be searched</param>
        /// <returns>we will return a list of line items</returns>
        
        ///LineItems AddLineItem(LineItems p_prodcutId);
        List<LineItem> GetAllLineItems(int p_productId);
        List<LineItem> GetAllLineItems();
          /// <summary>
          
        /// This is going to get all Store fronts.
        /// </summary>
        /// <returns>we will return a list of store fronts</returns>
          List<StoreFront> GetAllStoreFrontbylocation (string location);
        /// changed this in order to include what is above List<StoreFront> GetAllStoreFront (StoreFront p_storefront);

        //this is going to get a list of products from the database

        List<Product> GetAllProduct();

        ///This will get us a list of orders that was selected by the customer
        OrderPlacement PlaceOrder (Customer p_customer, OrderPlacement p_order);

        Product GetProductsByItemId(int p_ItemId);

        List<OrderPlacement> GetOrder();

        // List<OrderPlacement> GetAllOrder();

        /// <summary>
        /// It will delete a restaurant from the database
        /// </summary>
        /// <param name="p_rest">This is the restaurant it will delete</param>
        /// <returns>It returns the deleted restaurant</returns>
        OrderPlacement DeleteOrderPlacement(OrderPlacement p_orderPlacement);
        Customer DeleteCustomer(Customer p_customer);

        Customer GetCustomerById(int p_customer);
        List<Product> GetAllProductByProductID(int p_prodcutId);

         OrderPlacement GetOrderById(int OrderId);
    }
}