using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String email = txtemail.Text;
        String name = txtname.Text;
        String pass = txtpass.Text;
        String enroll = txtenroll.Text;

        Database d = new Database();

       

        String qry = "insert into register(email,pass,name,enroll,status) values('" + email + "','" + pass + "','" + name + "','" + enroll + "','not verified')";

        d.update("delete from register");

        if (d.insert(qry))
        {
            string contents = File.ReadAllText(@"C:\Users\Asus\Documents\.net\friendlygtusoln\friendlygtusoln\my.txt");
            contents = contents.Replace("user",name);
           // String body = "<h1>Successfully created</h1>";
            EmailRelay f = new EmailRelay("smtp.gmail.com", "friendlygtusoln@gmail.com", "12345fgs");
            if (f.SendMail("friendlygtusoln@gmail.com", txtemail.Text, "Verify Account", contents, "FriendlyGtuSoln", true) == true)
            {
                txtlab.Text = "Mail sent";

            }
            else
            {

                txtlab.Text = "registered successfully";

            }



        }
        else
        {
            txtlab.Text = "Try again later :" + d.getErrorMsg();
        }


    
}
}