using Microsoft.VisualStudio.TestTools.UnitTesting;
using OvoTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvoTest.Tests.Controllers
{
    [TestClass]
    public class CustomerRepositoryTests
    {
        private ICustomerRepository repo;

        [TestInitialize]
        public void setup()
        {
            //normally this would be mocked
            repo = new CustomerRepository();
        }

        [TestMethod]
        public void ShouldGetAllCustomers()
        {
            var result = repo.GetAllCustomers();

            Assert.IsInstanceOfType(result, typeof(IEnumerable<ICustomer>));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ShouldGetCustomerById()
        {
            var result = repo.GetCustomerById(new Guid());

            Assert.IsInstanceOfType(result, typeof(ICustomer));
            Assert.IsNotNull(result);
        }
    }
}
