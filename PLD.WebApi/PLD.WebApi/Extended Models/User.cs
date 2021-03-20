using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }

        
    }
}
