using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace MVC
{
    public static class GlobalVariables
    {
        public static HttpClient WebAppClient = new HttpClient();

        static GlobalVariables()
            {
            WebAppClient.BaseAddress = new Uri("http://localhost:65041/api/");
            WebAppClient.DefaultRequestHeaders.Clear();
            WebAppClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        
    }
}