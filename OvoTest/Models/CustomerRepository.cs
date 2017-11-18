using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OvoTest.Models
{
    public interface ICustomerRepository
    {
        IEnumerable<ICustomer> GetAllCustomers();
        Customer GetCustomerById(Guid id);
    }

    public class CustomerRepository : ICustomerRepository
    {
        private IHttpClient client;

        public CustomerRepository()
        {
            client = new HttpRestClient();
        }

        public IEnumerable<ICustomer> GetAllCustomers()
        {
            var result = client.GetJsonData("customers");
            return client.DeserialiseJsonList<Customer>(result);
        }

        Customer ICustomerRepository.GetCustomerById(Guid id)
        {
            var result = client.GetJsonData($"customer/{id}");
            return client.DeserialiseJson<Customer>(result);
        }
    }
}