using MayneFaniWindowsForm.DataBase;
using MayneFaniWindowsForm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayneFaniWindowsForm.DataAccess.Repositories_EF
{
    public interface IUserRepository
    {

        User GetUser(string userName);
        Result AddUser(User newUser);
        
    }
}
