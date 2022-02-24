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
    public partial class customer_signup : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Sign Up button click Event
        protected void btnSignupCustomer_Click(object sender, EventArgs e)
        {
            if(txtFullName.Text.Trim().Equals("") || txtDOB.Text.Equals("") || txtContactNo.Text.Trim().Equals("") || txtEmail.Text.Trim().Equals("") || txtCity.Text.Trim().Equals("") || txtPinCode.Text.Trim().Equals("") || txtAdress.Text.Trim().Equals("") || txtUsernameCustomer.Text.Trim().Equals("") || txtPasswordCustomer.Text.Trim().Equals(""))
            {
                Response.Write("<script>alert('Enter all necessary details to Sign Up!');</script>");
            }
            else
            {
                if (checkCustomer())
                {
                    Response.Write("<script>alert('Username already exists, Try another one!');</script>");
                }
                else
                {
                    signUp();
                }
            }
        }

        bool checkCustomer() {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select * from [customer] where username='"+txtUsernameCustomer.Text.Trim()+"'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }

        void signUp() {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("insert into [customer] values (@username,@password,@fullname,@dob,@contactno,@email,@state,@city,@pincode,@address)", con);
                cmd.Parameters.AddWithValue("@username", txtUsernameCustomer.Text.Trim());
                cmd.Parameters.AddWithValue("@password", txtPasswordCustomer.Text.Trim());
                cmd.Parameters.AddWithValue("@fullname", txtFullName.Text.Trim());
                cmd.Parameters.AddWithValue("@dob", txtDOB.Text.Trim());
                cmd.Parameters.AddWithValue("@contactno", txtContactNo.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@state", dropdownState.SelectedValue);
                cmd.Parameters.AddWithValue("@city", txtCity.Text.Trim());
                cmd.Parameters.AddWithValue("@pincode", txtPinCode.Text.Trim());
                cmd.Parameters.AddWithValue("@address", txtAdress.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Sign Up Successful, Go to Login Page to Login');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

    }
}