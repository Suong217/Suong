using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarProject.Entities
{
    public class CarDetail
    {
        public int Detail_Id { get; set; }
        public string Detail_Name { get; set; }
        public string DetailImg_Url { get; set; }
        public int Detail_Status { get; set; }
        public string Detail_Description { get; set; }
        public int Id_car { get; set; }
    }
}