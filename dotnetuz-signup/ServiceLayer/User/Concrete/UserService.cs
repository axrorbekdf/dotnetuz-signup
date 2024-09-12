using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using dotnetuz_signup.ServiceLayer.API;
using Newtonsoft.Json;

namespace dotnetuz_signup.ServiceLayer.User.Concrete
{
    class UserService : IUserService
    {
        public async Task<bool> Delete(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(APIService.DELETE_PERSON +$"/{id}");
            HttpResponseMessage res = await client.DeleteAsync(client.BaseAddress);
            string response = await res.Content.ReadAsStringAsync();

            return response == "true";
        }

        public async Task<UserModel> Get(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(APIService.GET_PERSON+$"/{id}");
            HttpResponseMessage res = await client.GetAsync(client.BaseAddress);
            string response = await res.Content.ReadAsStringAsync();

            UserModel user = JsonConvert.DeserializeObject<UserModel>(response);

            return user;
        }

        public async Task<IEnumerable<UserModel>> GetALl()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(APIService.GET_PERSON);
            HttpResponseMessage res = await client.GetAsync(client.BaseAddress);
            string response = await res.Content.ReadAsStringAsync();
            
            IEnumerable<UserModel> users = JsonConvert.DeserializeObject<IEnumerable<UserModel>>(response);

            return users;
        }

        public async Task<bool> Post(UserModel model)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(APIService.POST_PERSON);

            string json = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage res = await client.PostAsync(client.BaseAddress, content);
            string response = await res.Content.ReadAsStringAsync();

            return response == "true";
        }

        public async Task<bool> Update(int id, UserModel model)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(APIService.UPDATE_PERSON + $"/{id}");

            string json = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage res = await client.PostAsync(client.BaseAddress, content);
            string response = await res.Content.ReadAsStringAsync();

            return response == "true";
        }
    }
}
