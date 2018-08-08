using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using Newtonsoft.Json.Linq;

namespace Source
{
    class ConnectToJIRA
    {
        /**
         * Base de l'URL de connexion vers l'API Jira
         */
        public string BASE_HREF = ConfigurationManager.AppSettings.Get("API_JIRA");

        /**
         * Instance de connexion 
         */
        private static HttpClient Client = new HttpClient();

        /**
         * Permet d'obtenir la liste des actions possible sur l'API
         */
        public async Task<Object> GetPermission()
        {
            Object product = null;
            HttpResponseMessage response = await Client.GetAsync(this.BASE_HREF + "mypermissions");

            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsStringAsync();
                JObject rep = JObject.Parse(product.ToString());
                Console.WriteLine(rep);
            }
            return product;
        }
    }
}
