using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;
using System.IO;
using Newtonsoft.Json.Linq;

namespace OvoTest.Models
{
    public interface IHttpClient
    {
        string GetJsonData(string endpoint);
        IEnumerable<T> DeserialiseJsonList<T>(string result);
        T DeserialiseJson<T>(string result);
    }

    public class HttpRestClient : IHttpClient
    {
        private const string uri = "https://sheltered-depths-66346.herokuapp.com/";
        private JsonSerializer serialiser;

        public HttpRestClient()
        {
            serialiser = new JsonSerializer();
        }

        public T DeserialiseJson<T>(string result)
        {
            return JsonConvert.DeserializeObject<T>(result);
        }

        public IEnumerable<T> DeserialiseJsonList<T>(string result)
        {
            JObject jo = JObject.Parse(result);
            return jo.SelectToken("customers", false).ToObject<T[]>();
        }

        public string GetJsonData(string endpoint)
        {
            var client = new RestClient(uri);
            var request = new RestRequest(endpoint, Method.GET);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}