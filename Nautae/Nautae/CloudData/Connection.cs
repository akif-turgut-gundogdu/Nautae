using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using Nautae.Models;

namespace Nautae.CloudData
{
    public class Connection
    {
        private string url;
        private HttpClient client;
        private List<users> user;
        public Connection()
        {
            client = new HttpClient();
            user = new List<users>();
            url = "http://localhost:60188/api/values";

        }



        public List<users> userAll()
        {


            List<users> userlist = null;
            var task = client.GetAsync(url).ContinueWith((taskResponse) =>
            {
                var response = taskResponse.Result;
                var jsonString = response.Content.ReadAsStringAsync();
                jsonString.Wait();

                userlist = JsonConvert.DeserializeObject<List<users>>(jsonString.Result);

            }

            );
            task.Wait();


            return userlist;


        }
    }
}
