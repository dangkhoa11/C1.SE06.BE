using System;
using System.Collections.Generic;
using System.Text;

namespace login.ViewModels.System.User
{
    public class registerRequest
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dob { get; set; }
        public string Email { get; set; }
        public string phoneNumber { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }

    }
}
