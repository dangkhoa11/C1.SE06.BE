using RETP.ViewModels.System.User;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RETP.app.System.User
{
    public interface IUserService1
    {
        Task<string> Authencate(loginRequest request);
        Task<bool> Register(registerRequest request);
        ////Task<bool> Update()
        

    }
}
