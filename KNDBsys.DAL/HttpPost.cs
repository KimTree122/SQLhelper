using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace KNDBsys.DAL
{
    public class HttpPost
    {

        public static string PostResponse( string url, Dictionary<object, object> parameter)
        {
            var request = JsonConvert.SerializeObject(parameter);
            HttpContent httpContent = new StringContent(request);
            httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var httpClient = new HttpClient();
            var responseJson = httpClient.PostAsync(url, httpContent).Result.Content.ReadAsStringAsync().Result;
            return responseJson;
        }

        public static byte[] PostImage(string url, Dictionary<object, object> parameter)
        {
            var request = JsonConvert.SerializeObject(parameter);

            var message = new HttpClient().PostAsync(url, null).Result;
           var re =  message.Content.ReadAsByteArrayAsync().Result;
            return re;
        }
    }
}
