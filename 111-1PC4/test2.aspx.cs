using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC4
{
    public partial class test2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i_Age = 1;
            int i_Sex = 0;
            if (!(!(i_Age >= 50) || !(i_Sex == 1)))
            {
                Response.Write("壯年男人");
            }
            else if (!(!(i_Age < 50) || !(i_Sex == 1)))
            {
                Response.Write("年輕男人");
            }
            else if (!(!(i_Age >= 50) || !(i_Sex == 0)))
            {
                Response.Write("壯年女人");
            }
            else if (!(!(i_Age < 50) || !(i_Sex == 0)))
            {
                Response.Write("年輕女人");
            }
            else
            {
                Response.Write("其他");
            }
        }
    }
}