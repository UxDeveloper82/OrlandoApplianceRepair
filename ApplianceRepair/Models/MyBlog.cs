using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplianceRepair.Models
{
    public class MyBlog
    {
        public int Id { get; set; } 

        public string Title { get; set; } = "";

        public string ImgUrl { get; set; } = "";

        public string SomeDetails { get; set; } = "";

        public string MoreDetails { get; set; } = "";

        public DateTime DatePost { get; set; } = DateTime.Now;

        public string Author { get; set; } = "";
    }
}