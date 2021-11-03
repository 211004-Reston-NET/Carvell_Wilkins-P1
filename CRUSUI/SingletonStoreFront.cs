using CRUSModels;

namespace CRUSUI
{
    public class SingletonStoreFront
    {
        public static StoreFront storeFront = new StoreFront();
        public static string location { get; set; }

        public static int ProductId {get; set; }
        public static Product product = new Product ();
        
    }
}