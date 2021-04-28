using System;
using System.Security.Claims;

namespace login.app.System.User
{
    public class AppUser
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}