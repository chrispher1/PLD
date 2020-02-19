using System.ComponentModel.DataAnnotations;

namespace PLD.WebApi.Angular.DTO
{
    public class UserForRegisterDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
         public string Password{ get; set; }
    }
}