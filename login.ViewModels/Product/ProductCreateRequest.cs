using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace RETP.ViewModels.Product
{
    public class ProductCreateRequest
    {
        public int re_id { set; get; }
        public string title { set; get; }
        public string description { set; get; }
       // public Boolean status { set; get; }
        //public string imagePath { set; get; }
        public string address { set; get; }
        //public decimal longitude { set; get; }
        //public decimal latitude { set; get; }
        //public int userID { set; get; }
        //public DateTime postedDate { set; get; }
       // public DateTime updateDate { set; get; }
        //public IFormFile Image { set; get; }
    }
}
