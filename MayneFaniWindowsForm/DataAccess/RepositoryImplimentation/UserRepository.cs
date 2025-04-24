using MayneFaniWindowsForm.DataAccess.Repositories_EF;
using MayneFaniWindowsForm.DataBase;
using MayneFaniWindowsForm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayneFaniWindowsForm.DataAccess.RepositoryImplimentation
{
    public class UserRepository : IUserRepository
    {


        protected AppdbContext _Context;
        public UserRepository()
        {
            _Context = new AppdbContext();
        }
        public Result AddUser(User newUser)
        {
            if (newUser is null)
            {
                return new Result
                {
                    IsSuccess = false,
                    Message = "User is null"
                };

            }
            else
            {
                _Context.Users.Add(newUser);
                _Context.SaveChanges();
                return new Result { IsSuccess = true, Message = "User Added !" };
            }

        }

        public User GetUser(string userName)
        {
            return _Context.Users.FirstOrDefault(x => x.UserName == userName);

        }

    }
}
