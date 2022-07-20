using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using CarProject.DAL;

namespace CarProject.Controller
{
    public class Ctr_CarDetailImg
    {
        DetailImgDBContext dalCarDetailImg = new DetailImgDBContext();
        public DataTable getCarDetailImg()
        {
            return dalCarDetailImg.getCarDetailImg();
        }
        public DataTable getCarDetailImgById(int ImgGroupId)
        {
            return dalCarDetailImg.getCarDetailImgById(ImgGroupId);
        }
    }
}