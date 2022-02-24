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
    public partial class change_password : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"] != null)
                {
                    if (Session["username"].Equals(txtUsernameAdmin.Text.Trim()))
                    {
                        try
                        {
                            SqlConnection con = new SqlConnection(strcon);
                            if (con.State == ConnectionState.Closed)
                            {
                                con.Open();
                            }
                            SqlCommand cmd = new SqlCommand("update [admin_login] set password='" + txtPasswordAdmin.Text + "' where username='" + txtUsernameAdmin.Text.Trim() + "'", con);
                            cmd.ExecuteNonQuery();
                            Response.Write("<script>alert('Password Successfully Changed');</script>");
                            lblInvalidCredentials.Text = "";
                        }
                        catch (Exception ex)
                        {
                            lblInvalidCredentials.Text = ex.Message;
                        }
                    }
                    else
                    {
                        lblInvalidCredentials.Text = "Invalid Credentials...";
                    }
                }
                else 
                {
                    lblInvalidCredentials.Text = "Please Login First to Change Password...";
                }
            }
            catch (Exception ex)
            {
                lblInvalidCredentials.Text = ex.Message;
            }
        }
    }
}