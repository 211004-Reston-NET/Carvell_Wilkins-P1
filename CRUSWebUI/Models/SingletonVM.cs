using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUSModels;

namespace CRUSWebUI.Models
{
    public class SingletonVM
    {
        public static Customer customer = new Customer();
        public static OrderPlacement orderPlacement = new OrderPlacement();
        public static Product product = new Product();
        public static StoreFront storeFront = new StoreFront();
    }
}
