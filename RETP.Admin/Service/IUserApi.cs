using RETP.ViewModels.System.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RETP.Admin.Service
{
    public  interface IUserApi
    {
        Task<string>Authenticate(loginRequest request);
    }
}
