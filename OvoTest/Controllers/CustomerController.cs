using OvoTest.Models;
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
    }
}