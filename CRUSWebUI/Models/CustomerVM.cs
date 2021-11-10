using CRUSModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUSWebUI.Models
{
    public class CustomerVM
    {
        public CustomerVM()
        {

        }

        public CustomerVM(Customer p_rest)
        {
            this.CustomerId = p_rest.CustomerId;
            this.Name = p_rest.Name;
            this.Email = p_rest.Email;
            this.Address = p_rest.Address;
        }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
