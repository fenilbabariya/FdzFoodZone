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
    public partial class customer_profile : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        private string username;
        protected void Page_Load(object sender, EventArgs e)
        {
            fetchCartDetails();
        }

        private void fetchCartDetails()
        {
            //Fetching username from session
            try
            {
                if (Session["role"] != null)
                {
                    if (Session["role"].Equals("customer"))
                    {
                        username = Session["username"].ToString();
                        
                        //Fetching Cart values of perticular customer
                        try
                        {
                            SqlConnection con = new SqlConnection(strcon);
                            if (con.State == ConnectionState.Closed)
                            {
                                con.Open();
                            }
                            SqlCommand cmd = new SqlCommand("select itemname, price from [cart] where username='" + username + "'", con);
                            GridViewCart.DataSource = cmd.ExecuteReader();
                            GridViewCart.DataBind();
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            Response.Write(ex.Message);
                        }
                        //Fetching sum of price column
                        try
                        {
                            SqlConnection con = new SqlConnection(strcon);
                            if (con.State == ConnectionState.Closed)
                            {
                                con.Open();
                            }
                            SqlCommand cmd = new SqlCommand("select sum(price) from [cart] where username='" + username + "'", con);
                            SqlDataReader read = cmd.ExecuteReader();
                            while (read.Read())
                            {
                                lblTotalBill.Text = read.GetValue(0).ToString() + "₹";
                            }
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            Response.Write(ex.Message);
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Please login as Customer...');</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnClearCart_Click(object sender, EventArgs e)
        {
            if (checkorder())
            {
                Response.Write("<script>alert('After receiving your order cart items will automatically be cleared...');</script>");
            }
            else 
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("delete from [cart] where username='" + username + "'", con);
                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('Cart cleared...');</script>");
                    con.Close();
                    fetchCartDetails();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (checkCart())
            {
                if (checkorder())
                {
                    Response.Write("<script>alert('Your Order is alredy placed, wait till complete...');</script>");
                }
                else
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(strcon);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        SqlCommand cmd = new SqlCommand("insert into [customer_order_usernames] values ('" + username + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Response.Write("<script>alert('Your Order is being placed Successfully, You will get it soon...');</script>");
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.Message);
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('Cart is empty, Add some Item to place order...');</script>");
            }
        }

        bool checkCart()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select * from [cart] where username='" + username + "'", con);
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

        bool checkorder()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select * from [customer_order_usernames] where username='" + username + "'", con);
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
    }
}