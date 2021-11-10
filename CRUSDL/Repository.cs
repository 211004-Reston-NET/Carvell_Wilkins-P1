using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using CRUSModels;

namespace CRUSDL
{
    //The repository class has a bunch of methods that we will use to get or store information from the database
    //Does not actually hold the data itself
    public class Repository : IRepository
    {
        //Filepath need to reference from the startup project (RRUI) and hence why we need to go back a folder and cd into RRDL
        private const string _filepath = "./../CRUSDL/Database/";
        private string _jsonString;

        public Clothing AddClothing(Clothing p_rest)
        {
            //The reason why we need to grab all the information back is because File.WriteAllText method will overwrite anything inside the JSON file
            List<Clothing> listOfClothing = GetAllClothing();

            //We added the new restaurant from the parameter 
            listOfClothing.Add(p_rest);

            _jsonString = JsonSerializer.Serialize(listOfClothing, new JsonSerializerOptions{WriteIndented=true});

            //This is what adds the restaurant.json
            File.WriteAllText(_filepath+"Clothing.json",_jsonString);

            //Will return a restaurant object from the parameter
            return p_rest;
        }

        public Customer AddCustomer(Customer p_customer)
        {
          List<Customer> listOfCustomer= GetAllCustomer();
          listOfCustomer.Add(p_customer);
          _jsonString = JsonSerializer.Serialize(listOfCustomer, new JsonSerializerOptions { WriteIndented = true});
            File.WriteAllText(_filepath+ "Custotmer.json",_jsonString );
            return p_customer;
        
        }

        public OrderPlacement AddOrder(OrderPlacement p_orderplacement)
        {
            throw new NotImplementedException();
        }

        public Product AddProduct(Product p_product)
        {
            throw new NotImplementedException();
        }

        public OrderPlacement DeleteOrderPlacement(OrderPlacement p_orderPlacement)
        {
            throw new NotImplementedException();
        }

        public List<Clothing> GetAllClothing()
        {
            //File class will just read everything in the Resturant.json and put it in a string
            
            try
            {
                 _jsonString = File.ReadAllText(_filepath+"Clothing.json");
            }
            //This will catch a very specific exception and run the block
            catch (System.IO.FileNotFoundException)
            {
                //Added Dummy data
                Clothing newRest = new Clothing();
                List<Clothing> listOfRest = new List<Clothing>();
                listOfRest.Add(newRest);

                //Added a file to database folder
                File.WriteAllText(_filepath+"Clothing.json", JsonSerializer.Serialize<List<Clothing>>(listOfRest));

                //Read that file I just added
                _jsonString = File.ReadAllText(_filepath+"Clothing.json");
            }
            //Generic SystemException will always catch any exception
            catch(SystemException var)
            {
                throw var;
            }

            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<Clothing>>(_jsonString);
        }

        public List<Customer> GetAllCustomer()
        {
             try
            {
                 _jsonString = File.ReadAllText(_filepath+"Customer.json");
            }
            //This will catch a very specific exception and run the block
            catch (System.IO.FileNotFoundException)
            {
                //Added Dummy data
                Customer newCust = new Customer();
                List<Customer> listOfCust = new List<Customer>();
                listOfCust.Add(newCust);

                //Added a file to database folder
                File.WriteAllText(_filepath+"Customer.json", JsonSerializer.Serialize<List<Customer>>(listOfCust));

                //Read that file I just added
                _jsonString = File.ReadAllText(_filepath+"Customer.json");
            }
            //Generic SystemException will always catch any exception
            catch(SystemException var)
            {
                throw var;
            }

            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<Customer>>(_jsonString);
        }

        public List<LineItem> GetAllLineItems(int p_locations)
        {
          switch (p_locations)
          {
              case 1:
              _jsonString = File.ReadAllText(_filepath+"LineItemDallasTX.json");
              break;
              
              case 2:
              _jsonString = File.ReadAllText(_filepath+"LineItemSanDiegoCA.json");
              break;

              case 3:
              _jsonString = File.ReadAllText(_filepath+"LineItemSanAntonioTX.json");
              break;

              default:
              break;
          }

            return JsonSerializer.Deserialize<List<LineItem>>(_jsonString); 
        }

        public List<LineItem> GetAllLineItems()
        {
            throw new NotImplementedException();
        }

        public List<OrderPlacement> GetAllOrder()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public List<Review> GetAllReview()
        {
            _jsonString = File.ReadAllText(_filepath+"Review.json");

            return JsonSerializer.Deserialize<List<Review>>(_jsonString);
        }

        public List<StoreFront> GetAllStoreFront()
        {
            throw new NotImplementedException();
        }

        public List<StoreFront> GetAllStoreFront(StoreFront p_storefront)
        {
            throw new NotImplementedException();
        }

        public List<StoreFront> GetAllStoreFrontbylocation(string location)
        {
            throw new NotImplementedException();
        }

        public List<OrderPlacement> GetOrder()
        {
            throw new NotImplementedException();
        }

        public List<OrderPlacement> GetOrders(string p_order)
        {
            throw new NotImplementedException();
        }

        public Product GetProductsByItemId(int p_ItemId)
        {
            throw new NotImplementedException();
        }

        public OrderPlacement PlaceOrder(Customer p_customer, OrderPlacement p_order)
        {
            throw new NotImplementedException();

        }
        // public List<CRUSStoreFront> GetCRUSStoreFronts()
        // {
        //     _jsonString = File.ReadAllText(_filepath+"CRRUSStoreFront.json");

        //     return JsonSerializer.Deserialize<List<CRUSStoreFront>>(_jsonString);
        // }
    }

}

