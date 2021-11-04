using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using CRUSBL;
using CRUSDL;



namespace CRUSUI
{
    /// <summary>
    /// Designed to create menu objects
    /// </summary>
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
            var configuration = new ConfigurationBuilder() //Configurationbuilder is the class that came from the Microsoft.extensions.configuration package
                .SetBasePath(Directory.GetCurrentDirectory()) //Gets the current directory of the RRUI file path
                .AddJsonFile("appsetting.json") //Adds the appsetting.json file in our CRURRUI
                .Build(); //Builds our configuration

            DbContextOptions<ClothesRUSdemoContext> options = new DbContextOptionsBuilder<ClothesRUSdemoContext>()
                .UseSqlServer(configuration.GetConnectionString("Reference2DB"))
                .Options;

              switch (p_menu)
                {
                    case MenuType.MainMenu:
                        return new MainMenu();
                        //If user choosed to go back to the MainMenu
                        //page will start pointing to a MainMenu object instead
                        
                        
                    case MenuType.ClothesMenu:
                        return new ClothesMenu(); 
                        //This will point the page reference variable to a new Restaurant Object
                        //Since Restaurant Object has different implementation/function of the Menu Method
                        //It will have different implementations/functions when the while loop goes back and
                        //repeat itself
                                               

                    case MenuType.StoreFront:
                        return new StoreFrontMenu(new StoreFrontBL(new RepositoryCloud(new ClothesRUSdemoContext(options)))); 
                        ///return new StoreFrontMenu(new CRUSBL.StoreFrontBL(new Repository())); 
                        /// changed the line up top to add the storefront demo context 10.30 4:30                       

                    case MenuType.LineItem:
                        return new LineItemMenu(new LineItemBL(new RepositoryCloud(new ClothesRUSdemoContext(options))));                        
                   
                    case MenuType.AddCustomer:
                        return new AddCustomer(new CustomerBL(new RepositoryCloud(new ClothesRUSdemoContext(options)))); 

                    case MenuType.CustomerSearch:
                        return new SearchCustomers(new CustomerBL(new RepositoryCloud(new ClothesRUSdemoContext(options)))); 
                        
                                                               
                        
                    default:
                      return null;
                        
                }
        }
    }
}