using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace OnlineTest
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["timeout"] != null)
            {
                lbstatus.Text = "You test time expired, please try again! ";
            }
          
        }


        protected void btnStartTest_Click(object sender, EventArgs e)
        {

        }
    }
}