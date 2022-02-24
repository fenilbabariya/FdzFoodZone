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
    public partial class admin_order : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fetchCustomerDetails();
                fetchOrder();
                fetchTotalBill();
            }
        }

        private void fetchCustomerDetails()
        {
            try
            {
                if (Session["role"] != null)
                {
                    if (Session["role"].Equals("admin"))
                    {
                        //Fetching usernames of customers
                        try
                        {
                            SqlConnection con = new SqlConnection(strcon);
                            SqlDataAdapter adpt = new SqlDataAdapter("select * from[customer_order_usernames]",con);
                            DataTable dt = new DataTable();
                            adpt.Fill(dt);
                            DropDownListCustomer.DataSource = dt;
                            DropDownListCustomer.DataTextField = "username";
                            DropDownListCustomer.DataBind();
                        }
                        catch (Exception ex)
                        {
                            Response.Write(ex.Message);
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Please login as Admin...');</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void DropDownListCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchOrder();
            fetchTotalBill();
        }

        private void fetchTotalBill()
        {
            //Fetching sum of price column
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select sum(price) from [cart] where username='" + DropDownListCustomer.SelectedValue + "'", con);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    lblTotalBill.Text = "Total Bill: " + read.GetValue(0).ToString() + "₹";
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        private void fetchOrder()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlDataAdapter adpt = new SqlDataAdapter("select itemname, price from [cart] where username='"+ DropDownListCustomer.SelectedValue +"'", con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                GridViewOrder.DataSource = dt;
                GridViewOrder.DataBind();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("delete from [cart] where username='" + DropDownListCustomer.SelectedValue + "'", con);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("delete from [customer_order_usernames] where username='" + DropDownListCustomer.SelectedValue + "'", con);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Order Completed...');</script>");
                con.Close();
                fetchCustomerDetails();
                fetchOrder();
                fetchTotalBill();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}