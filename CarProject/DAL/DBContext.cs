using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CarProject.DAL
{
    public class DBContext
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-MAR9M20;Initial Catalog=CarProjectDB;User Id=admin2;Password=12345678;");
    }
}