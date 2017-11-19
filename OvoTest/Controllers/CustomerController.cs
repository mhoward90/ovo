using OvoTest.Models;
using System;
using System.Web.Mvc;

namespace OvoTest.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerRepository customerRepository;

        public CustomerController()
        {
            customerRepository = new CustomerRepository();
        }

        public ActionResult Customers()
        {
            var viewModel = new CustomerViewModel();
            try
            {
                var customers = customerRepository.GetAllCustomers();
                viewModel.Customers = customers;
            }
            catch(Exception exception)
            {
                return View(exception);
            }

            return View(viewModel);
        }

        public ActionResult CustomerDetails(Guid id)
        {
            if (id == null)
                throw new Exception("Customer ID cannot be null");

            var viewModel = new CustomerViewModel();

            try
            {
                var customer = customerRepository.GetCustomerById(id);
                viewModel.CustomerDetails = customer;
            }
            catch(Exception exception)
            {
                return View(exception);
            }

            return View(viewModel);
        }
    }
}