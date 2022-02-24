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
    public partial class Drinks : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            fetchData();
        }

        string[] DrinkName = new string[12];
        string[] DrinkPrice = new string[12];
        string[] DrinkDescription = new string[12];
        string[] DrinkImage = new string[12];
        int DrinkId;
        int BtnId;
        string itemname;
        int itemprice;
        private string username;

        private void fetchData()
        {
            try
            {
                for (int i = 0; i <= 11; i++)
                {
                    DrinkId = i + 1;
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("select * from [Drinks] where Id='" + DrinkId + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        DrinkName[i] = dr[1].ToString().Trim();
                        DrinkPrice[i] = dr[2].ToString().Trim();
                        DrinkDescription[i] = dr[3].ToString().Trim();
                        DrinkImage[i] = dr[4].ToString().Trim();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Response.Write("This is for loop catch part" + ex.Message);
            }
            try
            {
                //Card 1
                Label1.Text = DrinkName[0];
                Label2.Text = "₹" + DrinkPrice[0];
                Label3.Text = DrinkDescription[0];
                Image1.ImageUrl = DrinkImage[0];
                //Card 2
                Label4.Text = DrinkName[1];
                Label5.Text = "₹" + DrinkPrice[1];
                Label6.Text = DrinkDescription[1];
                Image2.ImageUrl = DrinkImage[1];
                //Card 3
                Label7.Text = DrinkName[2];
                Label8.Text = "₹" + DrinkPrice[2];
                Label9.Text = DrinkDescription[2];
                Image3.ImageUrl = DrinkImage[2];
                //Card 4
                Label10.Text = DrinkName[3];
                Label11.Text = "₹" + DrinkPrice[3];
                Label12.Text = DrinkDescription[3];
                Image4.ImageUrl = DrinkImage[3];
                //Card 5
                Label13.Text = DrinkName[4];
                Label14.Text = "₹" + DrinkPrice[4];
                Label15.Text = DrinkDescription[4];
                Image5.ImageUrl = DrinkImage[4];
                //Card 6
                Label16.Text = DrinkName[5];
                Label17.Text = "₹" + DrinkPrice[5];
                Label18.Text = DrinkDescription[5];
                Image6.ImageUrl = DrinkImage[5];
                //Card 7
                Label19.Text = DrinkName[6];
                Label20.Text = "₹" + DrinkPrice[6];
                Label21.Text = DrinkDescription[6];
                Image7.ImageUrl = DrinkImage[6];
                //Card 8
                Label22.Text = DrinkName[7];
                Label23.Text = "₹" + DrinkPrice[7];
                Label24.Text = DrinkDescription[7];
                Image8.ImageUrl = DrinkImage[7];
                //Card 9
                Label25.Text = DrinkName[8];
                Label26.Text = "₹" + DrinkPrice[8];
                Label27.Text = DrinkDescription[8];
                Image9.ImageUrl = DrinkImage[8];
                //Card 10
                Label28.Text = DrinkName[9];
                Label29.Text = "₹" + DrinkPrice[9];
                Label30.Text = DrinkDescription[9];
                Image10.ImageUrl = DrinkImage[9];
                //Card 11
                Label31.Text = DrinkName[10];
                Label32.Text = "₹" + DrinkPrice[10];
                Label33.Text = DrinkDescription[10];
                Image11.ImageUrl = DrinkImage[10];
                //Card 12
                Label34.Text = DrinkName[11];
                Label35.Text = "₹" + DrinkPrice[11];
                Label36.Text = DrinkDescription[11];
                Image12.ImageUrl = DrinkImage[11];
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        //Add item data into cart
        private void insertData()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("insert into [cart] (username, itemname, price) values ('" + username + "','" + itemname + "','" + itemprice + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Item Added to Cart');</script>");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        //Check weather User is Login or not
        private void checkLogin()
        {
            try
            {
                if (Session["role"] != null)
                {
                    if (Session["role"].Equals("customer"))
                    {
                        username = Session["username"].ToString();
                        itemname = DrinkName[BtnId];
                        itemprice = Convert.ToInt32(DrinkPrice[BtnId]);
                        insertData();
                    }
                    else
                    {
                        Response.Write("<script>alert('Please Login as Customer...');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Please Login...');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        //Cart button click events
        protected void Button1_Click(object sender, EventArgs e)
        {
            BtnId = 0;
            checkLogin();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            BtnId = 1;
            checkLogin();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            BtnId = 2;
            checkLogin();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            BtnId = 3;
            checkLogin();
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            BtnId = 4;
            checkLogin();
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            BtnId = 5;
            checkLogin();
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            BtnId = 6;
            checkLogin();
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            BtnId = 7;
            checkLogin();
        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            BtnId = 8;
            checkLogin();
        }
        protected void Button10_Click(object sender, EventArgs e)
        {
            BtnId = 9;
            checkLogin();
        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            BtnId = 10;
            checkLogin();
        }
        protected void Button12_Click(object sender, EventArgs e)
        {
            BtnId = 11;
            checkLogin();
        }
    }
}