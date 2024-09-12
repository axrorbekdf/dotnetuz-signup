using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetuz_signup.ServiceLayer.User
{
    interface IUserService
    {
        Task<IEnumerable<UserModel>> GetALl();

        Task<UserModel> Get(int id);

        Task<bool> Post(UserModel model);

        Task<bool> Update(int id, UserModel model);

        Task<bool> Delete(int id);
    }
}
