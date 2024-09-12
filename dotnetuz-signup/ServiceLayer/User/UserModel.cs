using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace dotnetuz_signup.ServiceLayer.User
{
    class UserModel
    {
        [JsonPropertyName("id")]
        public int ID { get; set; } = 0;

        [JsonPropertyName("firstName")]
        public string Firstname {  get; set; }

        [JsonPropertyName("lastName")]
        public string Lastname { get; set; }

        [JsonPropertyName("username")]
        public string Username {  get; set; }

        [JsonPropertyName("phone")]
        public string Phone {  get; set; }

        [JsonPropertyName("carID")]
        public int CarID { get; set; }


        public override string ToString()
        {
            return Firstname + " " + Lastname;
        }
    }
}
