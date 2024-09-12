using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetuz_signup.ServiceLayer.API
{
    class APIService
    {
        private static string BASE_URL = "https://cabinet-backend.herokuapp.com/api/";

        public static readonly string GET_PERSON = BASE_URL + "Person/Get";
        public static readonly string POST_PERSON = BASE_URL + "Person/Post";
        public static readonly string UPDATE_PERSON = BASE_URL + "Person/Update";
        public static readonly string DELETE_PERSON = BASE_URL + "Person/Delete";

    }
}
