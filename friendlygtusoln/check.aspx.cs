using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class check : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Database d = new Database();
        string v = Request.QueryString["name"];

      //  txtlab1.Text = v;

       if( d.update("update register set status='verified' where name='"+v+"'"))
        {
            Response.Redirect("login.aspx");

        }

      

    }
}