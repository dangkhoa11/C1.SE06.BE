using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace RETP.data.entities
{
    public class AppUser: IdentityUser<Guid>
    {
        //public int UserID { get; set; }
        //public string Username { get; set; }
        //public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        //public string PhoneNumber { get; set; }
        //public string Email { get; set; }
    }
}
