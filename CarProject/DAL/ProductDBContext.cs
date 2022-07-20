using CarProject.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CarProject.DAL
{
    public class ProductDBContext :DBContext
    {
        public DataTable getCarProduct()
        {
            SqlDataAdapter db = new SqlDataAdapter(string.Format("SELECT * FROM [dbo].[CarProduct]"), _conn);
            DataTable dbCarProduct = new DataTable();
            db.Fill(dbCarProduct);

            return dbCarProduct;
        }
        public DataTable getCarProductById(int carId)
        {
            
            SqlDataAdapter db = new SqlDataAdapter(string.Format("SELECT * FROM [dbo].[CarProduct] WHERE CarId = {0}", carId), _conn);
            DataTable dbCarProduct = new DataTable();
            db.Fill(dbCarProduct);

            return dbCarProduct;
        }
        public bool EditProduct(CarProduct cP)
        {
            try
            {
                //ket noi
                _conn.Open();
                //Query string
                string sql = string.Format("UPDATE CarProduct SET CarName = '{0}', CarImgUrl = '{1}', CarStatus = '{2}', CarDescription = '{3}' WHERE CarId = {4}", cP.Car_Name, cP.CarImg_Url, cP.Car_Status, cP.Car_Description, cP.Car_Id);
                //command
                SqlCommand cmd = new SqlCommand(sql, _conn);

                //Query & check
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool AddProduct(CarProduct cP)
        {
            try
            {
                //ket noi
                _conn.Open();
                //Query string
                string sql = string.Format("INSERT INTO CarProduct(CarName, CarImgUrl, CarStatus, CarDescription) VALUES('{0}','{1}','{2}','{3}')", cP.Car_Name, cP.CarImg_Url, cP.Car_Status, cP.Car_Description);
                //command
                SqlCommand cmd = new SqlCommand(sql, _conn);

                //Query & check
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool DeleteProduct(int Car_ID)
        {
            try
            {
                //ket noi
                _conn.Open();
                //Query string
                string sql = string.Format("DELETE FROM CarProduct WHERE CarId = {0}", Car_ID);
                //command
                SqlCommand cmd = new SqlCommand(sql, _conn);

                //Query & check
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}