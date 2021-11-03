using System.Collections.Generic;
using System.Linq;
using CRUSDL;
using CRUSModels;

namespace CRUSBL
{
    public interface IStoreFrontBL
    {
        /// <summary>
        /// This will return a list of StoreFront stored in the database
        /// It will also capitalize every name of the restaurant
        /// </summary>
        /// <returns>It will return a list of StoreFront</returns>
        List<StoreFront> GetAllStoreFront();

        //List<Product> GetAllProduct();

        





    }
}