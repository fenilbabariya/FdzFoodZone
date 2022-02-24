using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FdzFoodZone
{
    public partial class edit_dessert : System.Web.UI.Page
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
        string filename;
        string filepath;

        int Id;
        string Name;
        string Price;
        string Description;

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
                txtName1.Attributes["placeholder"] = DessertName[0];
                txtPrice1.Attributes["placeholder"] = DessertPrice[0];
                txtDescription1.Attributes["placeholder"] = DessertDescription[0];
                Image1.ImageUrl = DessertImage[0];
                //Card 2
                txtName2.Attributes["placeholder"] = DessertName[1];
                txtPrice2.Attributes["placeholder"] = DessertPrice[1];
                txtDescription2.Attributes["placeholder"] = DessertDescription[1];
                Image2.ImageUrl = DessertImage[1];
                //Card 3
                txtName3.Attributes["placeholder"] = DessertName[2];
                txtPrice3.Attributes["placeholder"] = DessertPrice[2];
                txtDescription3.Attributes["placeholder"] = DessertDescription[2];
                Image3.ImageUrl = DessertImage[2];
                //Card 4
                txtName4.Attributes["placeholder"] = DessertName[3];
                txtPrice4.Attributes["placeholder"] = DessertPrice[3];
                txtDescription4.Attributes["placeholder"] = DessertDescription[3];
                Image4.ImageUrl = DessertImage[3];
                //Card 5
                txtName5.Attributes["placeholder"] = DessertName[4];
                txtPrice5.Attributes["placeholder"] = DessertPrice[4];
                txtDescription5.Attributes["placeholder"] = DessertDescription[4];
                Image5.ImageUrl = DessertImage[4];
                //Card 6
                txtName6.Attributes["placeholder"] = DessertName[5];
                txtPrice6.Attributes["placeholder"] = DessertPrice[5];
                txtDescription6.Attributes["placeholder"] = DessertDescription[5];
                Image6.ImageUrl = DessertImage[5];
                //Card 7
                txtName7.Attributes["placeholder"] = DessertName[6];
                txtPrice7.Attributes["placeholder"] = DessertPrice[6];
                txtDescription7.Attributes["placeholder"] = DessertDescription[6];
                Image7.ImageUrl = DessertImage[6];
                //Card 8
                txtName8.Attributes["placeholder"] = DessertName[7];
                txtPrice8.Attributes["placeholder"] = DessertPrice[7];
                txtDescription8.Attributes["placeholder"] = DessertDescription[7];
                Image8.ImageUrl = DessertImage[7];
                //Card 9
                txtName9.Attributes["placeholder"] = DessertName[8];
                txtPrice9.Attributes["placeholder"] = DessertPrice[8];
                txtDescription9.Attributes["placeholder"] = DessertDescription[8];
                Image9.ImageUrl = DessertImage[8];
                //Card 10
                txtName10.Attributes["placeholder"] = DessertName[9];
                txtPrice10.Attributes["placeholder"] = DessertPrice[9];
                txtDescription10.Attributes["placeholder"] = DessertDescription[9];
                Image10.ImageUrl = DessertImage[9];
                //Card 11
                txtName11.Attributes["placeholder"] = DessertName[10];
                txtPrice11.Attributes["placeholder"] = DessertPrice[10];
                txtDescription11.Attributes["placeholder"] = DessertDescription[10];
                Image11.ImageUrl = DessertImage[10];
                //Card 12
                txtName12.Attributes["placeholder"] = DessertName[11];
                txtPrice12.Attributes["placeholder"] = DessertPrice[11];
                txtDescription12.Attributes["placeholder"] = DessertDescription[11];
                Image12.ImageUrl = DessertImage[11];
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        private void updateDetails()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("update [Dessert] set Name='" + Name + "', Price='" + Price + "', Description='" + Description + "' where Id='" + Id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Details Successfully Updated');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        private void updateImage()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("update [Dessert] set imglink='" + filepath + "' where Id='" + Id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Image Successfully Updated');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void btnUpdate1_Click(object sender, EventArgs e)
        {

            if (photoUpload1.HasFile)
            {
                filename = Path.GetFileName(photoUpload1.PostedFile.FileName);
                filepath = "~/items/" + filename;
                Id = 1;
                updateImage();
                photoUpload1.SaveAs((Server.MapPath("~/items/" + photoUpload1.FileName)));
            }
            if (txtName1.Text.Equals("") || txtPrice1.Text.Equals("") || txtDescription1.Text.Equals(""))
            {
                Response.Write("<script>alert('Enter all the necessary details of Item!');</script>");
            }
            else
            {
                Id = 1;
                Name = txtName1.Text.Trim().ToString().ToUpper();
                Price = txtPrice1.Text.Trim().ToString();
                Description = txtDescription1.Text.Trim().ToString();
                updateDetails();
            }
        }

        protected void btnUpdate2_Click(object sender, EventArgs e)
        {
            if (photoUpload2.HasFile)
            {
                filename = Path.GetFileName(photoUpload2.PostedFile.FileName);
                filepath = "~/items/" + filename;
                Id = 2;
                updateImage();
                photoUpload2.SaveAs((Server.MapPath("~/items/" + photoUpload2.FileName)));
            }

            if (txtName2.Text.Equals("") || txtPrice2.Text.Equals("") || txtDescription2.Text.Equals(""))
            {
                Response.Write("<script>alert('Enter all the necessary details of Item!');</script>");
            }
            else
            {
                Id = 2;
                Name = txtName2.Text.Trim().ToString().ToUpper();
                Price = txtPrice2.Text.Trim().ToString();
                Description = txtDescription2.Text.Trim().ToString();
                updateDetails();
            }
        }

        protected void btnUpdate3_Click(object sender, EventArgs e)
        {
            if (photoUpload3.HasFile)
            {
                filename = Path.GetFileName(photoUpload3.PostedFile.FileName);
                filepath = "~/items/" + filename;
                Id = 3;
                updateImage();
                photoUpload3.SaveAs((Server.MapPath("~/items/" + photoUpload3.FileName)));
            }

            if (txtName3.Text.Equals("") || txtPrice3.Text.Equals("") || txtDescription3.Text.Equals(""))
            {
                Response.Write("<script>alert('Enter all the necessary details of Item!');</script>");
            }
            else
            {
                Id = 3;
                Name = txtName3.Text.Trim().ToString().ToUpper();
                Price = txtPrice3.Text.Trim().ToString();
                Description = txtDescription3.Text.Trim().ToString();
                updateDetails();
            }
        }

        protected void btnUpdate4_Click(object sender, EventArgs e)
        {
            if (photoUpload4.HasFile)
            {
                filename = Path.GetFileName(photoUpload4.PostedFile.FileName);
                filepath = "~/items/" + filename;
                Id = 4;
                updateImage();
                photoUpload4.SaveAs((Server.MapPath("~/items/" + photoUpload4.FileName)));
            }

            if (txtName4.Text.Equals("") || txtPrice4.Text.Equals("") || txtDescription4.Text.Equals(""))
            {
                Response.Write("<script>alert('Enter all the necessary details of Item!');</script>");
            }
            else
            {
                Id = 4;
                Name = txtName4.Text.Trim().ToString().ToUpper();
                Price = txtPrice4.Text.Trim().ToString();
                Description = txtDescription4.Text.Trim().ToString();
                updateDetails();
            }
        }

        protected void btnUpdate5_Click(object sender, EventArgs e)
        {
            if (photoUpload5.HasFile)
            {
                filename = Path.GetFileName(photoUpload5.PostedFile.FileName);
                filepath = "~/items/" + filename;
                Id = 5;
                updateImage();
                photoUpload5.SaveAs((Server.MapPath("~/items/" + photoUpload5.FileName)));
            }

            if (txtName5.Text.Equals("") || txtPrice5.Text.Equals("") || txtDescription5.Text.Equals(""))
            {
                Response.Write("<script>alert('Enter all the necessary details of Item!');</script>");
            }
            else
            {
                Id = 5;
                Name = txtName5.Text.Trim().ToString().ToUpper();
                Price = txtPrice5.Text.Trim().ToString();
                Description = txtDescription5.Text.Trim().ToString();
                updateDetails();
            }
        }

        protected void btnUpdate6_Click(object sender, EventArgs e)
        {
            if (photoUpload6.HasFile)
            {
                filename = Path.GetFileName(photoUpload6.PostedFile.FileName);
                filepath = "~/items/" + filename;
                Id = 6;
                updateImage();
                photoUpload6.SaveAs((Server.MapPath("~/items/" + photoUpload6.FileName)));
            }

            if (txtName6.Text.Equals("") || txtPrice6.Text.Equals("") || txtDescription6.Text.Equals(""))
            {
                Response.Write("<script>alert('Enter all the necessary details of Item!');</script>");
            }
            else
            {
                Id = 6;
                Name = txtName6.Text.Trim().ToString().ToUpper();
                Price = txtPrice6.Text.Trim().ToString();
                Description = txtDescription6.Text.Trim().ToString();
                updateDetails();
            }
        }

        protected void btnUpdate7_Click(object sender, EventArgs e)
        {
            if (photoUpload7.HasFile)
            {
                filename = Path.GetFileName(photoUpload7.PostedFile.FileName);
                filepath = "~/items/" + filename;
                Id = 7;
                updateImage();
                photoUpload7.SaveAs((Server.MapPath("~/items/" + photoUpload7.FileName)));
            }

            if (txtName7.Text.Equals("") || txtPrice7.Text.Equals("") || txtDescription7.Text.Equals(""))
            {
                Response.Write("<script>alert('Enter all the necessary details of Item!');</script>");
            }
            else
            {
                Id = 7;
                Name = txtName7.Text.Trim().ToString().ToUpper();
                Price = txtPrice7.Text.Trim().ToString();
                Description = txtDescription7.Text.Trim().ToString();
                updateDetails();
            }
        }

        protected void btnUpdate8_Click(object sender, EventArgs e)
        {
            if (photoUpload8.HasFile)
            {
                filename = Path.GetFileName(photoUpload8.PostedFile.FileName);
                filepath = "~/items/" + filename;
                Id = 8;
                updateImage();
                photoUpload8.SaveAs((Server.MapPath("~/items/" + photoUpload8.FileName)));
            }

            if (txtName8.Text.Equals("") || txtPrice8.Text.Equals("") || txtDescription8.Text.Equals(""))
            {
                Response.Write("<script>alert('Enter all the necessary details of Item!');</script>");
            }
            else
            {
                Id = 8;
                Name = txtName8.Text.Trim().ToString().ToUpper();
                Price = txtPrice8.Text.Trim().ToString();
                Description = txtDescription8.Text.Trim().ToString();
                updateDetails();
            }
        }

        protected void btnUpdate9_Click(object sender, EventArgs e)
        {
            if (photoUpload9.HasFile)
            {
                filename = Path.GetFileName(photoUpload9.PostedFile.FileName);
                filepath = "~/items/" + filename;
                Id = 9;
                updateImage();
                photoUpload9.SaveAs((Server.MapPath("~/items/" + photoUpload9.FileName)));
            }

            if (txtName9.Text.Equals("") || txtPrice9.Text.Equals("") || txtDescription9.Text.Equals(""))
            {
                Response.Write("<script>alert('Enter all the necessary details of Item!');</script>");
            }
            else
            {
                Id = 9;
                Name = txtName9.Text.Trim().ToString().ToUpper();
                Price = txtPrice9.Text.Trim().ToString();
                Description = txtDescription9.Text.Trim().ToString();
                updateDetails();
            }
        }

        protected void btnUpdate10_Click(object sender, EventArgs e)
        {
            if (photoUpload10.HasFile)
            {
                filename = Path.GetFileName(photoUpload10.PostedFile.FileName);
                filepath = "~/items/" + filename;
                Id = 10;
                updateImage();
                photoUpload10.SaveAs((Server.MapPath("~/items/" + photoUpload10.FileName)));
            }

            if (txtName10.Text.Equals("") || txtPrice10.Text.Equals("") || txtDescription10.Text.Equals(""))
            {
                Response.Write("<script>alert('Enter all the necessary details of Item!');</script>");
            }
            else
            {
                Id = 10;
                Name = txtName10.Text.Trim().ToString().ToUpper();
                Price = txtPrice10.Text.Trim().ToString();
                Description = txtDescription10.Text.Trim().ToString();
                updateDetails();
            }
        }

        protected void btnUpdate11_Click(object sender, EventArgs e)
        {
            if (photoUpload11.HasFile)
            {
                filename = Path.GetFileName(photoUpload11.PostedFile.FileName);
                filepath = "~/items/" + filename;
                Id = 11;
                updateImage();
                photoUpload11.SaveAs((Server.MapPath("~/items/" + photoUpload11.FileName)));
            }

            if (txtName11.Text.Equals("") || txtPrice11.Text.Equals("") || txtDescription11.Text.Equals(""))
            {
                Response.Write("<script>alert('Enter all the necessary details of Item!');</script>");
            }
            else
            {
                Id = 11;
                Name = txtName11.Text.Trim().ToString().ToUpper();
                Price = txtPrice11.Text.Trim().ToString();
                Description = txtDescription11.Text.Trim().ToString();
                updateDetails();
            }
        }

        protected void btnUpdate12_Click(object sender, EventArgs e)
        {
            if (photoUpload12.HasFile)
            {
                filename = Path.GetFileName(photoUpload12.PostedFile.FileName);
                filepath = "~/items/" + filename;
                Id = 12;
                updateImage();
                photoUpload12.SaveAs((Server.MapPath("~/items/" + photoUpload12.FileName)));
            }

            if (txtName12.Text.Equals("") || txtPrice12.Text.Equals("") || txtDescription12.Text.Equals(""))
            {
                Response.Write("<script>alert('Enter all the necessary details of Item!');</script>");
            }
            else
            {
                Id = 12;
                Name = txtName12.Text.Trim().ToString().ToUpper();
                Price = txtPrice12.Text.Trim().ToString();
                Description = txtDescription12.Text.Trim().ToString();
                updateDetails();
            }
        }
    }
}