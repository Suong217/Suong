using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using CarProject.DAL;

namespace CarProject.Controller
{
    public class Ctr_CarDetail
    {
        DetailDBContext dalCarDetail = new DetailDBContext();
        public DataTable getCarDetailById(int carId)
        {
            return dalCarDetail.getCarDetailById(carId);
        }
    }
}