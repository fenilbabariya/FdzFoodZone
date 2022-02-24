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
    public partial class Food : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            fetchData();
        }

        string[] FoodName = new string[12];
        string[] FoodPrice = new string[12];
        string[] FoodDescription = new string[12];
        string[] FoodImage = new string[12];
        int FoodId;
        int BtnId;
        string itemname;
        int itemprice;
        private string username;

        private void fetchData()
        {
            //Fetching data of food items from database
            try
                {
                for (int i = 0; i <= 11; i++)
                {
                    FoodId = i + 1;
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("select * from [Food] where Id='" + FoodId + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        FoodName[i] = dr[1].ToString().Trim();
                        FoodPrice[i] = dr[2].ToString().Trim();
                        FoodDescription[i] = dr[3].ToString().Trim();
                        FoodImage[i] = dr[4].ToString().Trim();
                    }
                    con.Close();
                }
                }
                catch (Exception ex)
                {
                    Response.Write("This is for loop catch part" + ex.Message);
                }
            //Set data in labels
            try
            {
                //Card 1
                Label1.Text = FoodName[0];
                Label2.Text = "₹" + FoodPrice[0];
                Label3.Text = FoodDescription[0];
                Image1.ImageUrl = FoodImage[0];
                //Card 2
                Label4.Text = FoodName[1];
                Label5.Text = "₹" + FoodPrice[1];
                Label6.Text = FoodDescription[1];
                Image2.ImageUrl = FoodImage[1];
                //Card 3
                Label7.Text = FoodName[2];
                Label8.Text = "₹" + FoodPrice[2];
                Label9.Text = FoodDescription[2];
                Image3.ImageUrl = FoodImage[2];
                //Card 4
                Label10.Text = FoodName[3];
                Label11.Text = "₹" + FoodPrice[3];
                Label12.Text = FoodDescription[3];
                Image4.ImageUrl = FoodImage[3];
                //Card 5
                Label13.Text = FoodName[4];
                Label14.Text = "₹" + FoodPrice[4];
                Label15.Text = FoodDescription[4];
                Image5.ImageUrl = FoodImage[4];
                //Card 6
                Label16.Text = FoodName[5];
                Label17.Text = "₹" + FoodPrice[5];
                Label18.Text = FoodDescription[5];
                Image6.ImageUrl = FoodImage[5];
                //Card 7
                Label19.Text = FoodName[6];
                Label20.Text = "₹" + FoodPrice[6];
                Label21.Text = FoodDescription[6];
                Image7.ImageUrl = FoodImage[6];
                //Card 8
                Label22.Text = FoodName[7];
                Label23.Text = "₹" + FoodPrice[7];
                Label24.Text = FoodDescription[7];
                Image8.ImageUrl = FoodImage[7];
                //Card 9
                Label25.Text = FoodName[8];
                Label26.Text = "₹" + FoodPrice[8];
                Label27.Text = FoodDescription[8];
                Image9.ImageUrl = FoodImage[8];
                //Card 10
                Label28.Text = FoodName[9];
                Label29.Text = "₹" + FoodPrice[9];
                Label30.Text = FoodDescription[9];
                Image10.ImageUrl = FoodImage[9];
                //Card 11
                Label31.Text = FoodName[10];
                Label32.Text = "₹" + FoodPrice[10];
                Label33.Text = FoodDescription[10];
                Image11.ImageUrl = FoodImage[10];
                //Card 12
                Label34.Text = FoodName[11];
                Label35.Text = "₹" + FoodPrice[11];
                Label36.Text = FoodDescription[11];
                Image12.ImageUrl = FoodImage[11];
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
                        itemname = FoodName[BtnId];
                        itemprice = Convert.ToInt32(FoodPrice[BtnId]);
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