using System.Threading.Tasks;
using System;

namespace PLD.Repositories.Interface
{
    public interface IUserRepository<T>
    {
        Task<T> LogIn(string userName, string password);
        Task<T> Register(string userName, string password, 
            DateTime? birthDate, string firstName, string lastName);
        Task<bool> UserExists(string userName);

    }
}