using System;

namespace OvoTest.Models
{
    public interface ICustomerRepository
    {
        ICustomer GetAllCustomers();
        ICustomer GetCustomerById(Guid id);
    }

    public class CustomerRepository : ICustomerRepository
    {
        ICustomer ICustomerRepository.GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        ICustomer ICustomerRepository.GetCustomerById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}