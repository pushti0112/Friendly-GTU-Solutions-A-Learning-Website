using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String mycon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Asus\\Documents\\.net\\friendlygtusoln\\friendlygtusoln\\App_Data\\Database.mdf;Integrated Security=True";
 SqlConnection scon = new SqlConnection(mycon);
        String myquery = "select * from register";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = myquery;
        cmd.Connection = scon;
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);
        String uname;
        String pass;
        String status;
        int i = 0;
        
        while(true)
        {
            uname = ds.Tables[0].Rows[i]["name"].ToString();
            pass = ds.Tables[0].Rows[i]["pass"].ToString();
            status = ds.Tables[0].Rows[i]["status"].ToString();
            scon.Close();

            if(status=="verified")
            {
                if (uname == TextBox1.Text && pass == TextBox2.Text)
                {
                    Session["username"] = uname;
                    Response.Redirect("home2.aspx");
                }
                else
                {
                    Label2.Text = "Invalid Username or Password - Relogin with Correct Username Password";
                }
                i++;
            }
            else
            {
                Label2.Text = "Verify your account from your registered Email Id";
            }

           
        }
        

    

       
    }
}