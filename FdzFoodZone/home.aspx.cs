using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FdzFoodZone
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            setImageUrl();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            setImageUrl();
        }

        private void setImageUrl()
        {
            Random ran = new Random();
            int i = ran.Next(1, 6);
            Image1.ImageUrl = "~/slider/" + i.ToString() + ".png";
        }
    }
}