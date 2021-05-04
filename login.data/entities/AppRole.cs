﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RETP.data.entities
{
    public class AppRole: IdentityRole<long>
    {
        public AppRole() : base()
        {

        }

        public AppRole(string roleName)
        {
            Name = roleName;
        }
    }
}
