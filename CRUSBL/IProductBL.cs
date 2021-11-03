using System.Collections.Generic;
using System.Linq;
using CRUSDL;
using CRUSModels;
namespace CRUSBL
{
    public interface IProductBL
    {
        /// <summary>
        /// This Will grab the list of products from Repository.
        List<Product> getAllProduct(); 
        //CategoryMenu(string p_category);
        List<Product> getProduct( string p_product);
    }
}