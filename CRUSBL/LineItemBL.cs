using System.Collections.Generic;
using System.Linq;
using CRUSDL;
using CRUSModels;

namespace CRUSBL


{
    public class LineItemBL : ILineItemBL
    {
        private IRepository _repo;
        public LineItemBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        public List<LineItem> GetAllLineItems()
        {
            return _repo.GetAllLineItems();
            //return _repo.GetAllLineItems(p_prodcutId); - may have to use later. commenting out for now 10.30 11:55pm
        }

        public LineItem GetSingleLineItem(string p_product, int p_price, string p_decription, int p_quantity, int p_productId)
        {
            throw new System.NotImplementedException();
        }

        public OrderPlacement OrderPlacement(Customer p_customer, OrderPlacement p_order)
        {
            throw new System.NotImplementedException();
        }

        public OrderPlacement OrderPlacement(string o_ordrplacement)
        {
            throw new System.NotImplementedException();
        }
    }
}