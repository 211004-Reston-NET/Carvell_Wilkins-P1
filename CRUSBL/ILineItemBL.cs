

using System.Collections.Generic;
using System.Linq;
using CRUSDL;
using CRUSModels;
namespace CRUSBL
{
    public interface ILineItemBL

    {
        /// <summary>
        /// This is going to get all the line items for a specific store location
        /// </summary>
        /// <param name="p_locations"> This is the store location that will be searched</param>
        /// <returns>we will return a list of line items</returns>
        List<LineItem> GetAllLineItems(); //May have to change this back to p_locaton

        LineItem GetSingleLineItem(string p_product, int p_price, string p_decription, int p_quantity, int p_productId);

        OrderPlacement OrderPlacement (string o_ordrplacement);//(Customer p_customer, OrderPlacement p_order);
    }
}