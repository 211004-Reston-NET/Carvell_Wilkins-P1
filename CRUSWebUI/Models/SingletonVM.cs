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

    }
}
