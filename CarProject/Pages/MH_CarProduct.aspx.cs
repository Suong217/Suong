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
    public partial class MH_CarProduct : System.Web.UI.Page
    {
        Ctr_CarProduct ctr_CP = new Ctr_CarProduct();
        Ctr_CarDetail ctr_DT = new Ctr_CarDetail();
        protected void Page_Load(object sender, EventArgs e)
        {

            int carId = int.Parse(Request.QueryString["id"]);
            DataTable dt = ctr_CP.getCarProductById(carId);

            CarProduct a = null;
            if (dt != null && dt.Rows != null && dt.Rows.Count > 0)
            {
                
                    DataRow row = dt.Rows[0];
                    a = new CarProduct
                    {
                        CarImg_Url = row["CarImgUrl"].ToString(),
                        Car_Description = row["CarDescription"].ToString(),
                        Car_Id = (int)row["CarId"],
                        Car_Name = row["CarName"].ToString(),
                        Car_Status = (int)row["CarStatus"],
                    };

                    Image1.ImageUrl = a.CarImg_Url;
                    Label4.Text = a.Car_Id.ToString();
                    Label1.Text = a.Car_Name;
                    Label2.Text = a.Car_Description;
                    Label3.Text = a.Car_Status.ToString(); 
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int carId = int.Parse(Request.QueryString["id"]);
            DataTable dl = ctr_DT.getCarDetailById(carId);
            CarDetail b = null;

            if (dl != null && dl.Rows != null && dl.Rows.Count > 0)
            {
                DataRow row = dl.Rows[0];
                b = new CarDetail
                {
                    DetailImg_Url = row["DetailImgUrl"].ToString(),
                    Detail_Description = row["DetailDescription"].ToString(),
                    Detail_Id = (int)row["DetailId"],
                    Detail_Name = row["DetailName"].ToString(),
                    Detail_Status = (int)row["DetailStatus"],
                    Id_car = (int)row["Car_Id"],
                };
                if (carId == b.Id_car)
                {
                    GridView1.DataSource = dl;
                    GridView1.DataBind();
                }
                else
                    GridView1.DataSource = null;
            }
        }
        protected void btnView_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }

        
    }
}