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
    public partial class AdminLogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select * from [admin_login] where username='" + txtUsernameAdmin.Text.Trim() + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr.GetValue(0).ToString() == txtUsernameAdmin.Text.Trim() && dr.GetValue(1).ToString() == txtPasswordAdmin.Text.Trim())
                    {
                        Response.Write("<script>alert('Hello, " + dr.GetValue(2).ToString() + "');</script>");
                        Session["username"] = dr.GetValue(0).ToString();
                        Session["fullname"] = dr.GetValue(2).ToString();
                        Session["role"] = "admin";
                        Response.Redirect("home.aspx");
                    }
                    else
                    {
                        lblInvalidCredentials.Text = "Invalid Credentials...";
                    }
                }
                else
                {
                    lblInvalidCredentials.Text = "Invalid Credentials...";
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}