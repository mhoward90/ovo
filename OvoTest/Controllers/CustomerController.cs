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

        public ActionResult Index()
        {
            var viewModel = new CustomerViewModel();
            var customers = customerRepository.GetAllCustomers();

            viewModel.Customers = customers;

            return View(viewModel);
        }

        public ActionResult CustomerDetails(Guid id)
        {
            var viewModel = new CustomerViewModel();
            var customer = customerRepository.GetCustomerById(id);

            viewModel.CustomerDetails = customer;

            return View(viewModel);
        }
    }
}