using System.Collections.Generic;

namespace OvoTest.Models
{
    public class CustomerViewModel
    {
        public IEnumerable<ICustomer> Customers { get; set; }
        public Customer CustomerDetails { get; set; }
    }
}