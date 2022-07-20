using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CarProject.DAL
{
    public class DetailImgDBContext: DBContext
    {
        public DataTable getCarDetailImg()
        {
            SqlDataAdapter di = new SqlDataAdapter("SELECT * FROM [dbo].[CarDetailImg]", _conn);
            DataTable dbCarDetailImg = new DataTable();
            di.Fill(dbCarDetailImg);

            return dbCarDetailImg;
        }
        public DataTable getCarDetailImgById(int DetailId)
        {
            SqlDataAdapter db = new SqlDataAdapter(string.Format("SELECT * FROM [dbo].[CarDetailImg] WHERE Detail_Id = {0}", DetailId), _conn);
            DataTable dbCarDetailImg = new DataTable();
            db.Fill(dbCarDetailImg);

            return dbCarDetailImg;
        }
    }
}