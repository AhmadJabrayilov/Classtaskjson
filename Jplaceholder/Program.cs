using Jplaceholder.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Jplaceholder
{
    class Program
    {
        static void Main(string[] args)
        {

            HttpClient httpClient = new HttpClient();
            var response = httpClient.GetAsync("https://jsonplaceholder.typicode.com/users").Result;
            var responseJsonStr = response.Content.ReadAsStringAsync().Result;

            List<User> _user = JsonConvert.DeserializeObject<List<User>>(responseJsonStr);

            foreach (var item in _user)
            {
                Console.WriteLine(item.Name);
            }
            
           
        }
       
    }
}
