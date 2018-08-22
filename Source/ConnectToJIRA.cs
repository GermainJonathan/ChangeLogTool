using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

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
        public async Task<Permissions> GetPermission()
        {
            HttpResponseMessage response = await Client.GetAsync(this.BASE_HREF + "mypermissions");

            if (response.IsSuccessStatusCode)
            {
                string product = await response.Content.ReadAsStringAsync();
                JObject rep = JObject.Parse(product);
                //JObject rep2 = JObject.Parse(rep.Property("permissions").ToString());
                //Console.WriteLine("TEST2" + rep2);
                //Console.WriteLine((JArray)rep["permissions"]);
                //Console.WriteLine(rep.Children());
                //Console.WriteLine(rep.Path);
                //Console.WriteLine(rep.Previous);
                //Console.WriteLine("TEST" + rep.SelectToken("permissions.VIEW_WORKFLOW_READONLY"));
                //Permissions data = JsonConvert.DeserializeObject<Permissions>(product);
                //Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                //List<Permission> data = (List<Permission>)serializer.Deserialize(new JTokenReader(rep), typeof(List<Permission>));
                //Console.WriteLine(data);
                return null;
            } else
            {
                return null;
            }
            
        }
    }
}
