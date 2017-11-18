using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OvoTest.Models
{
    public interface ICustomerRepository
    {
        IEnumerable<ICustomer> GetAllCustomers();
        ICustomer GetCustomerById(Guid id);
    }

    public class CustomerRepository : ICustomerRepository
    {
        private IHttpClient client;
        private JsonSerializer serialiser;

        public CustomerRepository()
        {
            client = new HttpRestClient();
            serialiser = new JsonSerializer();
        }

        public IEnumerable<ICustomer> GetAllCustomers()
        {
            var result = client.GetJsonData("customers");
            yield return client.DeserialiseJson<ICustomer>(result);
        }

        ICustomer ICustomerRepository.GetCustomerById(Guid id)
        {
            var result = client.GetJsonData($"customer/{id}");
            return client.DeserialiseJson<ICustomer>(result);
        }
    }
}