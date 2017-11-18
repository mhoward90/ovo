using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;
using System.IO;

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
            JsonTextReader reader = new JsonTextReader(new StringReader(result));
            return serialiser.Deserialize<T>(reader);
        }

        public IEnumerable<T> DeserialiseJsonList<T>(string result)
        {
            JsonTextReader reader = new JsonTextReader(new StringReader(result));
            IList<T> list = new List<T>();
            list.Add(serialiser.Deserialize<T>(reader));
            return list;
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