using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace RETP.data.entities
{
    [Table("PROFILE")]
    public class profile
    {
        public int ProfileID { get; set; }
        public string UserID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public user user { get; set; }
    }
}
