using System;
using System.Security.Claims;

namespace login.app.System.User
{
    public class AppUser
    {
        

        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dob { get; set; }
        public string email { get; set; }
        public string userName { get; set; }
        public string password { get; set; }

    }
}