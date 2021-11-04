namespace CRUSModels
{
    public class LineItem
    {
        public int _productId;
        

            
        public int _quantity {get;set;}

        public int LineItemId {get; set;} // _lineItemId {get; set;}

        public int _orderId;

        public string Product {get; set;}
        public string OrderPlacement {get;set;}


    
        
        public int ProductId
        {
            get
            {
                return _productId;
            }
            set
            {
                _productId = value;
            }
        }
        //  public int Quantity
        // {
        //     get
        //     {
        //         return _quantity;
        //     }
        //     set
        //     {
        //         _quantity = value;
        //     }
        // }

         public int OrderId
        {
            get
            { return _orderId; }
            set
            {
                _orderId = value;
            }
        }

       
     

       

        
       //public override string ToString()
        //{
            //return $"Brand: {Product.Brand} \nName: {Product.Clothing_Type} \nPrice: {Product.Price} "; 
        }
    }
//}
