using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RETP.data.entities
{
    
    public class Products
    {
        public int RE_ID { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public Boolean Status { set; get; }
        
        public string Address { set; get; }
       public decimal Longitude { set; get; }
        public decimal Latitude { set; get; }
        //public int UserID { set; get; }
        public DateTime PostedDate { set; get; }
        public DateTime UpdateDate { set; get; }

    }
}
