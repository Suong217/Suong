using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarProject.Entities
{
    public class CarProduct
    {
        public int Car_Id { get; set; }
        public string Car_Name { get; set; }
        public string CarImg_Url { get; set; }
        public int Car_Status { get; set; }
        public string Car_Description { get; set; }

    }
}