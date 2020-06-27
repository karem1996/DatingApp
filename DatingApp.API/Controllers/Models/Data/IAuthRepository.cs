using System.Threading.Tasks;

namespace DatingApp.API.Controllers.Models.Data
{
    public interface IAuthRepository
    {
        Task<User> Register (User user, string Password);

        Task<User> Login(string username, string password);

        Task<User> UserExists(string username);
    }
}
