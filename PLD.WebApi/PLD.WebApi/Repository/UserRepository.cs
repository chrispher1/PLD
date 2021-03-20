using PLD.WebApi.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace PLD.WebApi.Repository
{
    public class UserRepository: IUserRepository<User>
    {        
        private readonly DMTPLDContext _context;
        public UserRepository(DMTPLDContext context)
        {
            _context = context;
        }
        public async Task<User> LogIn(string userName, string password)
        {
            var user = await _context.User.Where(u => u.Username == userName ).FirstOrDefaultAsync();
            
            if (user == null)
            return null;

            if(!PasswordMatch(password, user.PasswordHash, user.PasswordSalt))
            return null;

            return user;
        }
        public async Task<User> Register(string userName, string password,
            DateTime? birthDate, string firstName, string lastName)
        {   
            byte[] passwordHash;
            byte[] passwordSalt;
            User user= new User();

            CreatePasswordHash(password, out passwordHash, out passwordSalt);
            user.Username = userName;
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            user.BirthDate = birthDate;
            user.FirstName = firstName;
            user.LastName = lastName;

            await _context.User.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }
        public async Task<bool> UserExists(string userName)
        {
            if(await _context.User.AnyAsync(u => u.Username == userName))
                return true;

            return false;
        }
        private bool PasswordMatch(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

                for (int i=0; i < computedHash.Length;i++)
                    if( computedHash[i]!= passwordHash[i])
                    return false;
            }
            return true;
        }
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
               passwordSalt = hmac.Key;
               passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}