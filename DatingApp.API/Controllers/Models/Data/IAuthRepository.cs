using System.Threading.Tasks;
using DatingApp.API.Controllers.Models;
namespace DatingApp.API.Controllers.Models.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);

        Task<User> Login(string username, string password);

        Task<bool> UserExists(string username);
    }
}
