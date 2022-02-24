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
    public partial class Beverages : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            fetchData();
        }

        string[] BeverageName = new string[12];
        string[] BeveragePrice = new string[12];
        string[] BeverageDescription = new string[12];
        string[] BeverageImage = new string[12];
        int BeverageId;

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
                    BeverageId = i + 1;
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("select * from [Beverage] where Id='" + BeverageId + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        BeverageName[i] = dr[1].ToString().Trim();
                        BeveragePrice[i] = dr[2].ToString().Trim();
                        BeverageDescription[i] = dr[3].ToString().Trim();
                        BeverageImage[i] = dr[4].ToString().Trim();
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
                Label1.Text = BeverageName[0];
                Label2.Text = "₹" + BeveragePrice[0];
                Label3.Text = BeverageDescription[0];
                Image1.ImageUrl = BeverageImage[0];
                //Card 2
                Label4.Text = BeverageName[1];
                Label5.Text = "₹" + BeveragePrice[1];
                Label6.Text = BeverageDescription[1];
                Image2.ImageUrl = BeverageImage[1];
                //Card 3
                Label7.Text = BeverageName[2];
                Label8.Text = "₹" + BeveragePrice[2];
                Label9.Text = BeverageDescription[2];
                Image3.ImageUrl = BeverageImage[2];
                //Card 4
                Label10.Text = BeverageName[3];
                Label11.Text = "₹" + BeveragePrice[3];
                Label12.Text = BeverageDescription[3];
                Image4.ImageUrl = BeverageImage[3];
                //Card 5
                Label13.Text = BeverageName[4];
                Label14.Text = "₹" + BeveragePrice[4];
                Label15.Text = BeverageDescription[4];
                Image5.ImageUrl = BeverageImage[4];
                //Card 6
                Label16.Text = BeverageName[5];
                Label17.Text = "₹" + BeveragePrice[5];
                Label18.Text = BeverageDescription[5];
                Image6.ImageUrl = BeverageImage[5];
                //Card 7
                Label19.Text = BeverageName[6];
                Label20.Text = "₹" + BeveragePrice[6];
                Label21.Text = BeverageDescription[6];
                Image7.ImageUrl = BeverageImage[6];
                //Card 8
                Label22.Text = BeverageName[7];
                Label23.Text = "₹" + BeveragePrice[7];
                Label24.Text = BeverageDescription[7];
                Image8.ImageUrl = BeverageImage[7];
                //Card 9
                Label25.Text = BeverageName[8];
                Label26.Text = "₹" + BeveragePrice[8];
                Label27.Text = BeverageDescription[8];
                Image9.ImageUrl = BeverageImage[8];
                //Card 10
                Label28.Text = BeverageName[9];
                Label29.Text = "₹" + BeveragePrice[9];
                Label30.Text = BeverageDescription[9];
                Image10.ImageUrl = BeverageImage[9];
                //Card 11
                Label31.Text = BeverageName[10];
                Label32.Text = "₹" + BeveragePrice[10];
                Label33.Text = BeverageDescription[10];
                Image11.ImageUrl = BeverageImage[10];
                //Card 12
                Label34.Text = BeverageName[11];
                Label35.Text = "₹" + BeveragePrice[11];
                Label36.Text = BeverageDescription[11];
                Image12.ImageUrl = BeverageImage[11];
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
                        itemname = BeverageName[BtnId];
                        itemprice = Convert.ToInt32(BeveragePrice[BtnId]);
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