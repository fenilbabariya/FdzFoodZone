using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FdzFoodZone
{
    public partial class Index : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"] != null)
                {
                    if (Session["role"].Equals(""))
                    {
                        //Customer Buttons
                        btnLoginCustomer.Visible = true;
                        btnSignUpCustomer.Visible = true;

                        //Common Buttons
                        btnLogout.Visible = false;
                        btnHello.Visible = false;

                        //Admin Buttons
                        btnAdminLogin.Visible = true;
                        btnManageFood.Visible = false;
                        btnManageDrinks.Visible = false;
                        btnManageDessert.Visible = false;
                        btnManageBeverage.Visible = false;
                        btnCustomerList.Visible = false;
                        btnChangePassword.Visible = false;
                        
                    }
                    else if (Session["role"].Equals("customer"))
                    {
                        //All Admin Buttons are false now
                        btnAdminLogin.Visible = false;
                        btnManageFood.Visible = false;
                        btnManageDrinks.Visible = false;
                        btnManageDessert.Visible = false;
                        btnManageBeverage.Visible = false;
                        btnCustomerList.Visible = false;
                        btnChangePassword.Visible = false;

                        //Customer Buttons
                        btnLoginCustomer.Visible = false;
                        btnSignUpCustomer.Visible = false;

                        btnLogout.Visible = true;
                        btnHello.Visible = true;
                        btnHello.Text = "Hello, " + Session["username"].ToString();
                    }
                    else if (Session["role"].Equals("admin"))
                    {
                        //Admin Buttons
                        btnAdminLogin.Visible = false;
                        btnManageFood.Visible = true;
                        btnManageDrinks.Visible = true;
                        btnManageDessert.Visible = true;
                        btnManageBeverage.Visible = true;
                        btnChangePassword.Visible = true;
                        btnCustomerList.Visible = true;

                        //Customer Buttons are flase now
                        btnLoginCustomer.Visible = false;
                        btnSignUpCustomer.Visible = false;

                        btnLogout.Visible = true;
                        btnHello.Visible = true;
                        btnHello.Text = "Hello, " + Session["username"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnAdminLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin-login.aspx");
        }

        protected void btnLoginCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("customer-login.aspx");
        }

        protected void btnSignUpCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("customer-signup.aspx");
        }

        //Social Media Button Click Events
      
        protected void btnInsta_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("<script>window.open ('https://www.instagram.com/fdz.foodzone/','_blank');</script>");
        }


        protected void btnTwit_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("<script>window.open ('https://twitter.com/FDFoodzone','_blank');</script>");
        }

        protected void btnFB_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("<script>window.open ('https://www.facebook.com/fdz.foodzone.3/','_blank');</script>");
        }

        //Logout Button
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Session["fullname"] = null;
            Session["role"] = null;

            //Customer Buttons
            btnLoginCustomer.Visible = true;
            btnSignUpCustomer.Visible = true;

            //Common Buttons
            btnLogout.Visible = false;
            btnHello.Visible = false;

            //Admin Buttons
            btnAdminLogin.Visible = true;
            btnManageFood.Visible = false;
            btnManageDrinks.Visible = false;
            btnManageDessert.Visible = false;
            btnManageBeverage.Visible = false;
            btnChangePassword.Visible = false;
            btnCustomerList.Visible = false;

            Response.Redirect("home.aspx");
        }

        //Admin Buttons

        protected void btnManageFood_Click(object sender, EventArgs e)
        {
            Response.Redirect("edit-food.aspx");
        }

        protected void btnManageDrinks_Click(object sender, EventArgs e)
        {
            Response.Redirect("edit-drinks.aspx");
        }

        protected void btnManageDessert_Click(object sender, EventArgs e)
        {
            Response.Redirect("edit-dessert.aspx");
        }

        protected void btnManageBeverage_Click(object sender, EventArgs e)
        {
            Response.Redirect("edit-beverage.aspx");
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("change-password.aspx");
        }

        //Customer Buttons

        protected void btnFood_Click(object sender, EventArgs e)
        {
            Response.Redirect("food.aspx");
        }

        protected void btnDrinks_Click(object sender, EventArgs e)
        {
            Response.Redirect("drinks.aspx");
        }

        protected void btnDessert_Click(object sender, EventArgs e)
        {
            Response.Redirect("dessert.aspx");
        }

        protected void btnBeverages_Click(object sender, EventArgs e)
        {
            Response.Redirect("beverages.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void btnViewOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"] != null)
                {
                    if (Session["role"].Equals(""))
                    {
                        Response.Write("<script>alert('Please Login to View Oreder...');</script>");
                    }
                    else if (Session["role"].Equals("customer"))
                    {
                        Response.Redirect("customer-cart.aspx");
                    }
                    else if (Session["role"].Equals("admin"))
                    {
                        Response.Redirect("admin-order.aspx");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Please Login to View Oreders...');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnCustomerList_Click(object sender, EventArgs e)
        {
            Response.Redirect("customer-list.aspx");
        }
    }
}