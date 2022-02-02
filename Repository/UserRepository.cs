using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using census.Entities.Models;

namespace census.Repository
{
    public class UserRepository : IUserRepository
    {
        private List<UserModel> users = new List<UserModel>();
        private int _nextId = 1;

        public UserRepository()
        {
            Add(new UserModel { FirstName= "first1", LastName="last1", Email="email1@gmail.com"});
            Add(new UserModel { FirstName= "first2", LastName="last2", Email="email2@gmail.com"});
            Add(new UserModel { FirstName= "first3", LastName="last3", Email="email3@gmail.com"});
        }

        public IEnumerable<UserModel> GetAll()
        {
            return users;
        }

        public UserModel Add(UserModel item)
        {
            if(item == null)
            {
                throw new ArgumentException("item");
            }

            item.Id = _nextId++;
            users.Add(item);
            return item;
        }
    }
}