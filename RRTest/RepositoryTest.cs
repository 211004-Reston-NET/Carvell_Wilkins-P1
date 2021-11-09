using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using CRUSDL;
using CRUSModels;
using Xunit;

namespace RRTest
{
    public class RepositoryTest
    {
        private readonly DbContextOptions<ClothesRUSdemoContext> _options;
        public RepositoryTest()
        {
            _options = new DbContextOptionsBuilder<ClothesRUSdemoContext>()
                        .UseSqlite("Filename = Test.db").Options; //UseSqlite() method will create an inmemory database for use named Test.db
            Seed();
        }

        [Fact]
        public void GetAllCustomerShouldReturnAllCustomer()
        {
            using (var context = new ClothesRUSdemoContext(_options))
            {
                 //Arrange
                IRepository repo = new RepositoryCloud(context);

                 //Act
                 List<Customer> test = repo.GetAllCustomer();

                 //Assert
                 Assert.Equal(2, test.Count);
                 Assert.Equal("Stephen Restaurant", test[0].Name);
            }
        }

        [Fact]
        public void AddCustomerShouldAddACustomer()
        {
            //First using block will add a restaruant
            using (var context = new ClothesRUSdemoContext(_options))
            {
                 //Arrange
                IRepository repo = new RepositoryCloud(context);
                Customer addedCustomer = new Customer
                {
                    Name = "Colin Restaurant",
                    Address = "Dallas",
                    Email = "Texas"
                };

                 //Act
                 repo.AddCustomer(addedCustomer);
            }

            //Second using block will find that restaurant and see if it is similar to what we added
            //Assert
            using (ClothesRUSdemoContext contexts = new ClothesRUSdemoContext(_options))
            {
                Customer result = contexts.Customers.Find(3);

                Assert.NotNull(result);
                Assert.Equal("Colin Restaurant", result.Name);
                Assert.Equal("Dallas", result.Address);
                Assert.Equal("Texas", result.Email);
            }
        }

         [Fact]
         public void GetAllStoreFrontShouldReturnLineItems()
        {
            using (var context = new ClothesRUSdemoContext(_options))
            {
                 //Arrange
                IRepository repo = new RepositoryCloud(context);

                 //Act
                 List<LineItem> test = repo.GetAllLineItems();

                 //Assert
                 Assert.Equal(2, test.Count);
                 Assert.Equal("3", test[0]._quantity);
            }
        }
        // public void AddCustomerShouldAddACustomer()
        // {
        //     //First using block will add a restaruant
        //     using (var context = new ClothesRUSdemoContext(_options))
        //     {
        //          //Arrange
        //         IRepository repo = new RepositoryCloud(context);
        //         Customer addedCustomer = new Customer
        //         {
        //             Name = " My Dog",
        //             Address = "Detroit",
        //             Email = "Detroit@yahoo.com"
        //         };

        //          //Act
        //          repo.AddCustomer(addedCustomer);
        //     }

        //     //Second using block will find that restaurant and see if it is similar to what we added
        //     //Assert
        //     using (ClothesRUSdemoContext contexts = new ClothesRUSdemoContext(_options))
        //     {
        //         Customer result = contexts.Customers.Find(3);

        //         Assert.NotNull(result);
        //         Assert.Equal("My Dog", result.Name);
        //         Assert.Equal("Detroit", result.Address);
        //         Assert.Equal("Detroit@yahoo.com", result.Email);
        //     }
        // }

        private void Seed()
        {
            //using block to automatically close the resource that is used to connect to this db after seeding data to it
            using (var context = new ClothesRUSdemoContext(_options))
            {
                //We want to make sure that our inmemory db gets deleted and recreated to not have any data from previous tests
                //We want a pristine database to ensure that every tests will have the exact same database being used to execute the test
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                context.Customers.AddRange
                (
                    new Customer
                    {
                        Name = "Stephen Restaurant",
                        Address = "Houston",
                        Email = "Texas",
                        
                       
                    },
                    new Customer
                    {
                        Name = "Danny Restaurant",
                        Address = "NYC",
                        Email = "Florida@mike.com",
                       
                    }

                   
                );

                 context.LineItems.AddRange
                (
                    new LineItem
                    {
                        _quantity = "3",
                        // Address = "Houston",
                        
                        
                       
                    },
                  new LineItem
                    {
                        _quantity = "4",
                        // Address = "Housto",
                        
                        
                       
                    }
                  
                   
                );

                context.SaveChanges();
            }
        }
    }
}