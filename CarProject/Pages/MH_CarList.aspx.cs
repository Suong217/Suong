using CarProject.Controller;
using CarProject.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarProject.Pages
{
    public partial class MH_CarList : System.Web.UI.Page
    {
        Ctr_CarProduct ctr_CP = new Ctr_CarProduct();
        Ctr_CarDetail ctr_DT = new Ctr_CarDetail();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataTable cp = ctr_CP.getCarProduct();
                CarProduct a = null;

                if (cp != null && cp.Rows != null && cp.Rows.Count > 0)
                {
                    DataRow row = cp.Rows[0];
                    a = new CarProduct
                    {
                        CarImg_Url = row["CarImgUrl"].ToString(),
                        Car_Description = row["CarDescription"].ToString(),
                        Car_Id = (int)row["CarId"],
                        Car_Name = row["CarName"].ToString(),
                        Car_Status = (int)row["CarStatus"],
                    };

                    rpCarList.DataSource = cp;
                    rpCarList.DataBind();

                }
            }
            
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            DataTable cp = ctr_CP.getCarProduct();
            CarProduct a = null;

            if (cp != null && cp.Rows != null && cp.Rows.Count > 0)
            {
                for (int i = 0; i < cp.Rows.Count; i++)
                {
                    DataRow row = cp.Rows[i];
                    a = new CarProduct
                    {
                        CarImg_Url = row["CarImgUrl"].ToString(),
                        Car_Description = row["CarDescription"].ToString(),
                        Car_Id = (int)row["CarId"],
                        Car_Name = row["CarName"].ToString(),
                        Car_Status = (int)row["CarStatus"],
                    };
                    Response.Redirect($"MH_CarProduct.aspx?id={a.Car_Id}");
                }
            }
            
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}