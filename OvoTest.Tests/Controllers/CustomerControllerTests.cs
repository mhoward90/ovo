using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OvoTest.Controllers;

namespace OvoTest.Tests.Controllers
{
    [TestClass]
    public class CustomerControllerTests
    {
        [TestMethod]
        public void Customers()
        {
            // Arrange
            CustomerController controller = new CustomerController();

            // Act
            ViewResult result = controller.Customers() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CustomerDetails()
        {
            // Arrange
            CustomerController controller = new CustomerController();

            // Act
            ViewResult result = controller.CustomerDetails(new Guid("452e644a-8b21-4cfb-9683-f363be7aef6f")) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
