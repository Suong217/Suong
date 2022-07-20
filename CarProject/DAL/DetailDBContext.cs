using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CarProject.DAL
{
    public class DetailDBContext :DBContext
    {
        public DataTable getCarDetail()
        {
            SqlDataAdapter db = new SqlDataAdapter("SELECT * FROM [dbo].[CarDetail]", _conn);
            DataTable dbCarDetail = new DataTable();
            db.Fill(dbCarDetail);

            return dbCarDetail;
        }
        public DataTable getCarDetailById(int carId)
        {
            SqlDataAdapter db = new SqlDataAdapter(string.Format("SELECT * FROM [dbo].[CarDetail] WHERE  Car_Id = {0}", carId), _conn);
            DataTable dbCarDetail = new DataTable();
            db.Fill(dbCarDetail);

            return dbCarDetail;
        }
    }
}