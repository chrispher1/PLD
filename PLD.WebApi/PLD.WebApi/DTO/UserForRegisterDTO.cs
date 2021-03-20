using System.ComponentModel.DataAnnotations;
using System;
namespace PLD.WebApi.DTO
{
    public class UserForRegisterDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
         public string Password{ get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
         public string LastName { get; set; }
         public DateTime? BirthDate { get; set; }
    }
}