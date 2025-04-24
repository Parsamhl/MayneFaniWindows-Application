
using MayneFaniWindowsForm.DataAccess.RepositoryImplimentation;
using MayneFaniWindowsForm.Entities;

namespace MayneFaniWindowsForm.Authentication
{
    public class Authentication
    {
        protected UserRepository userRepository;

        public Authentication()
        {
            userRepository = new UserRepository();
        }
        public bool Login(string userName, string password)
        {
            var user = userRepository.GetUser(userName);

            if (user is not null)
            {
                if (user.UserName == userName && user.Password == password)
                {
                    return true;

                }
            }
            return false;
        }
    }
}
