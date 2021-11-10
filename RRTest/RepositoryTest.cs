using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using CRUSDL;
using CRUSModels;
using CRUSBL;
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
        public void DeleteOrderPlacementShouldDeleteOrderPlacement()
        {
            using (var context = new ClothesRUSDemoContext(_options))
            {
                //Arrange
                IRepository repo = new RespositoryCloud(context);
                OrderPlacement rest = context.OrderPlacement.Find(1);

                //Act
                repo.DeleteOrderPlacement(rest);
            }

            using (var context = new ClothesRUSdemoContext(_options))
            {
                //Assert
                List<OrderPlacement> listOfOrderPlacement = context.OrderPlacement.ToList();

                Assert.Single(listOfOrderPlacement);
                Assert.Null(context.OrderPlacement.Find(1));
                
            }
        }

        [Fact]
        public void GetRestuarantByIdShouldWork()
        {
            using (var context = new RRDatabaseContext(_options))
            {
                //Arrange
                IRepository repo = new RespositoryCloud(context);

                //Act
                Restaurant foundRest = repo.GetRestaurantById(1);

                //Assert
                Assert.Equal("Stephen Restaurant", foundRest.Name);
            }
        }

        [Fact]
        public void DeleteRestaurantShouldDeleteCustomer()
        {
            using (var context = new ClothesRUSDemoContext(_options))
            {
                //Arrange
                IRepository repo = new RepositoryCloud(context);
                Customer rest = context.Customer.Find(1);

                

                //Act
                repo.Customer(rest);
            }

            using (var context = new ClothesRUSdemoContext(_options))
            {
                //Assert
                List<Customer> listOfCustomer = context.Customer.ToList();

                Assert.Single(listOfCustomer);
                Assert.Null(context.Customer.Find(1));
                
            }
        }

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

                //  context.LineItems.AddRange
                // (
                //     new LineItem
                //     {
                //         _quantity = "3",
                //         // Address = "Houston",
                        
                        
                       
                //     },
                //   new LineItem
                //     {
                //         _quantity = "4",
                //         // Address = "Housto",
                        
                        
                       
                //     }
                  
                   
                

                context.SaveChanges();
            }
        }
    }
}