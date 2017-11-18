using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OvoTest.Models
{
    public interface ICustomer
    {
        Guid id { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
        string gender { get; set; }
        string title { get; set; }
    }

    public class Customer : ICustomer
    {
        [JsonProperty("id")]
        public Guid id { get; set; }
        [JsonProperty("firstName")]
        public string firstName { get; set; }
        [JsonProperty("lastName")]
        public string lastName { get; set; }
        [JsonProperty("gender")]
        public string gender { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
    }
}