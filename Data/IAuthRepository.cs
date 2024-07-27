using DatingApp_API.Model;
using System.Threading.Tasks;

namespace DatingApp_API.Data
{
    public interface IAuthRepository
    {

        Task<User> Register(User User, string password);
        Task<User> Login(string username, string password);

        Task <bool> UserExist(string username);
    }
}
