using System.ComponentModel.DataAnnotations;

namespace PLD.WebApi.DTO
{
    public class UserForRegisterDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
         public string Password{ get; set; }
    }
}