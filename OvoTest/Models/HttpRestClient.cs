using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OvoTest.Models
{
    public interface IHttpClient
    {
        string GetJsonData(string endpoint);
    }

    public class HttpRestClient : IHttpClient
    {
        private const string uri = "https://sheltered-depths-66346.herokuapp.com/";

        public string GetJsonData(string endpoint)
        {
            throw new NotImplementedException();
        }
    }
}