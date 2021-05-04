using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RETP.data.entities
{
    [Table("USER")]
    public class user : IdentityUser
    {
        public string UserID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        //public profile profile { get; set; }
    }
}
