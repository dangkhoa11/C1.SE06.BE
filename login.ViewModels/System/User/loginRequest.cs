using System;
using System.Collections.Generic;
using System.Text;

namespace login.ViewModels.System.User
{
    public class loginRequest
    {
        public string userName { get; set; }
        public string password { get; set; }
        public bool rememberMe { get; set; }
    }
}
