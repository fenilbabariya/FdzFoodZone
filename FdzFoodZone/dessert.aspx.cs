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
    public partial class Dessert : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            fetchData();
        }

        string[] DessertName = new string[12];
        string[] DessertPrice = new string[12];
        string[] DessertDescription = new string[12];
        string[] DessertImage = new string[12];
        int DessertId;
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
                    DessertId = i + 1;
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("select * from [Dessert] where Id='" + DessertId + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        DessertName[i] = dr[1].ToString().Trim();
                        DessertPrice[i] = dr[2].ToString().Trim();
                        DessertDescription[i] = dr[3].ToString().Trim();
                        DessertImage[i] = dr[4].ToString().Trim();
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
                Label1.Text = DessertName[0];
                Label2.Text = "₹" + DessertPrice[0];
                Label3.Text = DessertDescription[0];
                Image1.ImageUrl = DessertImage[0];
                //Card 2
                Label4.Text = DessertName[1];
                Label5.Text = "₹" + DessertPrice[1];
                Label6.Text = DessertDescription[1];
                Image2.ImageUrl = DessertImage[1];
                //Card 3
                Label7.Text = DessertName[2];
                Label8.Text = "₹" + DessertPrice[2];
                Label9.Text = DessertDescription[2];
                Image3.ImageUrl = DessertImage[2];
                //Card 4
                Label10.Text = DessertName[3];
                Label11.Text = "₹" + DessertPrice[3];
                Label12.Text = DessertDescription[3];
                Image4.ImageUrl = DessertImage[3];
                //Card 5
                Label13.Text = DessertName[4];
                Label14.Text = "₹" + DessertPrice[4];
                Label15.Text = DessertDescription[4];
                Image5.ImageUrl = DessertImage[4];
                //Card 6
                Label16.Text = DessertName[5];
                Label17.Text = "₹" + DessertPrice[5];
                Label18.Text = DessertDescription[5];
                Image6.ImageUrl = DessertImage[5];
                //Card 7
                Label19.Text = DessertName[6];
                Label20.Text = "₹" + DessertPrice[6];
                Label21.Text = DessertDescription[6];
                Image7.ImageUrl = DessertImage[6];
                //Card 8
                Label22.Text = DessertName[7];
                Label23.Text = "₹" + DessertPrice[7];
                Label24.Text = DessertDescription[7];
                Image8.ImageUrl = DessertImage[7];
                //Card 9
                Label25.Text = DessertName[8];
                Label26.Text = "₹" + DessertPrice[8];
                Label27.Text = DessertDescription[8];
                Image9.ImageUrl = DessertImage[8];
                //Card 10
                Label28.Text = DessertName[9];
                Label29.Text = "₹" + DessertPrice[9];
                Label30.Text = DessertDescription[9];
                Image10.ImageUrl = DessertImage[9];
                //Card 11
                Label31.Text = DessertName[10];
                Label32.Text = "₹" + DessertPrice[10];
                Label33.Text = DessertDescription[10];
                Image11.ImageUrl = DessertImage[10];
                //Card 12
                Label34.Text = DessertName[11];
                Label35.Text = "₹" + DessertPrice[11];
                Label36.Text = DessertDescription[11];
                Image12.ImageUrl = DessertImage[11];
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
                        itemname = DessertName[BtnId];
                        itemprice = Convert.ToInt32(DessertPrice[BtnId]);
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