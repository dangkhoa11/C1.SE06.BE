using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace login.data.entities
{
    [Table("Users")]
    public class user
    {
        public int ID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
