using System.Collections.Generic;
using System.Linq;
using CRUSDL;
using CRUSModels;

namespace CRUSBL
{
    public interface ICustomerBL
    {
        /// <summary>
        /// This will return a list of Customers stored in the database
        /// It will also capitalize every name of the Customers
        /// </summary>
        /// <returns>It will return a list of Customerss</returns>
        List<Customer> GetAllCustomer();

        /// <summary>
        /// Adds a customer to the database
        /// </summary>
        /// <param name="p_customer">This is the customer we are adding</param>
        /// <returns>It returns the added customer</returns>
        Customer AddCustomer(Customer p_customer);
        OrderPlacement AddOrder(OrderPlacement p_orderPlacement);

        /// <summary>
        /// Will find multiple restaurant given a name
        /// </summary>
        /// <param name="p_name">This is the string it will check to find restaurants if their name has those letters</param>
        /// <returns>It will return restaurants it found</returns>
        List<Customer> GetCustomer(string p_name);

        OrderPlacement OrderPlacement(Customer p_customer, OrderPlacement p_order);

        List<OrderPlacement> GetOrders( ); //string p_order);


         /// <summary>
        ///     Will check the database for a customer with a name, email, and address. 
        ///     It will thenthen return the 1st customer if finds with that information.
        /// </summary>
        /// <param name="p_name"> customer name to search for </param>
        /// <param name="p_email"> customer email to search for </param>
        /// <param name="p_address"> customer address to search for </param>
        /// <returns> returns the customer from the database</returns>
        Customer GetSingleCustomer(string p_name, string p_email);
        Customer GetACustomer(string p_name, string p_email);

        /// <summary>
        /// It will delete a restaurant from the database
        /// </summary>
        /// <param name="p_rest">This is the restaurant it will delete</param>
        /// <returns>It returns the deleted restaurant</returns>
        OrderPlacement DeleteOrderPlacement(OrderPlacement p_orderPlacement);

        Customer GetCustomerById(int p_customerId);

        Customer DeleteCustomer(Customer p_customer);

        List<OrderPlacement> GetAllOrders();

        OrderPlacement GetOrderById(int p_orderPlacementId);



    }
}