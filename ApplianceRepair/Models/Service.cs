using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplianceRepair.Models
{
    public class Service
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Price { get; set; }

        public string Description { get; set; }

        public DateTime GetDays { get; set; }

        public string ImageUrl { get; set; }
    }
}