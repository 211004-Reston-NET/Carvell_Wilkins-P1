using CRUSModels;

namespace CRUSUI
{
    public class SingletonCustomer
    {
        public static Customer customer = new Customer();
        //public static OrderPlacement order = new Order();
        public static string location { get; set; }
        
    }
}