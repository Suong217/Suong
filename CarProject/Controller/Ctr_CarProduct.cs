using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using CarProject.DAL;
using CarProject.Entities;

namespace CarProject.Controller
{
    public class Ctr_CarProduct
    {
        ProductDBContext dalCarProduct = new ProductDBContext();
        public DataTable getCarProduct()
        {
            return dalCarProduct.getCarProduct();
        }
        public DataTable getCarProductById(int carId)
        {
            return dalCarProduct.getCarProductById(carId);
        }
        public bool AddProduct(CarProduct cp)
        {
            return dalCarProduct.AddProduct(cp);
        }
        public bool EditProduct(CarProduct cp)
        {
            return dalCarProduct.EditProduct(cp);
        }
        public bool DeleteProduct(int Car_ID)
        {
            return dalCarProduct.DeleteProduct(Car_ID);
        }
    }
}