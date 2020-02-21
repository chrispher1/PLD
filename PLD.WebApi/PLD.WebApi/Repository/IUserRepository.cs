using System.Threading.Tasks;

namespace PLD.WebApi.Repository
{
    public interface IUserRepository<T>
    {
        Task<T> LogIn(string userName, string password);
        Task<T> Register(string userName, string password);
        Task<bool> UserExists(string userName);

    }
}