using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarProject.Entities
{
    public class CarDetailImg
    {
        public int Detail_Id { get; set; }
        public int DetailImg_Id { get; set; }
        public string DetailImg_Name { get; set; }
        public string DetailImg_Url { get; set; }
    }
}