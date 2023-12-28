using JobHunt_Models.User;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunt_Interface.Interface
{
    public interface IUser
    {
        public Task<List<dynamic>> IsValidUserInfo(NewUser user);

        public Task<dynamic> StoreInfoInDb(NewUser user);
        public Task<List<dynamic>> UserExist(Login user);
        public NewUser getUserById(int id);

    }
}
