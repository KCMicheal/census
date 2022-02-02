using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using census.Entities.Models;

namespace census.Repository
{
    public interface IUserRepository
    {
        IEnumerable<UserModel> GetAll();
        UserModel Add(UserModel user);
    }
}