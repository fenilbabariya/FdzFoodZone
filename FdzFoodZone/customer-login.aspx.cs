using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FdzFoodZone
{
    public partial class CustomerLogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Sign Up button click Event
        protected void btnSignUpCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("customer-signup.aspx");
        }

        //Login button click Event
        protected void btnLoginCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select * from [customer] where username='" + txtUsernameCustomer.Text.Trim() + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr.GetValue(0).ToString() == txtUsernameCustomer.Text.Trim() && dr.GetValue(1).ToString() == txtPasswordCustomer.Text.Trim())
                    {
                        Response.Write("<script>alert('Hello, " + dr.GetValue(2).ToString() + "');</script>");
                        Session["username"] = dr.GetValue(0).ToString();
                        Session["fullname"] = dr.GetValue(2).ToString();
                        Session["role"] = "customer";
                        Response.Redirect("home.aspx");
                    }
                    else
                    {
                        lblInvalidCredentials.Text = "Invalid Credentials...";
                    }
                }
                else 
                {
                    lblInvalidCredentials.Text = "No such User Found, Please Sign Up...";
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}