using Newtonsoft.Json;
using RETP.ViewModels.System.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RETP.Admin.Service
{
    public class UserApi : IUserApi
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public UserApi(IHttpClientFactory httpClientFactory)

        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<string> Authenticate(loginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("http://127.0.0.1:5001");
           var reponse= await client.PostAsync("/api/User/Authenticate", httpContent);
            var token = await reponse.Content.ReadAsStringAsync();
            return token;
        }
    }
}
